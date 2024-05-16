using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5MyLib
{
    public class Variant12
    {
        public static int[,] Task1(int[,] P)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (P[i, j] == -2)
                    {
                        P[i, j] = 30;
                    }
                }
            }
            return P;
        }
        public static int Task2(int[,] P)
        {
            int a = 0;
            for (int i = 0; i < 7; i++)
            {
                if (P[i, 7] < 0)
                {
                    a++;
                }
            }
            return a;
        }
        public static int[] Task3(int[,] P)
        {
            int[] T = new int[P.GetLength(0)];
            for (int i = 0; i < P.GetLength(0); i++)
            {
                int k = 0;
                for (int j = 0; j < P.GetLength(1); j++)
                {
                    if (P[i, j] > 0)
                    {
                        k++;
                    }
                }
                T[i] = k;
            }
            return T;
        }
        public static int[] Task4(int[,] P)
        {
            int Min = 0;
            for (int i = 0; i < P.GetLength(0); i++)
            {
                for (int j = 0; j < P.GetLength(1); j++)
                {
                    if (P[i, j] < 6)
                    {
                        Min++;
                    }
                }
            }
            int[] R = new int[Min];
            int count = 0;
            for (int i = 0; i < P.GetLength(0); i++)
            {
                for (int j = 0; j < P.GetLength(1); j++)
                {
                    if (P[i, j] < 6)
                    {
                        R[count] = P[i, j];
                        count++;
                    }
                }
            }
            return R;
        }
    }
}