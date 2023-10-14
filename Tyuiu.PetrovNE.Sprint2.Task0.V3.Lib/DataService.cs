using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PetrovNE.Sprint2.Task0.V3.Lib
{
    public class DataService : ISprint2Task0V3
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];
            result[0] = (x == y); result[1] = (x != y); result[2] = (x + 83 < y);
            result[3] = (x + 83 > y); result[4] = (x + 83 <= y); result[5] = (x + 83 >= y);

            return result;
        }
    }
}
//из операций сравнений (==, !=, <, >, <=, >=, последовательность операций
//не должна нарушаться) 
//x = 45, y = 127 (False, True, False, True, False, True)