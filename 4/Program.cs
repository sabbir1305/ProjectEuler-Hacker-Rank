using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {

        private static int  makePalindrome(int firstHalf)
        {
            char[] reversed = firstHalf.ToString().Reverse().ToArray();
            return Convert.ToInt32(firstHalf + new string(reversed));
        }
        static void Main(string[] args)
        {

            bool found = false;
            int firstHalf = 998, palin = 0;
            int[] factors = new int[2];
            int N = 800000;
            while (!found)
            {
                firstHalf--;
                palin = makePalindrome(firstHalf);
                for (int i = 999; i > 99; i--)
                {
                    if (((palin / i) > 999 || i * i < palin) )
                    {
                        break;
                    }

                    if ((palin % i == 0) && palin < N)
                    {
                        found = true;
                        factors[0] = palin / i;
                        factors[1] = i;
                        break;
                    }
                }
            }


            Console.WriteLine("Found the palindrom {0}, which is made from {1}*{2}", palin, factors[0], factors[1]);











            //var number = (from a in Enumerable.Range(100, 1000)
            //              from b in Enumerable.Range(100, 1000)
            //              select a * b ).Where(x => (x.ToString().ToCharArray().SequenceEqual(x.ToString().Reverse()))).Max();
            //Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
