using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FileTools
{
    internal class FileTools
    {
        static public FileFields FileList(string fullFilePath)
        {
            bool isFile = File.Exists(fullFilePath);
            FileInfo fileInfo = new FileInfo(fullFilePath);

            FileFields fields = new FileFields(
                fileInfo.Directory?.ToString() ?? "unknown",
                fileInfo.Name,
                fileInfo.Extension,
                fileInfo.UnixFileMode.ToString(),
                fileInfo.LastWriteTime.ToString(),
                fileInfo.CreationTime.ToString()
                );

            if (isFile)
            {
                fields = fields with { Length = fileInfo.Length.ToString() };
            }

            return fields;
        }
    }
}
