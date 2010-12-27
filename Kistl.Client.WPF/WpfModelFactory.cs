
namespace Kistl.Client.WPF
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows;
    using System.Windows.Threading;
    using Autofac;
    using Kistl.API;
    using Kistl.Client.GUI;
    using Kistl.Client.Presentables;
    using Microsoft.Win32;
    using Kistl.API.Client;
    using Kistl.API.Configuration;

    public class WpfModelFactory
        : ViewModelFactory
    {
        private readonly IUiThreadManager uiThread;

        public WpfModelFactory(Autofac.ILifetimeScope container, IUiThreadManager uiThread, IFrozenContext frozenCtx, KistlConfig cfg)
            : base(container, frozenCtx, cfg)
        {
            this.uiThread = uiThread;
        }

        /// <inheritdoc/>
        public override Kistl.App.GUI.Toolkit Toolkit
        {
            get { return Kistl.App.GUI.Toolkit.WPF; }
        }

        /// <inheritdoc/>
        protected override void ShowInView(ViewModel mdl, object view, bool activate, bool asDialog)
        {
            uiThread.Verify();

            if (view is Window)
            {
                var viewControl = (Window)view;
                viewControl.DataContext = mdl;
                viewControl.ShowActivated = activate;
                if (asDialog)
                {
                    viewControl.ShowDialog();
                }
                else
                {
                    viewControl.Show();
                }
            }
            else
            {
                // TODO: what should be done here, really?
                throw new NotImplementedException(String.Format("Cannot show view of type {0}, it's not a Window", view == null ? "(null)" : view.GetType().ToString()));
            }
        }

        /// <inheritdoc/>
        public override void CreateTimer(TimeSpan tickLength, Action action)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = tickLength;
            timer.Tick += (obj, args) => action();
            timer.Start();
        }

        protected override object CreateDefaultView(ViewModel mdl)
        {
            System.Windows.Controls.Control view = (System.Windows.Controls.Control)base.CreateDefaultView(mdl);
            if (view != null) view.DataContext = mdl;
            return view;
        }

        protected override object CreateSpecificView(ViewModel mdl, Kistl.App.GUI.ControlKind kind)
        {
            System.Windows.Controls.Control view = (System.Windows.Controls.Control)base.CreateSpecificView(mdl, kind);
            if (view != null) view.DataContext = mdl;
            return view;
        }

        /// <inheritdoc/>
        public override string GetSourceFileNameFromUser(params string[] filter)
        {
            var dialog = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                DereferenceLinks = true,
                Filter = String.Join("|", filter),
                Multiselect = false,
                ShowReadOnly = false,
                ValidateNames = true,
            };

            if (dialog.ShowDialog() == true)
            {
                return dialog.FileName;
            }
            else
            {
                return String.Empty;
            }
        }
        /// <inheritdoc/>
        public override string GetDestinationFileNameFromUser(string filename, params string[] filter)
        {
            var dialog = new SaveFileDialog()
            {
                CheckFileExists = false,
                CheckPathExists = false,
                DereferenceLinks = true,
                Filter = String.Join("|", filter),
                ValidateNames = true,
                FileName = filename
            };

            if (dialog.ShowDialog() == true)
            {
                return dialog.FileName;
            }
            else
            {
                return String.Empty;
            }
        }

        public override bool GetDecisionFromUser(string message, string caption)
        {
            return MessageBox.Show(message, caption, MessageBoxButton.YesNo) == MessageBoxResult.Yes;
        }

        public override void ShowMessage(string message, string caption)
        {
            MessageBox.Show(message, caption);
        }

        protected override void ShowWaitDialog()
        {
            SplashScreen.ShowSplashScreen(IToolkitResources.WaitDialog_Message, IToolkitResources.WaitDialog_Info, 1);
        }

        protected override void CloseWaitDialog()
        {
            SplashScreen.HideSplashScreen();
        }
    }
}
