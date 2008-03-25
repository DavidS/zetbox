using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;

namespace Kistl.API
{
    /// <summary>
    /// Binary Serializer Helper.
    /// </summary>
    public class BinarySerializer
    {
        #region ToBinary
        /// <summary>
        /// Serialize a bool
        /// </summary>
        /// <param name="val">Value to serialize,</param>
        /// <param name="sw">BinaryWrite to serialize to.</param>
        public static void ToBinary(bool val, System.IO.BinaryWriter sw)
        {
            sw.Write(val);
        }

        /// <summary>
        /// Serialize a DateTime
        /// </summary>
        /// <param name="val">Value to serialize,</param>
        /// <param name="sw">BinaryWrite to serialize to.</param>
        public static void ToBinary(DateTime val, System.IO.BinaryWriter sw)
        {
            sw.Write(val.ToBinary());
        }

        /// <summary>
        /// Serialize a int
        /// </summary>
        /// <param name="val">Value to serialize,</param>
        /// <param name="sw">BinaryWrite to serialize to.</param>
        public static void ToBinary(int val, System.IO.BinaryWriter sw)
        {
            sw.Write(val);
        }

        /// <summary>
        /// Serialize a float
        /// </summary>
        /// <param name="val">Value to serialize,</param>
        /// <param name="sw">BinaryWrite to serialize to.</param>
        public static void ToBinary(float val, System.IO.BinaryWriter sw)
        {
            sw.Write(val);
        }

        /// <summary>
        /// Serialize a double
        /// </summary>
        /// <param name="val">Value to serialize,</param>
        /// <param name="sw">BinaryWrite to serialize to.</param>
        public static void ToBinary(double val, System.IO.BinaryWriter sw)
        {
            sw.Write(val);
        }

        /// <summary>
        /// Serialize a string. Format is: NULL (true/false), Value (if not null).
        /// </summary>
        /// <param name="val">Value to serialize,</param>
        /// <param name="sw">BinaryWrite to serialize to.</param>
        public static void ToBinary(string val, System.IO.BinaryWriter sw)
        {
            if (val != null) { sw.Write(true); sw.Write(val); } else sw.Write(false);
        }

        /// <summary>
        /// Serialize an ObjectType object. Format is: Namespace, Classname.
        /// </summary>
        /// <param name="val">Value to serialize,</param>
        /// <param name="sw">BinaryWrite to serialize to.</param>
        public static void ToBinary(ObjectType val, System.IO.BinaryWriter sw)
        {
            if (val == null) throw new ArgumentNullException("val");
            ToBinary(val.Namespace, sw);
            ToBinary(val.Classname, sw);
        }

        /// <summary>
        /// Serialize a nullable bool. Format is: NULL (true/false), Value (if not null).
        /// </summary>
        /// <param name="val">Value to serialize,</param>
        /// <param name="sw">BinaryWrite to serialize to.</param>
        public static void ToBinary(bool? val, System.IO.BinaryWriter sw)
        {
            if (val.HasValue) { sw.Write(true); sw.Write(val.Value); } else sw.Write(false);
        }

        /// <summary>
        /// Serialize a nullable DateTime. Format is: NULL (true/false), Value (if not null).
        /// </summary>
        /// <param name="val">Value to serialize,</param>
        /// <param name="sw">BinaryWrite to serialize to.</param>
        public static void ToBinary(DateTime? val, System.IO.BinaryWriter sw)
        {
            if (val.HasValue) { sw.Write(true); sw.Write(val.Value.ToBinary()); } else sw.Write(false);
        }

        /// <summary>
        /// Serialize a nullable int. Format is: NULL (true/false), Value (if not null).
        /// </summary>
        /// <param name="val">Value to serialize,</param>
        /// <param name="sw">BinaryWrite to serialize to.</param>
        public static void ToBinary(int? val, System.IO.BinaryWriter sw)
        {
            if (val.HasValue) { sw.Write(true); sw.Write(val.Value); } else sw.Write(false);
        }

        /// <summary>
        /// Serialize a nullable float. Format is: NULL (true/false), Value (if not null).
        /// </summary>
        /// <param name="val">Value to serialize,</param>
        /// <param name="sw">BinaryWrite to serialize to.</param>
        public static void ToBinary(float? val, System.IO.BinaryWriter sw)
        {
            if (val.HasValue) { sw.Write(true); sw.Write(val.Value); } else sw.Write(false);
        }

        /// <summary>
        /// Serialize a nullable double. Format is: NULL (true/false), Value (if not null).
        /// </summary>
        /// <param name="val">Value to serialize,</param>
        /// <param name="sw">BinaryWrite to serialize to.</param>
        public static void ToBinary(double? val, System.IO.BinaryWriter sw)
        {
            if (val.HasValue) { sw.Write(true); sw.Write(val.Value); } else sw.Write(false);
        }

