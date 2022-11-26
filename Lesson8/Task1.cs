using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson8
{
    public class Task1
    {
        public static void RunTask()
        {
            int[,] matrix = Helper.CreateIntMatrix();
            Helper.FillMatrix(matrix);
            Helper.PrintMatrix(matrix);
            SortMatrix(matrix);
            System.Console.WriteLine();
            Helper.PrintMatrix(matrix);
        }

        static void SortMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    for (int k = 0; k < matrix.GetLength(1) - 1; k++)
                    {
                        if (matrix[i, k] < matrix[i, k + 1])
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
                }
            }
        }

    }
}