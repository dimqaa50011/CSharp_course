using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson8
{

    // Задайте прямоугольный двумерный массив. 
    // Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:
    // 1 строка
    public class Task2
    {
        private static int MinSum = 0;
        private static int Count = 0;
        private static int LineWithMinSum;
        public static void RunTask()
        {
            int[,] matrix = Helper.CreateIntMatrix(3, 3);
            Helper.FillMatrix(matrix);
            Helper.PrintMatrix(matrix);
            SumCalculationProcess(matrix);
            System.Console.WriteLine($"строка {LineWithMinSum}");
        }
        private static void SumCalculationProcess(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                MinSum = Count;
                Count = GetMinSum(i, matrix);
                if (Count < MinSum) LineWithMinSum = i;
            }
        }
        private static int GetMinSum(int j, int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
                count += matrix[j, i];

            return count;
        }

    }
}
