﻿

namespace Zetbox.Client.WPF.View.ZetboxBase
{
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
    using Zetbox.Client.Presentables;
    using Zetbox.Client.WPF.Toolkit;

    [ViewDescriptor(Zetbox.App.GUI.Toolkit.WPF)]
    public class SingleLineDisplay : DockPanel, IHasViewModel<ViewModel>
    {
        public SingleLineDisplay()
        {
            var img = new Image() { Width = 14, Height = 14 };
            BindingOperations.SetBinding(img, Image.SourceProperty, new Binding("Icon") { Converter = (IValueConverter)FindResource("ImageConverter") });
            Children.Add(img);

            var txt = new TextBlock() { Margin = new Thickness(3, 0, 0, 0) };
            BindingOperations.SetBinding(txt, TextBlock.TextProperty, new Binding("Name"));
            Children.Add(txt);

            BindingOperations.SetBinding(this, Zetbox.Client.WPF.Styles.Controls.HighlightProperty, new Binding("HighlightAsync"));
        }

        public ViewModel ViewModel
        {
            get { return (ViewModel)WPFHelper.SanitizeDataContext(DataContext); }
        }
    }
}
