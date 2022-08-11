using System.Linq;

namespace Assignment4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[100];
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = i + 1;
            }
            foreach (int i in numberArray)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();

            ReturnEvenNumbers(numberArray);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(IfYearIsLeap());
            Console.WriteLine();
            Console.WriteLine();

            StringInReverseOrder();
            SpaceCounter();
        }

        public static int[] ReturnEvenNumbers(int[] ints)
        {
            foreach (int i in ints)
            {
                if (i%2 == 0)
                {
                    Console.Write(i + ", ");
                } 
            }
            return ints;

        }

        public static bool IfYearIsLeap()
        {
            Console.WriteLine("Please enter a four digit year to test.");
            int yearNumb = Convert.ToInt32(Console.ReadLine());
            if ((yearNumb % 4) == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static string StringInReverseOrder()
        {
            
            Console.WriteLine("Please enter a string for us to test.");
            string input = Console.ReadLine();
            char[] args = input.ToCharArray();
            char[] sgra = new char[args.Length];
            for (int i = 0; i < (args.Length); i++)
            {
                sgra[i] = args[args.Length - i - 1];
            }
            string result = new(sgra);
            Console.WriteLine(result);
            return result;
        }

        public static int SpaceCounter()
        {
            Console.WriteLine("Please enter a sentence for us to test.");
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            int result = 0;
            foreach (char c in charArray)
            {
                if (c==' ')
                {
                    result++;
                }
            }
            Console.WriteLine($"'{input}' contains {result} space(s).");
            return (int)result;
        }
    }
}