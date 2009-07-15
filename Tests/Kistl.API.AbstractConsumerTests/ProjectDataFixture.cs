
namespace Kistl.API.AbstractConsumerTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Kistl.API;
    using Kistl.App.Base;
    using Kistl.App.Projekte;

    using NUnit.Framework;

    /// <summary>
    /// This fixture creates a set of Kunden, Projekte, Mitarbeiter and Tasks for testing.
    /// </summary>
    public abstract class ProjectDataFixture
    {
        /// <summary>
        /// Creates a few new test objects
        /// </summary>
        /// <param name="ctx">this context is used to create the objects</param>
        public static void CreateTestData(IKistlContext ctx)
        {
            var kunde = ctx.Create<Kunde>();
            kunde.EMails.Add("office@example.com");
            kunde.EMails.Add("privat@example.com");
            kunde.Kundenname = "com Kunde";
            kunde.PLZ = "1111";

            kunde = ctx.Create<Kunde>();
            kunde.EMails.Add("office@example.net");
            kunde.Kundenname = "net Kunde";
            kunde.PLZ = "2222";

            kunde = ctx.Create<Kunde>();
            kunde.Kundenname = "empty Kunde";
            kunde.PLZ = "3333";

            kunde = ctx.Create<Kunde>();
            kunde.EMails.Add("office@example.org");
            kunde.EMails.Add("privat@example.org");
            kunde.EMails.Add("muh@example.org");
            kunde.EMails.Add("blah@example.org");
            kunde.Kundenname = "org Kunde";
            kunde.PLZ = "4444";

            var prj = ctx.Create<Projekt>();
            prj.Name = "Kistl";

            var task1 = ctx.Create<Task>();
            task1.Projekt = prj;

            var task2 = ctx.Create<Task>();
            task2.Projekt = prj;

            var ma1 = ctx.Create<Mitarbeiter>();
            ma1.Geburtstag = new DateTime(1960, 01, 02);
            ma1.Name = "Mitarbeiter Alpha";
            ma1.Projekte.Add(prj);
            ma1.SVNr = "123456789";
            ma1.TelefonNummer = "+43664123456789";

            var ma2 = ctx.Create<Mitarbeiter>();
            ma2.Geburtstag = new DateTime(1970, 12, 30);
            ma2.Name = "Mitarbeiter Beta";
            ma2.Projekte.Add(prj);
            ma2.SVNr = "987654321";
            ma2.TelefonNummer = "+43664987654321";
        }

        /// <summary>
        /// Deletes all remaining test objects.
        /// </summary>
        /// <param name="ctx">this context is used to delete the objects</param>
        public static void DeleteData(IKistlContext ctx)
        {
            ctx.GetQuery<Kunde>().ForEach(obj => ctx.Delete(obj));
            ctx.GetQuery<Projekt>().ForEach(obj => { obj.Mitarbeiter.Clear(); obj.Tasks.Clear(); ctx.Delete(obj); });
            ctx.GetQuery<Task>().ForEach(obj => ctx.Delete(obj));
            ctx.GetQuery<Mitarbeiter>().ForEach(obj => ctx.Delete(obj));
        }

        /// <summary>
        /// Override this method to provide the context under test.
        /// </summary>
        /// <returns>a context that can be used for creating and deleting the test objects</returns>
        protected abstract IKistlContext GetContext();

        /// <summary>
        /// Deletes all existing test data and creates new objects.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            using (var ctx = GetContext())
            {
                DeleteData(ctx);
                CreateTestData(ctx);
                ctx.SubmitChanges();
            }
        }

        /// <summary>
        /// Deletes all remaining test data.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            using (var ctx = GetContext())
            {
                DeleteData(ctx);
                ctx.SubmitChanges();
            }
        }
    }
}
