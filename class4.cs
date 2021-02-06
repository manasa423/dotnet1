//reverse digit of a number

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class2
    {
        static void Main(string[] args)
        {
            int n = 123;
            int reverse = 0;
            while (n > 0)
            {
                int m = n % 10;
                reverse = reverse*10 + m;

              

            }
            Console.WriteLine(reverse);


        }
    }
}
