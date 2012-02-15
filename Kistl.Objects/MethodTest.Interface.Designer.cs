// <autogenerated/>

namespace Kistl.App.Test
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Test class for methods
    /// </summary>
    public interface MethodTest : IDataObject 
    {

        /// <summary>
        /// 
        /// </summary>

        ICollection<Kistl.App.Test.MethodTest> Children { get; }

        /// <summary>
        /// 
        /// </summary>
        Kistl.App.Test.MethodTest Parent {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        string StringProp {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        void Group1();

        /// <summary>
        /// 
        /// </summary>
        void Group2();

        /// <summary>
        /// 
        /// </summary>
        void ObjParameter(Kistl.App.Test.MethodTest objParam);

        /// <summary>
        /// 
        /// </summary>
        Kistl.App.Test.MethodTest ObjRet();

        /// <summary>
        /// 
        /// </summary>
        void Parameterless();

        /// <summary>
        /// 
        /// </summary>
        void StringParameter(string str);

        /// <summary>
        /// 
        /// </summary>
        void Summary();
    }
}
