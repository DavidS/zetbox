// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// 
    /// </summary>
    public interface SequenceData : IDataObject 
    {

        /// <summary>
        /// 
        /// </summary>
        int CurrentNumber {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        Kistl.App.Base.Sequence Sequence {
            get;
            set;
        }
    }
}
