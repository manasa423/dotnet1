
//avg of digits
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 189;
            int sum = 0;
            while (n > 0)
            {
                int m = n % 10;
                sum = sum + m;

                n = n / 10;

            }
            Console.WriteLine(sum/3);


        }
    }
}
