using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PetrovNE.Sprint2.Task2.V16.Lib
{
    public class DataService : ISprint2Task2V16
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (((x >= 3 && x <= 5) && ((y >= 3 && y <= 7) || (y == 11))) || ((x == 3 && y == 12) || (x == 3 && y == 13)))
            {
                return true;
            }
            else if (((x == 6 || x == 7) && (y >= 5 && y <= 11)) || ((x >= 7 && x <= 9) && (y == 12 || (y >= 6 && y <= 8))))
            {
                return true;
            }
            else if (((x >= 10 && x <= 12) && (y == 7 || y == 13)) || (x == 10 && y == 12))
            {
                return true;
            }
            else if ((x == 13 || x == 14) && (y >= 3 && y <= 10))
            {
                return true;
            }
            else { return false; }
        }
    }
}
