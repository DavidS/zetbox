// http://code.google.com/p/dot-net-solution-templates/source/browse/trunk/TemplateWizard/Wizard/Wizard.cs

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.TemplateWizard;


namespace ZetboxApp.Wizard
{
    public class SolutionWizard : IWizard
    {
        private static string _wrongProjectFolder;
        private static string _solutionFolder;
        private static string _templatePath;
        private static string _solutionName;
        private Dictionary<string, string> _replacementsDictionary;

        public static string SolutionName
        {
            get
            {
                return _solutionName ?? string.Empty;
            }
        }

        private DTE _dte;
        private Solution _solution;

        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            _dte = (DTE)automationObject;
            _wrongProjectFolder = replacementsDictionary["$destinationdirectory$"];
            _solutionFolder = Path.GetDirectoryName(_wrongProjectFolder);
            _templatePath = Path.GetFullPath(Path.Combine(Path.GetDirectoryName((string)customParams[0]), ".."));
            _solutionName = replacementsDictionary["$safeprojectname$"];
            replacementsDictionary.Add("$safesolutionname$", _solutionName);

            var dlg = new WizardForm(_solutionName);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                replacementsDictionary.Add("$connectionstring$", dlg.ConnectinString);
                replacementsDictionary.Add("$databasename$", dlg.DatabaseName);
                replacementsDictionary.Add("$databaseuser$", dlg.DatabaseUser);
                replacementsDictionary.Add("$ormapperclassname$", dlg.ORMapperClassName);
                replacementsDictionary.Add("$ormappermodule$", dlg.ORMapperModule);
                replacementsDictionary.Add("$schema$", dlg.Schema);
                replacementsDictionary.Add("$provider$", dlg.Provider);
            }
            else
            {
                throw new WizardCancelledException("Aborted by user");
            }

