using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

namespace Final
{
    public class Task3
    {
        public static void Run()
        {
            int n = Helper.InputArg("Введите первое число");
            int m = Helper.InputArg("Введите второе число");
            System.Console.WriteLine($"n = {m}; m = {m} -> A(n,m) = {Akkerman(n, m)}");
        }

        private static int Akkerman(int n, int m)
        {
            if(n == 0)
                return m + 1;
            else if (m == 0)
                return Akkerman(n - 1, 1);
            return Akkerman(n - 1, Akkerman(n, m - 1));
        }
    }
}