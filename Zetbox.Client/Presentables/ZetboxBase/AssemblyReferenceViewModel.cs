
namespace Zetbox.Client.Presentables.ZetboxBase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Zetbox.API;
    using Zetbox.App.Base;
    using Zetbox.App.Extensions;
    using Zetbox.Client.Models;
    using Zetbox.Client.Presentables.ValueViewModels;

    /// <summary>
    /// Models an Assembly.
    /// </summary>
    public class AssemblyReferenceViewModel
        : ObjectReferenceViewModel
    {
        public AssemblyReferenceViewModel(
            IViewModelDependencies appCtx, IZetboxContext dataCtx, ViewModel parent,
            IValueModel mdl)
            : base(appCtx, dataCtx, parent, mdl)
        {
            //// TODO: use a static reference here
            //if (prop.GetReferencedObjectClass() != DataContext.GetQuery<ObjectClass>().Where(oc => oc.Name == "Assembly"))
            //{
            //    throw new ArgumentOutOfRangeException("prop", "Can only handle Assembly References");
            //}
        }

        public void LoadValueFromFile()
        {
            string assemblyFileName = ViewModelFactory.GetSourceFileNameFromUser("Assembly files|*.dll;*.exe", "All files|*.*");
            var assembly = System.Reflection.Assembly.ReflectionOnlyLoadFrom(assemblyFileName);
            var assemblyDescriptor = DataContext.GetQuery<Assembly>().SingleOrDefault(a => a.Name == assembly.FullName);
            if (assemblyDescriptor == null)
            {
                assemblyDescriptor = DataContext.Create<Assembly>();
                assemblyDescriptor.Name = assembly.FullName;
            }

            this.Value = DataObjectViewModel.Fetch(ViewModelFactory, DataContext, ViewModelFactory.GetWorkspace(DataContext), assemblyDescriptor);
        }
    }
}
