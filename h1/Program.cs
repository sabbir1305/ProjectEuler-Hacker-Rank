using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{


    /*
     * Complete the berthType function below.
     */
    static string berthType(int n)
    {
        string result;

        if (n % 8 == 0)
            result = "SLB";
        else if(n%8==7)
            result = "SUB";
        else if(n %8 ==1 || n % 8 == 4)
        {
            result = "LB";
        }
        else if (n % 8 == 2 || n % 8 == 5)
        {
            result = "MB";
        }
        else
        {
            result = "UB";
        }
        return result;

    }


    static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string result = berthType(n);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
