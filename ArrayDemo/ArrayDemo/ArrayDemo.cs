using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ArrayDemo
{
    class ArrayDemo
    {
      

        static void Main(string[] args)
        {
            //int[] numbers = { 1, 7, 5, 2, 9, 11, 6, 18 };
            //const int STOP = 0000;
            //string userPref;
            //int pref;

            //Console.Write("Choose 1 of 3 choices >> ");
            //userPref = ReadLine();
            //pref = Convert.ToInt32(userPref);

            //if (pref == 1)
            //{
            //    Array.Sort(numbers);
            //    WriteLine("Numbers in sequential sort order");
            //    for (int x = 0; x < numbers.Length; x++)
            //    {
            //        Write(numbers[x]);
            //    }
            //}
            //else if (pref == 2)
            //{
            //    Array.Reverse(numbers);
            //    WriteLine("Numbers in reverse order");
            //    for (int x = 0; x < numbers.Length; x++)
            //    {
            //        Write(numbers[x]);
            //    }
            //}
            //else if (pref == 3)
            //{
            //    int x;
            //    WriteLine("What which one do you want?");
            //    string inputOption = ReadLine();
            //    int option = Convert.ToInt32(inputOption);
            //    WriteLine("Finding a number with Binary Search");
            //   x= Array.BinarySearch(numbers, option);
            //    Write("{0}", numbers[x]);


            //}

            //ReadKey();

            int[] numbers = { 1, 7, 5, 2, 9, 11, 6, 18 };
            const int STOP = 0000;  
            string userNumChoice;   
            int numChoice = 0;       

           

            do
            {
                WriteLine("Enter a number: 1, 2, or 3. Press 0000 to escape.");
                userNumChoice = ReadLine();
                numChoice = Convert.ToInt32(userNumChoice);

                if (numChoice==1)
                {
                    Array.Sort(numbers);
                    for (int x = 0; x < numbers.Length; x++)
                    {
                        WriteLine(numbers[x]);
                    }
                    WriteLine("This is a demonstration of the 'Sort' method.");
                }
                else if (numChoice == 2)
                {
                    Array.Reverse(numbers);
                    WriteLine("This is a demonstration of The 'Reverse' method.");
                    for (int x = 0; x < numbers.Length; x++)
                    {
                        WriteLine(numbers[x]);
                    }
                }
                else if (numChoice == 3)
                {
                    int x;
                    WriteLine("Which integer from the array do you want to choose? ");
                   
                    string inputOption = ReadLine();
                    int option = Convert.ToInt32(inputOption);
                    WriteLine("Finding a number with Binary Search");
                    x = Array.BinarySearch(numbers, option);
                    WriteLine("{0}", numbers[x]);
                }

            } while (numChoice == 1 || numChoice == 2 || numChoice == 3 || numChoice != STOP);








            {


            }












        }
    }

}