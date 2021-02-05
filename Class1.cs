//perfect number
using System;
using System.Collections.Generic;
using System.Text;

public class Class1
{
    public static void Main()
    {
        int n=28, i, sum;

      

        sum = 0;
        Console.Write("The positive divisor  : ");
        for (i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                sum = sum + i;
                Console.Write("{0}  ", i);
            }
        }
        Console.Write("\nThe sum of the divisor is : {0}", sum);
        if (sum == n)
            Console.Write("\nSo, the number is perfect.");
        else
            Console.Write("\nSo, the number is not perfect.");
        Console.Write("\n");
    }
}