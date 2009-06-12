using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Kistl.API;
using Kistl.App.Base;

namespace Kistl.Client.Presentables.KistlBase
{
    /// <summary>
    /// Models a <see cref="System.Type"/>. Contains references to the Assembly and the respective TypeRef.
    /// </summary>
    public class SystemTypeModel
        : PresentableModel
    {
        private Type _type;

        public SystemTypeModel(
            IGuiApplicationContext appCtx, IKistlContext dataCtx,
            Type type)
            : base(appCtx, dataCtx)
        {
            _type = type;
        }

        #region Public Interface

        /// <summary>
        /// Returns a direct reference to the wrapped <see cref="Type"/>.
        /// </summary>
        public Type Value { get { return _type; } }

        /// <summary>
        /// Whether or not this Type's Assembly is already in the Database.
        /// If HasAssembly is true, the Assembly property contains the stored 
        /// assembly. if HasAssembly is false, the CreateAssembly command can
        /// construct a new Assembly.
        /// </summary>
        public bool HasAssembly { get { return this.Assembly != null; } }

        /// <summary>
        /// The Assembly containing this Type. MAY be null, see HasAssembly.
        /// </summary>
        public AssemblyModel Assembly { get; private set; }

        /// <summary>
        /// If the Assembly containing this Type is not yet stored in the data 
        /// store, this command can construct it.
        /// </summary>
        public ICommand CreateAssembly { get; private set; }

        #endregion
    }
}
