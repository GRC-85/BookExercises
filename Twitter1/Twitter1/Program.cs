using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter1
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputString;
            Console.WriteLine("Please enter a message to display to Twitter.");
            inputString = Console.ReadLine();

            if (inputString.Length > 140)

            {
                Console.WriteLine("Sorry.");
            }
            else
            {
                Console.WriteLine("We will post your message.");
            }
            Console.ReadKey();
        }
    }
}
