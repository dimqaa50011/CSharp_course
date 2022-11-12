using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Depends
    {
        public static int[] CreateArray(int len = 10, int startPointBorder = 0, int endPointBorder = 999)
        {
            int[] arr = new int[len];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(startPointBorder, endPointBorder);
            }

            return arr;
        }

        public static void PrintArray(int[] arr)
        {
            string msg = String.Empty;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                msg += $"{arr[i]}, ";
            }
            msg += $"{arr[arr.Length - 1]}";

            System.Console.WriteLine(msg);
        }
    }
}