using System;
using System.Collections.Generic;
using System.Linq;

namespace AreaOfShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose one of the following shapes by entering the corresponding number: 1 - Triangle, 2 - Quadrilateral, 3 - Circle");
            string userShape = Console.ReadLine();
            //Console.WriteLine(userShape);
            List<double> sideTriangle = new List<double>();
            List<double> sideQuadrilateral = new List<double>();

            if (userShape == "1") 
            {
                
                Console.WriteLine("Please enter a number:");
                string firstNumber = Console.ReadLine().Trim();
                double dblFirstNumber = Convert.ToDouble(firstNumber);
                Console.WriteLine("Please enter a second number:");
                string secondNumber = Console.ReadLine().Trim();
                double dblSecondNumber = Convert.ToDouble(secondNumber);
                Console.WriteLine("Please enter a third number:");
                string thirdNumber = Console.ReadLine().Trim();
                double dblThirdNumber = Convert.ToDouble(thirdNumber);
                double areaTriangle = 0;
                double halfTotalSides = 0;
                sideTriangle.Add(dblFirstNumber);
                sideTriangle.Add(dblSecondNumber);
                sideTriangle.Add(dblThirdNumber);
                sideTriangle.Sort();
                if (sideTriangle[0] * sideTriangle[0] + sideTriangle[1] * sideTriangle[1] > sideTriangle[2] * sideTriangle[2])
                {
                    Console.WriteLine("Acute Triangle");
                }
                if (sideTriangle[0] * sideTriangle[0] + sideTriangle[1] * sideTriangle[1] == sideTriangle[2] * sideTriangle[2])
                {
                    Console.WriteLine("Right Triangle");
                }
                if (sideTriangle[0] * sideTriangle[0] + sideTriangle[1] * sideTriangle[1] < sideTriangle[2] * sideTriangle[2])
                {
                    Console.WriteLine("Obtuse Triangle");
                }
                halfTotalSides = (sideTriangle[0] + sideTriangle[1] + sideTriangle[2])/2;
                Console.WriteLine(halfTotalSides);
                areaTriangle = Math.Sqrt(halfTotalSides*((halfTotalSides-sideTriangle[0])*(halfTotalSides-sideTriangle[1])*(halfTotalSides-sideTriangle[2])));
                Console.WriteLine(areaTriangle);
            }
            if (userShape == "2")
            {
                double quadArea = 0;
                List <double> dblQuadSide = new List<double>();

                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("Please enter a number:");
                    dblQuadSide.Add(Convert.ToDouble(Console.ReadLine().Trim()));
                }
                
                var uniqueLengthSide = dblQuadSide.Distinct().ToList();
                uniqueLengthSide.Sort();
                
                var uniqueSideCount = uniqueLengthSide.Count();
                //Console.WriteLine(uniqueSideCount);

                if (uniqueSideCount == 1)
                {
                    Console.WriteLine("Square");
                    quadArea = uniqueLengthSide[0] *  uniqueLengthSide[0];
                    Console.WriteLine(quadArea);
                    Console.WriteLine("The area of the shape you chose is: {0}", quadArea);
                }
                else if (uniqueSideCount == 2)
                {
                    Console.WriteLine("Rectangle");
                    quadArea = uniqueLengthSide[0] * uniqueLengthSide[1];
                    Console.WriteLine("The area of the shape you chose is: {0}", quadArea);
                }
                else if (uniqueSideCount == 3)
                {
                    Console.WriteLine("Please enter the height:");
                    double trapHeight = (Convert.ToDouble(Console.ReadLine().Trim()));
                    var duplicates =  dblQuadSide.GroupBy(x => x).SelectMany(g => g.Skip(1)).ToList();
                    //duplicates.ForEach(side => Console.WriteLine("The Length is:" + side));
                    uniqueLengthSide.Remove(duplicates[0]);

                    //Console.WriteLine(duplicates);
                    Console.WriteLine("Trapezoid");
                    quadArea = ((uniqueLengthSide[0] * uniqueLengthSide[1])/2)*trapHeight;
                    Console.WriteLine("The area of the shape you chose is: {0}", quadArea);
                }
               
            }

            if (userShape == "3")
            {
                Console.WriteLine("Please enter the radius of the circle:");
                double radius = (Convert.ToDouble(Console.ReadLine().Trim()));
                double circleArea = Math.PI * radius * radius;
                if (circleArea > 100)
                {
                    Console.WriteLine("Big Circle");
                }
                else
                {
                    Console.WriteLine("Small Circle");

                }
                Console.WriteLine("The area of the shape you chose is: {0}", circleArea);
            }
        }
    }
}
