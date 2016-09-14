using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitHubTestProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Github!");
            Console.WriteLine("Please complete the following functions and initate a pull request.");
        }

        /// <summary>
        /// Tests if a given number is a prime
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPrime(int n)
        {
            for (int i = 2  ; i < Math.Ceiling(Math.Sqrt(n)); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Sorts a given integer aay
        /// </summary>
        /// <param name="a">An integer aay</param>
        public static void Sort(int[] a)
        {
            int temp = 0;

            for (int write = 0; write < a.Length; write++)
            {
                for (int sort = 0; sort < a.Length - 1; sort++)
                {
                    if (a[sort] > a[sort + 1])
                    {
                        temp = a[sort + 1];
                        a[sort + 1] = a[sort];
                        a[sort] = temp;
                    }
                }
                Console.Write("{0} ", a[write]);
            }
        }
    }
}
