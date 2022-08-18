namespace MergeSortArrayInterviewQuestion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = new int[] { 0, 1, 2, 3, 8, 9, 23, 87, 99 };
            int[] arrayTwo = new int[] { 3, 6, 10, 21, 42, 56, 80 };
            Array.ForEach(MergeSortArray(arrayOne, arrayTwo), Console.Write);
        }

        public static int[] MergeSortArray(int[] firstArray, int[] secondArray)
        {
            int resultArrayLength = firstArray.Length + secondArray.Length;
            int[] resultArray = new int[resultArrayLength];
            int k = 0;
            while (k < resultArrayLength)
            {
                if (firstArray[k] <= secondArray[k])
                {
                    resultArray[k] = firstArray[k];
                } else
                {
                    resultArray[k] = secondArray[k];
                }
                k++;
            }
/*            for (int i = 0; i < firstArray.Length; i++ )
            {
                for (int j = 0; j < secondArray.Length; j++ )
		        {
                    if (firstArray[i] >= secondArray[j])
                    {
                        resultArray.Append(firstArray[i]);
                    }
                    else
                    {
                       resultArray.Append(secondArray[j]);
                    }
                }
            }*/
        return resultArray;
        }
    }
}