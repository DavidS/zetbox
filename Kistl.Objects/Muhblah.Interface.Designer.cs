// <autogenerated/>

namespace Kistl.App.Test
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// 
    /// </summary>
    public interface Muhblah : IDataObject 
    {

        /// <summary>
        /// 
        /// </summary>
		bool? TestBool {
			get;
			set;
		}
        /// <summary>
        /// 
        /// </summary>

        ICollection<Kistl.App.Test.TestCustomObject> TestCustomObjects_List_Nav { get; }
        /// <summary>
        /// 
        /// </summary>
		DateTime? TestDateTime {
			get;
			set;
		}
        /// <summary>
        /// 
        /// </summary>
		Kistl.App.Test.TestEnum TestEnum {
			get;
			set;
		}
        /// <summary>
        /// 
        /// </summary>
		string TestString {
			get;
			set;
		}
    }
}