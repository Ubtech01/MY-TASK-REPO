using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int row = 4;
            int coloum = 9;

            for (int i = 1; i < row; i++)
            {
                for (int j = 3; j < coloum; j++)
                {
                    Console.Write(i * j);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
