﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTasksLibrary;

namespace UnitTest
{
    [TestClass]
    public class Task_0 //1-е тестовое задание
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

    [TestClass]
    public class Task_1 //2-е тестовое задание
    {

        [TestMethod]
        public void Test_0()
        {
            Assert.AreEqual(true, BalancedBracket.Balanced("(lkjl(l)()KKK)"));
        }

        [TestMethod]
        public void Test_1()
        {
            Assert.AreEqual(false, BalancedBracket.Balanced(")(lkjl(l)()KKK)"));
        }

        [TestMethod]
        public void Test_2()
        {
            Assert.AreEqual(true, BalancedBracket.Balanced("((1+3)()(4+(3-5)))"));
        }

        [TestMethod]
        public void Test_3()
        {
            Assert.AreEqual(false, BalancedBracket.Balanced("((1+3)()(4+(3-5)))("));
        }

    }
}
