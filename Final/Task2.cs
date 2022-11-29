using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

namespace Final
{
    public class Task2
    {
        public static int EndBorder { get; private set; }
        public static void Run()
        {
            int startBorder = Helper.InputArg("Введите первое число");
            EndBorder = Helper.InputArg("Введите второе число");
            System.Console.WriteLine($"M = {startBorder}; N = {EndBorder} -> {GetSumAllElements(startBorder)}");
        }
        private static int GetSumAllElements(int start)
        {
            if (start > EndBorder)
            return 0;
            return start + GetSumAllElements(start + 1);
        }     
    }
}