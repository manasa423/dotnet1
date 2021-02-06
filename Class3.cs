
//factorial of a number
using System;
using System.Collections.Generic;
using System.Text;

namespace NumberApp
{
    class Class3
    {
        static void Main(string[] args)
        {
        
            int fact = 1;
            for(int j = 1; j <= 5; j++)
            {
                fact = fact * j;
               
            }
            Console.WriteLine($"fact of i is:{fact}");

        }
    }
}