        /// <summary>
        /// Serialize a IDataObject Collection. Format is: CONTINUE (true/false), IDataObject (if Object is present).
        /// </summary>
        /// <param name="val">Collection to serialize,</param>
        /// <param name="sw">BinaryWrite to serialize to.</param>
        public static void ToBinary(IEnumerable<IDataObject> val, System.IO.BinaryWriter sw)// where T : IDataObject
        {
            foreach (IDataObject obj in val)
            {
                ToBinary(true, sw);
                obj.ToStream(sw);
            }

            ToBinary(false, sw);
        }

        /// <summary>
        /// Serialize a ICollectionEntry Collection. Format is: CONTINUE (true/false), ICollectionEntry (if Object is present).
        /// </summary>
        /// <param name="val">Collection to serialize,</param>
        /// <param name="sw">BinaryWrite to serialize to.</param>
        public static void ToBinary<T>(ICollection<T> val, System.IO.BinaryWriter sw) where T : ICollectionEntry
        {
            foreach (ICollectionEntry obj in val)
            {
                ToBinary(true, sw);
                obj.ToStream(sw);
            }

            ToBinary(false, sw);
        }

        public static void ToBinary(SerializableExpression e, System.IO.BinaryWriter sw)
        {
            if (e != null)
            {
                sw.Write(true);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(sw.BaseStream, e);
            }
            else
            {
                sw.Write(false);
            }
        }
        #endregion

        #region FromBinary
        /// <summary>
        /// Deserialize a bool
        /// </summary>
        /// <param name="val">Destination Value.</param>
        /// <param name="sr">BinaryReader to deserialize from.</param>
        public static void FromBinary(out bool val, System.IO.BinaryReader sr)
        {
            val = sr.ReadBoolean();
        }

        /// <summary>
        /// Deserialize a DateTime
        /// </summary>
        /// <param name="val">Destination Value.</param>
        /// <param name="sr">BinaryReader to deserialize from.</param>
        public static void FromBinary(out DateTime val, System.IO.BinaryReader sr)
        {
            val = DateTime.FromBinary(sr.ReadInt64());
        }

        /// <summary>
        /// Deserialize a int
        /// </summary>
        /// <param name="val">Destination Value.</param>
        /// <param name="sr">BinaryReader to deserialize from.</param>
        public static void FromBinary(out int val, System.IO.BinaryReader sr)
        {
            val = sr.ReadInt32();
        }

        /// <summary>
        /// Deserialize a float
        /// </summary>
        /// <param name="val">Destination Value.</param>
        /// <param name="sr">BinaryReader to deserialize from.</param>
        public static void FromBinary(out float val, System.IO.BinaryReader sr)
        {
            val = sr.ReadSingle();
        }

        /// <summary>
        /// Deserialize a double
        /// </summary>
        /// <param name="val">Destination Value.</param>
        /// <param name="sr">BinaryReader to deserialize from.</param>
        public static void FromBinary(out double val, System.IO.BinaryReader sr)
        {
            val = sr.ReadDouble();
        }

        /// <summary>
        /// Deserialize a string, expected format: NULL (true/false), Value (if not null).
        /// </summary>
        /// <param name="val">Destination Value.</param>
        /// <param name="sr">BinaryReader to deserialize from.</param>
        public static void FromBinary(out string val, System.IO.BinaryReader sr)
        {
            val = sr.ReadBoolean() ? sr.ReadString() : null;
        }

        /// <summary>
        /// Deserialize a ObjectType Object, expected format: Namespace, Classname
        /// </summary>
        /// <param name="val">Destination Value.</param>
        /// <param name="sr">BinaryReader to deserialize from.</param>
        public static void FromBinary(out ObjectType val, System.IO.BinaryReader sr)
        {
            // I HATE THIS!!!! Give me my C## freinds back!
            // Properties or Indexer are not to be allowed to be used as out Parameter!
            string tmpN, tmpC;
            FromBinary(out tmpN, sr);
            FromBinary(out tmpC, sr);

            val = new ObjectType();
            val.Namespace = tmpN;
            val.Classname = tmpC;
        }

        /// <summary>
        /// Deserialize a nullable bool, expected format: NULL (true/false), Value (if not null).
        /// </summary>
        /// <param name="val">Destination Value.</param>
        /// <param name="sr">BinaryReader to deserialize from.</param>
        public static void FromBinary(out bool? val, System.IO.BinaryReader sr)
        {
            val = sr.ReadBoolean() ? (bool?)sr.ReadBoolean() : null;
        }

        /// <summary>
        /// Deserialize a nullable DateTime, expected format: NULL (true/false), Value (if not null).
        /// </summary>
        /// <param name="val">Destination Value.</param>
        /// <param name="sr">BinaryReader to deserialize from.</param>
        public static void FromBinary(out DateTime? val, System.IO.BinaryReader sr)
        {
            val = sr.ReadBoolean() ? (DateTime?)DateTime.FromBinary(sr.ReadInt64()) : null;
        }

        /// <summary>
        /// Deserialize a nullable int, expected format: NULL (true/false), Value (if not null).
        /// </summary>
        /// <param name="val">Destination Value.</param>
        /// <param name="sr">BinaryReader to deserialize from.</param>
        public static void FromBinary(out int? val, System.IO.BinaryReader sr)
        {
            val = sr.ReadBoolean() ? (int?)sr.ReadInt32() : null;
        }

