using System;

public class Monkeyisland
{
	public Monkeyisland()
	{
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            float funkiness = float.Parse(Console.ReadLine());

            string m = "monkey";

            if (day == "friday")
            {
                m = "funky" + m + "fiday";
            }
            if (funkiness >= 7)
            {
                m = m.ToUpper();
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", m);
            }
            Console.ReadLine();
            //console.log(m.repeat(n).trim());( in JS)
        }
    }
}
