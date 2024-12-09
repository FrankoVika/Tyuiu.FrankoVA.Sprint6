using Tyuiu.FrankoVA.Sprint6.Task4.V10.Lib;
namespace Tyuiu.FrankoVA.Sprint6.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            int len = (stop - start) + 1;
            double[] wait = new double[len];
            wait[0] = -15.4;
            wait[1] = -13.31;
            wait[2] = -11.36;
            wait[3] = -8;
            wait[4] = -2.62;
            wait[5] = 1.83;
            wait[6] = 4.49;
            wait[7] = 6.78;
            wait[8] = 10.58;
            wait[9] = 17.38;
            wait[10] = 23.76;
            double[] res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}