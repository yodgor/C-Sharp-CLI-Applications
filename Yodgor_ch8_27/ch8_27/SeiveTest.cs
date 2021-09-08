using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch8_27
{
    class SieveTest
    {
        public static void Main()
        {
            int count = 0; // the number of primes found

            int SIZE = 2000;
            bool[] primes = new bool[SIZE]; // array of primes

            Sieve s = new Sieve(SIZE);

            primes = s.SE();

            // cycle through the array one last time to display all primes
            for (int index = 2; index < primes.Length; index++)
                if (primes[index])
                {
                    Console.WriteLine($"{index} is prime.");
                    ++count;
                } // end if

            Console.WriteLine($"\n{count} primes found.");
        } // end Main
    } // end class SieveTest
}
