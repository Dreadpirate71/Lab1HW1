using System;

namespace CoinExchange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a dollar amount in dollars and cents (Ex. 2.15:");
            string strDollarsCents = Console.ReadLine();
            double dblDollarsCents = Convert.ToDouble(strDollarsCents);
            Console.WriteLine(dblDollarsCents);
            int wholeDollars = (int)dblDollarsCents;
            Console.WriteLine(wholeDollars);
            double quarters = wholeDollars/.25;
            //Console.WriteLine(quarters);
            decimal decDollarsCents = (decimal)dblDollarsCents;
            decimal cents = decDollarsCents % 1;
            Console.WriteLine(cents);
            double dblCents = (double)cents;
            double centQuarters = dblCents / .25;
            int totalQuarters = (int)centQuarters + (int)quarters;
            Console.WriteLine(totalQuarters);
            double centTotalAfterQuarters =  dblCents - (int)centQuarters*.25;
            //Console.WriteLine(centTotalAfterQuarters);
            double dimes = centTotalAfterQuarters / .10;
            //Console.WriteLine(dimes);
            int wholeDimes = (int)dimes;
            Console.WriteLine(wholeDimes);
            double centTotalAfterDimes = centTotalAfterQuarters - (wholeDimes * .10);
            //Console.WriteLine(centTotalAfterDimes);
            double nickels = centTotalAfterDimes / .05;
            int wholeNickels = (int)nickels;
            Console.WriteLine(wholeNickels);
            double centTotalAfterNickels = centTotalAfterDimes - (wholeNickels * .05);
            Console.WriteLine(centTotalAfterNickels);
            double rndCentTotalAfterNickels = Math.Round(centTotalAfterNickels, 2);
            Console.WriteLine(rndCentTotalAfterNickels);
            double pennies = rndCentTotalAfterNickels / .01;
            Console.WriteLine(pennies);
            Console.WriteLine("{0} quarter(s), {1} dime(s), {2} nickel(s), {3} pennies", totalQuarters, wholeDimes, wholeNickels, pennies);
        }
    }
}
