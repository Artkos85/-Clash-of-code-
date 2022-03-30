using System;

public class Fact
{
    public Fact()
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

            int fact1 = 1;
            for (int i = 1; x <= X; i++)
            {
                fact1 *= i;
            }
            int fact2 = 1;
            for (int j = 1; x <= (X - N); j++)
            {
                fact2 *= j;
            }
            // You should output :  X! / (X - N)!

            result = fact1 / fact2;
            coansole,write(result);



        }
    }



