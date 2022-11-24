using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

namespace Lesson7
{
    public class Task3
    {
        public static void RunTask()
        {
            int[,] matrix = CreateIntMatrix(lines: 5, columns: 7);
            PrintMatrix(matrix);
            PrintArr(GetAvarageArr(matrix));
        }
        static int[,] CreateIntMatrix(int lines = 3, int columns = 3, int minBorder = 0, int maxBorder = 20)
        {
            int[,] matrix = new int[lines, columns];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = new Random().Next(minBorder, maxBorder);
                }
            }
            return matrix;
        }
        static void PrintMatrix(int[,] matrix)
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
        static double Avagare(int[] arr)
        {
            double sum = 0;
            foreach (var item in arr) sum += item;
            return sum / arr.Length;
        }
        static double[] GetAvarageArr(int[,] matrix)
        {
            double[] avarageArr = new double[matrix.GetLength(1)];
            int[] tempArr = new int[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    tempArr[j] = matrix[j,i];
                }
                avarageArr[i] = Avagare(tempArr);
            }
            return avarageArr;
        }
        static void PrintArr(double[] arr)
        {
            foreach (var item in arr) System.Console.Write($"{item} ");
            System.Console.WriteLine();
            
        }
    }
}