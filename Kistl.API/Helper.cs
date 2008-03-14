using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Collections;
using System.Reflection;
using TraceClient;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Kistl.API
{
    /// <summary>
    /// Globale Helpermethoden
    /// </summary>
    public sealed class Helper
    {
        public const int INVALIDID = -1;

        public static string GetLegalPathName(string path)
        {
            System.IO.Path.GetInvalidPathChars().ToList().ForEach(c => path = path.Replace(c, '_'));

            return path;
        }

        private static string _WorkingFolder;
        public static string WorkingFolder
        {
            get
            {
                if (string.IsNullOrEmpty(_WorkingFolder))
                {
                    _WorkingFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    _WorkingFolder += _WorkingFolder.EndsWith(@"\") ? "" : @"\";

                    _WorkingFolder += @"dasz\Kistl\"
                        + Helper.GetLegalPathName(Configuration.KistlConfig.Current.ConfigName)
                        + @"\"
                        + Helper.GetLegalPathName(AppDomain.CurrentDomain.FriendlyName)
                        + @"\";

                    System.IO.Directory.CreateDirectory(_WorkingFolder);
                }
                return _WorkingFolder;
            }
        }
        /// <summary>
        /// prevent this class from being instantiated
        /// </summary>
        private Helper() { }
    }

    /// <summary>
    /// C# Extensions
    /// </summary>
    public static class ExtensionHelpers
    {
        /// <summary>
        /// Objekt in einen XML String umwandeln
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToXmlString(this object obj)
        {
            using (TraceHelper.TraceMethodCall())
            {
                XmlSerializer xml = new XmlSerializer(obj.GetType());
                StringBuilder sb = new StringBuilder();
                xml.Serialize(new System.IO.StringWriter(sb), obj);
                return sb.ToString();
            }
        }

        /// <summary>
        /// XML String in Objekt umwandeln
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmlStr"></param>
        /// <returns></returns>
        public static T FromXmlString<T>(this string xmlStr) where T : new()
        {
            using (TraceHelper.TraceMethodCall("Size = {0}", xmlStr.Length))
            {
                System.IO.StringReader sr = new System.IO.StringReader(xmlStr);
                XmlSerializer xml = new XmlSerializer(typeof(T));
                return (T)xml.Deserialize(sr);
            }
        }

        public static bool In(this Enum e, params object[] p)
        {
            foreach (object v in p)
            {
                if (e.Equals(v)) return true;
            }
            return false;
        }

        public static T GetPropertyValue<T>(this object obj, string propName)
        {
            if (obj == null) return default(T);
            PropertyInfo pi = obj.GetType().GetProperty(propName);
            if (pi == null) throw new ArgumentOutOfRangeException("propName", string.Format("Property {0} was not found in Type {1}", propName, obj.GetType().FullName));
            return (T)pi.GetValue(obj, null);
        }

        public static void SetPropertyValue<T>(this object obj, string propName, T val)
        {
            PropertyInfo pi = obj.GetType().GetProperty(propName);
            if (pi == null) throw new ArgumentOutOfRangeException("propName", string.Format("Property {0} was not found in Type {1}", propName, obj.GetType().FullName));
            pi.SetValue(obj, val, null);
        }

        public static void ForEach<T>(this IEnumerable lst, Action<T> action)
        {
            foreach(T obj in lst)
            {
                action(obj);
            }
        }

        public static List<T> Clone<T>(this List<T> lst) where T : ICloneable
        {
            List<T> result = new List<T>(lst.Capacity);

            lst.ForEach(item => result.Add((T)item.Clone()));

            return result;
        }

        public static ObservableCollection<T> Clone<T>(this ObservableCollection<T> lst) where T : ICloneable
        {
            ObservableCollection<T> result = new ObservableCollection<T>();

            lst.ForEach<T>(item => result.Add((T)item.Clone()));

            return result;
        }

        public static NotifyingObservableCollection<T> Clone<T>(this NotifyingObservableCollection<T> lst, IDataObject newParent) where T : ICloneable, INotifyPropertyChanged
        {
            NotifyingObservableCollection<T> result = new NotifyingObservableCollection<T>(newParent, lst.PropertyName);

            lst.ForEach<T>(item => result.Add((T)item.Clone()));

            return result;
        }

        public static void ForEach<T>(this ObservableCollection<T> lst, Action<T> action)
        {
            foreach (T i in lst)
            {
                action.Invoke(i);
            }
        }
    }
}
