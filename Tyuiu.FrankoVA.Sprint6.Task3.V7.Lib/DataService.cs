using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FrankoVA.Sprint6.Task3.V7.Lib
{
    public class DataService : ISprint6Task3V7
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < matrix.GetLength(0); j++)
                {
                    if (matrix[j, 3] < matrix[i, 3])
                    {
                        int temp = matrix[i, 3];
                        matrix[i, 3] = matrix[j, 3];
                        matrix[j, 3] = temp;
                    }
                }
            }
            return matrix;
        }
    }
}


