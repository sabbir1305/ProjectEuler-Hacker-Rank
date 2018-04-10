using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Any integer greater than 1 is 
            //either a prime number, or can be written
            //as a unique product of prime numbers(ignoring the order).
            long num = 28;
            long newNum = num;
            long largestFact = 0;
            int counter = 2;
            while (counter * counter <= newNum)
            {
                if (newNum == 1)
                    break;
                if(newNum % counter == 0)
                {
                    newNum = newNum / counter;
                    largestFact = counter;
                }
                else
                {
                    counter = (counter == 2) ? 3 : counter + 2;
                    //counter is 2 , we increase it to 3, otherwise we increase it by 2
                }
            }
            if(newNum > largestFact)
            {
                largestFact = newNum;
            }
            Console.WriteLine(largestFact);
            Console.ReadKey();
        }
    }
}