            _replacementsDictionary = replacementsDictionary;
        }

        public void RunFinished()
        {
            _solution = _dte.Solution;
            _solution.SaveAs((string)_solution.Properties.Item("Path").Value);

            ExtractSolutionItems();
            MoveProjects();
            AddImportTargets();
            SetupConfigurationManager();
            SetProjectReferences();
            SetStartupProject();
        }

        private void SetupConfigurationManager()
        {
            var config = _solution.SolutionBuild.SolutionConfigurations.Item("Linux.Debug");
            foreach (SolutionContext ctx in config.SolutionContexts)
            {
                ctx.ShouldBuild = !ctx.ProjectName.EndsWith(".WPF.csproj");
            }


            var fallbackConfig = _solution.SolutionBuild.SolutionConfigurations.Item("Fallback");
            foreach (SolutionContext ctx in fallbackConfig.SolutionContexts)
            {
                ctx.ShouldBuild = ctx.ProjectName.EndsWith(".Migrations.csproj");
            }
        }

        private void AddImportTargets()
        {
            var msBuildEngine = new Microsoft.Build.BuildEngine.Engine();

            foreach (Project prj in _solution.Projects)
            {
                prj.Save();
                var fileName = prj.FullName;
                var prjName = prj.Name;

                SolutionFolder folder = null;

                if (prj.ParentProjectItem != null)
                {
                    folder = (SolutionFolder)prj.ParentProjectItem.ContainingProject.Object;
                }
                _solution.Remove(prj);

                var msBuildProj = new Microsoft.Build.BuildEngine.Project(msBuildEngine);
                msBuildProj.Load(fileName);

                msBuildProj.Imports.AddNewImport(@"$(SolutionDir)\.nuget\nuget.targets", null);
                if (prjName == ToProjectName("Common"))
                {
                    msBuildProj.Imports.AddNewImport(@"$(SolutionDir)\.zetbox\common.targets", null);
                }
                else if (prjName == ToProjectName("Client") || prjName == ToProjectName("Client.Tests"))
                {
                    msBuildProj.Imports.AddNewImport(@"$(SolutionDir)\.zetbox\client.targets", null);
                }
                else if (prjName == ToProjectName("Client.WPF"))
                {
                    msBuildProj.Imports.AddNewImport(@"$(SolutionDir)\.zetbox\clientwpf.targets", null);
                }
                else if (prjName == ToProjectName("WPF"))
                {
                    msBuildProj.Imports.AddNewImport(@"$(SolutionDir)\.zetbox\wpf.targets", null);
                }
                else if (prjName == ToProjectName("Server") || prjName == ToProjectName("Server.Tests"))
                {
                    msBuildProj.Imports.AddNewImport(@"$(SolutionDir)\.zetbox\server.targets", null);
                }
                else if (prjName == ToProjectName("Server.Migrations"))
                {
                    msBuildProj.Imports.AddNewImport(@"$(SolutionDir)\.zetbox\fallback.targets", null);
                }

                msBuildProj.Save(fileName);

                if (folder != null)
                {
                    folder.AddFromFile(fileName);
                }
                else
                {
                    _solution.AddFromFile(fileName);
                }
            }
        }

        private void SetProjectReferences()
        {
            var allProjects = new Dictionary<string, Project>();
            foreach (Project prj in _solution.Projects)
            {
                if (prj.Name == ToProjectName("Client"))
                {
                    allProjects["client"] = prj;
                }
                else if (prj.Name == ToProjectName("Client.WPF"))
                {
                    allProjects["wpf"] = prj;
                }
                else if (prj.Name == ToProjectName("Common"))
                {
                    allProjects["common"] = prj;
                }
                else if (prj.Name == ToProjectName("Server"))
                {
                    allProjects["server"] = prj;
                }
            }

            foreach (Project prj in _solution.Projects)
            {
                VSLangProj.VSProject vsProj = (VSLangProj.VSProject)prj.Object;
                if (prj.Name == ToProjectName("Common"))
                {
                }
                else if (prj.Name == ToProjectName("Client"))
                {
                    vsProj.References.AddProject(allProjects["common"]).CopyLocal = false;
                }
                else if (prj.Name == ToProjectName("Client.WPF"))
                {
                    vsProj.References.AddProject(allProjects["common"]).CopyLocal = false;
                    vsProj.References.AddProject(allProjects["client"]).CopyLocal = false;
                }
                else if (prj.Name == ToProjectName("Server"))
                {
                    vsProj.References.AddProject(allProjects["common"]).CopyLocal = false;
                }
            }
        }

        private void SetStartupProject()
        {
            _dte.Solution.Properties.Item("StartupProject").Value = ToProjectName("WPF");
        }

        private void MoveProjects()
        {
            var projects = new List<Project>();
            foreach (Project project in _solution.Projects)
            {
                projects.Add(project);
            }
            foreach (Project project in projects)
            {
                string projectDestination = Path.Combine(_solutionFolder, project.Name);
                MoveProjectToDirectory(project, projectDestination);
            }

            try
            {
                Directory.Delete(_wrongProjectFolder, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ExtractSolutionItems()
        {
            var assembly = typeof(SolutionWizard).Assembly;
            foreach (var res in assembly.GetManifestResourceNames())
            {
                if (res.Contains(".SolutionItems."))
                {
                    // ZetboxApp.Wizard.SolutionItems.Configs.test___a.xml
                    var relFilePath = res.Substring(res.IndexOf(".SolutionItems.") + ".SolutionItems.".Length);
                    // Configs.test___a.xml
                    var ext = Path.GetExtension(relFilePath);
                    // .xml
                    relFilePath = relFilePath.Substring(0, relFilePath.Length - ext.Length);
                    // Configs.test___a
                    relFilePath = relFilePath.Replace('.', '\\');
                    // Configs\test___a
                    relFilePath = relFilePath + ext;
                    // Configs\test___a.xml
                    relFilePath = relFilePath.Replace("___", ".");
                    // Configs\test.a.xml
                    var destFilePath = Path.Combine(_solutionFolder, ExpandMacros(relFilePath));
                    var folder = Path.GetDirectoryName(destFilePath);
                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);

                    using (var s = assembly.GetManifestResourceStream(res))
                    {
                        if (".xml".Equals(ext, StringComparison.InvariantCultureIgnoreCase) ||
                            ".txt".Equals(ext, StringComparison.InvariantCultureIgnoreCase) ||
                            ".cmd".Equals(ext, StringComparison.InvariantCultureIgnoreCase) ||
                            ".config".Equals(ext, StringComparison.InvariantCultureIgnoreCase) ||
                            ".gitignore".Equals(relFilePath, StringComparison.InvariantCultureIgnoreCase))
                        {
                            var sr = new StreamReader(s);
                            var content = sr.ReadToEnd();

                            content = ExpandMacros(content);

                            using (var fs = File.CreateText(destFilePath))
                            {
                                fs.BaseStream.SetLength(0);
                                fs.Write(content);
                            }
                        }
                        else
                        {
                            using (var fs = File.Create(destFilePath))
                            {
                                fs.SetLength(0);
                                s.CopyTo(fs);
                            }
                        }
                    }
                }
            }
        }

        private string ExpandMacros(string content)
        {
            foreach (var keyVal in _replacementsDictionary)
            {
                content = content.Replace(keyVal.Key, keyVal.Value);
            }
            return content;
        }

        private void MoveProjectToDirectory(Project project, string destinationDirectory)
        {
            string projectFilename = Path.GetFileName(project.FileName);
            string projectDir = Path.GetDirectoryName(project.FileName);
            Helper.CopyFolder(projectDir, destinationDirectory);
            string newProjectFilename = Path.Combine(destinationDirectory, projectFilename);

            Project newProject;
            if (project.ParentProjectItem != null)
            {
                var folder = (SolutionFolder)project.ParentProjectItem.ContainingProject.Object;
                _solution.Remove(project);
                newProject = folder.AddFromFile(newProjectFilename);
            }
            else
            {
                _solution.Remove(project);
                newProject = _solution.AddFromFile(newProjectFilename, false);
            }

            Directory.Delete(projectDir, true);
        }

        private void ShellExecute(string file)
        {
            if (string.IsNullOrEmpty(file)) throw new ArgumentNullException("file");

            System.Diagnostics.ProcessStartInfo si = new System.Diagnostics.ProcessStartInfo();
            si.UseShellExecute = true;
            si.WorkingDirectory = _solutionFolder;
            si.FileName = file;
            var process = System.Diagnostics.Process.Start(si);
            process.WaitForExit();
            if (process.ExitCode > 0)
            {
                MessageBox.Show("Error executing " + file, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string ToProjectName(string suffix)
        {
            return _solutionName + "." + suffix;
        }
    }
}
