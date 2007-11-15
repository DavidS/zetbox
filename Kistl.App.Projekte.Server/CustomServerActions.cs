using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kistl.App.Projekte
{
    /// <summary>
    /// Implementierung durch den Entwickler der Custom Actions für den Server
    /// </summary>
    public partial class CustomServerActions : API.Server.ICustomServerActions
    {
        /// <summary>
        /// PreSave für Projekte, beim Projektnamen "_action" hinzufügen.
        /// Sinnlos, aber ganz lustig
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="obj"></param>
        void Projekt_OnPreSetObject(Projekt obj)
        {
            obj.AufwandGes = obj.Tasks.Sum(t => t.Aufwand);

            /*var result = (from t in Kistl.API.Server.KistlDataContext.Current.GetTable<Task>()
                          where t.fk_Projekt == obj.ID
                          select t).Sum(s => s.Aufwand);*/
        }

        /// <summary>
        /// Überprüfung eines Tasks - sinnlos, aber ganz lustig.
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="obj"></param>
        void Task_OnPreSetObject(Task obj)
        {
            if (obj.Aufwand < 0) throw new ApplicationException("Ungültiger Aufwand");
            if (obj.DatumBis < obj.DatumVon) throw new ApplicationException("Falsches Zeitalter");
        }

        /// <summary>
        /// Auch am Server ToString überschreiben.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        void Projekt_OnToString(Projekt obj, Kistl.API.ToStringEventArgs e)
        {
            e.Result = obj.Name;
        }

        /// <summary>
        /// Auch am Server ToString überschreiben.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        void Task_OnToString(Task obj, Kistl.API.ToStringEventArgs e)
        {
            if (obj.DatumVon.HasValue && obj.DatumBis.HasValue)
            {
                e.Result = string.Format("{0} [{1}] ({2} - {3})",
                    obj.Name, obj.Aufwand, obj.DatumVon.Value.ToShortDateString(), obj.DatumBis.Value.ToShortDateString());
            }
            else
            {
                e.Result = string.Format("{0} [{1}]",
                    obj.Name, obj.Aufwand);
            }
        }
    }
}
