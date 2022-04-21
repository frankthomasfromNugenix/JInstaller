using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JInstaller;
internal static class EventProcessor
{
    public static async Task RunAsync(InstallEvent installEvent)
    {
        switch (installEvent.InstallType)
        {
            case InstallType.AddDirectory:
                await RunAddEvent(installEvent);
                break;
        }
    }
    #region Add Event
    private static async Task RunAddEvent(InstallEvent installEvent)
    {
        string[] files = Directory.GetFiles(installEvent.FilesDirectory);

        if (!Directory.Exists(installEvent.ExtractDirectory))
            Directory.CreateDirectory(installEvent.ExtractDirectory);


        foreach (string file in files)
        {
            await MoveFile(file, installEvent.ExtractDirectory, false);
        }
    }

    private static async Task MoveFile(string filePath, string destination, bool isUpdating)
    {
        string fileName =  $"{destination}{Path.DirectorySeparatorChar}{filePath.Substring(filePath.LastIndexOf('\\') + 1)}";

        if (isUpdating && File.Exists(fileName))
            File.Delete(fileName);
        else if (!isUpdating && File.Exists(fileName))
            return;

        byte[] fileContent = await File.ReadAllBytesAsync(filePath);
        await File.WriteAllBytesAsync(fileName, fileContent);
    }
    #endregion
    private static Task RunRemoveEvent()
    {
        throw new NotImplementedException();
    }

    private static Task RunUpdateEvent()
    {
        throw new NotImplementedException();
    }
}

