using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Checkstring("ABC"));
        }
        public static bool Checkstring(string word)
        {
            return word[0] == word[1] - 1 || word[0] == word[1] + 1 || word[2] == word[1] - 1 || word[2] == word[1] + 1; 
        }
    }
}
