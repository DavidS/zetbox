using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kistl.API.Server
{
    /// <summary>
    /// Factory for Context Objects.
    /// </summary>
    public static class KistlContext
    {
        private readonly static object _lock = new object();
        private static Type _KistlDataContextType = null;

        /// <summary>
        /// Creates a new Context.
        /// </summary>
        /// <returns>A new Context.</returns>
        public static IKistlContext GetContext()
        {
            return GetServerContext();
        }

        public static IKistlServerContext GetServerContext()
        {
            lock (_lock)
            {
                if (_KistlDataContextType == null)
                {
                    _KistlDataContextType = Type.GetType(ApplicationContext.Current.Configuration.Server.KistlDataContextType);
                    if (_KistlDataContextType == null)
                    {
                        throw new Configuration.ConfigurationException(string.Format("Unable to load Type '{0}' for IKistlObjects. Check your Configuration '/Server/KistlDataContextType'.", ApplicationContext.Current.Configuration.Server.KistlDataContextType));
                    }
                }
            }
            object obj = Activator.CreateInstance(_KistlDataContextType);
            if (!(obj is IKistlContext))
            {
                throw new Configuration.ConfigurationException(string.Format("Type '{0}' is not a IKistlContext object. Check your Configuration '/Server/KistlDataContextType'.", ApplicationContext.Current.Configuration.Server.KistlDataContextType));
            }
            return (IKistlServerContext)obj;
        }
    }
}
