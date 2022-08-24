using System;

namespace DataStructuresAndAlgorithmsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33 };
            Console.WriteLine("What number would you like to search for?");
            int myTerm = Convert.ToInt32(Console.ReadLine());
            bool isFound = SearchArray(myTerm, myArray, 0, myArray.Count(), out isFound);
            string GetMyResult(bool isFound) => isFound == true ? $"{myTerm} was found in the array!" : $"{myTerm} was NOT found in the array.";
            Console.WriteLine(GetMyResult(isFound));
        }

        private static bool SearchArray(int searchTerm, int[] searchArray, int lowNumber, int highNumber, out bool found)
        {
            try
            {
                if (lowNumber > highNumber)
                {
                    found = false;
                    return found;
                }

                int middle = (lowNumber + highNumber) / 2;

                if (searchTerm == searchArray[middle])
                {
                    found = true;
                    return found;
                }
                else if (searchTerm > searchArray[middle])
                {
                    SearchArray(searchTerm, searchArray, lowNumber, middle - 1, out found);
                }
                else
                {
                    SearchArray(searchTerm, searchArray, middle - 1, highNumber, out found);
                }
                return found;
            }
            catch (Exception OutOfRangeException)
            {
                found = false;
                return found;
            }
        }
    }
}