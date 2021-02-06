using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i= 1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(i+"\t");
                }
                Console.WriteLine();
            }
           
        }
    }
}
