
namespace Kistl.Client.Forms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using Kistl.API;
    using Kistl.Client.Forms.View;
    using Kistl.Client.GUI;
    using Kistl.Client.Presentables;
    using Kistl.Client.Presentables.ObjectBrowser;

    public class FormsModelFactory
        : ViewModelFactory
    {

        private List<WorkspaceView> _workspaces = new List<WorkspaceView>();

        public FormsModelFactory(Autofac.ILifetimeScope container, IFrozenContext metaCtx)
            : base(container, metaCtx)
        {
        }

        public override Kistl.App.GUI.Toolkit Toolkit
        {
            get { return Kistl.App.GUI.Toolkit.WinForms; }
        }

        protected void CreateWorkspace(WorkspaceViewModel mdl, bool activate)
        {
            var workspace = new WorkspaceView(); // TODO: delegate to data store / TypeDescriptor
            workspace.DataContext = mdl;
            workspace.Closed += new EventHandler(workspace_Closed);
            workspace.Show();
            _workspaces.Add(workspace);
        }

        void workspace_Closed(object sender, EventArgs e)
        {
            _workspaces.Remove((WorkspaceView)sender);
            if (_workspaces.Count == 0)
                Application.Exit();
        }

        protected override void ShowInView(ViewModel mdl, object view, bool activate, bool asDialog)
        {
            var control = (IFormsView)view;
            control.SetRenderer(_renderer);
            control.SetDataContext(mdl);
            if (asDialog)
            {
                control.ShowDialog();
            }
            else
            {
                control.Show();
                if (activate)
                    control.Activate();
            }
        }

        private Renderer _renderer = new Renderer();

        public override void CreateTimer(TimeSpan tickLength, Action action)
        {
            throw new NotImplementedException();
        }

        public override string GetSourceFileNameFromUser(params string[] filters)
        {
            throw new NotImplementedException();
        }
        public override string GetDestinationFileNameFromUser(string filename, params string[] filters)
        {
            throw new NotImplementedException();
        }

        public override bool GetDecisionFromUser(string message, string caption)
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        public override void ShowMessage(string message, string caption)
        {
            MessageBox.Show(message, caption);
        }
    }
}
