using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dailyprogrammer367
{
    class Program
    // Dailyprogrammer 367: https://www.reddit.com/r/dailyprogrammer/comments/9cvo0f/20180904_challenge_367_easy_subfactorials_another/ 
    // The formula for subfactorial is !N = (N - 1) * (!(N-1) + !(N - 2))
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate subfactorial");
            Console.WriteLine("Please enter a number");
            string SubFac = Console.ReadLine();

            int N = int.Parse(SubFac);

            Console.WriteLine(CalculateSubfactorial(N));

            Console.ReadKey();
        }

        public static int CalculateSubfactorial(int N)
        {
            if (N == 0)
            {
                throw new ArgumentException();
            }
            else if (N == 1)
            {
                return 0;
            }
            else if (N == 2)
            {
                return 1;
            }
            else
            {        
                return (N - 1) * (CalculateSubfactorial(N - 1) + CalculateSubfactorial(N - 2));
            }
        }

    }
}
