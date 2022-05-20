using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleLogAnalyzerLab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests_ConsoleLogAnalyzerLab1.Fakes;

namespace ConsoleLogAnalyzerLab1.Tests
{
    [TestClass()]
    public class Tests_FileManager
    {
        [TestMethod()]
        public void Test_IsValidLogFileName()
        {
            // Arrange
            //LogAnalyzer target = new LogAnalyzer(new FileManager(new FakeFileUtility()));
            FileManager target = new FileManager(new FakeFileUtility());
            bool expected = true;
            bool actual;

            // Act
            actual = target.IsValid("20190527_Error.log");

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}