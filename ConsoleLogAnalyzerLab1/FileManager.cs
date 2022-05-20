using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLogAnalyzerLab1
{
    /// <summary>
    /// 
    /// </summary>
    public class FileManager : IFileManager
    {
        private readonly IFileUtility _fileUtility;

        public FileManager(IFileUtility fileUtility)
        {
            _fileUtility = fileUtility;
        }

        public bool IsValid(string fileName)
        {
            if (_fileUtility.IsFileExist(fileName)
                && fileName.EndsWith(".LOG", StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }
            return false;
        }

        
    }
}
