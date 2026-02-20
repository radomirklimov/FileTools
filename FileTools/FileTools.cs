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
        private string ConsoleLikeOutput(Dictionary<string, string> infos)
        {
            return $"Verzeichnis von {infos["Full Path"]}<br>";
        }

        static public string FileList(string fullFilePath)
        {
            bool isFile = File.Exists(fullFilePath);
            FileInfo fileInfo = new FileInfo(fullFilePath);

            Dictionary<string, string> infos = new Dictionary<string, string>();
            infos.Add("Full Path", fullFilePath);
            infos.Add("Name", fileInfo.Name);
            infos.Add("Extention", fileInfo.Extension);
            infos.Add("Mode", fileInfo.UnixFileMode.ToString());
            infos.Add("Last write time", fileInfo.LastWriteTime.ToString());
            infos.Add("Creation time", fileInfo.CreationTime.ToString());

            if (isFile)
            {
                infos.Add("Lenght", fileInfo.Length.ToString());
            } else
            {
                infos.Add("Length", "Dir");
            }

            return new FileTools().ConsoleLikeOutput(infos);
        }

    }
}
