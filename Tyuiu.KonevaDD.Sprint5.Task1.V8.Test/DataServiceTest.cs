using Tyuiu.KonevaDD.Sprint5.Task1.V8.Lib;
using System.IO;
namespace Tyuiu.KonevaDD.Sprint5.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string path = @"C:\Users\konev\AppData\Local\Temp\OutPutFileTask1.txt"; FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists; bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

    }
}