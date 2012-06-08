using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Zetbox.Client.GUI;
using Zetbox.Client.Presentables.DocumentManagement;

namespace Zetbox.Client.WPF.View.DocumentManagement
{
    /// <summary>
    /// Interaction logic for ImageEditor.xaml
    /// </summary>
    [ViewDescriptor(Zetbox.App.GUI.Toolkit.WPF)]
    public partial class ImportedFileWithPreviewEditor : PreviewEditor, IHasViewModel<ImportedFileViewModel>
    {
        public ImportedFileWithPreviewEditor()
        {
            if (DesignerProperties.GetIsInDesignMode(this)) return;
            InitializeComponent();
        }

        protected override ContentPresenter PreviewControl
        {
            get { return preview; }
        }

        public new ImportedFileViewModel ViewModel
        {
            get { return (ImportedFileViewModel)DataContext; }
        }
    }
}
