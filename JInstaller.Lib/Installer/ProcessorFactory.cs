using JInstaller.Lib.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JInstaller.Lib.Installer
{
    public class ProcessorFactory
    {
        public IProcessor? GetProcessor(InstallType installType)
        {
            switch(installType)
            {
                case InstallType.AddDirectory: return new AddDirectory();
                case InstallType.AddFile: return new AddFile();
                case InstallType.RemoveDirectory: return new RemoveDirectory();
                case InstallType.RemoveFile: return new RemoveFile();
                case InstallType.UpdateFile: return new UpdateFile();
                case InstallType.UpdateDirectory: return new UpdateDirectory();
                default: return null;
            }
        }
    }
}
