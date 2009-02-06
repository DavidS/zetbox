
namespace Kistl.App.Projekte
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// 
    /// </summary>
    public interface Projekt : IDataObject 
    {

        /// <summary>
        /// 
        /// </summary>

        ICollection<Kistl.App.Projekte.Task> Tasks { get; }
        /// <summary>
        /// 
        /// </summary>

        IList<Kistl.App.Projekte.Mitarbeiter> Mitarbeiter { get; }
        /// <summary>
        /// Kostenträger
        /// </summary>

        ICollection<Kistl.App.Zeiterfassung.Kostentraeger> Kostentraeger { get; }
        /// <summary>
        /// Aufträge
        /// </summary>

        ICollection<Kistl.App.Projekte.Auftrag> Auftraege { get; }
        /// <summary>
        /// Projektname
        /// </summary>

		string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>

		double? AufwandGes { get; set; }
        /// <summary>
        /// Bitte geben Sie den Kundennamen ein
        /// </summary>

		string Kundenname { get; set; }
    }
}