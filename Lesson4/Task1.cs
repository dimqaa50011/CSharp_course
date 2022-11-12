// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Task1
    {
        static public void RunTask()
        {
            int num1 = Halper.InputArg("Введите число");
            int num2 = Halper.InputArg("Введите степень числа");

            int result = Exponent(num1, num2);
            System.Console.WriteLine(result);

        }

        private static int Exponent(int baseNumber, int exp)
        {
            int result = 1;
            for (int i = 0; i < exp; i++)
            {
                result *= baseNumber;
            }

            return result;
        }
    }
}