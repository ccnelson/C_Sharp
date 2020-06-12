

using System;
using System.Collections.Generic;

namespace prime_Factorsname
{
    class Prime_Factors
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

        // return list of prime factors of n, from list of primes supplied
        static List<int> PrimeFactors(int n, List<int> primeList)
        {
            int primeIndex = 0; // track which prime
            List<int> factorList = new List<int>(); // list to store factors
            while (n > 1)
            {
                if ( n % primeList[primeIndex] == 0 ) // if number divides evenly into prime
                {
                    factorList.Add(primeList[primeIndex]); // add prime to list
                    n = n / primeList[primeIndex]; // divide and continue
                }
                else { primeIndex += 1; } // if doesnt divide evenly increment prime being used
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

            List<List<int>> primeFactorList = new List<List<int>>();
            for (int i = 0; i <= limit; i++)
            {
                // each element added to primeFactorList is a list itself
                primeFactorList.Add(PrimeFactors(i, primes));
            }

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
