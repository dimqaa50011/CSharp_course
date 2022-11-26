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
            int[,] matrix = CreateIntMatrix();
            FillMatrix(matrix);
            PrintMatrix(matrix);
            SortMatrix(matrix);
            System.Console.WriteLine();
            PrintMatrix(matrix);
        }

        static int[,] CreateIntMatrix(int lines = 5, int columns = 5)
        {
            return new int[lines, columns];
        }

        static void FillMatrix(int[,] matrix, int minBorder = 0, int maxBorder = 20)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = new Random().Next(minBorder, maxBorder);
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    System.Console.Write($"{matrix[i, j]}\t");
                }
                System.Console.WriteLine();
            }
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