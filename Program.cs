using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    a += i;
                }
                else
                {
                    b += i;
                }
            }
            c = a - b;

            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine("difference between two sums {0}", c);
            Console.ReadLine();
        }
    }
}
