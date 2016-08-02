namespace Zetbox.Client.Presentables.ObjectEditor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Zetbox.Client.Presentables;
    using Zetbox.API;
    using Zetbox.Client.Presentables.ValueViewModels;
    using Zetbox.Client.Models;
    using Zetbox.App.Base;
    using Zetbox.App.Extensions;

    [ViewModelDescriptor]
    public class MergeObjectsTaskViewModel : ViewModel
    {
        public new delegate MergeObjectsTaskViewModel Factory(IZetboxContext dataCtx, ViewModel parent, IDataObject target, IDataObject source);

        public MergeObjectsTaskViewModel(IViewModelDependencies appCtx, IZetboxContext dataCtx, ViewModel parent, IDataObject target, IDataObject source)
            : base(appCtx, dataCtx, parent)
        {
            if (target == null && source == null) throw new ArgumentException("Either source or target must not be null");

            ObjectClass = (source ?? target).GetObjectClass(FrozenContext);

            _targetMdl = new ObjectReferenceValueModel("Target", "", false, false, ObjectClass);
            _targetMdl.Value = target;

            _sourceMdl = new ObjectReferenceValueModel("Source", "", false, false, ObjectClass);
            _sourceMdl.Value = source;

            var ws = GetWorkspace() as IContextViewModel;
            if(ws == null)
            {
                throw new InvalidOperationException("A MergeObjectsTaskViewModel must be bound to a IContextViewModel workspace");
            }

            ws.Saving += OnSaving;
            ws.Saved += OnSaved;
        }

        void OnSaving(object sender, EventArgs e)
        {
            // optional additional merge tasks
            var mergeable = _targetMdl.Value as IMergeable;
            if (mergeable != null)
            {
                mergeable.MergeFrom(_sourceMdl.Value);
            }

            // save the workspace
            // done by caller
        }

        void OnSaved(object sender, EventArgs e)
        {
            // Send replace request to the server
            // The replace task will run in a server context
            // but does not change anything else
            var objClass = DataContext.FindPersistenceObject<ObjectClass>(ObjectClass.ExportGuid); // call from our context
            objClass.ReplaceObject(_targetMdl.Value, _sourceMdl.Value);

            // Cleanup UI
            _sourceMdl.Value = null;
        }

        public override System.Drawing.Image Icon
        {
            get
            {
                return base.Icon ?? (base.Icon = IconConverter.ToImage(Zetbox.NamedObjects.Gui.Icons.ZetboxBase.reload_png.Find(FrozenContext)));
            }
            set
            {
                base.Icon = value;
            }
        }

        private ObjectReferenceValueModel _targetMdl = null;
        private ObjectReferenceValueModel _sourceMdl = null;

        public ObjectClass ObjectClass { get; private set; }

        public override string Name
        {
            get { return MergeObjectsTaskViewModelResources.Name; }
        }

        private ObjectReferenceViewModel _target = null;
        public ObjectReferenceViewModel Target
        {
            get
            {
                if(_target == null)
                {
                    _target = ViewModelFactory.CreateViewModel<ObjectReferenceViewModel.Factory>().Invoke(DataContext, this, _targetMdl);
                }
                return _target;
            }
        }

        private ObjectReferenceViewModel _source = null;
        public ObjectReferenceViewModel Source
        {
            get
            {
                if (_source == null)
                {
                    _source = ViewModelFactory.CreateViewModel<ObjectReferenceViewModel.Factory>().Invoke(DataContext, this, _sourceMdl);
                }
                return _source;
            }
        }
    }
}