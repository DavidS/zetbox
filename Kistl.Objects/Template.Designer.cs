//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kistl.App.GUI
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
    
    
    public interface Template : IDataObject
    {
        
        /// <summary>
        /// a short name to identify this Template to the user
        /// </summary>
        string DisplayName
        {
            get;
            set;
        }
        
        /// <summary>
        /// The visual representation of this Template
        /// </summary>
        Kistl.App.GUI.Visual VisualTree
        {
            get;
            set;
        }
        
        /// <summary>
        /// FullName of the Type that is displayed with this Template
        /// </summary>
        string DisplayedTypeFullName
        {
            get;
            set;
        }
        
        /// <summary>
        /// Assembly of the Type that is displayed with this Template
        /// </summary>
        Kistl.App.Base.Assembly DisplayedTypeAssembly
        {
            get;
            set;
        }
        
        /// <summary>
        /// The main menu for this Template
        /// </summary>
        ICollection<Kistl.App.GUI.Visual> Menu
        {
            get;
        }
        
        void PrepareDefault(Kistl.App.Base.ObjectClass cls);
    }
}
