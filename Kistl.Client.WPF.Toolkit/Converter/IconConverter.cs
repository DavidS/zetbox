
namespace Kistl.Client.WPF.Converter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Data;

    using Kistl.API;
    using Kistl.API.Client;
    using Kistl.App.Extensions;
    using System.Windows.Media.Imaging;

    [ValueConversion(typeof(IDataObject), typeof(string))]
    public class IconConverter : IValueConverter
    {
        private readonly IFrozenContext FrozenContext;
        private readonly IKistlContext Context;
        private readonly Dictionary<Guid, BitmapImage> _cache = new Dictionary<Guid, BitmapImage>();

        public IconConverter(IFrozenContext frozenCtx, IKistlContext ctx)
        {
            this.FrozenContext = frozenCtx;
            this.Context = ctx;
        }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Kistl.App.GUI.Icon icon = null;
            if (value is Kistl.App.Base.ObjectClass)
            {
                Kistl.App.Base.ObjectClass objClass = (Kistl.App.Base.ObjectClass)value;
                icon = objClass.DefaultIcon;
            }
            else if (value is Kistl.App.GUI.Icon)
            {
                icon = (Kistl.App.GUI.Icon)value;
            }
            else if (value is IDataObject)
            {
                IDataObject obj = (IDataObject)value;
                icon = obj.GetObjectClass(FrozenContext).DefaultIcon;
            }
            else if (value is Kistl.Client.Presentables.IViewModelWithIcon)
            {
                icon = ((Kistl.Client.Presentables.IViewModelWithIcon)value).Icon;
            }

            if (icon == null)
            {
                return Binding.DoNothing;
            }
            else
            {
                // Not initialized yet
                if (icon.ObjectState == DataObjectState.New) return Binding.DoNothing;

                BitmapImage bmp;
                if (!_cache.TryGetValue(icon.ExportGuid, out bmp))
                {
                    var realIcon = Context.FindPersistenceObject<Kistl.App.GUI.Icon>(icon.ExportGuid);
                    bmp = new BitmapImage();
                    bmp.BeginInit();
                    bmp.StreamSource = realIcon.Blob != null ? realIcon.Blob.GetStream() : null;
                    bmp.EndInit();
                    _cache[icon.ExportGuid] = bmp;
                }
                return bmp;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // not implemented
            return Binding.DoNothing;
        }
    }
}
