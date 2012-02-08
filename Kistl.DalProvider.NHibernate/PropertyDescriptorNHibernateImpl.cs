
namespace Kistl.DalProvider.NHibernate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Kistl.API;
    using Kistl.App.Base;

    public class PropertyDescriptorNHibernateImpl<TComponent, TProperty>
        : BaseCustomPropertyDescriptor<TComponent, TProperty>
    {
        private readonly Func<IFrozenContext> _lazyCtx;
        private readonly Guid? _propertyGuid;

        public PropertyDescriptorNHibernateImpl(
            Func<IFrozenContext> lazyCtx,
            Guid? propertyGuid,
            string name,
            Attribute[] attrs,
            Func<TComponent, TProperty> getter,
            Action<TComponent, TProperty> setter,
            Func<TComponent, PropertyIsValidHandler<TComponent>> isValid)
            : base(name, attrs, getter, setter, isValid)
        {
            _lazyCtx = lazyCtx;
            _propertyGuid = propertyGuid;
        }

        public override string[] GetValidationErrors(object component)
        {
            IReadOnlyKistlContext ctx;
            if (_lazyCtx != null && _propertyGuid != null && (ctx = _lazyCtx()) != null)
            {
                var property = ctx.FindPersistenceObject<Kistl.App.Base.Property>(_propertyGuid.Value);
                var self = (TComponent)component;
                var val = getter(self);
                return property
                    .Constraints
                    .Where(c => !c.IsValid(self, val))
                    .Select(c => c.GetErrorText(self, val))
                    .Concat(TryExecuteIsValidEvent(self))
                    .ToArray();
            }
            else
            {
                return NoErrors;
            }
        }
    }
}
