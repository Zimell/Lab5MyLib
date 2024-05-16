using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab5MyLib;

namespace Lab5MyLibTests
{
    [TestClass]
    public class Lab5Tests
    {
        [TestMethod]
        public void Task1_Enter_RandomMatrix_Minus1_to_5_Replace_Minus2_with_30()
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
        public void Task1_Enter_RandomMatrix_Minus4_to_4_Replace_Minus2_with_30()
        {
            int[,] m = new int[,]
            {
                { 0,3,-3,-3,-1, -2 ,3,0 },
                { 3,3,3,2,0,-1,3,2 },
                { 0,0,2, -2 , -2 ,-1,1,4 },
                { 3,3,-1,1,-3,1,-4,-3 },
                { 0,3,-1,0,3,-3,1,3 },
                { -3,2,1,4,2,3,-1,1 },
                { 1,1,3,-1,-1,3,3,0 }
            };
            int[,] expected =
            {
                { 0,3,-3,-3,-1, 30 ,3,0 },
                { 3,3,3,2,0,-1,3,2 },
                { 0,0,2, 30 , 30 ,-1,1,4 },
                { 3,3,-1,1,-3,1,-4,-3 },
                { 0,3,-1,0,3,-3,1,3 },
                { -3,2,1,4,2,3,-1,1 },
                { 1,1,3,-1,-1,3,3,0 }
            };
            int[,] actual = Variant12.Task1(m);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task1_Enter_RandomMatrix_Minus3_to_3_Replace_Minus2_with_30()
        {
            int[,] m = new int[,]
            {
                { -1,-3,1,-2,1,2,0,-1 },
                { -1,2,1,-3,3,-1,-3,-2 },
                { 0,2,1,-1,-2,2,-2,2 },
                { 0,2,1,3,-1,2,1,1 },
                { -1,-1,3,-1,1,-2,1,1 },
                { -3,0,-1,-1,1,1,0,2 },
                { -3,0,1,3,2,-1,-1,2 }
            };
            int[,] expected =
            {
                { -1,-3,1, 30 ,1,2,0,-1 },
                { -1,2,1,-3,3,-1,-3, 30 },
                { 0,2,1,-1, 30 ,2, 30 ,2 },
                { 0,2,1,3,-1,2,1,1 },
                { -1,-1,3,-1,1, 30 ,1,1 },
                { -3,0,-1,-1,1,1,0,2 },
                { -3,0,1,3,2,-1,-1,2 }
            };
            int[,] actual = Variant12.Task1(m);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task1_Enter_RandomMatrix_Minus2_to_2_Replace_Minus2_with_30n()
        {
            int[,] m = new int[,]
            {
                { 1,1,-1,-1,1,1,0,2 },
                { 1,1,1,2,-2,-1,2,-2 },
                { 0,0,1,-2,0,2,0,-1 },
                { 1,-1,0,-1,-1,1,0,2 },
                { 2,0,0,2,2,1,1,0 },
                { 0,-1,1,2,2,-1,2,1 },
                { 0,1,-1,1,-1,0,-2,2 }
            };
            int[,] expected =
            {
                { 1,1,-1,-1,1,1,0,2 },
                { 1,1,1,2, 30 ,-1,2, 30 },
                { 0,0,1, 30 ,0,2,0,-1 },
                { 1,-1,0,-1,-1,1,0,2 },
                { 2,0,0,2,2,1,1,0 },
                { 0,-1,1,2,2,-1,2,1 },
                { 0,1,-1,1,-1,0, 30 ,2 }
                };
            int[,] actual = Variant12.Task1(m);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task1_Enter_RandomMatrix_Minus5_to_5_Return()
        {
            int[,] m = new int[,]
            {
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 }
            };
            int[,] expected =
            {
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 }
                };
            int[,] actual = Variant12.Task1(m);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task2_Enter_RandomMatrix_Minus1_to_5_Return_1()
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
        public void Task2_Enter_RandomMatrix_Minus1_to_Minus56_Return_8()
        {
            int[,] m = new int[,]
            {
                { -51,-4,-3,-17,-21,-54,-43,-51 },
                { -4,-13,-19,-3,-33,-56,-40,-55 },
                { -47,-22,-6,-36,3,-12,-42,-20 },
                { -12,-50,-28,-42,-17,-25,-34,-2 },
                { -9,-31,-50,-32,6,-31,-30,-2 },
                { -36,-55,-5,3,4,-1,-32,-38 },
                { -48,-47,7,1,-28,-55,-28,-42 }
            };
            int expected = 7;
            int actual = Variant12.Task2(m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task2_Enter_RandomMatrix_Minus5_to_10_Return_2()
        {
            int[,] m = new int[,]
            {
                { 8,8,7,4,-3,3,7,7 },
                { 1,-1,4,-4,7,8,7,-4 },
                { 3,-1,-5,9,-2,-4,4,6 },
                { -4,6,-2,-2,-3,8,-3,5 },
                { 3,6,7,10,-2,0,8,-4 },
                { 8,3,-1,-1,-4,6,3,10 },
                { 7,-1,1,-4,2,3,4,9 }
            };
            int expected = 2;
            int actual = Variant12.Task2(m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task2_Enter_RandomMatrix_Minus50_to_10_Return_5()
        {
            int[,] m = new int[,]
            {
                { -28,-6,9,5,-44,-39,-21,-33 },
                { 0,8,-40,-43,-19,-23,-6,-3},
                {7,-35,-37,-27,3,-18,-4,-37},
                {-48,-16,-31,-38,-2,-38,-37,-46},
                { -8,5,-3,-13,-36,-38,3,3},
                { -39,-48,-49,8,-6,-46,-39,8},
                { -4,-30,9,-41,-21,-45,-27,-41}
            };
            int expected = 5;
            int actual = Variant12.Task2(m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task2_Enter_RandomMatrix_0_Return_0()
        {
            int[,] m = new int[,]
            {
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 }
            };
            int expected = 0;
            int actual = Variant12.Task2(m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task3_Enter_RandomMatrix_Minus2_to_5_Return_5_4_6_4_7_4()
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
        public void Task3_Enter_RandomMatrix_Minus2_to_2_Return_5_5_2_3_4_6_3()
        {
            int[,] m = new int[,]
            {
                { 1,1,-1,-1,1,1,0,2 },
                { 1,1,1,2,-2,-1,2,-2 },
                { 0,0,1,-2,0,2,0,-1 },
                { 1,-1,0,-1,-1,1,0,2 },
                { 2,0,0,2,2,1,-1,0 },
                { 2,-1,1,2,2,-1,2,1 },
                { 0,1,-1,1,-1,0,-2,2 }
            };
            int[] expected = new int[] { 5, 5, 2, 3, 4, 6, 3};
            int[] actual = Variant12.Task3(m);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task3_Enter_RandomMatrix_Minus10_to_10_Return_5_4_4_6_4_0_7()
        {
            int[,] m = new int[,]
            {
                { -1,-4,2,4,3,5,-5,1 },
                { 3,6,-6,-3,8,-8,3,-8 },
                { 3,3,-8,8,-1,-9,9,0 },
                { 5,5,-3,8,0,4,1,6 },
                { 1,-5,-4,9,2,-1,3,-9 },
                { -7,-9,-2,-1,-8,-4,-8,-4 },
                { 3,5,7,6,6,6,0,5 },
            };
            int[] expected = new int[] { 5, 4, 4, 6, 4, 0, 7};
            int[] actual = Variant12.Task3(m);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task3_Enter_RandomMatrix_Minus100_to_100_Return_5_3_3_5_5_2_6()
        {
            int[,] m = new int[,]
            {
                { -22,40,-84,77,-80,25,66,36 },
                { 9,67,-54,-3,-94,48,-12,-42 },
                { -25,-40,29,-92,-5,79,-89,47 },
                { 52,-73,-41,-96,16,9,87,15 },
                { 25,48,14,8,-32,-14,-14,77 },
                { 95,74,-36,-91,-11,-8,-37,-26 },
                { 26,39,100,-82,14,92,57,-30 }
            };
            int[] expected = new int[] { 5, 3, 3, 5, 5, 2, 6};
            int[] actual = Variant12.Task3(m);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task3_Enter_RandomMatrix_0_Return_0_0_0_0_0_0_0_()
        {
            int[,] m = new int[,]
            {
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 }
            };
            int[] expected = new int[] {0,0,0,0,0,0,0};
            int[] actual = Variant12.Task3(m);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task4_Enter_RandomMatrix_Minus1_to_4_Return_Minus1_2_1_Minus2_2_Minus2_4_2_3_()
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
        [TestMethod]
        public void Task4_Enter_RandomMatrix_0_to_10_Return_1_2_3_2_3_1_0_2_()
        {
            int[,] m = new int[,]
            {
                { 7,1,8,2 },
                { 8,3,2,9 },
                { 3,1,6,0 },
                { 2,8,7,10 }
            };
            int[] expected = new int[] { 1, 2, 3, 2, 3, 1, 0, 2 };
            int[] actual = Variant12.Task4(m);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task4_Enter_RandomMatrix_1_to_11_Return_1_3_3_3_3_5_2_5_1_4_5_5_3_1_3_5_4_4_3_2_2_3_()
        {
            int[,] m = new int[,]
            {
                { 10,6,8,1,9,7,3,8 },
                { 3,6,10,10,9,3,11,6 },
                { 9,3,8,5,2,10,7,11 },
                { 11,11,11,8,5,8,1,8 },
                { 9,11,4,6,5,5,8,3 },
                { 1,3,5,4,8,4,3,6 },
                { 2,2,5,3,7,9,9,7 }
            };
            int[] expected = new int[] { 1,3,3,3,3,5,2,5,1,4,5,5,3,1,3,5,4,4,3,2,2,5,3 };
            int[] actual = Variant12.Task4(m);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task4_Enter_RandomMatrix_3_to_9_Return_3_4_4_4_4_3_4_5_5_5_4_5_4_4_4_()
        {
            int[,] m = new int[,]
            {
                { 6,6,7,3,4,9 },
                { 4,4,7,4,3,4 },
                { 5,5,7,7,7,5 },
                { 4,6,9,6,8,6 },
                { 8,9,5,4,5,4 },
                { 9,4,9,7,4,9 }
            };
            int[] expected = new int[] { 3,4,4,4,4,3,4,5,5,5,4,5,4,5,4,4,4 };
            int[] actual = Variant12.Task4(m);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task4_Enter_RandomMatrix_0_Return_0()
        {
            int[,] m = new int[,]
            {
                { 0 },
            };
            int[] expected = new int[] { 0 };
            int[] actual = Variant12.Task4(m);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
