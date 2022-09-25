using System;

namespace Week3InClass1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] arrNums = { 45, 23, 44, 68, 65, 70, 80, 81, 82 };
            int [] arrNums2 = { 7, 3, 5, 8, 9, 3, 1, 4 };
            bool consNumbersInArray = false;
            bool consNumbersInArray2 = false;
            for (int i = 0, j = 1, k = 2; i < arrNums.Length; i++, j++, k++)
            {
                if (arrNums[i] + 1 == arrNums[j] && arrNums[j] + 1  == arrNums[k])
                {
                    consNumbersInArray = true;
                    break;
                }
            }
            for (int i = 0, j = 1, k = 2; i < arrNums2.Length; i++, j++, k++)
            {
                if (k > arrNums2.Length)
                {
                    break;
                }
                if (arrNums2[i] + 1 == arrNums2[j] && arrNums2[j] + 1 == arrNums2[k])
                {
                    consNumbersInArray2 = true;
                    break;
                }
            }
            Console.WriteLine(consNumbersInArray);
            Console.WriteLine(consNumbersInArray2);
        }
    }
}
