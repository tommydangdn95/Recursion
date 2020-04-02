using NUnit.Framework;
using ReverseString;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseString.Test
{
    [TestFixture]
    public class Tests
    {
        string test1;
        string test2;
        string test1Reverse;
        string test2Reverse;
        Program testRecursion;
        [SetUp]
        public void Setup()
        {
            testRecursion = new Program();
            test1 = "abc";
            test2 = "abcdef";
            test1Reverse = "cba";
            test2Reverse = "fedcba";
        }

        [TestCase]
        public void TestReverseString()
        {
            // Act
            var test1CharArray = test1.ToCharArray();
            var test2CharArray = test2.ToCharArray();
            testRecursion.reverseString(test1CharArray, 0, test1CharArray.Length-1);
            testRecursion.reverseString(test2CharArray, 0, test2CharArray.Length - 1);

            // Assert

            Assert.AreEqual(test1Reverse, new string(test1CharArray));
            Assert.AreEqual(test2Reverse, new string(test2CharArray));
        }
    }
}