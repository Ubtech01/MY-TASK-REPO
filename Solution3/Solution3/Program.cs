using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Printuppercase("xyz"));
            Console.WriteLine(Printuppercase("CASE"));
            Console.WriteLine(Printuppercase("Ubong"));
            Console.WriteLine(Printuppercase("CASE"));
        }
        public static bool Printuppercase(string str)
        {
            return (str[0] >= 65 && str[1] >= 65 && str[2] >= 65) && (str[0] <= 90 && str[1] <= 90 && str[2] <= 90);
        }
    }
}
