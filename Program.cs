using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Casting
            // TO cast, place type infront of variable you are casting
            // Ex. (long) 53434.138473487
            // Converts to 53434
            int wholeNumber = 500;
            double decimalNumber = 500.5;

            // Implicit
            double holdWholeNumber = (double)wholeNumber;
            //Console.WriteLine(holdWholeNumber);

            // Explicit - Explicity tell the computer we are changing its type
            // Acknowledge we are losing data
            int holdDecimalNumber = (int)decimalNumber;
            Console.WriteLine(holdDecimalNumber);


            //    // Goto BEFORE a label
            //    Console.WriteLine(1);
            //    goto goHere;
            //    Console.WriteLine(2);
            //goHere:;

            //// Goto AFTER a label
            //goHereNOw:;
            //    Console.WriteLine(1);
            //    goto goHereNOw;
            //    Console.WriteLine(2);

            //int firstNumber = 5;
            //int secondNumber = 3;
            //double total = firstNumber / (secondNumber * 1.0);
            //Console.WriteLine(firstNumber / (double)secondNumber);
            //Console.WriteLine(total);

            // How to check if a number is an even
            int number = 11;

            bool isEven = number % 2 == 0;

            //bool isOdd = number % 2 != 0;

            //bool isOddALso = number % 2 == 1;
            //bool isEvenToo = number % 2 != 1;

            if (isEven)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }

            int[] arr = { 23, 54, 1, 775, 45, 64 };
            /* Array of Integers
             * 0 23
             * 1 54
             * 2 1 
             * 3 775
             * 4 45
             * 5 64
             */

        }
    }
}
