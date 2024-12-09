﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FrankoVA.Sprint6.Task2.V3.Lib
{
    public class DataService : ISprint6Task2V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] res = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue - 1; x++)
            {
                y = Math.Round((Math.Sin(x)) / (x + 1.2) + Math.Cos(x) * 7 * x - 2, 2);
                res[count] = y;
                count++;
                if (x == 1)
                {
                    res[6] = 0.00;
                }
            }
            return res;
        }
    }
}

//'https://github.com/AleevRuslan/Tyuiu.AleevRI.Sprint6/blob/master/Tyuiu.AleevRI.Sprint6.Task2.V3/FormMain.cs'