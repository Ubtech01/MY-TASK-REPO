using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(n);
            bool prime = true;

            while (prime && (divider <= maxDivider))
            {
                if (n % 2 == 0)
                {
                    prime = false;
                }
                divider++;
            }
            Console.WriteLine("prime? " + prime);
            Console.ReadKey();
        }
    }
}
