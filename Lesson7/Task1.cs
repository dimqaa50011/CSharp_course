using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

namespace Lesson7
{
    public class Task1
    {
        public static void RunTask()
        {
            double[,] matrix = CreateMatrix(lines: 5, columns: 4);
            PrintMatrix(matrix);
        }   

        static double[,] CreateMatrix(int lines = 3, int columns = 3, int minBorder = 0, int maxBorder = 20)
        {
            double[,] matrix = new double[lines, columns];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    double element =new Random().Next(minBorder, maxBorder) + new Random().NextDouble(); 
                    matrix[i,j] = Math.Round(element, 2);
                }
            }

            return matrix;
        } 

        static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    System.Console.Write($"{matrix[i,j]}\t");
                }
                System.Console.WriteLine();
            }
        }
    }
    
}