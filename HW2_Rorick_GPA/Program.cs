using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Rorick_GPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double MarketGrade, AcctGrade, EconGrade, MISGrade, GPA;
            double MrkPnt, AcctPnt, EconPnt, MISPnt;
            string MrkLett, AcctLett, EconLett, MISLett;
            int CreditHr = 3;

            Console.WriteLine("What is your grade in Marketing?");
            MarketGrade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your grade in Accounting?");
            AcctGrade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your grade in Economics?");
            EconGrade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your grade in MIS?");
            MISGrade = Convert.ToDouble(Console.ReadLine());

            if (MarketGrade >= 90 && MarketGrade <= 100)
            {
                MrkLett = "A";
                MrkPnt = 4 * CreditHr;
            }
            else if (MarketGrade >= 80 && MarketGrade < 90)
            {
                MrkLett = "B";
                MrkPnt = 3 * CreditHr;
            }
            else if (MarketGrade >= 70 && MarketGrade < 80)
            {
                MrkLett = "C";
                MrkPnt = 2 * CreditHr;
            }
            else if (MarketGrade >= 60 && MarketGrade < 70)
            {
                MrkLett = "D";
                MrkPnt = 1 * CreditHr;
            }
            else if (MarketGrade >= 0 && MarketGrade < 60)
            {
                MrkLett = "F";
                MrkPnt = 0;
            }
            else
            {
                MrkLett = "unknown due to an invalid input";
                MrkPnt = 0;

            }
            //Marketing number grade to letter grade

            if (AcctGrade >= 90 && AcctGrade <= 100)
            {
                AcctLett = "A";
                AcctPnt = 4 * CreditHr;
            }
            else if (AcctGrade >= 80 && AcctGrade < 90)
            {
                AcctLett = "B";
                AcctPnt = 3 * CreditHr;
            }
            else if (AcctGrade >= 70 && AcctGrade < 80)
            {
                AcctLett = "C";
                AcctPnt = 2 * CreditHr;
            }
            else if (AcctGrade >= 60 && AcctGrade < 70)
            {
                AcctLett = "D";
                AcctPnt = 1 * CreditHr;
            }
            else if (AcctGrade >= 0 && AcctGrade < 60)
            {
                AcctLett = "F";
                AcctPnt = 0;
            }
            else
            {
                AcctLett = "unknown due to an invalid input";
                AcctPnt = 0;

            }
            //Accounting number grade to letter grade


            if (EconGrade >= 90 && EconGrade <= 100)
            {
                EconLett = "A";
                EconPnt = 4 * CreditHr;
            }
            else if (EconGrade >= 80 && EconGrade < 90)
            {
                EconLett = "B";
                EconPnt = 3 * CreditHr;
            }
            else if (EconGrade >= 70 && EconGrade < 80)
            {
                EconLett = "C";
                EconPnt = 2 * CreditHr;

            }
            else if (EconGrade >= 60 && EconGrade < 70)
            {
                EconLett = "D";
                EconPnt = 1 * CreditHr;

            }
            else if (EconGrade >= 0 && EconGrade < 60)
            {
                EconLett = "F";
                EconPnt = 0;

            }
            else
            {
                EconLett = "unknown due to an invalid input";
                EconPnt = 0;
            }
            //Economics number grade to letter grade

            if (MISGrade >= 90 && MISGrade <= 100)
            {
                MISLett = "A";
                MISPnt = 4 * CreditHr;

            }
            else if (MISGrade >= 80 && MISGrade < 90)
            {
                MISLett = "B";
                MISPnt = 3 * CreditHr;

            }
            else if (MISGrade >= 70 && MISGrade < 80)
            {
                MISLett = "C";
                MISPnt = 2 * CreditHr;

            }
            else if (MISGrade >= 60 && MISGrade < 70)
            {
                MISLett = "D";
                MISPnt = 1 * CreditHr;

            }
            else if (MISGrade >= 0 && MISGrade < 60)
            {
                MISLett = "F";
                MISPnt = 0;

            }
            else
            {
                MISLett = "unknown due to an invalid input";
                MISPnt = 0;
            }
            //MIS number grade to letter grade

            GPA = (MrkPnt + EconPnt + AcctPnt + MISPnt) / 12;





            Console.WriteLine($"Your letter grade for Marketing is {MrkLett}.");
            Console.WriteLine($"Your letter grade for Accounting is {AcctLett}.");
            Console.WriteLine($"Your letter grade for Economics is {EconLett}.");
            Console.WriteLine($"Your letter grade for MIS is {MISLett}.");
            Console.WriteLine($"Your overall GPA for the semester is {GPA.ToString("N2")}.");
           
            //outputs


            Console.ReadKey();

        }
    }
}
