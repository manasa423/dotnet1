//check the given number is palndrome or not

using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 232,
               r, sum=0,
                pal=n;
            while (n > 0)
            {
                r= n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (pal == sum)
                Console.WriteLine("number is palindrome");

        }
    }
}
