using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.API.Server;
using Kistl.API;

namespace Kistl.App.Projekte
{
    /// <summary>
    /// Server implementation
    /// </summary>
    [Implementor]
    public static class ProjektActions
    {
        /// <summary>
        /// PreSave für Projekte, beim Projektnamen "_action" hinzufügen.
        /// Sinnlos, aber ganz lustig
        /// </summary>
        [Invocation]
        public static void NotifyPreSave(Projekt obj)
        {
            if (obj.ObjectState == Kistl.API.DataObjectState.Modified)
            {
                obj.AufwandGes = obj.Tasks.Sum(t => t.Aufwand);
            }
        }

        [Invocation]
        public static void GetSummaryReport(Projekt obj, MethodReturnEventArgs<System.Object> e, Kistl.App.Base.DateTimeRange range)
        {
            e.Result = string.Format("This will be a summary report in the range {0}", range);
        }
    }
}
