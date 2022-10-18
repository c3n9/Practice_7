using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input А>1");
            double a = double.Parse(Console.ReadLine());
            double k = 1; double s = 1;
            do
            {
                k++;
                s = s + (1d / k);
            }
            while (s <= a);
                Console.WriteLine($"А = {k}, Sum = {s}");
        }
    }
}
