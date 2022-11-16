using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson6
{
    public class Depends
    {
        public static int InputArg(string msg)
        {
            System.Console.Write(msg + ": ");
            return int.Parse(Console.ReadLine());
        }
        public static double InputDoubleArg(string msg)
        {
            System.Console.Write(msg + ": ");
            return double.Parse(Console.ReadLine());
        }
        public static void Requisition(string msg)
        {
            System.Console.WriteLine("\nУсловие задачи:");
            System.Console.WriteLine(msg);
            System.Console.WriteLine();
        }
    }
}