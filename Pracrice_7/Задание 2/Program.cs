using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p = 1;
            do
            {
                int i = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    break;
                }
                p *= i;
                
            }
            while (p != 0);
            Console.WriteLine("Ответ"+p);
        }
    }
}
