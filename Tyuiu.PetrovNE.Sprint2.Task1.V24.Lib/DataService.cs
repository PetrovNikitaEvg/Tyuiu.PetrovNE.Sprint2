using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PetrovNE.Sprint2.Task1.V24.Lib
{
    public class DataService : ISprint2Task1V24
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            result[0] = ((a > b) | (c < d)); result[1] = ((a > b) & (c < d)); result[2] = ((a+1 > b) || (c + 100 < d));
            result[3] = ((a - 1 > b) && (c < d)); result[4] = (!result[1]); result[5] = ((a > b) ^ (c + 100 < d));

            return result;

        }
    }
}
//(True, False, True, False, True, False), при a = 325, b = 325, c = 242, d = 324
// (|, &, ||, &&, !, ^