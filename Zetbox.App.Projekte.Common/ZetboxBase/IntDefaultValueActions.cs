namespace Zetbox.App.Base
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Zetbox.API;

    [Implementor]
    public static class IntDefaultValueActions
    {
        [Invocation]
        public static void GetDefaultValue(Zetbox.App.Base.IntDefaultValue obj, MethodReturnEventArgs<object> e)
        {
            e.Result = obj.IntValue;
        }

        [Invocation]
        public static void ToString(Zetbox.App.Base.IntDefaultValue obj, MethodReturnEventArgs<System.String> e)
        {
            if (obj.Property != null)
            {
                e.Result = string.Format("{0} will be initialized with '{1}'",
                    obj.Property.Name,
                    obj.IntValue);
            }
            else
            {
                e.Result = "Initializes a property with a configured int value";
            }
        }
    }
}
