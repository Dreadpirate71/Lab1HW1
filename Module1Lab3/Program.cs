using System;

namespace Module1Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a proper name:");
            string properName = Console.ReadLine();
            Console.WriteLine("Enter a favorite city:");
            string favoriteCity = Console.ReadLine();
            Console.WriteLine("Enter a number less than 100");
            string numberOne = Console.ReadLine();
            Console.WriteLine("Enter an animal that scares you:");
            string scaryAnimal = Console.ReadLine();
            Console.WriteLine("Enter a noun:");
            string firstNoun = Console.ReadLine();
            Console.WriteLine("Enter a present tense verb:");
            string firstVerb = Console.ReadLine();
            Console.WriteLine("Enter an adjective:");
            string firstAdjective = Console.ReadLine();
            Console.WriteLine("Enter an adverb:");
            string firstAdverb = Console.ReadLine();
            Console.WriteLine("{0} lived in {1} for {2} years.", properName, favoriteCity, numberOne);
            Console.WriteLine("This was surpirsing because {0} were {1} {2} on {3} {4}.", scaryAnimal, firstAdverb, firstVerb, firstAdjective, firstNoun);

        }
    }
}
