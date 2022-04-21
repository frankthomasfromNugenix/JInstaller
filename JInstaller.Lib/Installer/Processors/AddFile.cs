using JInstaller.Lib.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JInstaller.Lib.Installer
{
    internal class AddFile : IProcessor
    {
        public async Task Run(InstallEvent installEvent)
        {
            await ProcessorBasic.MoveFile(installEvent.FilesDirectory, installEvent.ExtractDirectory, false);
        }
    }
}
