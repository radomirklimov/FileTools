using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FileTools
{
    public record FileFields
     (
        string Directory,
        string Name,
        string Extension,
        string Mode,
        string LastWriteTime,
        string CreationTime,
        string Length = "Dir"
    )
    {
        public override string ToString()
        {
            string nameText = Length == "Dir"
                ? "Directory Name: "
                : "File Name: ";

            return
                $"Verzeichnis von {Directory}\n" +
                $"{nameText}{Name}\n" +
                $"Mode: {Mode}\n" +
                $"Last write time: {LastWriteTime}\n" +
                $"Creation time: {CreationTime}\n" +
                $"File Length: {Length} Bytes";
        }
    }
}
