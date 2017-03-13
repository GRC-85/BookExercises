
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Admissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputGPA, inputTstScr;
            double gradePntAvg;
            int testScore;

            WriteLine("Enter your GPA");
           inputGPA  = ReadLine();
            WriteLine("Enter your testscore");
           inputTstScr  = ReadLine();

            testScore = Convert.ToInt32(inputTstScr);
            gradePntAvg = Convert.ToDouble(inputGPA);

            if ((gradePntAvg < 3.0 && testScore >= 80) || (gradePntAvg >= 3.0 && testScore >= 60))
            {
                WriteLine("Accept");
            }
            else {
                WriteLine("Reject");
            }

            ReadKey();

        }
    }
}
