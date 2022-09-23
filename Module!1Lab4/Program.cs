using System;

namespace Module_1Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte puddle = 100;
            short pond = 29456;
            int lake = 100000;
            long ocean = 5;
            long lakeInOcean = lake; //implicit casting
            Console.WriteLine(lakeInOcean);
            byte pondInPuddle = (byte) pond; //explicit casting with truncation
            Console.WriteLine(pondInPuddle);
            long pondInOcean = pond; // implicit casting
            Console.WriteLine(pondInOcean);
            int oceanInLake = (int)ocean; //explicit casting
            Console.WriteLine(oceanInLake);
        }
    }
}
