using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PetrovNE.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task6V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            string res, n1 = Convert.ToString(n), m1 = Convert.ToString(m), g1 = Convert.ToString(g);
            switch (m)
            {
                case 1: if (n != 01) { n1 = Convert.ToString(n - 1); } else { n1 = "31"; m1 = "12"; g1 = Convert.ToString(g - 1);} break;
                case 2: if (n != 01) { n1 = Convert.ToString(n - 1); } else { n1 = "31"; m1 = Convert.ToString(m - 1); } break;
                case 3: if (n != 01) { n1 = Convert.ToString(n - 1); } else { n1 = "28"; m1 = Convert.ToString(m - 1); ; } break;
                case 4: if (n != 01) { n1 = Convert.ToString(n - 1); } else { n1 = "31"; m1 = Convert.ToString(m - 1); ; } break;
                case 5: if (n != 01) { n1 = Convert.ToString(n - 1); } else { n1 = "30"; m1 = Convert.ToString(m - 1); ; } break;
                case 6: if (n != 01) { n1 = Convert.ToString(n - 1); } else { n1 = "31"; m1 = Convert.ToString(m - 1); ; } break;
                case 7: if (n != 01) { n1 = Convert.ToString(n - 1); } else { n1 = "31"; m1 = Convert.ToString(m - 1); ; } break;
                case 8: if (n != 01) { n1 = Convert.ToString(n - 1); } else { n1 = "31"; m1 = Convert.ToString(m - 1); ; } break;
                case 9: if (n != 01) { n1 = Convert.ToString(n - 1); } else { n1 = "30"; m1 = Convert.ToString(m - 1); ; } break;
                case 10: if (n != 01) { n1 = Convert.ToString(n - 1); } else { n1 = "31"; m1 = Convert.ToString(m - 1); ; } break;
                case 11: if (n != 01) { n1 = Convert.ToString(n - 1); } else { n1 = "30"; m1 = Convert.ToString(m - 1); ; } break;
                case 12: n1 = Convert.ToString(n - 1); break;
                default:
                    return "неправильная форма даты.";
            }
            res = n1 + "." + m1 + "." + g1;
            return res;
        }
    }
}
