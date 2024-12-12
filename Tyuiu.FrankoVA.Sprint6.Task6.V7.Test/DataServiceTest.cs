using Tyuiu.FrankoVA.Sprint6.Task6.V7.Lib;
namespace Tyuiu.FrankoVA.Sprint6.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C: \Users\1\AppData\Local\Temp\InPutFileTask6V7.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}