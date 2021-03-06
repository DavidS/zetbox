// This file is part of zetbox.
//
// Zetbox is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as
// published by the Free Software Foundation, either version 3 of
// the License, or (at your option) any later version.
//
// Zetbox is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with zetbox.  If not, see <http://www.gnu.org/licenses/>.

namespace Zetbox.Client.Presentables
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;

    using Zetbox.API;
    using Zetbox.API.Utils;

    /// <summary>
    /// Models a group of Property(Models)
    /// </summary>
    [ViewModelDescriptor]
    public abstract class PropertyGroupViewModel
        : ViewModel
    {
        public new delegate PropertyGroupViewModel Factory(IZetboxContext dataCtx, ViewModel parent, string tagName, string title, IEnumerable<ViewModel> lst);

        private readonly string _title;
        protected readonly ObservableCollection<ViewModel> properties;

        public PropertyGroupViewModel(
            IViewModelDependencies appCtx, IZetboxContext dataCtx, ViewModel parent,
            string tagName,
            string title,
            IEnumerable<ViewModel> lst)
            : base(appCtx, dataCtx, parent)
        {
            if (string.IsNullOrWhiteSpace(tagName)) throw new ArgumentNullException("tagName");

            _tagName = tagName;
            _title = title ?? string.Empty;
            properties = new ObservableCollection<ViewModel>(lst);
            properties.CollectionChanged += PropertyListChanged;
            foreach (var prop in properties)
            {
                prop.PropertyChanged += ErrorPropertyChangedHandler;
            }
        }

        #region Public Interface

        private string _titleCache;
        public string Title
        {
            get
            {
                if (_titleCache == null)
                {
                    _titleCache = _title.Replace('_', ' ');
                }
                return _titleCache;
            }
        }
        public string ToolTip { get { return Title; } }

        public override string Name
        {
            get { return Title; }
        }

        private string _tagName;
        public string TagName
        {
            get { return _tagName; }
        }

        private ReadOnlyObservableCollection<ViewModel> _propertyModelsCache;
        public ReadOnlyObservableCollection<ViewModel> PropertyModels
        {
            get
            {
                if (_propertyModelsCache == null)
                {
                    _propertyModelsCache = new ReadOnlyObservableCollection<ViewModel>(properties);
                }
                return _propertyModelsCache;
            }
        }
        #endregion


        #region Event handlers

        private void PropertyListChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (var prop in e.NewItems.OfType<INotifyPropertyChanged>())
                {
                    prop.PropertyChanged += ErrorPropertyChangedHandler;
                }
            }

            if (e.OldItems != null)
            {
                foreach (var prop in e.OldItems.OfType<INotifyPropertyChanged>())
                {
                    prop.PropertyChanged -= ErrorPropertyChangedHandler;
                }
            }
        }

        private void ErrorPropertyChangedHandler(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Error")
            {
                OnPropertyChanged("Title");
                OnPropertyChanged("Error");
            }
        }

        #endregion
    }

    public class SinglePropertyGroupViewModel : PropertyGroupViewModel
    {
        public new delegate SinglePropertyGroupViewModel Factory(IZetboxContext dataCtx, ViewModel parent, string tagName, string title, IEnumerable<ViewModel> lst);

        public SinglePropertyGroupViewModel(
            IViewModelDependencies appCtx, IZetboxContext dataCtx, ViewModel parent,
            string tagName, 
            string title,
            IEnumerable<ViewModel> lst)
            : base(appCtx, dataCtx, parent, tagName, title, lst)
        {
        }

        public ViewModel PropertyModel
        {
            get
            {
                return PropertyModels.Single();
            }
        }

    }

    public class MultiplePropertyGroupViewModel : PropertyGroupViewModel
    {
        public new delegate MultiplePropertyGroupViewModel Factory(IZetboxContext dataCtx, ViewModel parent, string tagName, string title, IEnumerable<ViewModel> lst);

        public MultiplePropertyGroupViewModel(
            IViewModelDependencies appCtx, IZetboxContext dataCtx, ViewModel parent,
            string tagName, 
            string title,
            IEnumerable<ViewModel> lst)
            : base(appCtx, dataCtx, parent, tagName, title, lst)
        {
        }
    }

    public class CustomPropertyGroupViewModel : PropertyGroupViewModel
    {
        public new delegate CustomPropertyGroupViewModel Factory(IZetboxContext dataCtx, ViewModel parent, string tagName, string title, IEnumerable<ViewModel> lst);

        public CustomPropertyGroupViewModel(
            IViewModelDependencies appCtx, IZetboxContext dataCtx, ViewModel parent,
            string tagName, 
            string title,
            IEnumerable<ViewModel> lst)
            : base(appCtx, dataCtx, parent, tagName, title, lst)
        {
            // die fast
            if (lst.Count() != 1) throw new ArgumentException("lst may only contain exact one element", "lst");
        }

        public ViewModel CustomModel
        {
            get
            {
                return PropertyModels.Single();
            }
        }

    }

    public class CustomPropertyListGroupViewModel : PropertyGroupViewModel
    {
        public new delegate CustomPropertyListGroupViewModel Factory(IZetboxContext dataCtx, ViewModel parent, string tagName, string title, IEnumerable<ViewModel> lst);

        public CustomPropertyListGroupViewModel(
            IViewModelDependencies appCtx, IZetboxContext dataCtx, ViewModel parent,
            string tagName,
            string title,
            IEnumerable<ViewModel> lst)
            : base(appCtx, dataCtx, parent, tagName, title, lst)
        {
        }
    }
}
