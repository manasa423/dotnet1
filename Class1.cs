
//sum of digits

using System;
using System.Collections.Generic;
using System.Text;

namespace NumberApp
{
    class Class1
    {
        static void Main(string[] args)
        {
            int n = 120;
             int sum = 0;
            while (n > 0)
            {
                int m = n % 10;
                sum = sum + m;

                n = n / 10;

            }
            Console.WriteLine(sum);
            

        }
    }
}
