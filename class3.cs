//max digit of a number

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class1
    {
        static void Main(string[] args)
        {
            int num = 126;
            int large = 0,
                rem = 0;
            while (num > 0)
            {
                rem = num % 10;
                if (rem > large)
                {
                    large = rem;
                }

            }
            Console.WriteLine(large);


        }

    }
}
