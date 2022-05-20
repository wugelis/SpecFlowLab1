using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLogAnalyzerLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string fileName = args[0];

                LogAnalyzer log = new LogAnalyzer(new FileManager(new FileUtility()));
                bool isValid = log.IsValidLogFileName(fileName);
                Console.WriteLine($"Test LogFileName '{fileName}' isValid={isValid}!!!.");
            }
            else
            {
                Console.WriteLine("No arugments input!!!.");
            }
            Console.ReadLine();
        }
    }
}
