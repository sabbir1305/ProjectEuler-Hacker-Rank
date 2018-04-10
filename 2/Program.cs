using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
//Fn = Fn-1 + Fn-2 
//Fn-1 = fn-2 + fn-3
//Fn-2 + Fn-3 + Fn-3 +Fn-4 
//Fn-3 + Fn-4 + Fn-3 +Fn-3 +Fn-4 = 3Fn-3 + 2Fn-4 =
//3Fn-3 + Fn-4 + Fn-5 + Fn-6) =
//4Fn-3 + Fn-6 (since Fn-4 + Fn-5 = Fn-3)
    class Program
    {
        static void Main(string[] args)
        {
           ulong FibN3 = 2;
            ulong FibN6 = 0;
            ulong Result = 2;
            ulong Sum = 0;

            ulong N=100;
            while (Result < N)
            {
                Sum = Sum + Result;
                Result = 4 * FibN3 + FibN6;
                FibN6 = FibN3;
                FibN3 = Result;
                Console.WriteLine("res"+ Result);
                Console.WriteLine("f3: "+FibN3);
                Console.WriteLine("f6: "+ FibN6);


            }
            Console.WriteLine(Sum);
            Console.ReadKey();
        }
    }
}
