using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CheckMonth
{
    class Program
    {
        enum Month
        {
            JANUARY = 1, FEBRUARY, MARCH, APRIL, MAY, JUNE,
            JULY, AUGUST, SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER

        }
        static void Main(string[] args)
        {

            string message = "";
            Console.WriteLine("Enter Your Birth Month, 1 - 12. >>");
            int month = Convert.ToInt32(Console.ReadLine());
          

            switch ((Month)month)
            {
                case Month.JANUARY:
                    message = "This is the first month.";
                    break;
                case Month.FEBRUARY:
                    message = "This is the second month.";
                   break;
                case Month.MARCH:
                    message = "This is the third month.";
                    break;
                case Month.APRIL:
                    message = "This is the fourth month.";
                    break;
                case Month.MAY:
                    message = "This is the fifth month.";
                    break;
                case Month.JUNE:
                    message = "This is the sixth month.";
                    break;
                case Month.JULY:
                    message = "This is the seventh month.";
                    break;
                case Month.AUGUST:
                    message = "This is the eigth month.";
                    break;
                case Month.SEPTEMBER:
                    message = "This is the ninth month.";
                    break;
                case Month.OCTOBER:
                    message = "This is the tenth month.";
                    break;
                case Month.NOVEMBER:
                    message = "This is the eleveth month.";
                    break;
                case Month.DECEMBER:
                    message = "This is the twelth month.";
                    break;

                   
                
        }
            WriteLine(message);
            Console.ReadLine();
        }
    }
}
