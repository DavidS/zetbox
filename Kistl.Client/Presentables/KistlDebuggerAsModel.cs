using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Kistl.API;

namespace Kistl.Client.Presentables
{

    public class KistlDebuggerAsModel 
        : ViewModel, IKistlContextDebugger
    {
        public new delegate KistlDebuggerAsModel Factory(IKistlContext dataCtx);

        public KistlDebuggerAsModel(IViewModelDependencies appCtx, IKistlContext dataCtx)
            : base(appCtx, dataCtx)
        {
            KistlContextDebuggerSingleton.SetDebugger(this);
        }

        public KistlDebuggerAsModel(bool designMode)
            : base(designMode)
        {
        }

        public override string Name
        {
            get { return this.GetType().Name; }
        }

        #region Public Interface

        private ObservableCollection<KistlContextModel> _activeCtxCache = new ObservableCollection<KistlContextModel>();
        private ObservableCollection<KistlContextModel> _disposedCtxCache = new ObservableCollection<KistlContextModel>();
        private ReadOnlyObservableCollection<KistlContextModel> _activeCtxView;
        private ReadOnlyObservableCollection<KistlContextModel> _disposedCtxView;

        public ReadOnlyObservableCollection<KistlContextModel> ActiveContexts
        {
            get
            {
                if (_activeCtxView == null)
                {
                    _activeCtxView = new ReadOnlyObservableCollection<KistlContextModel>(_activeCtxCache);
                }
                return _activeCtxView;
            }
        }

        public ReadOnlyObservableCollection<KistlContextModel> DisposedContexts
        {
            get
            {
                if (_disposedCtxView == null)
                {
                    _disposedCtxView = new ReadOnlyObservableCollection<KistlContextModel>(_disposedCtxCache);
                }
                return _disposedCtxView;
            }
        }
        #endregion

        #region IKistlContextDebugger Members

        private KistlContextModel GetModel(IKistlContext ctx)
        {
            return ModelFactory.CreateViewModel<KistlContextModel.Factory>().Invoke(ctx);
        }

        void IKistlContextDebugger.Created(IKistlContext ctx)
        {
            _activeCtxCache.Add(GetModel(ctx));
            ctx.Disposing += Disposing;
            ctx.Changed += Changed;
        }

        void Disposing(object sender, GenericEventArgs<IReadOnlyKistlContext> e)
        {
            var mdl = GetModel((IKistlContext)e.Data);
            _activeCtxCache.Remove(mdl);
            _disposedCtxCache.Add(mdl);
        }

        void Changed(object sender, GenericEventArgs<IKistlContext> e)
        {
            var mdl = GetModel(e.Data);
            mdl.OnContextChanged();
        }
        #endregion
    }

    public class KistlContextModel
        : ViewModel
    {
        public new delegate KistlContextModel Factory(IKistlContext dataCtx);

        protected IDebuggingKistlContext DebuggingContext { get; private set; }

        public KistlContextModel(IViewModelDependencies appCtx, IDebuggingKistlContext dataCtx)
            : base(appCtx, dataCtx)
        {
            DebuggingContext = dataCtx;
        }

        #region Public Interface

        private ObservableCollection<string> _objCache = new ObservableCollection<string>();
        public ObservableCollection<string> AttachedObjects
        {
            get
            {
                return _objCache;
            }
        }

        private int _countCache = 0;
        public int Count
        {
            get
            {
                return _countCache;
            }
            private set
            {
                if (_countCache != value)
                {
                    _countCache = value;
                    OnPropertyChanged("Count");
                }
            }
        }

        public string CreatedAt
        {
            get
            {
                return String.Join(String.Empty, DebuggingContext.CreatedAt.GetFrames().Take(10).Select(sf => sf.ToString()).ToArray());
            }
        }

        public string DisposedAt
        {
            get
            {
                if (DebuggingContext.DisposedAt == null)
                {
                    return "still active";
                }
                else
                {
                    return String.Join(String.Empty, DebuggingContext.DisposedAt.GetFrames().Take(10).Select(sf => sf.ToString()).ToArray());
                }
            }
        }

        #endregion

        #region Utilities and UI callbacks

        /// <summary>
        /// Update the model's state when the context is changed
        /// </summary>
        /// is only called by the <see cref="KistlDebuggerAsModel"/>
        internal void OnContextChanged()
        {
            var objs = DataContext.AttachedObjects.OfType<IDataObject>().ToArray();
            SyncObjects(objs);
        }

        private void SyncObjects(IDataObject[] objs)
        {
            _objCache.Clear();
            objs.ForEach(o => _objCache.Add(string.Format("({0}) {1}", o.ID, DataContext.GetInterfaceType(o).Type.FullName)));
            Count = objs.Length;
        }

        #endregion

        public override string Name
        {
            get { return "KistlContext"; }
        }
    }
}
