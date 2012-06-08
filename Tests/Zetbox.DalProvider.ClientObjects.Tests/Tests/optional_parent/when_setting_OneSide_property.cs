
namespace Zetbox.DalProvider.Client.Tests.optional_parent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Zetbox.API;
    using Zetbox.App.Test;

    using NUnit.Framework;

    public class when_setting_OneSide_property
        : Zetbox.API.AbstractConsumerTests.optional_parent.when_setting_OneSide_property
    {
        public class after_reloading
            : when_setting_OneSide_property
        {
            public override void InitTestObjects()
            {
                base.InitTestObjects();
                SubmitAndReload();
            }
        }
        public class and_reloading
            : when_setting_OneSide_property
        {
            protected override void DoModification()
            {
                base.DoModification();
                SubmitAndReload();
            }
            protected override DataObjectState GetExpectedModifiedState()
            {
                return DataObjectState.Unmodified; // after submit changes, all objects should be unmodified
            }
        }
    }
}
