// <autogenerated/>

namespace Kistl.App.Test
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// 
    /// </summary>
    public interface TestCustomObject : IDataObject 
    {

        /// <summary>
        /// Happy Birthday!
        /// </summary>
		DateTime? Birthday {
			get;
			set;
		}
        /// <summary>
        /// 
        /// </summary>
		Kistl.App.Test.Muhblah MubBlah_Nav {
			get;
			set;
		}
        /// <summary>
        /// Person&apos;s Name
        /// </summary>
		string PersonName {
			get;
			set;
		}
    }
}