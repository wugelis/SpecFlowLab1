using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;

namespace Integrated_ConsoleLogAnalyzer
{
    [TestClass]
    public class Integrated_AnalyzerLog
    {
        [TestMethod]
        public void Test_AnazlyerLog()
        {
            string targetExecutable = Path.Combine(Environment.CurrentDirectory.Replace("Integrated_ConsoleLogAnalyzer", "ConsoleLogAnalyzerLab1"), "ConsoleLogAnalyzerLab1.exe");

            ProcessStartInfo startInfo = new ProcessStartInfo(targetExecutable)
            {
                Arguments = "20190527_Error.log",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                WorkingDirectory = Path.GetDirectoryName(targetExecutable)
            };

            Process p = Process.Start(startInfo);

            StreamReader streamReader = p.StandardOutput;
            string output = streamReader.ReadToEnd();

            Assert.IsTrue(output.IndexOf("IsValid=True", StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }
}
