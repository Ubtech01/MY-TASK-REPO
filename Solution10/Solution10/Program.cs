using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Leapyear(2019));
        }
        public static bool Leapyear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
    
}
