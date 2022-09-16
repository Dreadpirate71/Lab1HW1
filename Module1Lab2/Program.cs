using System;

namespace Week_1Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite season:");
            string userFavoriteSeason = Console.ReadLine();
            Console.WriteLine("Enter your favorite car:");
            string userFavoriteCar = Console.ReadLine();
            Console.WriteLine("Enter your favorite TV Show:");
            string userFavoriteShow = Console.ReadLine();
            Console.WriteLine("Enter total amount spent on streaming last year:");
            string streamAmount = Console.ReadLine();
            string streamAmountDollars = String.Format("0:C2", streamAmount);
            string finalOutputDisplay = String.Format("Your favorite season is {0}. Your favorite car is a {1}. Your favorite TV show is {2}. You spent {3:C2} last year on streaming", userFavoriteSeason, userFavoriteCar, userFavoriteShow, streamAmount);
            Console.WriteLine(finalOutputDisplay);
        }
    }
}
