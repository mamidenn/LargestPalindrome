using System;
using System.Numerics;

namespace LargestPalindrome
{
    public static class ExtensionMethods
    {
        public static BigInteger GetLargestPalindrome(this int n)
        {
            if (n < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            var largest = (int) Math.Pow(10, n) - 1;
            var smallest = (int) Math.Pow(10, n - 1);
            BigInteger largestProduct = 0;
            for (BigInteger i = largest; i >= smallest; i--)
            {
                for (var j = i; j >= smallest; j--)
                {
                    var product = i * j;
                    if (product < largestProduct)
                    {
                        break;
                    }
                    if (Convert.ToString(product).IsPalindrome())
                    {
                        largestProduct = product;
                    }
                }
            }
            return largestProduct;
        }

        public static bool IsPalindrome(this string s)
        {
            return s == s.Reverse();
        }

        private static string Reverse(this string s)
        {
            var chars = s.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}