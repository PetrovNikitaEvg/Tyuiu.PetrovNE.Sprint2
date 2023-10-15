using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PetrovNE.Sprint2.Task6.V10.Lib;
namespace Tyuiu.PetrovNE.Sprint2.Task6.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Петров Н. Е.  | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                               *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Петров Никита Евгеньевич | АСОиУБ-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch, вычисляет       *");
            Console.WriteLine("* требуемое значение и возвращает результат. Условие: Дата некоторого дня *");
            Console.WriteLine("* характеризуется тремя натуральными числами: g (год), m (порядковый      *");
            Console.WriteLine("* номер месяца) и n (число). По заданным g, n и m определить дату         *");
            Console.WriteLine("* предыдущего дня. Заданный год не является високосным.                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();

            Console.Write("Год = ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Месяц = ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("День = ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.FindDateOfPreviousDay(year, month, day);

            Console.WriteLine("Дата предыдущего дня: " + res);

            Console.ReadLine();
        }
    }
}
