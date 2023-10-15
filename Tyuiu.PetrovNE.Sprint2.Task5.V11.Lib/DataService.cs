using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PetrovNE.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            string res, n1 = Convert.ToString(n), m1 = Convert.ToString(m), g1 = Convert.ToString(g);
           //string FirstDate = Convert.ToString(n) + '.' + Convert.ToString(m) + '.' + Convert.ToString(g);
            switch (m)
            {
                case 1:
                    if (n != 31)
                    {
                        n1 = Convert.ToString(n + 1);
                    }
                    else { n1 = "01"; m1 = Convert.ToString(m + 1); }
                    break;
                case 2:
                    if (n != 28)
                    {
                        n1 = Convert.ToString(n + 1);
                    }
                    else { n1 = "01"; m1 = Convert.ToString(m + 1); }
                    break;
                case 3:
                    if (n != 31)
                    {
                        n1 = Convert.ToString(n + 1);
                    }
                    else { n1 = "01"; m1 = Convert.ToString(m + 1); }
                    break;
                case 4:
                    if (n != 30)
                    {
                        n1 = Convert.ToString(n + 1);
                    }
                    else { n1 = "01"; m1 = Convert.ToString(m + 1); }
                    break;
                case 5:
                    if (n != 31)
                    {
                        n1 = Convert.ToString(n + 1);
                    }
                    else { n1 = "01"; m1 = Convert.ToString(m + 1); }
                    break;
                case 6:
                    if (n != 30)
                    {
                        n1 = Convert.ToString(n + 1);
                    }
                    else { n1 = "01"; m1 = Convert.ToString(m + 1); }
                    break;
                case 7:
                    if (n != 31)
                    {
                        n1 = Convert.ToString(n + 1);
                    }
                    else { n1 = "01"; m1 = Convert.ToString(m + 1); }
                    break;
                case 8:
                    if (n != 31)
                    {
                        n1 = Convert.ToString(n + 1);
                    }
                    else { n1 = "01"; m1 = Convert.ToString(m + 1); }
                    break;
                case 9:
                    if (n != 31)
                    {
                        n1 = Convert.ToString(n + 1);
                    }
                    else { n1 = "01"; m1 = Convert.ToString(m + 1); }
                    break;
                case 10:
                    if (n != 30)
                    {
                        n1 = Convert.ToString(n + 1);
                    }
                    else { n1 = "01"; m1 = Convert.ToString(m + 1); }
                    break;
                case 11:
                    if (n != 30)
                    {
                        n1 = Convert.ToString(n + 1);
                    }
                    else { n1 = "01"; m1 = Convert.ToString(m + 1); }
                    break;
                case 12:
                    if (n != 31)
                    {
                        n1 = Convert.ToString(n + 1);
                    }
                    else { n1 = "01"; m1 = "01"; g1 = Convert.ToString(g + 1); }
                    break;
                default:
                    return "неправильная форма даты.";
            }
            res = n1 + "." + m1 + "." + g1;
            return res;
        }
    }
}
