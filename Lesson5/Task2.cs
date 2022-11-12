// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Task2
    {
        public static void RunTask()
        {
            int[] numbers = Depends.CreateArray(startPointBorder:-10, endPointBorder:50, len:5);
            Depends.PrintArray(numbers);
            System.Console.WriteLine($"Сумма элементов на нечетных позицыях = {SumOddPointElements(numbers)}");

        }

        private static int SumOddPointElements(int[] arr)
        {
            int sumOddPointElements = 0;
            for (int i = 1; i < arr.Length; i+=2)
            {
                sumOddPointElements += arr[i];
            }
            return sumOddPointElements;
        }
    }
}