using System;

namespace NumberApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int i,
            sum = 0;
            Console.Write("the first 10 natural numbers are:\n");
            for (i = 1; i <= 10; i++)
            {
                sum = sum + i;
                Console.WriteLine(i);
            }
            Console.WriteLine(sum);

        }
    }
}
