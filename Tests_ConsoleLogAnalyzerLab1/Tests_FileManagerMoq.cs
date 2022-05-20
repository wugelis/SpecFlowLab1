using ConsoleLogAnalyzerLab1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Tests_ConsoleLogAnalyzerLab1
{
    [TestClass]
    public class Tests_FileManagerMoq
    {
        [TestMethod]
        public void Test_IsValidMoq()
        {
            // Arrange
            //LogAnalyzer target = new LogAnalyzer();
            string fileName = "20190527_Error.log";

            Mock<IFileUtility> fakeUtil = new Mock<IFileUtility>();
            fakeUtil
                .Setup(c => c.IsFileExist(fileName))
                .Returns(true);

            Mock<IFileManager> target = new Mock<IFileManager>();
            target.Setup(p => p.IsValid(fileName))
                .Returns(new FileManager(fakeUtil.Object).IsValid(fileName));

            bool expected = true;
            bool actual;

            // Act
            //actual = target.IsValidLogFileName(fileName);
            actual = target.Object.IsValid(fileName);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_IsValidMoq2()
        {
            string fileName = "20190527_Error.log";
            Mock<FileManager> target = new Mock<FileManager>();
            target
                .Setup(c => c.IsValid(fileName))
                .Returns(true);
            bool actual = target.Object.IsValid(fileName);
        }
    }
}
