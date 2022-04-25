using JInstaller.Lib.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JInstaller.Lib.Installer
{
    internal class UpdateDirectory : IProcessor
    {
        public async Task Run(InstallEvent installEvent)
        {
            string[] files = Directory.GetFiles(installEvent.FilesDirectory);

            if (!Directory.Exists(installEvent.ExtractDirectory))
                Directory.CreateDirectory(installEvent.ExtractDirectory);


            foreach (string file in files)
            {
                await ProcessorBasic.MoveFile(file, installEvent.ExtractDirectory, true);
            }
        }
    }
}
