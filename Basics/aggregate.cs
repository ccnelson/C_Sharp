using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Scratchname
{
    class Scratch
    {
        static void Main()
        {
            Console.WriteLine(GCD(new[] { 1605, 4200, 10235 }));
        }

        static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        static int GCD(int[] integerSet) // overloaded method
        {
            return integerSet.Aggregate(GCD); // similar to pythons reduce function
        }
    }
}
