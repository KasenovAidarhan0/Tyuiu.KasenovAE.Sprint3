using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KasenovAE.Sprint3.Task3.V12.Lib
{
    public class DataService : ISprint3Task3V12
    {
        public int GetMaxCharCount(string value, char item)
        {
            int count = 1;
            int i = 0;

            foreach (char h in value)
            {               
                i++;
                if (i >= value.Length)
                    break;
                if (h == value[i] && h == item)
                    count++;
            }

            if (count == 1)
                count = 0;

            return count;
        }
    }
}
