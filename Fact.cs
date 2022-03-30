using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fact
{
    class Program
    {
        static void Main(string[] args)
        {
            
               
                    /*You are given two numbers
                    X and N
                    You should output :
                    X!/ (X - N)!
                    Example:
                    input: X = 6, N = 4
                    output should be the result of 6*5*4*3*/

                    int X = int.Parse(Console.ReadLine());
                    int N = int.Parse(Console.ReadLine());
                    
                    // X!
                    int fact1 = 1;
                    for (int i = 1; i <= X; i++)
                    {
                        fact1 *= i;
                    }

                    //(X - N)!
                    int fact2 = 1;
                    for (int j = 1; j <= (X - N); j++)
                    {
                        fact2 *= j;
                    }
                   
                    // You should output :  X! / (X - N)!
                    int result = fact1 / fact2;
                    Console.Write(result);
                    Console.ReadLine();




                




        }
    }
}
