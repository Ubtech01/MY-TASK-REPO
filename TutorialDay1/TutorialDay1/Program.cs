using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Abs(-10));
        }
        public static int Abs(int number)
        {
            if (number < 0)
            {
               return number * -1;
            }
            return number;
        }
    }
}
       
        
