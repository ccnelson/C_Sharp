using System;
using System.Collections.Generic;
using System.Linq;

namespace Scratchname
{
    class Scratch
    {
        static void Main(string[] args)
        {
            Int32 vals = Enumerable.Range(1, 999).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
            Console.WriteLine("Answer: {0}", vals);
        }
    }
}