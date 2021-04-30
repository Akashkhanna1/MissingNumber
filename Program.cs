using System;
using System.Collections.Generic;
using System.Linq;

namespace MissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, i;
            int sumarr, total, miss;
            int[] arr = new int[100];
            Console.Write("Enter length of the array!...\n");
            Console.Write("------------------------------------\n");
            l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the elements for the array!..In this form:  [1,2,3,5,6]  \n");
            for (i = 0; i < l; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            total = (l + 1) * (l + 2) / 2;
            sumarr = arr.Sum();
            miss = total - sumarr;
            Console.Write("Missing Number: {0}\n", miss);
            Console.Write("press any key to close the app \n");
            Console.ReadKey();

        }
    }
}
