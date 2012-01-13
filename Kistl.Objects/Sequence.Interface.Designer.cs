// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Provides the definition of a database sequence
    /// </summary>
    public interface Sequence : IDataObject, Kistl.App.Base.IChangedBy, Kistl.App.Base.IExportable, Kistl.App.Base.IModuleMember, Kistl.App.Base.INamedObject 
    {

        /// <summary>
        /// The current number of this Sequence. This is calculated from the Data and initialises this, if not available.
        /// </summary>
        int? CurrentNumber {
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        Kistl.App.Base.SequenceData Data {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        string Description {
            get;
            set;
        }

        /// <summary>
        /// Set to true if the sequence is guaranteed to be continous
        /// </summary>
        bool IsContinuous {
            get;
            set;
        }
    }
}
