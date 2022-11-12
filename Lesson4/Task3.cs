// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Task3
    {
        public static void RunTask()
        {
            PrintArray(CreateArr());
        }

        private static int[] CreateArr(int len = 8, int startPointBorder = 0, int endPointBorder = 50)
        {
            int[] arr = new int[len];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(startPointBorder, endPointBorder);
            }

            return arr;
        }

        private static void PrintArray(int[] arr)
        {
            string msg = $"[{arr[0]}";
            for (int i = 1; i < arr.Length; i++)
            {
                msg += $", {arr[i]}";
            }
            msg += "]";

            System.Console.WriteLine(msg);
        }
    }
}