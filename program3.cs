﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Class2
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j}\t");
                    count++;
                }
                Console.WriteLine();
            }
        }
    }
}
