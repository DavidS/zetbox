using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Zetbox.Client.Bootstrapper
{
    public enum FileType
    {
        File = 1,
        Exec = 2,
        AppConfig = 3,
    }

    [XmlRoot("ArrayOfFileInfo", Namespace = "http://dasz.at/Zetbox/Bootstrapper")]
    public class FileInfoArray
    {
        [XmlElement("FileInfo")]
        public FileInfo[] Files { get; set; }
    }

    public class FileInfo
    {
        public string Name { get; set; }
        public string DestPath { get; set; }
        public DateTime Date { get; set; }
        public long Size { get; set; }
        public FileType Type { get; set; }

        public string GetFullFileName(string targetDir)
        {
            switch (DestPath)
            {
                case "Exe":
                    return Path.GetFullPath(Path.Combine(targetDir, Path.Combine(String.Empty, Name)));
                case "Config":
                case "Configs":
                    return Path.GetFullPath(Path.Combine(targetDir, Path.Combine(DestPath, "DefaultConfig.xml")));
                default:
                    return Path.GetFullPath(Path.Combine(targetDir, Path.Combine(DestPath, Name)));
            }
        }

        public string GetDisplayFileName()
        {
            return Path.Combine(DestPath, Name);
        }
    }
}
