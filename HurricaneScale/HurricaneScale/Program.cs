using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HurricaneScale
{
    class Program
    {

        static void Main(string[] args)
        {
            const int CAT_1 = 74, CAT_2 = 96, CAT_3 = 111, CAT_4 = 130, CAT_5 = 157;
            string inputSpeed;
            int windSpeed;

            Console.WriteLine("Enter the current wind speed >>");
            inputSpeed = ReadLine();
            windSpeed = Convert.ToInt32(inputSpeed);

            if (windSpeed >= CAT_5)
            {
                WriteLine("This is a Category 5 Hurricane.");
            }
            else if (windSpeed < CAT_5 && windSpeed >= CAT_4)
            {
                WriteLine("This is a Category 4 Hurricane.");
            }
            else if (windSpeed < CAT_4 && windSpeed >= CAT_3)
            {
                WriteLine("This is a Category 3 Hurricane.");
            }
            else if (windSpeed < CAT_3 && windSpeed >= CAT_2)
            {
                WriteLine("This is a Category 2 Hurricane.");
            }
            else if (windSpeed < CAT_2 && windSpeed >= CAT_1)
            {
                WriteLine("This is a Category 1 Hurricane.");
            }
            else
                WriteLine("There is no Hurricane.");
            ReadKey();
        }
    }
}