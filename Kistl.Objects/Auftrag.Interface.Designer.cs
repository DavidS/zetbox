
namespace Kistl.App.Projekte
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// 
    /// </summary>
    public interface Auftrag : IDataObject 
    {

        /// <summary>
        /// 
        /// </summary>

		Kistl.App.Projekte.Mitarbeiter Mitarbeiter { get; set; }
        /// <summary>
        /// Projekt zum Auftrag
        /// </summary>

		Kistl.App.Projekte.Projekt Projekt { get; set; }
        /// <summary>
        /// Kunde des Projektes
        /// </summary>

		Kistl.App.Projekte.Kunde Kunde { get; set; }
        /// <summary>
        /// Bitte füllen Sie einen sprechenden Auftragsnamen aus
        /// </summary>

		string Auftragsname { get; set; }
        /// <summary>
        /// Wert in EUR des Auftrages
        /// </summary>

		double? Auftragswert { get; set; }
        /// <summary>
        /// Testmethode zum Erstellen von Rechnungen mit Word
        /// </summary>

		 void RechnungErstellen() ;
    }
}