using JInstaller.Lib.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JInstaller.Lib.Installer
{
    internal class RemoveFile : IProcessor
    {
        public Task Run(InstallEvent installEvent)
        {
            File.Delete(installEvent.FilesDirectory);
            return Task.CompletedTask;
        }
    }
}
