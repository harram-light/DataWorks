using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTasksLibrary;

namespace UnitTest
{
    [TestClass]
    public class Task_0
    {

        [TestMethod]
        public void Test_on_null_input()
        {
            Assert.AreEqual(-1, RomanNum.RomanToArabic(""));
        }

        [TestMethod]
        public void Test_on_4_in_row()
        {
            Assert.AreEqual(-2, RomanNum.RomanToArabic("VIIII"));
        }

        [TestMethod]
        public void Test_on_overflow()
        {
            Assert.AreEqual(-3, RomanNum.RomanToArabic("MMMI"));
        }

        [TestMethod]
        public void Test_on_incorrect_value()
        {
            Assert.AreEqual(-4, RomanNum.RomanToArabic("CVCCXAS-1"));
        }

    }
}
