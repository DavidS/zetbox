
namespace Kistl.App.Zeiterfassung
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// 
    /// </summary>
    public interface Zeitkonto : IDataObject 
    {

        /// <summary>
        /// Name des Zeiterfassungskontos
        /// </summary>

		string Kontoname { get; set; }
        /// <summary>
        /// Tätigkeiten
        /// </summary>

        ICollection<Kistl.App.Zeiterfassung.Taetigkeit> Taetigkeiten { get; }
        /// <summary>
        /// Zugeordnete Mitarbeiter
        /// </summary>

        ICollection<Kistl.App.Projekte.Mitarbeiter> Mitarbeiter { get; }
        /// <summary>
        /// Maximal erlaubte Stundenanzahl
        /// </summary>

		double? MaxStunden { get; set; }
        /// <summary>
        /// Aktuell gebuchte Stunden
        /// </summary>

		double? AktuelleStunden { get; set; }
    }
}