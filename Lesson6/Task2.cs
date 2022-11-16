using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

namespace Lesson6
{
    public class Task2 : Task
    {
        public override void RunTask()
        {
            Depends.Requisition("Напишите программу, которая найдёт точку пересечения двух прямых,\nзаданных уравнениями y = k1 * x + b1, y = k2 * x + b2;\nзначения b1, k1, b2 и k2 задаются пользователем.");
            double k1 = Depends.InputDoubleArg("Введите k1");
            double b1 = Depends.InputDoubleArg("Введите b1");
            double k2 = Depends.InputDoubleArg("Введите k2");
            double b2 = Depends.InputDoubleArg("Введите b2");

            IntersectionLine(k1, b1, k2, b2);
        }
        // k1 * x + b1 = k2 * x + b2
        // k1 * x - k2 * x = b2 - b1
        // x(k1 - k2) = b2 - b1
        // x = (b2 - b1) / (k1 - k2)
        private static double[] IntersectionLine(double k1, double b1, double k2, double b2)
        {
            double[] unionPoint = new double[2];
            unionPoint[0] = (b2 - b1) / (k1 - k2);
            unionPoint[1] = k1 * unionPoint[0] + b1;
            return unionPoint;
        }
    }
}