using Tyuiu.FrankoVA.Sprint6.Task2.V3.Lib;
namespace Tyuiu.FrankoVA.Sprint6.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = (stopValue - startValue) + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -12.18;
            valueWaitArray[1] = 16.03;
            valueWaitArray[2] = 18.87;
            valueWaitArray[3] = 4.96;
            valueWaitArray[4] = -9.99;
            valueWaitArray[5] = -2.00;
            valueWaitArray[6] = 0;
            valueWaitArray[7] = -7.54;
            valueWaitArray[8] = -22.76;
            valueWaitArray[9] = -20.45;
            valueWaitArray[10] = 0;


            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}