//Declare at least three integer arrays of different sizes
//Pass each array to a method that displays all the integers
//in each array and thier sum
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleArrayMethod
{
    class Program
    {
        public static void DisplayArray(int[] a, int[] b, int[] c)
        {

            Console.WriteLine("The values held in Array 1 are: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("{0, 5}", a[i]);
            }
            Console.WriteLine("The sum of Array1 is: {0, 5}", a.Sum());

            Console.WriteLine("\nThe values held in Array 2 are: ");
            for (int j = 0; j < b.Length; j++)
            {
                Console.WriteLine("{0, 5}", b[j]);
            }
            Console.WriteLine("The sum of Array2 is: {0, 5}", b.Sum());

            Console.WriteLine("\nThe values held in Array 3 are: ");
            for (int k = 0; k < c.Length; k++)
            {
                Console.WriteLine("{0, 5}", c[k]);
            }
            Console.WriteLine("The sum of Array3 is: {0, 5}", c.Sum());


        }

        static void Main(string[] args)
        {
            int[] Array1 = { 2, 4, 7, 9, 11 };
            int[] Array2 = { 9, 11, 40, 6 };
            int[] Array3 = { 1, 8, 17, 16, 9, 8 };

            DisplayArray(Array1, Array2, Array3);
            Console.ReadLine();
        }
    }

}





