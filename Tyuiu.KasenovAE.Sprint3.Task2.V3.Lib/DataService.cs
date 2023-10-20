using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KasenovAE.Sprint3.Task2.V3.Lib
{
    public class DataService : ISprint3Task2V3
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double res = 0;
            int i = startValue;

            do
            {
                res += (value * value * i) + 1;
                i++;
            }
            while (i <= stopValue);

            return res;
        }
    }
}
