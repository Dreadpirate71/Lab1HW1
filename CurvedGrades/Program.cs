using System;
using System.Linq;

namespace CurvedGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double highestScore = 0;
            double pointsToAddForCurve = 0;
            double student1CurvedPts = 0;
            double student2CurvedPts = 0;
            double student3CurvedPts = 0;
            double student4CurvedPts = 0;
            double student5CurvedPts = 0;
            double student1CurvedPerc = 0;
            double student2CurvedPerc = 0;
            double student3CurvedPerc = 0;
            double student4CurvedPerc = 0;
            double student5CurvedPerc = 0;

            Console.WriteLine("Please enter the total points for the assignment");
            double totalPoints = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the points of the first student:");
            double student1Points = Convert.ToDouble(Console.ReadLine());
            double student1Percentage = student1Points / totalPoints;

            Console.WriteLine("Please enter the points of the second student:");
            double student2Points = Convert.ToDouble(Console.ReadLine());
            double student2Percentage = student2Points / totalPoints;

            Console.WriteLine("Please enter the points of the third student:");
            double student3Points = Convert.ToDouble(Console.ReadLine());
            double student3Percentage = student3Points / totalPoints;

            Console.WriteLine("Please enter the points of the fourth student:");
            double student4Points = Convert.ToDouble(Console.ReadLine());
            double student4Percentage = student4Points / totalPoints;

            Console.WriteLine("Please enter the points of the fifth student:");
            double student5Points = Convert.ToDouble(Console.ReadLine());
            double student5Percentage = student5Points / totalPoints;

            if (student1Points > student2Points && student1Points > student3Points && student1Points> student4Points && student1Points > student5Points)
            {
                highestScore = student1Points;
                student1CurvedPts = totalPoints;
                student1CurvedPerc = student1CurvedPts / totalPoints;
                pointsToAddForCurve = totalPoints - student1Points;
                student2CurvedPts = student2Points + pointsToAddForCurve;
                student2CurvedPerc = student2CurvedPts / totalPoints;
                student3CurvedPts = student3Points + pointsToAddForCurve;
                student3CurvedPerc = student3CurvedPts / totalPoints;
                student4CurvedPts = student4Points + pointsToAddForCurve;
                student4CurvedPerc = student4CurvedPts / totalPoints;
                student5CurvedPts = student5Points + pointsToAddForCurve;
                student5CurvedPerc = student5CurvedPts / totalPoints;
            }
            else if (student2Points > student1Points && student2Points > student3Points && student2Points > student4Points && student2Points > student5Points)
            {
                highestScore = student2Points;
                student2CurvedPts = totalPoints;
                student2CurvedPerc = student2CurvedPts / totalPoints;
                pointsToAddForCurve = totalPoints - student2Points;
                student1CurvedPts = student1Points + pointsToAddForCurve;
                student1CurvedPerc = student1CurvedPts / totalPoints;
                student3CurvedPts = student3Points + pointsToAddForCurve;
                student3CurvedPerc = student3CurvedPts / totalPoints;
                student4CurvedPts = student4Points + pointsToAddForCurve;
                student4CurvedPerc = student4CurvedPts / totalPoints;
                student5CurvedPts = student5Points + pointsToAddForCurve;
                student5CurvedPerc = student5CurvedPts / totalPoints;

            }
            else if (student3Points > student1Points && student3Points > student2Points && student3Points > student4Points && student3Points > student5Points)
            {
                highestScore = student3Points;
                student3CurvedPts = totalPoints;
                student3CurvedPerc = student3CurvedPts/totalPoints;
                pointsToAddForCurve = totalPoints - student3Points;
                student2CurvedPts = student2Points + pointsToAddForCurve;
                student2CurvedPerc = student2CurvedPts / totalPoints;
                student1CurvedPts = student1Points + pointsToAddForCurve;
                student1CurvedPerc = student1CurvedPts / totalPoints;
                student4CurvedPts = student4Points + pointsToAddForCurve;
                student4CurvedPerc = student4CurvedPts / totalPoints;
                student5CurvedPts = student5Points + pointsToAddForCurve;
                student5CurvedPerc = student5CurvedPts / totalPoints;
            }
            else if (student4Points > student1Points && student4Points > student2Points && student4Points > student3Points && student4Points > student5Points)
            {
                highestScore = student4Points;
                student4CurvedPts = totalPoints;
                student4CurvedPerc = student4CurvedPts / totalPoints; 
                pointsToAddForCurve = totalPoints - student4Points;
                student2CurvedPts = student2Points + pointsToAddForCurve;
                student2CurvedPerc = student2CurvedPts / totalPoints;
                student3CurvedPts = student3Points + pointsToAddForCurve;
                student3CurvedPerc = student3CurvedPts / totalPoints;
                student1CurvedPts = student1Points + pointsToAddForCurve;
                student1CurvedPerc = student1CurvedPts / totalPoints;
                student5CurvedPts = student5Points + pointsToAddForCurve;
                student5CurvedPerc = student5CurvedPts / totalPoints;
            }
            else
            {
                highestScore = student5Points;
                student5CurvedPts = totalPoints;
                student5CurvedPerc = student5CurvedPts / totalPoints;
                pointsToAddForCurve = totalPoints - student5Points;
                student2CurvedPts = student2Points + pointsToAddForCurve;
                student2CurvedPerc = student2CurvedPts / totalPoints;
                student3CurvedPts = student3Points + pointsToAddForCurve;
                student3CurvedPerc = student3CurvedPts / totalPoints;
                student4CurvedPts = student4Points + pointsToAddForCurve;
                student4CurvedPerc = student4CurvedPts / totalPoints;
                student1CurvedPts = student1Points + pointsToAddForCurve;
                student1CurvedPerc = student1CurvedPts / totalPoints;
            }
            Console.WriteLine("\t\tStudent1\tStudent2\tStudent3\tStudent4\tStudent5\t");
            Console.WriteLine("Uncurved Points {0}\t \t{1} \t \t{2} \t \t{3} \t \t{4}", student1Points, student2Points, student3Points, student4Points, student5Points);
            Console.WriteLine("Uncurved %\t{0}\t\t{1} \t \t{2} \t \t{3} \t \t{4}", student1Percentage.ToString("P1"), student2Percentage.ToString("P1"), student3Percentage.ToString("P1"), student4Percentage.ToString("P1"), student5Percentage.ToString("P1"));
            Console.WriteLine("Curved Points\t{0}\t\t{1} \t \t{2} \t\t{3} \t \t{4}", student1CurvedPts, student2CurvedPts, student3CurvedPts, student4CurvedPts, student5CurvedPts);
            Console.WriteLine("Curved %\t{0}\t\t{1} \t\t{2} \t \t{3} \t\t{4}", student1CurvedPerc.ToString("P1"), student2CurvedPerc.ToString("P1"), student3CurvedPerc.ToString("P1"), student4CurvedPerc.ToString("P1"), student5CurvedPerc.ToString("P1"));
        }
    }
}