        /// <summary>
        /// Deserialize a nullable float, expected format: NULL (true/false), Value (if not null).
        /// </summary>
        /// <param name="val">Destination Value.</param>
        /// <param name="sr">BinaryReader to deserialize from.</param>
        public static void FromBinary(out float? val, System.IO.BinaryReader sr)
        {
            val = sr.ReadBoolean() ? (float?)sr.ReadSingle() : null;
        }

        /// <summary>
        /// Deserialize a nullable double, expected format: NULL (true/false), Value (if not null).
        /// </summary>
        /// <param name="val">Destination Value.</param>
        /// <param name="sr">BinaryReader to deserialize from.</param>
        public static void FromBinary(out double? val, System.IO.BinaryReader sr)
        {
            val = sr.ReadBoolean() ? (double?)sr.ReadDouble() : null;
        }

        /// <summary>
        /// Deserialize a IDataObject Collection, expected format: CONTINUE (true/false), IDataObject (if Object is present).
        /// </summary>
        /// <param name="val">Destination Value.</param>
        /// <param name="sr">BinaryReader to deserialize from.</param>
        public static void FromBinary<T>(out List<T> val, System.IO.BinaryReader sr, IKistlContext ctx) where T : IDataObject
        {
            val = new List<T>();
            while (sr.ReadBoolean())
            {
                long pos = sr.BaseStream.Position;
                ObjectType objType;
                BinarySerializer.FromBinary(out objType, sr);

                sr.BaseStream.Seek(pos, System.IO.SeekOrigin.Begin);

                IDataObject obj = objType.NewDataObject();
                obj.FromStream(ctx, sr);

                val.Add((T)obj);
            }
        }

        /// <summary>
        /// Deserialize a ICollectionEntry Collection, expected format: CONTINUE (true/false), IDataObject (if Object is present).
        /// </summary>
        /// <param name="val">Destination Value.</param>
        /// <param name="sr">BinaryReader to deserialize from.</param>
        public static void FromBinaryCollectionEntries<T>(out List<T> val, System.IO.BinaryReader sr, IKistlContext ctx) where T : ICollectionEntry, new()
        {
            val = new List<T>();
            FromBinaryCollectionEntries<T>(val, sr, ctx);
        }

        /// <summary>
        /// Deserialize a ICollectionEntry Collection, expected format: CONTINUE (true/false), IDataObject (if Object is present).
        /// </summary>
        /// <param name="val">Destination Value.</param>
        /// <param name="sr">BinaryReader to deserialize from.</param>
        public static void FromBinaryCollectionEntries<T>(out ObservableCollection<T> val, System.IO.BinaryReader sr, IKistlContext ctx) where T : ICollectionEntry, new()
        {
            val = new ObservableCollection<T>();
            FromBinaryCollectionEntries<T>(val, sr, ctx);
        }

        /// <summary>
        /// Deserialize a ICollectionEntry Collection, expected format: CONTINUE (true/false), IDataObject (if Object is present).
        /// </summary>
        /// <param name="val">Destination Value.</param>
        /// <param name="sr">BinaryReader to deserialize from.</param>
        public static void FromBinaryCollectionEntries<T>(out NotifyingObservableCollection<T> val, System.IO.BinaryReader sr, IKistlContext ctx, IDataObject parent, string propertyName) where T : ICollectionEntry, INotifyPropertyChanged, new()
        {
            val = new NotifyingObservableCollection<T>(parent, propertyName);
            FromBinaryCollectionEntries<T>(val, sr, ctx);
        }

        /// <summary>
        /// Deserialize a ICollectionEntry Collection, expected format: CONTINUE (true/false), IDataObject (if Object is present).
        /// </summary>
        /// <param name="val">Destination Value.</param>
        /// <param name="sr">BinaryReader to deserialize from.</param>
        public static void FromBinaryCollectionEntries<T>(ICollection<T> val, System.IO.BinaryReader sr, IKistlContext ctx) where T : ICollectionEntry, new()
        {
            if (val == null) throw new ArgumentNullException("val");

            List<T> tmpList = new List<T>();
            while (sr.ReadBoolean())
            {
                T obj = new T();
                obj.FromStream(ctx, sr);

                tmpList.Add(obj);

                T objInCollection = val.FirstOrDefault(i => obj.ID != Helper.INVALIDID && i.ID == obj.ID);
                if (objInCollection != null)
                {
                    obj.CopyTo(objInCollection);
                }
                else
                {
                    val.Add((T)obj);
                }
            }

            foreach (T obj in val.ToArray())
            {
                if (tmpList.FirstOrDefault(i => i.ID == obj.ID) == null)
                {
                    ctx.Delete(obj);
                }
            }
        }

        public static void FromBinary(out SerializableExpression e, System.IO.BinaryReader sr)
        {
            e = null;
            if (sr.ReadBoolean())
            {
                BinaryFormatter bf = new BinaryFormatter();
                e = (SerializableExpression)bf.Deserialize(sr.BaseStream);
            }
        }
        #endregion
    }
}
