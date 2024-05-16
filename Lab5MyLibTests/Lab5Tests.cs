using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab5MyLib;

namespace Lab5MyLibTests
{
    [TestClass]
    public class Lab5Tests
    {
        [TestMethod]
        public void Task1_Enter_RandomMatrix_Minus2_to_5_Return()
        {
            int[,] m = new int[,]
            {
                { 1, 2, 1, 1, 5, -2, 1, 1 },
                { 2, 2, -2, 3, 1, 1, 1, 1, },
                { 4, 2, 3, 4, 5, -1, 2, -3 },
                { 1, 2, 3, 4, 5, 1, 5, 2 },
                { 1, 5, 5, 2, 2, 2, 5, 4},
                { 1, 1, 5, 4, 1, 1, 1, 1 },
                { -1, 3, 5, 1, 1, 4, 4, 4 }
            };
            int[,] expected =
            {
                { 1, 2, 1, 1, 5, 30, 1, 1 },
                { 2, 2, 30, 3, 1, 1, 1, 1, },
                { 4, 2, 3, 4, 5, -1, 2, -3 },
                { 1, 2, 3, 4, 5, 1, 5, 2 },
                { 1, 5, 5, 2, 2, 2, 5, 4},
                { 1, 1, 5, 4, 1, 1, 1, 1 },
                { -1, 3, 5, 1, 1, 4, 4, 4 }
                };
            int[,] actual = Variant12.Task1(m);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task2_Enter_RandomMatrix_Minus2_to_5_Return()
        {
            int[,] m = new int[,]
            {
                { 1, 2, 1, 1, 5, -2, 1, 1 },
                { 2, 2, -2, 3, 1, 1, 1, 1, },
                { 4, 2, 3, 4, 5, -1, 2, -3 },
                { 1, 2, 3, 4, 5, 1, 5, 2 },
                { 1, 5, 5, 2, 2, 2, 5, 4},
                { 1, 1, 5, 4, 1, 1, 1, 1 },
                { -1, 3, 5, 1, 1, 4, 4, 4 }
            };
            int expected = 1;
            int actual = Variant12.Task2(m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task3_Enter_RandomMatrix_Minus2_to_5_Return()
        {
            int[,] m = new int[,]
            {
                { -1, 2, 1, 1, 5, -2, 1 },
                { -2, 2, -2, 3, 1, -1, 1 },
                { 4, 2, 3, 4, 5, -1, 2 },
                { -1, -2, 3, 4, 5, -1, 5 },
                { 1, 5, 5, 2, 2, 2, 5},
                { 1, -1, 5, 4, -1, 1, -1 },
            };
            int[] expected = new int[] { 5, 4, 6, 4, 7, 4 };
            int[] actual = Variant12.Task3(m);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task4_Enter_RandomMatrix_Minus2_to_5_Return()
        {
            int[,] m = new int[,]
            {
                { -1, 2, 1 },
                { -2, 2, -2 },
                { 4, 2, 3}
            };
            int[] expected = new int[] {-1,2,1,-2,2,-2,4,2,3 };
            int[] actual = Variant12.Task4(m);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
