namespace ch8_27
{

    public class Sieve
    {
        bool[] primes; //array of primes 
        public Sieve(int s)
        {
            primes = new bool[s];
        }

        public bool[] SE()
        {
            //initialize all array values to true
            for (int index = 0; index < primes.Length; index++)
                primes[index] = true;
            for (int i = 2; i < primes.Length; i++)
                if (primes[i])
                {
                    for (int j = i + i; j < primes.Length; j += i)
                        primes[j] = false;
                }
            return primes;
        }
    }
}