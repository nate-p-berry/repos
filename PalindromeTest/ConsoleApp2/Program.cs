using System.Collections;
using System.Collections.Generic;

namespace PalindromeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a test word (test: is word a palindrome. return type: boolean)");
            Console.WriteLine();
            string text = Console.ReadLine();
            var result = IsWordPalindrome(text, out string reversedText);
            Console.WriteLine($"{result} " + reversedText);
        }
        public static bool IsWordPalindrome(string text, out string reversedText)
        {
            int textLength = text.Length;
            string textLower = text.ToLower();
            char[] chars = textLower.ToCharArray();
            char[] result = new char[textLength];
            for (int i = 0; i < textLength; i++)
            {
                result[i] = chars[textLength - 1 - i];
            }
            string outText = new(result);
            reversedText = outText;
            if (outText == textLower)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}