
namespace Zetbox.DalProvider.Ef.Tests.optional_parent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Zetbox.API;
    using Zetbox.App.Test;

    using NUnit.Framework;

    public class when_deleting_NSide_object
        : Zetbox.API.AbstractConsumerTests.optional_parent.when_deleting_NSide_object
    {
        public class after_reloading
                 : when_deleting_NSide_object
        {
            public override void InitTestObjects()
            {
                base.InitTestObjects();
                SubmitAndReload();
            }
        }
    }
}
