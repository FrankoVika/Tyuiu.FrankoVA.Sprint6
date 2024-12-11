using Tyuiu.FrankoVA.Sprint6.Task5.V22.Lib;
namespace Tyuiu.FrankoVA.Sprint6.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C: \Users\1\AppData\Local\Temp\InPutFileTask5V22.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
