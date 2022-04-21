using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JInstaller;
public sealed class InstallEvent
{
    public InstallType InstallType { get; set; }
    public string FilesDirectory { get; set; }
    public string ExtractDirectory { get; set; }
}

