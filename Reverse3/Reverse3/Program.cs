using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Reverse3
{
    class Program
    {
        public static void IntSwap(ref int one, ref int two, ref int three)
        {
            int temp;
            temp = one;
            one = three;
            three = temp;
        }
            

        

        static void Main(string[] args)
        {
            int firstInt=11, middleInt=84, lastInt=20;

            WriteLine("Before being passed to IntSwap():");
            Write("\n firstInt: {0}, middleInt: {1}, lastInt: {2}"
                , firstInt, middleInt, lastInt);
            Write("\n-----------------------------------------");
            IntSwap(ref firstInt, ref middleInt, ref lastInt);
            WriteLine("\nAfter being passed to IntSwap():");
            Write("\nfirstInt: {0}, middleInt: {1}, lastInt: {2}",
                firstInt, middleInt, lastInt);
            Write("\n-----------------------------------------");
            ReadLine();
        }
    }
}
