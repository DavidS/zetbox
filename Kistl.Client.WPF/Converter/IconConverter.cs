
namespace Kistl.Client.WPF.Converter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Data;

    using Kistl.API;
    using Kistl.API.Client;

    [ValueConversion(typeof(IDataObject), typeof(string))]
    public class IconConverter : IValueConverter
    {
        private string GetIconPath(string name)
        {
            string result = ApplicationContext.Current.Configuration.Client.DocumentStore
                + @"\GUI.Icons\"
                + name;
            result = System.IO.Path.IsPathRooted(result) ? result : Environment.CurrentDirectory + "\\" + result;
            return result;
        }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is Kistl.App.Base.ObjectClass)
            {
                Kistl.App.Base.ObjectClass objClass = (Kistl.App.Base.ObjectClass)value;
                if (objClass.DefaultIcon != null)
                {
                    return GetIconPath(objClass.DefaultIcon.IconFile);
                }
                else
                {
                    return Binding.DoNothing;
                }
            }
            else if (value is Kistl.App.GUI.Icon)
            {
                Kistl.App.GUI.Icon obj = (Kistl.App.GUI.Icon)value;
                return GetIconPath(obj.IconFile);
            }
            else if (value is IDataObject)
            {
                IDataObject obj = (IDataObject)value;
                if (ClientHelper.ObjectClasses[obj.GetInterfaceType()].DefaultIcon != null)
                {
                    return GetIconPath(ClientHelper.ObjectClasses[obj.GetInterfaceType()].DefaultIcon.IconFile);
                }
                else
                {
                    return Binding.DoNothing;
                }
            }
            else if (value is Kistl.Client.Presentables.DataObjectModel)
            {
                string path = (value as Kistl.Client.Presentables.DataObjectModel).IconPath;
                return String.IsNullOrEmpty(path) ? Binding.DoNothing : path;
            }

            return GetIconPath("error.ico");
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // not implemented
            return Binding.DoNothing;
        }
    }
}
