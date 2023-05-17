using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Positivenegativeorzero(-12.23));
            Console.WriteLine(Positivenegativeorzero(12.23));
            Console.WriteLine(Positivenegativeorzero(0.00));
        }
        public static string Positivenegativeorzero(double num)
        {
            return num < 0 ? "Negative Number" : num > 0 ? "Positive Number" : "Zero"; 
        }
        
    }
}
