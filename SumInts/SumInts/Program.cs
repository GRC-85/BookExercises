//user enters any numbers of integers continuiously until user enters 999 to escape loop.
//Display the sum of values entered.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ESCAPE = "999";
           // const int END = 999;
            int number;
            string userInput = "";
          // int i = 0;
          int  total = 0;

            do
            {
                WriteLine("\nEnter a number.");
                userInput = ReadLine();
                number = Convert.ToInt32(userInput);
                total += number;
                WriteLine("\nThe running total is: {0}", total);

            } while (userInput != ESCAPE);

              
            
            
          
        }
    }
}
