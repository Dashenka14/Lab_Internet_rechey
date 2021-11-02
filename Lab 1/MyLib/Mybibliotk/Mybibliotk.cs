using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib14;

namespace Mybibliotk
{
    /// <summary>
    /// program for checking the use of the library MyLib
    /// </summary>
    class Mybibliotk
    {
        /// <summary>
        /// calling library methods from MyLib.dll
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        { 
            double S, weeks, z;
            int n, days, e;
            Console.WriteLine("Введите дату:");
            DateTime date1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Введите количество дней:");
            days = Convert.ToInt32(Console.ReadLine());
            //calling the calculation method "Kolvo_week" from the library
            weeks = Math.Round(MyLib.Kolvo_week(days), 3);
            Console.WriteLine("Количество полных недель = " + weeks);
            Console.WriteLine("Введите натуральное число рядов:");
            n = Convert.ToInt32(Console.ReadLine());
            //calling the calculation method "Sumrow" from the library
            S = Math.Round(MyLib.Sumrow(n), 3);
            Console.WriteLine("Сумма ряда = " + S);
            Console.WriteLine("Введите число:");
            z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите натуральное число рядов:");
            n = Convert.ToInt32(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("n должно быть натуральным! Введите еще раз:");
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите точность:");
            e = Convert.ToInt32(Console.ReadLine());
            //calling the calculation method "Sumrow2" from the library
            S = Math.Round(MyLib.Sumrow2(n, z, e), 3);
            Console.WriteLine("Сумма ряда = " + S);
            //calling the calculation method "Error" from the library
            S = Math.Round(MyLib.Error(n, z, e), 3);
            Console.WriteLine("Погрешность = " + S + " %");
            Console.ReadKey();
        }
    }
}
