using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson8
{
    public class Task3
    {
        public static void RunTask()
        {
            int[,] matrixA = Helper.GetFillMatrix(lines: 2, columns: 2, maxBorder: 10);
            int[,] matrixB = Helper.GetFillMatrix(lines: 2, columns: 3, maxBorder: 10);

            int[,] matrixC = MuliMatrix(matrixA, matrixB);

            Helper.PrintMatrix(matrixA);
            Helper.PrintMatrix(matrixB);
            Helper.PrintMatrix(matrixC);
        }

        private static int[,] MuliMatrix(int[,] matrixA, int[,] matrixB)
        {
            int[,] matrixC = Helper.CreateIntMatrix(matrixB.GetLength(0), matrixB.GetLength(1));
            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                for (int j = 0; j < matrixC.GetLength(1); j++)
                {
                    int count = 0;
                    for (int k = 0; k < matrixA.GetLength(0); k++)
                        count += matrixA[i, k] * matrixB[k, j];
                    matrixC[i, j] = count;
                }
            }

            return matrixC;
        }
        private static bool MatrixValidator(int[,] matrixA, int[,] matrixB)
        {
            return matrixA.GetLength(0) == matrixB.GetLength(1);
        }

    }
}