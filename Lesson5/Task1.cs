//  Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Task1
    {
        public static void RunTask()
        {
            int[] numArr = Depends.CreateArray(startPointBorder: 100);
            Depends.PrintArray(numArr);
            int evenNumbers = GetEvenNumbers(numArr);
            System.Console.WriteLine($"Количество четных чисиел в массиве = {evenNumbers}");
        }

        private static int GetEvenNumbers(int[] arr)
        {
            int counter = 0;
            foreach (var item in arr)
            {
                if (item % 2 == 0) counter++;
            }
            return counter;
        }
    }
}