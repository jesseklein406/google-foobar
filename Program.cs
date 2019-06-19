using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace googel
{
    class Program
    {
        static void Main(string[] args)
        {
            string candy;

            Console.Write("Enter input: ");
            candy = Console.ReadLine();

            while (candy != "" && candy != null)
            {
                Console.WriteLine("Solution.solution(\"" + candy + "\"):");
                Console.WriteLine(Solution.solution(candy));
                Console.Write("Enter input: ");
                candy = Console.ReadLine();
            }
        }
    }

    class Solution
    {
        public static int solution(string candy)
        {
            int length = candy.Length;
            string repeated = candy + candy;

            int possibilities = 0;

            for (int i = 0; i < length; i++)
            {
                if (repeated.Substring(i, length) == candy)
                {
                    possibilities++;
                }
            }

            return possibilities;
        }
    }
}
