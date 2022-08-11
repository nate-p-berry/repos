namespace RomanNumeralCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a roman numeral to test.");
            Console.WriteLine();
            string s = Console.ReadLine();
            RomanToInt(s);
        }
        static int RomanToInt(string s)
        {

            IDictionary<char, int> table = new Dictionary<char, int>();
            table.Add('M', 1000);
            table.Add('D', 500);
            table.Add('C', 100);
            table.Add('L', 50);
            table.Add('X', 10);
            table.Add('V', 5);
            table.Add('I', 1);

            int result = 0;
            char[] chars = s.ToUpper().ToCharArray();
            foreach (char c in chars)
            {
                if (table.ContainsKey(c))
                {
                    result = result + table[c];
                }
            }
            return result;
        }
    }
}