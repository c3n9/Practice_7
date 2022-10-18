using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            do
            {
                sum += i++;
            }
            while (i <= 6);
            Console.WriteLine("Ответ "+sum);
        }
    }
}
