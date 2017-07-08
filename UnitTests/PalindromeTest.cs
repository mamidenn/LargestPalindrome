using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LargestPalindrome.Tests
{
    [TestClass]
    public class PalindromeTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LargestPalindromeOf0ThrowsException()
        {
            0.GetLargestPalindrome();
        }
        [TestMethod]
        public void LargestPalindromeOf1Is9()
        {
            Assert.AreEqual(9, 1.GetLargestPalindrome());
        }
        [TestMethod]
        public void LargestPalindromeOf2Is9009()
        {
            Assert.AreEqual(9009, 2.GetLargestPalindrome());
        }
        [TestMethod]
        public void LargestPalindromeOf3Is906609()
        {
            Assert.AreEqual(906609, 3.GetLargestPalindrome());
        }
        [TestMethod]
        public void LargestPalindromeOf4Is99000099()
        {
            Assert.AreEqual(99000099, 4.GetLargestPalindrome());
        }
        [TestMethod]
        public void LargestPalindromeOf5Is9966006699()
        {
            Assert.AreEqual(9966006699, 5.GetLargestPalindrome());
        }
        [TestMethod]
        public void AnnaIsPalindrome()
        {
            Assert.IsTrue("ANNA".IsPalindrome());
        }
        [TestMethod]
        public void FrankIsNotPalindrome()
        {
            Assert.IsFalse("FRANK".IsPalindrome());
        }
    }
}
