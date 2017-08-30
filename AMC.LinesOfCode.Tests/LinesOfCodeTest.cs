using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using AMC.LinesOfCode;

namespace AMC.LinesOfCode.Tests
{
    [TestClass]
    public class LinesOfCodeTest
    {
        [TestMethod]
        public void CountLinesOfCodTest()
        {
            // Arrange 
                 
            LineCounterRepository repo = new LineCounterRepository();
            string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string rootPath = Path.GetDirectoryName(dir);
            string path = rootPath+ "\\AMC.LinesOfCode.Tests\\Files\\";

            // Acct
            int line= repo.GetCountOfTotalLinesOfCode(path);

            // Assert

            Assert.AreEqual(210, line);
       

        }
       
    }
}
