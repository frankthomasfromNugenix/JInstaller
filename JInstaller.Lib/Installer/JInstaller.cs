using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JInstaller;
public sealed class JInstaller
{
    private Queue<InstallEvent> _events;

    public JInstaller(Queue<InstallEvent> events)
    {
        _events = events ?? throw new NullReferenceException("JInstall event queue must not be null");

        if (_events.Count == 0)
            throw new Exception("Event queue must not be empty");
    }

    public async Task RunAsync()
    {
        InstallEvent installEvent; 
        
        while (_events.Count > 0)
        {
            installEvent = _events.Dequeue();

            await EventProcessor.ProcessAsync(installEvent);
        }
    }
}

