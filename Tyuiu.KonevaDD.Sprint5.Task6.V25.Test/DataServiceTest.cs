using Tyuiu.KonevaDD.Sprint5.Task6.V25.Lib;
using System.IO;
namespace Tyuiu.KonevaDD.Sprint5.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V25.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}