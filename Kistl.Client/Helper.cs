using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.API;
using Kistl.API.Client;

namespace Kistl.Client
{
    /// <summary>
    /// Client Helper Methods
    /// </summary>
    public class Helper
    {
        /// <summary>
        /// Auch das könnte man besser implementieren
        /// </summary>
        /// <param name="ex"></param>
        public static void HandleError(Exception ex)
        {
            System.Windows.MessageBox.Show(ex.ToString());
        }

        private static Dictionary<ObjectType, Kistl.App.Base.ObjectClass> _ObjectClasses = null;

        public static Dictionary<ObjectType, Kistl.App.Base.ObjectClass> ObjectClasses
        {
            get
            {
                if (_ObjectClasses == null)
                {
                    _ObjectClasses = new Dictionary<ObjectType,Kistl.App.Base.ObjectClass>();
                    Kistl.App.Base.ObjectClassClient clientObjectClasses = new Kistl.App.Base.ObjectClassClient();
                    Kistl.App.Base.ModuleClient clientModules = new Kistl.App.Base.ModuleClient();
                    Dictionary<int, Kistl.App.Base.Module> modules = new Dictionary<int, Kistl.App.Base.Module>();
                    clientModules.GetList().ForEach(m => modules[m.ID] = m);
                    clientObjectClasses.GetList().ForEach(o => _ObjectClasses.Add(
                        new ObjectType(modules[o.fk_Module].Namespace, o.ClassName), o));
                }

                return _ObjectClasses;
            }
        }
    }
}
