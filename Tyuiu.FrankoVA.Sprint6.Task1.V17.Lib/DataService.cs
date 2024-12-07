using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FrankoVA.Sprint6.Task1.V17.Lib
{
    public class DataService : ISprint6Task1V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((3 * x - 1.5) / (Math.Sin(x) - 3 + x) + 2, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
