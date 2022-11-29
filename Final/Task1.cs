using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

namespace Final
{
    public class Task1
    {
        public static int EndSeq { get; private set; }
        public static int StartSeq { get; private set; }
        public static void Run()
        {
            StartSeq = Helper.InputArg("Введите первоe число");
            EndSeq = Helper.InputArg("Введите второе число");
            GetEvenIntegers();
        }
        private static void GetEvenIntegers()
        {
            if (StartSeq > EndSeq)
            {
                System.Console.WriteLine();
                return;
            }
            if (StartSeq % 2 != 0)
                StartSeq += 1;
            System.Console.Write($"{StartSeq} ");
            StartSeq += 2;
            GetEvenIntegers();
        }
    }
}