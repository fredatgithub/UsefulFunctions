using System;
using System.Collections.Generic;

namespace ConsoleAppSieveEratosthenes
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Action<string> display = Console.WriteLine;
      int maxPrime = 2_000_000;
      //Console.SetWindowSize = 
      List<int> primes = GetPrimes(maxPrime);
      display($"Primes less than {maxPrime}:");
      display(string.Empty);
      display($"   {string.Join(" ", primes)}");
      display(string.Empty);
      display("Press any key to exit:");
      Console.ReadKey();
    }

    private static List<int> GetPrimes(int maxPrime)
    {
      Array values = Array.CreateInstance(typeof(int), new int[] { maxPrime - 1 }, new int[] { 2 });
      // Use Sieve of Eratosthenes to determine prime numbers.
      for (int ctr = values.GetLowerBound(0); ctr <= (int)Math.Ceiling(Math.Sqrt(values.GetUpperBound(0))); ctr++)
      {
        if ((int)values.GetValue(ctr) == 1)
        {
          continue;
        }

        for (int multiplier = ctr; multiplier <= maxPrime / 2; multiplier++)
        {
          if (ctr * multiplier <= maxPrime)
          {
            values.SetValue(1, ctr * multiplier);
          }
        }
      }

      List<int> primes = new List<int>();
      for (int ctr = values.GetLowerBound(0); ctr <= values.GetUpperBound(0); ctr++)
      {
        if ((int)values.GetValue(ctr) == 0)
        {
          primes.Add(ctr);
        }
      }

      return primes;
    }
  }
}
