using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

namespace Lesson5
{
    public class Task3
    {
        public static void RunTask()
        {
            double[] realNumbers = Depends.CreateDoubleArry(endPointBorder:25);
            Depends.PrintArray(realNumbers);
            System.Console.WriteLine($"Разница между максимальным и миниматльным элеменом = {DifferenceNumbers(realNumbers)}");

        }

        private static double DifferenceNumbers(double[] arr)
        {
            double minNumber = arr[0];
            double maxNumber = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxNumber) maxNumber = arr[i];
                if (arr[i] < minNumber) minNumber = arr[i];
            }

            return Math.Round(maxNumber - minNumber, 2);

        }
    }
}