using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОпределениеНаибольшегоОбщегоДелителя2чисел
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый делитель");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй делитель");
            int b = int.Parse(Console.ReadLine());
            int big;
            int delitel = 1;
            if (a > b)
            {
                big = a;
            }
            else
            {
                big = b;
            }
            for (int i = 1; i < big; i++) 
            {
                if(a % i == 0 && b % i == 0)
                {
                    delitel = i;
                }
            }
            Console.WriteLine($"Наибольший общий делитель числа {a} и числа {b} это число {delitel}");
            Console.ReadKey();

        }
    }
}
