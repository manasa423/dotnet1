using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'a';
            for(int i=1;i<6;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write($"{ch++}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
