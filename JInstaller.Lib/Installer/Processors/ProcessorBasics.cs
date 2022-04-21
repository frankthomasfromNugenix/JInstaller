using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JInstaller.Lib.Installer
{
    internal static class ProcessorBasic
    {
        internal static async Task MoveFile(string filePath, string destination, bool isUpdating)
        {
            string fileName = $"{destination}{Path.DirectorySeparatorChar}{filePath.Substring(filePath.LastIndexOf('\\') + 1)}";

            if (isUpdating && File.Exists(fileName))
                File.Delete(fileName);
            else if (!isUpdating && File.Exists(fileName))
                return;

            byte[] fileContent = await File.ReadAllBytesAsync(filePath);
            await File.WriteAllBytesAsync(fileName, fileContent);
        }


    }
}
