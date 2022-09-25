using System;
using System.Linq;
using System.Collections.Generic;
namespace Week3InClassExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listNums1 = new List<int> {3,5,6,7,8,10,1};
            List<int> listNums2 = new List<int> {2,1,9,11,10,4};
            List<int> diffNums = new List<int>();
            var firstNotSecond = listNums1.Except(listNums2).ToList();
            var secondNotFirst = listNums2.Except(listNums1).ToList();
            foreach (int i in firstNotSecond)
            {
                diffNums.Add(i);
            }
            foreach (int i in secondNotFirst)
            {
                diffNums.Add(i);
            }
            Console.WriteLine(string.Join(", ", diffNums));
            
        }
    }
}
