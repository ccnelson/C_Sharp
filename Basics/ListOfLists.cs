
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace listoflists
{
    class ListOfLists
    {
        static Boolean IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if ((n & 1) != 1) return false; // bitwise
            int boundary = (int)Math.Floor(Math.Sqrt(n));
            for (int i = 3; i <= boundary; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        // function to return a list
        static List<int> PrimeFactors(int n, List<int> primeList)
        {
            int primeIndex = 0;
            List<int> factorList = new List<int>();
            while (n > 1)
            {
                if ( n % primeList[primeIndex] == 0 )
                {
                    factorList.Add(primeList[primeIndex]);
                    n = n / primeList[primeIndex];
                }
                else
                {
                    primeIndex += 1;
                }
            }
            return factorList;
        }
        

        static void Main()
        {
            int limit = 20;
            List<int> primes = new List<int>();
            for (int i = 0; i <= limit; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            // list of lists
            List<List<int>> primeFactorList = new List<List<int>>();
            for (int i = 0; i <= limit; i++)
            {
                // each element added to primeFactorList is a list itself
                primeFactorList.Add(PrimeFactors(i, primes));
            }

            // To iterate over it.
            int counter = 0;
            foreach (List<int> subList in primeFactorList)
            {
                Console.Write("Number: {0} has prime factors: ", counter); 
                foreach (int item in subList)
                {
                    Console.Write(" {0},", item);
                }
                Console.WriteLine();
                counter += 1;
            }

            
        }
    }
}
