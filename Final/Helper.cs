using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final
{
    public class Helper
    {
        public static int InputArg(string msg)
        {
            System.Console.Write(msg + ": ");
            return int.Parse(Console.ReadLine());
        }
    }
}