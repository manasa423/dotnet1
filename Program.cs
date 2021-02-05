//strong or not

using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=371, r, sum = 0, temp;
           
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Armstrong Number.");
            else
                Console.Write("Not Armstrong Number.");
        }
    }
}
