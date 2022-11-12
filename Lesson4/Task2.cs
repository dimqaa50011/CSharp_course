//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Task2
    {
        public static void RunTask()
        {
            int num = Halper.InputArg("Введите число");
            int res = SuNumbers(num);
            System.Console.WriteLine($"Сумма цыфр в числе = {res}");
        }

        private static int SuNumbers(int digit)
        {
            int result = 0;
            while (digit > 0)
            {
                result += digit % 10;
                digit /= 10;
            }

            return result;
        }
    }
}