//sum of the numbers for the given range

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class2
    {
        static void Main(string[] args)
        {
            int i=1, 
            sum = 0;
            while(i<=10)
            {
                sum = sum + i;
                
                i++;
                Console.WriteLine(sum);
            }


        }
           
    }
}
