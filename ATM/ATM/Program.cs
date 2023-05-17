using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ATM
{

            public class ATM
        {
            public static void CalculateBills(int amount)
            {
                int num100 = 0;
                int num50 = 0;
                int num20 = 0;

                if (amount >= 400 && amount <= 100000)
                {
                    num100 = amount / 100;
                    amount -= num100 * 100;

                    num50 = amount / 50;
                    amount -= num50 * 50;

                    num20 = amount / 20;
                }

                Console.WriteLine($"Number of $100 bills: {num100}");
                Console.WriteLine($"Number of $50 bills: {num50}");
                Console.WriteLine($"Number of $20 bills: {num20}");
            }
        
            static void Main()
            {
                int amount = 1450;
                ATM.CalculateBills(amount);
            }
        }
    }

