namespace Zetbox.App.Base
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Zetbox.API;

    [Implementor]
    public static class NewGuidDefaultValueActions
    {
        [Invocation]
        public static void GetDefaultValue(Zetbox.App.Base.NewGuidDefaultValue obj, MethodReturnEventArgs<System.Object> e)
        {
            e.Result = Guid.NewGuid();
        }

        [Invocation]
        public static void ToString(Zetbox.App.Base.NewGuidDefaultValue obj, MethodReturnEventArgs<string> e)
        {
            if (obj.Property != null)
            {
                e.Result = string.Format("{0} will be initialized with a new Guid", obj.Property.Name);
            }
            else
            {
                e.Result = "Initializes a property with a new Guid";
            }
        }
    }
}
