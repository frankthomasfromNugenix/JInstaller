using JInstaller.Lib.Contracts;
using JInstaller.Lib.Installer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JInstaller;
internal static class EventProcessor
{
    public static async Task ProcessAsync(InstallEvent installEvent)
    {
        ProcessorFactory processorFactory = new ProcessorFactory();

        IProcessor processor = processorFactory.GetProcessor(installEvent.InstallType) ?? throw new Exception();

        await processor.Run(installEvent);
    }

}

