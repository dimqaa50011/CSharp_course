using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson8
{
    public class Helper
    {
        public static int[,] CreateIntMatrix(int lines = 5, int columns = 5)
        {
            return new int[lines, columns];
        }

        public static void FillMatrix(int[,] matrix, int minBorder = 0, int maxBorder = 20)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = new Random().Next(minBorder, maxBorder);
                }
            }
        }

        public static void PrintMatrix(int[,] matrix)
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
    }
}