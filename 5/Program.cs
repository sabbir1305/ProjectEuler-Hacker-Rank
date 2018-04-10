using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {

        //All numbers have a unique prime factorisation
        //All non-prime factors of a number, can be generated from the prime factors
        //private static int PrimeGenerator(int limit)
        //{
        //    List<int> primes = new List<int>();
        //    bool isPrime;
        //    int j;
        //    primes.Add(2);
        //    for(int i=3;i)

        //}

        static void Main(string[] args)
        {
            string brackets = Console.ReadLine();
            char[] brackArray = brackets.ToCharArray();
            Stack BracketStack = new Stack();
            bool result = true;
            foreach (char item in brackArray)
            {
                string bracket = item.ToString();
                if(bracket=="[" || bracket == "{" || bracket == "(") {
                    BracketStack.Push(bracket);
                }
                else
                {
                    if(BracketStack.Count > 0)
                    {
                        if (bracket == "]")
                        {
                            if (BracketStack.Peek().ToString() == "[")
                            {
                                BracketStack.Pop();
                            }
                            else
                            {
                                result = false;
                            }
                        }
                        else if (bracket == "}")
                        {
                            if (BracketStack.Peek().ToString() == "{")
                            {
                                BracketStack.Pop();
                            }
                            else
                            {
                                result = false;

                            }
                        }
                        else if (bracket == ")")
                        {
                            if (BracketStack.Peek().ToString() == "(")
                            {
                                BracketStack.Pop();
                            }
                            else
                            {
                                result = false;

                            }
                        }
                    }
                    else
                    {
                        result = false;

                    }
                }
            }
            if (BracketStack.Count > 0)
                result = false;
            if (result)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
            Console.ReadLine();
        }
    }
}
