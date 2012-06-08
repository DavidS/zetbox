namespace Zetbox.App.Base
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Zetbox.API;

    [Implementor]
    public static class IdentityActions
    {
        [Invocation]
        public static void ToString(Zetbox.App.Base.Identity obj, MethodReturnEventArgs<string> e)
        {
            e.Result = (obj.DisplayName ?? string.Empty) + " (" + (obj.UserName ?? string.Empty) + ")";

            ToStringHelper.FixupFloatingObjectsToString(obj, e);
        }

    }
}
