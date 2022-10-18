
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int s = 10000;
            Console.WriteLine("Введите проценты");
            int p = int.Parse(Console.ReadLine()); //0< p < 25
            do
            {
                s += s * p/100;
                k++;
            }
            while (s <= 11000);
            Console.WriteLine("Число месяцев " + k + "Итогоый размер вклада"+s);
        }
    }
}
