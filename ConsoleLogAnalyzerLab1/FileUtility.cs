using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLogAnalyzerLab1
{
    public class FileUtility : IFileUtility
    {
        public bool IsFileExist(string fileName)
        {
            return File.Exists(fileName);
        }
    }
}
