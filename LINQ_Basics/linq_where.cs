using System;
using System.Collections.Generic;
using System.Linq;

namespace Scratchname
{
    class Scratch
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // below shows 'x =>' designated as iterator
            var biggerThanThree = numbers.Where(x => x > 3); // 1st result: filters > 3
            // below show using 'y' as iterator instead
            var smallerThanSeven = biggerThanThree.Where(y => y < 7); // 2nd result: filters 1st < 7
            // next, iterate thru generated enumerators
            foreach (var b in biggerThanThree) { Console.Write("{0}, ", b); };
            Console.WriteLine(""); // just a newline
            foreach (var s in smallerThanSeven) { Console.Write("{0}, ", s); };
        }
    }
}
