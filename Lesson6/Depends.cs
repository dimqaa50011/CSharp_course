using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson6
{
    public class Depends
    {
        public static double InputDoubleArg(string msg)
        {
            System.Console.Write(msg + ": ");
            double digit;
            while (true)
            {
                string? answer = Console.ReadLine();
                try
                {
                    digit = double.Parse(answer);
                    break;
                }
                catch (FormatException ex)
                {
                    System.Console.WriteLine($"Неверный формат данных. Вводите только вещественные числа. Вы ввели: {answer}");
                    System.Console.WriteLine("Попробуте снова.");
                    System.Console.Write(msg + ": ");
                }
            }
            return digit;
        }
        public static void Requisition(string msg)
        {
            System.Console.WriteLine("\nУсловие задачи:");
            System.Console.WriteLine(msg);
            System.Console.WriteLine();
        }
    }
}