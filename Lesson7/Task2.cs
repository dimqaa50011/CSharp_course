using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

namespace Lesson7
{
    public class Task2
    {
        public static void RunTask()
        {
            int[,] matrix = CreateIntMatrix();
            PrintMatrix(matrix);
            int pointLine = InputArg("Введите номер строки");
            int pointColumn = InputArg("Введите номер столбца");
            PrintResult(matrix, pointLine, pointColumn);
        }
        static void PrintResult(int[,] matrix, int pointLine, int pointColumn)
        {
            string response = String.Empty;
            bool parsed = TryGetElement(matrix, pointLine, pointColumn, out int element);
            if (parsed) response = $"По заданным позицыям найден элемент: {element}";
            else response = "Tакого числа в массиве нет";
            System.Console.WriteLine(response);
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
        static bool TryGetElement(int[,] matrix, int line, int column, out int element)
        {
            element = 0;
            try
            {
                element = matrix[line, column];
                return true;
            }
            catch (System.IndexOutOfRangeException)
            {
                return false;
            }
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

        static int InputArg(string msg)
        {
            System.Console.Write(msg + ": ");
            bool parsed = int.TryParse(Console.ReadLine(), out int result);
            if (parsed) return result;
            System.Console.WriteLine("Недопустимый формат данных. Используйте только целый числа");
            return -1;
        }
    }
}