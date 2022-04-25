using JInstaller.Lib.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JInstaller.Lib.Installer
{
    internal class AddDirectory : IProcessor
    {
        public async Task Run(InstallEvent installEvent)
        {
            string[] files = Directory.GetFiles(installEvent.FilesDirectory);

            if (!Directory.Exists(installEvent.ExtractDirectory))
                Directory.CreateDirectory(installEvent.ExtractDirectory);


            foreach (string file in files)
            {
                Console.WriteLine("FILE:" + file);
                await ProcessorBasic.MoveFile(file, installEvent.ExtractDirectory, false);
            }

            string[] dirs = Directory.GetDirectories(installEvent.FilesDirectory);

            foreach (string dir in dirs)
            {
                await Run(new InstallEvent()
                {
                    FilesDirectory = dir,
                    ExtractDirectory = $"{installEvent.ExtractDirectory}{Path.DirectorySeparatorChar}{dir.Substring(dir.LastIndexOf('\\'))}"
                });
            }
        }

    }
}
