using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace Kistl.API
{
    public interface IPackageProvider : IDisposable
    {
        /// <summary>
        /// The stream of ZBox content
        /// </summary>
        Stream Data { get; }

        XmlReader Reader { get; }

        XmlWriter Writer { get; }

        void RewindData();

        /// <summary>
        /// Returns true, if Blobs are supported.
        /// </summary>
        /// <remarks>
        /// If Blobs are not supported, PubBlob &amp; GetBlob should throw a NotSupportedException.
        /// </remarks>
        bool SupportsBlobs { get; }
        /// <summary>
        /// Puts a Blob into the Package
        /// </summary>
        /// <exception cref="NotSupportedException">
        /// If Blobs are not supported, a NotSupportedException is thrown.
        /// </exception>
        /// <param name="guid">Guid of the Blob</param>
        /// <param name="filename">Optional file name. The Package can use the filename but must not rely on it. file name may be null or empty.</param>
        /// <param name="blob">The blob to store</param>
        void PutBlob(Guid guid, string filename, Stream blob);
        /// <summary>
        /// Returns a 
        /// </summary>
        /// <exception cref="NotSupportedException">
        /// If Blobs are not supported, a NotSupportedException is thrown.
        /// </exception>
        /// <exception cref="FileNotFoundException">
        /// Throws a FileNotFoundException if the Package does not contain the requested Blob.
        /// </exception>
        /// <param name="guid">Guid of the Blob</param>
        /// <returns>The stored Blob.</returns>
        Stream GetBlob(Guid guid);
    }

    public abstract class BasePackageProvider : IPackageProvider
    {
        public enum Modes
        {
            Read,
            Write,
        }

        public BasePackageProvider(Modes mode)
        {
            this.Mode = mode;
        }

        protected Modes Mode { get; private set; }

        #region IPackageProvider Members

        public abstract Stream Data
        {
            get;
        }

        private XmlReader _reader = null;
        public virtual XmlReader Reader
        {
            get 
            {
                if (_reader == null)
                {
                    if (Mode != Modes.Read) throw new InvalidOperationException();
                    _reader = XmlReader.Create(Data, new XmlReaderSettings() { CloseInput = false });
                }
                return _reader;
            }
        }

        private XmlWriter _writer = null;
        public virtual XmlWriter Writer
        {
            get
            {
                if (_writer == null)
                {
                    if (Mode != Modes.Write) throw new InvalidOperationException();
                    _writer = XmlTextWriter.Create(Data, new XmlWriterSettings() { Indent = true, CloseOutput = false, Encoding = Encoding.UTF8 });
                }
                return _writer;
            }
        }

        public virtual void RewindData()
        {
            Data.Seek(0, SeekOrigin.Begin);
            _reader = null;
            _writer = null;
        }

        public abstract bool SupportsBlobs { get; }

        public abstract void PutBlob(Guid guid, string filename, Stream blob);
        public abstract Stream GetBlob(Guid guid);

        #endregion

        #region IDisposable Members

        public virtual void Dispose()
        {
            if (_reader != null) ((IDisposable)_reader).Dispose();
            if (_writer != null) ((IDisposable)_writer).Dispose();
        }

        #endregion
    }

    public class FileSystemPackageProvider : BasePackageProvider
    {
        private string _fileName;
        private string _blobDir;

        public FileSystemPackageProvider(string filename, Modes mode)
            : base(mode)
        {
            if (string.IsNullOrEmpty(filename)) throw new ArgumentNullException("filename");
            _fileName = filename;
            _blobDir = Path.Combine(Path.GetDirectoryName(filename), Path.GetFileNameWithoutExtension(filename));

            switch (mode)
            {
                case Modes.Read:
                    _data = File.OpenRead(filename);
                    break;
                case Modes.Write:
                    Directory.CreateDirectory(Path.GetDirectoryName(filename));
                    Directory.CreateDirectory(_blobDir);
                    _data = File.OpenWrite(filename);
                    _data.SetLength(0);
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        #region IPackageProvider Members

        private FileStream _data;
        public override Stream Data
        {
            get
            {
                return _data;
            }
        }

        public override bool SupportsBlobs
        {
            get { return true; }
        }

        public override void PutBlob(Guid guid, string filename, Stream blob)
        {
            string destName;
            if(!string.IsNullOrEmpty(filename))
            {
                destName = Path.Combine(_blobDir, string.Format("{0} - {1}", guid, filename));
            }
            else
            {
                destName = Path.Combine(_blobDir, string.Format("{0}.blob", guid));
            }
            using (var fs = File.OpenWrite(destName))
            {
                fs.SetLength(0);
                blob.CopyTo(fs);
            }
        }

        public override Stream GetBlob(Guid guid)
        {
            var file = Directory.GetFiles(_blobDir, string.Format("{0}*.*", guid)).FirstOrDefault();
            if (string.IsNullOrEmpty(file)) throw new FileNotFoundException();
            return File.OpenRead(file);
        }

        #endregion

        public override void Dispose()
        {
            base.Dispose();
            _data.Dispose();
        }
    }

    //public class ZipFilePackageProvider : BasePackageProvider
    //{
    //    #region IPackageProvider Members

    //    public Stream Data
    //    {
    //        get { throw new NotImplementedException(); }
    //    }

    //    public bool SupportsBlobs
    //    {
    //        get { throw new NotImplementedException(); }
    //    }

    //    public void PutBlob(Guid guid, string filename, Stream blob)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Stream GetBlob(Guid guid)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    #endregion
    //}

    public class StreamPackageProvider : BasePackageProvider
    {
        public StreamPackageProvider(Stream data, Modes mode)
            : base(mode)
        {
            this._data = data;
        }

        #region IPackageProvider Members

        private Stream _data;
        public override Stream Data
        {
            get
            {
                return _data;
            }
        }

        public override bool SupportsBlobs
        {
            get { return false; }
        }

        public override void PutBlob(Guid guid, string filename, Stream blob)
        {
            throw new NotSupportedException();
        }

        public override Stream GetBlob(Guid guid)
        {
            throw new NotSupportedException();
        }

        #endregion

        public override void Dispose()
        {
            base.Dispose();
        }
    }
}
