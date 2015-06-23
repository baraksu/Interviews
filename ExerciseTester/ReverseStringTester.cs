using System;
using JobTester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExerciseTester
{
    [TestClass]
    public class ReverseStringTester
    {
        [TestMethod]
        public void Reverse_EmptyString_EmptyString()
        {
            ReverseString rs = new ReverseString();

            string reverse = rs.Reverse(" 01234");

            Assert.AreEqual(reverse, "43210 ");
        }
           [TestMethod]
        public void Reverse_Regular_ReverseString()
        {
            ReverseString rs = new ReverseString();

            string reverse = rs.Reverse(String.Empty);

            Assert.AreEqual(reverse, String.Empty);
        }
    }
}
