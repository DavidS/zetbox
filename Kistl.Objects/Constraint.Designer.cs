//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Collections;
    using System.Xml;
    using System.Xml.Serialization;
    using Kistl.API;
    
    
    public interface Constraint : IDataObject
    {
        
        Kistl.App.Base.BaseProperty ConstrainedProperty
        {
            get;
            set;
        }
        
        string Reason
        {
            get;
            set;
        }
        
        bool IsValid(object constrainedObj, object constrainedValue);
        
        string GetErrorText(object constrainedObject, object constrainedValue);
    }
}
