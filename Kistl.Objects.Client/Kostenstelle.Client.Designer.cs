//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.1433
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kistl.App.Zeiterfassung
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Collections;
    using System.Xml;
    using System.Xml.Serialization;
    using Kistl.API;
    using Kistl.API.Client;
    
    
    public class Kostenstelle : Kistl.App.Zeiterfassung.Zeitkonto, ICloneable
    {
        
        public event ToStringHandler<Kostenstelle> OnToString_Kostenstelle;
        
        public event ObjectEventHandler<Kostenstelle> OnPreSave_Kostenstelle;
        
        public event ObjectEventHandler<Kostenstelle> OnPostSave_Kostenstelle;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Kostenstelle != null)
            {
                OnToString_Kostenstelle(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Kostenstelle != null) OnPreSave_Kostenstelle(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Kostenstelle != null) OnPostSave_Kostenstelle(this);
        }
        
        public override object Clone()
        {
            Kostenstelle obj = new Kostenstelle();
            CopyTo(obj);
            return obj;
        }
        
        public void CopyTo(Kostenstelle obj)
        {
            base.CopyTo(obj);
        }
    }
}
