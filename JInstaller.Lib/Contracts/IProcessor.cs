using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JInstaller.Lib.Contracts
{
    public interface IProcessor
    {
        Task Run(InstallEvent installEvent);
    }
}
