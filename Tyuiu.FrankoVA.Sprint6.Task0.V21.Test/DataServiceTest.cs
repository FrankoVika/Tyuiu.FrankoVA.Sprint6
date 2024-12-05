using Tyuiu.FrankoVA.Sprint6.Task0.V21.Lib;
namespace Tyuiu.FrankoVA.Sprint6.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2);
            double wait = 13;
            Assert.AreEqual(wait, res);
        }
    }
}