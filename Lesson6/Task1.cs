using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

namespace Lesson6
{
    public class Task1 : Task
    {
        public override void RunTask()
        {
            Depends.Requisition("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
            System.Console.WriteLine("Сейчас вам будет предложено ввести несколько чилел.\nЧтобы закончить вводить напишите букву 'q'.");
            System.Console.WriteLine("Чтобы продолжить нажмите Enter");
            System.Console.ReadKey();

            int result = CountPositiveNumbers();
            System.Console.WriteLine($"Результат: {result} положительных числа");
        }
        private static int CountPositiveNumbers()
        {
            int countPositive = 0;
            while (true)
            {
                System.Console.Write("Введите целое число: ");
                bool parsed = TryParesDigit(Console.ReadLine(), out int digit);

                if (parsed) 
                {
                    if (digit > 0) countPositive++;
                }
                else break;
            }
            return countPositive;
        }
        private static bool TryParesDigit(string answer, out int digit)
        {
            digit = -0;
            if (answer == "q") return false;
            try
            {
                digit = int.Parse(answer);
                return true;
            }
            catch (FormatException ex)
            {
                System.Console.WriteLine($"Неверный формат данных. Вводите только вещественные числа. Вы ввели: {answer}");
                return true;
            }
        }

    }
}