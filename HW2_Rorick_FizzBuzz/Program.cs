﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Rorick_FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string LuckyNumber;
            int conversion;
            //Variable Declaration

            Console.WriteLine("Please enter your lucky number!");
            LuckyNumber = Console.ReadLine();



            if (int.TryParse(LuckyNumber, out conversion))
            {
                if (conversion % 3 == 0 && conversion % 5 != 0)
                {
                    Console.WriteLine($"{conversion} Fizz");
                }//If is divisible by 3 only

                else if (conversion % 3 != 0 && conversion % 5 == 0)
                {
                    Console.WriteLine($"{conversion} Buzz");
                }//If is disible by 5 only

                else if (conversion % 3 == 0 && conversion % 5 == 0)
                {
                    Console.WriteLine($"{conversion} FizzBuzz");
                }//If is disible by both 3 & 5

                else
                {
                    Console.WriteLine("I'm sorry, but you have entered an invalid number.\nPlease try again.");
                }
            else
            {

             }
            }
        }
    }
}
