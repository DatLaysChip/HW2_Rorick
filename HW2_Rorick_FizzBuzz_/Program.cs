using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Rorick_FizzBuzz_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string LuckyNumber;
            int conversion;
            //Variable Declaration

            Console.WriteLine("Please input your lucky number!");
            LuckyNumber = Console.ReadLine();
            //User Input

            if (int.TryParse(LuckyNumber, out conversion))
            {
                if (conversion % 3 == 0 && conversion % 5 != 0)
                {
                    Console.WriteLine($"{conversion} Fizz");
                }//If divisible by 3 only

                else if (conversion % 3 != 0 && conversion % 5 == 0)
                {
                    Console.WriteLine($"{conversion} Buzz");
                }//If divisible by 5 only

                else if (conversion % 3 == 0 && conversion % 5 == 0)
                {
                    Console.WriteLine($"{conversion} FizzBuzz");
                }//If divisible by 3 & 5

                else
                {
                    Console.WriteLine(conversion);
                }//If not divisible by 3 or 5
            }
            else
            {
                Console.WriteLine("An invalid input has been detected. \nPlease try again.");
            }
            //Conditional whether UserInput is valid or not
            //Output

            Console.ReadKey();
        }
    }
}
