using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using Kistl.API;
using Kistl.API.Client;
using System.ComponentModel;

namespace Kistl.Client.WPF.Dialogs
{
    /// <summary>
    /// Interaktionslogik für ChooseObject.xaml
    /// </summary>
    public partial class ChooseObjectDialog : Window
    {
        public ChooseObjectDialog()
        {
            InitializeComponent();
        }

        public Kistl.API.IDataObject Result { get; protected set; }


        public IKistlContext Context
        {
            get { return (IKistlContext)GetValue(ContextProperty); }
            set { SetValue(ContextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Context.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContextProperty =
            DependencyProperty.Register("Context", typeof(IKistlContext), typeof(ChooseObjectDialog), new PropertyMetadata());


        public Type ObjectType
        {
            get { return (Type)GetValue(ObjectTypeProperty); }
            set { SetValue(ObjectTypeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ObjectType.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ObjectTypeProperty =
            DependencyProperty.Register("ObjectType", typeof(Type), typeof(ChooseObjectDialog), new PropertyMetadata());


        public string FilterString
        {
            get { return (string)GetValue(FilterStringProperty); }
            set { SetValue(FilterStringProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilterString.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterStringProperty =
            DependencyProperty.Register("FilterString", typeof(string), typeof(ChooseObjectDialog),
            new PropertyMetadata("", new PropertyChangedCallback(FilterStringChanged)));

        private static void FilterStringChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ChooseObjectDialog dlg = d as ChooseObjectDialog;

            ICollectionView view = CollectionViewSource.GetDefaultView(dlg.lstObjects.ItemsSource);
            if (dlg.FilterString.Length == 0)
                view.Filter = null;
            else
                view.Filter = (object o) => o.ToString().IndexOf(dlg.FilterString, StringComparison.CurrentCultureIgnoreCase) != -1;
        }


        #region Behaviours

        protected virtual void OnLoad()
        {
            // load all available Objects of this type
            // TODO: implement paging/searching in order to reduce server load
            lstObjects.ItemsSource = Context.GetQuery(ObjectType).ToList().OrderBy(i => i.ToString()).ToList();
            txtFilterString.Focus();
        }

        protected virtual void OnSelect()
        {
            Result = (Kistl.API.IDataObject)lstObjects.SelectedItem;
            DialogResult = true;
            this.Close();
        }

        protected virtual void OnNew()
        {
            Result = Context.Create(ObjectType);
            Manager.Renderer.ShowObject(Result);
            DialogResult = true;
            this.Close();
        }

        #endregion

        #region EventHandlers

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OnLoad();
        }

        private void lstObjects_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            OnSelect();
        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            OnSelect();
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            OnNew();
        }

        #endregion
    }
}
