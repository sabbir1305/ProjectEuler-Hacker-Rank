using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            ulong sum = new ulong();
            n = n - 1;
            int n15 = (n - (n % 15)) / 15;


            int n3 = (n - (n % 3)) / 3;

            int n5 = (n - (n % 5)) / 5;


            sum = Convert.ToUInt64((3 * ((n3 * (n3 + 1)) / 2) + 5 * ((n5 * (n5 + 1)) / 2) - 15 * ((n15 * (n15 + 1)) / 2)));

            Console.WriteLine(sum);
            Console.ReadKey();
        }


    }
}
