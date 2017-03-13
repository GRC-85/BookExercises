using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CheckCredit1
{
    class CheckCredit
    {
        private static void GetPurchaseAmount()
        {
            string inputAmount;
            double amount;

            WriteLine("Enter the amount of your purchase.");
            inputAmount = ReadLine();
            amount = Convert.ToDouble(inputAmount);

            if (amount < 5000)
                WriteLine("Approved");
            else
                WriteLine("Declined.");

            ReadLine();
            {
              
            }


        }

        static void Main(string[] args)
        {
            GetPurchaseAmount();
        }
    }
}
