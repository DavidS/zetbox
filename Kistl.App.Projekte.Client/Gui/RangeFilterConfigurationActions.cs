namespace Kistl.App.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Kistl.API;
    using Kistl.App.Base;
    using Kistl.Client;
    using Kistl.Client.Models;
    using Kistl.Client.Presentables;
    using ViewModelDescriptors = Kistl.NamedObjects.Gui.ViewModelDescriptors;

    /// <summary>
    /// Client implementation
    /// </summary>
    [Implementor]
    public static class RangeFilterConfigurationActions
    {
        [Invocation]
        public static void CreateFilterModel(Kistl.App.GUI.RangeFilterConfiguration obj, MethodReturnEventArgs<Kistl.API.IFilterModel> e)
        {
            var mdl = new RangeFilterModel();
            mdl.Label = obj.GetLabel();
            mdl.Required = obj.Required;
            mdl.ValueSource = FilterValueSource.FromProperty(obj.Property);

            mdl.ViewModelType = obj.ViewModelDescriptor;
            mdl.RequestedKind = obj.RequestedKind;

            mdl.FilterArguments.Add(new FilterArgumentConfig(obj.Property.GetDetachedValueModel(true), /*cfg.ArgumentViewModel ?? */ obj.Property.ValueModelDescriptor));
            mdl.FilterArguments.Add(new FilterArgumentConfig(obj.Property.GetDetachedValueModel(true), /*cfg.ArgumentViewModel ?? */ obj.Property.ValueModelDescriptor));
            e.Result = mdl;
        }

        [Invocation]
        public static void NotifyCreated(Kistl.App.GUI.RangeFilterConfiguration obj)
        {
            obj.ViewModelDescriptor = ViewModelDescriptors.Kistl_Client_Presentables_FilterViewModels_RangeFilterViewModel.Find(obj.Context);
        }
    }
}
