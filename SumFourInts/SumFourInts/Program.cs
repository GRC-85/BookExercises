//Write an application that allows users to enter four integers and displays the sum
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SumFourInts
{
    class Program
    {
     

        static void Main(string[] args)
        {
            string userInput;
            int number;
            int total = 0;
            const int END = 4;

            
            int i = 1;
            while (i <= END)
            {
               
                Console.WriteLine("Enter a number.");
                userInput = ReadLine();
                number = Convert.ToInt32(userInput);
                ++i;
                total += number;
            }
            WriteLine("The total of the numbers you enter is {0}", total);
            ReadLine();
        }
    }
}
