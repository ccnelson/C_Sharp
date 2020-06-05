using System;
using System.Collections.Generic;
using System.Linq;

namespace Scratchname
{
    class Scratch
    {
        static void Main(string[] args)
        {
            int[] vals = Enumerable.Range(1, 999).ToArray(); // array comprehension
            int total = 0;

            var lq = from v in vals  // actual linq query
                     where (v % 3 == 0) || (v % 5 == 0)
                     select v;

            foreach (var sv in lq) // use the linq object
            {
                total += sv;
            };

            Console.WriteLine("Answer: {0}", total);
        }
    }
}
