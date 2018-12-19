using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace FonctionsUtiles.Fred.Csharp
{
  public class FunctionsMath
  {
    public static long Factorial(long x)
    {
      if (x < 1 || x > long.MaxValue)
      {
        return 0;
      }

      long fact = 1;
      long i = 1;
      while (i <= x)
      {
        fact = fact * i;
        i++;
      }

      return fact;
    }

    public static BigInt Factorial(BigInt x)
    {
      if (x < 1)
      {
        return 0;
      }

      BigInt fact = 1;
      BigInt i = 1;
      while (i <= x)
      {
        fact = fact * i;
        i++;
      }

      return fact;
    }

    public static long Factorial(long x, long lowerBound)
    {
      if (x < 1 || x > long.MaxValue)
      {
        return 0;
      }

      long fact = 1;
      while (x >= 1 && x > lowerBound)
      {
        fact *= x;
        x--;
      }

      return fact;
    }

    public static ulong RecursiveFactorial(int number)
    {
      if (number < 1 || number > int.MaxValue)
      {
        return 0;
      }

      if (number == 1)
      {
        return 1;
      }

      return (ulong)number * RecursiveFactorial(number - 1);
    }

    public static long Sommielle(long endNumber)
    {
      long sommeIterative = 0;
      for (long i = 0; i <= endNumber; i++)
      {
        sommeIterative += i;
      }

      return sommeIterative;
    }

    public static long Sommielle(long startNumber, long endNumber)
    {
      long sommeIterative = 0;
      for (long i = startNumber; i <= endNumber; i++)
      {
        sommeIterative += i;
      }

      return sommeIterative;
    }

    public static long SommielleRecursive(long startNumber, long endNumber)
    {
      if (startNumber > endNumber)
      {
        return 0;
      }

      if (startNumber == endNumber)
      {
        return startNumber;
      }

      return startNumber + SommielleRecursive(startNumber + 1, endNumber);
    }

    public static int GenerateRandomNumberUsingCrypto(int min, int max)
    {
      if (max >= 255)
      {
        return 0;
      }
      int result;
      var crypto = new RNGCryptoServiceProvider();
      byte[] randomNumber = new byte[1];
      do
      {
        crypto.GetBytes(randomNumber);
        result = randomNumber[0];
      }
      while (result <= min || result >= max);

      return result;
    }

    public static ulong GenerateRandomBigNumbers(int min, int max)
    {
      if ((ulong)max >= ulong.MaxValue)
      {
        return 0;
      }

      ulong result = 0;
      do
      {
        ulong hundreds = (ulong)GenerateRandomNumberUsingCrypto(0, 9);
        ulong thousands = (ulong)GenerateRandomNumberUsingCrypto(0, 9);
        ulong tenOfThousands = (ulong)GenerateRandomNumberUsingCrypto(0, 9);
        ulong hundredOfThousands = (ulong)GenerateRandomNumberUsingCrypto(0, 9);
        ulong millions = (ulong)GenerateRandomNumberUsingCrypto(0, 9);
        ulong tenOfMillions = (ulong)GenerateRandomNumberUsingCrypto(0, 9);
        ulong hundredOfMillions = (ulong)GenerateRandomNumberUsingCrypto(0, 9);
        ulong billions = (ulong)GenerateRandomNumberUsingCrypto(0, 9);
        ulong tenOfBillions = (ulong)GenerateRandomNumberUsingCrypto(0, 9);
        ulong hundredOfBillions = (ulong)GenerateRandomNumberUsingCrypto(0, 9);
        ulong trillions = (ulong)GenerateRandomNumberUsingCrypto(0, 9);
        ulong tenOfTrillions = (ulong)GenerateRandomNumberUsingCrypto(0, 9);
        ulong hundredOfTrillions = (ulong)GenerateRandomNumberUsingCrypto(0, 9);
        ulong quintillions = (ulong)GenerateRandomNumberUsingCrypto(0, 9);
        result = hundreds * 100 + thousands * 1000 + tenOfThousands * 10000 + hundredOfThousands * 100000
                 + millions * 1000000 + tenOfMillions * 10000000 + hundredOfMillions * 100000000 + billions * 1
                 + tenOfBillions * 1 + hundredOfBillions * 1 + trillions * 1 + tenOfTrillions * 1
                 + hundredOfTrillions * 1 + quintillions * 1;
      }
      while (result >= (ulong)min && result <= (ulong)max);

      return result;
    }

    public static bool IsPrime(int candidate)
    {
      if (candidate <= 1)
      {
        return false;
      }

      if (candidate == 2 || candidate == 3)
      {
        return true;
      }

      if (candidate % 2 == 0)
      {
        return false;
      }

      for (int i = 3; i <= Math.Abs(Math.Sqrt(candidate)); i += 2)
      {
        if ((candidate % i) == 0)
        {
          return false;
        }
      }

      return true;
    }

    public static List<int> GetListOfPrime(int min, int count)
    {
      var result = new List<int>();
      if (min >= count)
      {
        return result;
      }

      var array = Enumerable.Range(min, count);
      var primes = from number in array.AsParallel() where IsPrime(number) select number;
      result = primes.ToList();
      return result;
    }

    public static List<int> GetSmallests(List<int> list, int count)
    {
      if (count >= list.Count)
      {
        return list;
      }

      var result = new List<int>();
      while (result.Count < count)
      {
        var min = GetSmallest(list);
        result.Add(min);
        list.Remove(min);
      }

      return result;
    }

    public static int GetSmallest(List<int> list)
    {
      return list.Min();
    }

    public static int GetGreatest(List<int> list)
    {
      return list.Max();
    }

    public static List<int> GetGreatests(List<int> list, int count)
    {
      if (count >= list.Count)
      {
        return list;
      }

      var result = new List<int>();
      while (result.Count < count)
      {
        var max = GetGreatest(list);
        result.Add(max);
        list.Remove(max);
      }

      return result;
    }

    public static int PrimeByFormula(ushort number)
    {
      if (number > 40)
      {
        return 0;
      }

      return (number * number) - number + 41;
    }

    // TODO Ppcm and Pgcm methods to be implemented
    public static bool IsAPowerOfTwo(int number)
    {
      return (number != 0) && ((number & number - 1) == 0);
    }

    public static List<int> Factorization(int number)
    {
      List<int> result = new List<int>();
      while (number % 2 == 0)
      {
        result.Add(2);
        number /= 2;
      }

      int divisor = 3;
      while (divisor * divisor <= number)
      {
        if (number % divisor == 0)
        {
          result.Add(divisor);
          number /= divisor;
        }
        else
        {
          divisor += 2;
        }
      }

      if (number > 1)
      {
        result.Add(number);
      }

      return result;
    }

    public static List<int> GetDivisors(int number)
    {
      List<int> result = new List<int> { 1, number }; // one is always divisible by 1 and itself
      for (int i = 2; i < number; i++)
      {
        if (number % i != 0)
        {
          continue;
        }

        if (!result.Contains(i))
        {
          result.Add(i);
        }
      }

      return result;
    }

    public static List<int> GetDivisorsSorted(int number)
    {
      var result1 = GetDivisors(number);
      var result2 = result1.OrderBy(i => i).ToList();
      return result2;
    }
  }
}
