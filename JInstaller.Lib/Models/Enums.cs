using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JInstaller;

public enum InstallType
{
    AddDirectory,
    AddFile,
    RemoveDirectory,
    RemoveFile,
    UpdateDirectory,
    UpdateFile,
    Advanced
}

public enum CompressionType
{ 
    GZip,
    Zip
}
