// http://www.codeproject.com/KB/WPF/wpf_vista_preview_handler.aspx

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;

namespace Kistl.Client.WPF.View.DocumentManagement
{
    public class WPFPreviewControl : ContentPresenter
    {
        Rect actualRect = new Rect();
        System.Windows.Forms.Integration.WindowsFormsHost host;
        PreviewersManager pManager;

        public WPFPreviewControl()
        {
            this.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.VerticalAlignment = VerticalAlignment.Stretch;

            this.Unloaded += new RoutedEventHandler(WPFPreviewControl_Unloaded);

            host = new System.Windows.Forms.Integration.WindowsFormsHost();
            host.Child = new System.Windows.Forms.Panel();
            host.Loaded += new RoutedEventHandler(host_Loaded);
            this.Content = host;
        }

        void WPFPreviewControl_Unloaded(object sender, RoutedEventArgs e)
        {
            if (pManager != null)
            {
                pManager.Dispose();
                pManager = null;
            }
        }

        void host_Loaded(object sender, RoutedEventArgs e)
        {
            AttachPreview();
        }

        public string PreviewFilePath
        {
            get { return (string)GetValue(PreviewFilePathProperty); }
            set { SetValue(PreviewFilePathProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Content.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PreviewFilePathProperty =
            DependencyProperty.Register("PreviewFilePath", typeof(string), typeof(WPFPreviewControl));

        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            if (e.Property == ContentControl.ActualHeightProperty || e.Property == ContentControl.ActualWidthProperty)
            {
                actualRect = new Rect(0, 0, this.ActualWidth, this.ActualHeight);
                InvalidateAttachedPreview();
            }
            if (e.Property == PreviewFilePathProperty)
            {
                AttachPreview();
            }
            base.OnPropertyChanged(e);
        }

        private void InvalidateAttachedPreview()
        {
            EnsurePreviewManager();
            if (host != null && host.Handle != IntPtr.Zero)
            {
                pManager.InvalidateAttachedPreview(host.Handle, actualRect);
            }
        }

        private void AttachPreview()
        {
            EnsurePreviewManager();
            if (host != null && host.Handle != IntPtr.Zero && !string.IsNullOrEmpty(PreviewFilePath))
            {
                pManager.AttachPreview(host.Handle, PreviewFilePath, actualRect);
            }
        }

        private void EnsurePreviewManager()
        {
            if (pManager == null) pManager = new PreviewersManager();
        }
    }
}
