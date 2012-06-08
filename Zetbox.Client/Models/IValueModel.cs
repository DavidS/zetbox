
namespace Zetbox.Client.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using Zetbox.API;
    using Zetbox.API.Utils;
    using Zetbox.App.Base;
    using Zetbox.App.GUI;
    using Zetbox.Client.Presentables;

    public interface IValueModel : INotifyPropertyChanged, IDataErrorInfo
    {
        /// <summary>
        /// Gets a value indicating whether or not to allow <value>null</value> as input.
        /// </summary>
        bool AllowNullInput { get; }

        /// <summary>
        /// Gets a label to display with the Value.
        /// </summary>
        string Label { get; }

        /// <summary>
        /// Gets a tooltip to display with the Value.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets a value indicating whether or not the property may be edited
        /// </summary>
        bool IsReadOnly { get; }

        /// <summary>
        /// Clears the value of this Model. After calling this method the value should be <value>null</value> or "empty".
        /// </summary>
        void ClearValue();

        /// <summary>
        /// Returns the untyped value
        /// </summary>
        /// <returns></returns>
        object GetUntypedValue();

        /// <summary>
        /// DefaultKind override from the underlying Value model.
        /// </summary>
        ControlKind RequestedKind { get; }
    }

    public interface IValueModel<TValue> : IValueModel
    {
        TValue Value { get; set; }
    }

    public interface IEnumerationValueModel : IValueModel<int?>
    {
        Enumeration Enumeration { get; }
        IEnumerable<KeyValuePair<int, string>> GetEntries();
    }

    public interface IDateTimeValueModel : IValueModel<DateTime?>
    {
        DateTimeStyles DateTimeStyle { get; }
    }

    public interface IDecimalValueModel : IValueModel<decimal?>
    {
        int? Precision { get; }
        int? Scale { get; }
    }

    public interface IBoolValueModel : IValueModel<bool?>
    {
        Zetbox.App.GUI.Icon FalseIcon { get; }
        string FalseLabel { get; }

        Zetbox.App.GUI.Icon NullIcon { get; }
        string NullLabel { get; }

        Zetbox.App.GUI.Icon TrueIcon { get; }
        string TrueLabel { get; }
    }

    public interface IObjectReferenceValueModel : IValueModel<IDataObject>
    {
        ObjectClass ReferencedClass { get; }
        RelationEnd RelEnd { get; }
    }

    public interface ICompoundObjectValueModel : IValueModel<ICompoundObject>
    {
        CompoundObject CompoundObjectDefinition { get; }
    }

    public interface IListValueModel<TValue> : IValueModel<IList<TValue>>, INotifyCollectionChanged
    {
        IEnumerable UnderlyingCollection { get; }
    }

    public interface ICompoundCollectionValueModel : IListValueModel<ICompoundObject>
    {
        CompoundObject CompoundObjectDefinition { get; }
    }

    // TODO: refactor to use ICollectionValueModel<TValue>
    public interface IObjectCollectionValueModel<TCollection> : IValueModel<TCollection>, INotifyCollectionChanged
    {
        ObjectClass ReferencedClass { get; }
        RelationEnd RelEnd { get; }
        IEnumerable UnderlyingCollection { get; }
        bool? IsInlineEditable { get; }
    }
}
