using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiplicationcheck(new int[]{ 9,8,10}));
            Console.WriteLine(Multiplicationcheck(new int[] { 2, 8, 20 }));
            Console.WriteLine(Multiplicationcheck(new int[] { 4, 2, 10 }));
            Console.WriteLine(Multiplicationcheck(new int[] { 9, 2, 50 }));
            Console.ReadKey();
        }
        public static bool Multiplicationcheck(int[] arr)
        {
            return arr[0] + arr[1] > arr[2] || arr[0] * arr[1] > arr[2]; 
        }
    }
}
