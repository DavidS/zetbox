// <autogenerated/>

namespace Zetbox.App.Projekte
{
    using System;
    using System.Collections.Generic;

    using Zetbox.API;

    /// <summary>
    /// 
    /// </summary>
    [Zetbox.API.DefinitionGuid("77933a20-338a-4961-b751-62ffa0a75c6a")]
    public interface Mitarbeiter : IDataObject, Zetbox.App.Base.IChangedBy, Zetbox.App.Base.IExportable 
    {

        /// <summary>
        /// Herzlichen Glückwunsch zum Geburtstag
        /// </summary>
        [Zetbox.API.DefinitionGuid("b10bf288-1252-49c3-9129-cfabb1637c47")]
        DateTime? Geburtstag {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("5e148730-ec8a-4349-bcf7-e59cef2ce29f")]
        Zetbox.App.Base.Identity Identity {
            get;
            set;
        }

        /// <summary>
        /// Vorname Nachname
        /// </summary>
        [Zetbox.API.DefinitionGuid("5aab79fd-3083-4ce1-a558-ed1449ecddce")]
        string Name {
            get;
            set;
        }

        /// <summary>
        /// Projekte des/der Mitarbeiters/Mitarbeiterin für die er/sie Verantwortlich ist
        /// </summary>

        [Zetbox.API.DefinitionGuid("1abb5a1b-ba9f-4b75-b6ea-3d28be877b7c")]
        IList<Zetbox.App.Projekte.Projekt> Projekte { get; }

        /// <summary>
        /// NNNN TTMMYY
        /// </summary>
        [Zetbox.API.DefinitionGuid("505988c4-dd50-4a0f-be21-a360b25e7d7d")]
        string SVNr {
            get;
            set;
        }

        /// <summary>
        /// +43 123 12345678
        /// </summary>
        [Zetbox.API.DefinitionGuid("73230333-f975-4f0b-9dd3-e850b48d9c13")]
        string TelefonNummer {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        DateTime TestMethodForParameter(bool TestBool, System.Guid TestCLRObjectParameter, DateTime TestDateTime, double TestDouble, int TestInt, Zetbox.App.Projekte.Auftrag TestObjectParameter, string TestString);
    }
}
