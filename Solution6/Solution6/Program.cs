using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Arrayinascending(new int[] {4, 12, 9}));
            Console.WriteLine(Arrayinascending(new int[] { 4, 7, 9 }));
            Console.WriteLine(Arrayinascending(new int[] { 4, 7, 2 }));
            Console.WriteLine(Arrayinascending(new int[] { 1, 7, 9 }));
        }
        public static bool Arrayinascending(int[] arr)
        {
            return arr[0] < arr[1] && arr[1] < arr[2];
        }
    }
}
