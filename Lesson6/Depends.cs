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
    }
}