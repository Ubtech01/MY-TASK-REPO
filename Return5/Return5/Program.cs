using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFive());
        }
        public static int GetFive()
        {
            return "abcdef".Length ;
        }
    }
}
