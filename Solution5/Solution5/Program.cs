using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Solution5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Checkevennumber(8));
            Console.WriteLine(Checkevennumber(15));
            Console.WriteLine(Checkevennumber(9));
            Console.WriteLine(Checkevennumber(17));
        }
        public static bool Checkevennumber(int number)
        {
            return number % 2 == 0; 
        }
    }
}
