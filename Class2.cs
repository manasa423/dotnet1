using System;
using System.Collections.Generic;
using System.Text;

namespace NumberApp
{
    class Class2
    {
        static void Main(string[] args)
        {
            int num=678;
            int count = 0;
            while (num > 0)
            {
                int digit = num % 10;
                count++;

                num = num / 10;

            }
            Console.WriteLine($"{ count}");


        }
    }
}
