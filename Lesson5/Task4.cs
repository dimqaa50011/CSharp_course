using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// При помощи рекурсии вывести последовательность чисел, с заданым количеством этих чисел по принципу:
// Ввожу => 12
// 1 2 2 3 3 3 4 4 4 4 5 5

namespace Lesson5
{
    public class Task4
    {
        public static void RunTask()
        {
            int userLength = Depends.InputArg("Введите длину последоветельности");
            System.Console.WriteLine(PrintSubsiquence(userLength, 1 , String.Empty));
        }

        private static string PrintSubsiquence(int lengthSubsiuqence, int counter, string msg)
        {   
            for (int i = 0; i < counter; i++)
            {
                if (lengthSubsiuqence == 0) return msg;
                msg += $"{counter}";
                lengthSubsiuqence--;
            }
            return PrintSubsiquence(lengthSubsiuqence, counter + 1, msg);
        }
    }
}