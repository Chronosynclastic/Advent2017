using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day2.Tests
{
    [TestClass]
    public class ACTests
    {
        /* 5 1 9 5
           7 5 3
           2 4 6 8

           The first row's largest and smallest values are 9 and 1, and their difference is 8.
           The second row's largest and smallest values are 7 and 3, and their difference is 4.
           The third row's difference is 6.*/


        [TestMethod]
        public void AC1_1()
        {
            var inputString = "5 1 9 5";

            int checksum = -1;

            Assert.AreEqual(8, checksum);
        }
    }
}
