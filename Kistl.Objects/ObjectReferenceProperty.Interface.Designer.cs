// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Metadefinition Object for ObjectReference Properties.
    /// </summary>
    public interface ObjectReferenceProperty : Kistl.App.Base.Property 
    {

        /// <summary>
        /// Pointer zur Objektklasse
        /// </summary>
		Kistl.App.Base.ObjectClass ReferenceObjectClass {
			get;
			set;
		}
        /// <summary>
        /// The RelationEnd describing this Property
        /// </summary>
		Kistl.App.Base.RelationEnd RelationEnd {
			get;
			set;
		}
    }
}