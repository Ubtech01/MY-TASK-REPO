using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Solution2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divisibleby3or2(8,4));
            Console.WriteLine(Divisibleby3or2(4,4));
            Console.WriteLine(Divisibleby3or2(24,12));
            Console.WriteLine(Divisibleby3or2(15,6));
        }
        public static int Divisibleby3or2(int a, int b)
        {
            return (a % 2 == 0 && b % 2 == 0 || a % 3 == 0 && b % 3 == 0 ? a + b : a * b);
        }
       
    }
}
