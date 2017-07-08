using System;
using Largest_Palindrome;

namespace Program
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Find the largest palindrome number, that is the product of two n-digit numbers.");
            int digits;
            string input;
            do
            {
                Console.Write("Specify n: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out digits));
            Console.WriteLine("Largest palindrome number: {0}", digits.GetLargestPalindrome());
            Console.ReadLine();
        }
    }
}
