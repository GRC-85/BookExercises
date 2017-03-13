//ask user to type a lowercase letter from the keyboard. 
//if entry lowecase, display "OK" if not, display ""Error"
//Program continues until user types exclamation point.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EnterLowerCaseLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            char letter;
            WriteLine("Enter a lowercase letter");
            input = ReadLine();
            letter = Convert.ToChar(input);


            while (input != "!" )
            {
                if (char.IsLower(letter))
                {
                    WriteLine("\nOK.");
                    WriteLine("\nEnter another lowercase letter or press ! to escape.");
                    input = ReadLine();
                    letter = Convert.ToChar(input);
                }
                else
                    WriteLine("\nError");
                WriteLine("\nEnter another lowercase letter or press ! to escape.");
                input = ReadLine();
                letter = Convert.ToChar(input);
            }
        }
    }
}
