using ConsoleLogAnalyzerLab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests_ConsoleLogAnalyzerLab1.Fakes
{
    public class FakeFileUtility : IFileUtility
    {
        public bool IsFileExist(string fileName)
        {
            return true;
        }
    }
}
