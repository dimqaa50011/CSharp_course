using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// (*) Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов.
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов.
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

namespace Lesson6
{
    public class Task3
    {
        public static void RunTask()
        {
            int[,] matrix = CreateMatrix();
            FillMatrix(matrix);
            PrintMatrix(matrix);
            System.Console.WriteLine();
            
            int sumMax = SumMaxInMatrix(matrix);
            int sumMin = SumMinInMatrix(matrix);

            System.Console.WriteLine($"Сумма максимумов = {sumMax};\nСумма минимумов = {sumMin};");
            System.Console.WriteLine($"Результат: {sumMax - sumMin}");
        }
        private static int[,] CreateMatrix(int lines = 5, int columns = 5)
        {
            return new int[lines, columns];
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    System.Console.Write($"{matrix[i,j]} ");
                }
                System.Console.WriteLine();
            }
        }
        private static void FillMatrix(int[,] matrix, int minBorder = 0, int maxBorder = 10)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = new Random().Next(minBorder, maxBorder);
                }
            }
        }
        private static int SumMaxInMatrix(int[,] matrix)
        {
            return SumExtermeElemetns(matrix);
        }
        private static int SumMinInMatrix(int[,] matrix)
        {
            int[,] transposedMatix = TransposingMatrix(matrix);
            return SumExtermeElemetns(transposedMatix, max: false);
        }
        private static int SumExtermeElemetns(int[,] matrix, bool max = true)
        {
            int sumExterme = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int extermeElement = matrix[i,0];
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (max) {if (matrix[i,j] > extermeElement) extermeElement = matrix[i,j];}
                    else {if (matrix[i,j] < extermeElement) extermeElement = matrix[i,j];}
                }
                sumExterme += extermeElement;
            } 
            return sumExterme;
        }
        private static int[,] TransposingMatrix(int[,] matrix)
        {
            int[,] transposedMatix = CreateMatrix(matrix.GetLength(0), matrix.GetLength(1));
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    transposedMatix[j,i] = matrix[i,j];
                }
            }
            return transposedMatix;
        }
    }
}