using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JInstaller.Test
{
    [TestClass]
    public class InstallerTest
    {
        private readonly string _testDirPath;
        private readonly string _testOutput;

        public InstallerTest()
        {
            _testDirPath = @"C:\Users\chris\OneDrive\Desktop\skate";
            _testOutput = @"C:\Users\chris\OneDrive\Documents\JinstallerTest\output2";
        }

        [TestMethod]
        public async Task WhenAddingDirectory()
        {
            Queue<InstallEvent> queue = new Queue<InstallEvent>();
            queue.Enqueue(new InstallEvent()
            {
                InstallType = InstallType.AddDirectory,
                FilesDirectory = _testDirPath,
                ExtractDirectory = _testOutput
            });

            await RunInstaller(queue);

            Assert.IsTrue(Directory.Exists(_testOutput));
        }

        [TestMethod]
        public async Task WhenRemovingDirectory()
        {
            Queue<InstallEvent> queue = new Queue<InstallEvent>();
            queue.Enqueue(new InstallEvent()
            {
                InstallType = InstallType.RemoveDirectory,
                FilesDirectory = _testOutput
            });

            await RunInstaller(queue);

            Assert.IsTrue(!Directory.Exists(_testOutput));
        }

        [TestMethod]
        public async Task WhenCompressingVideo()
        {
            Queue<InstallEvent> queue = new Queue<InstallEvent>();
        }

        private async Task RunInstaller(Queue<InstallEvent> testQueue) => await new JInstaller(testQueue).RunAsync();
    }
}
