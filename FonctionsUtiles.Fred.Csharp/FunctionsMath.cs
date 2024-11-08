using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;

namespace FonctionsUtiles.Fred.Csharp
{
  public static class FunctionsMath
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

    /// <summary>
    /// Compute is a number is a prime number.
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <returns>True is the number is prime, false otherwise.</returns>
    public static bool IsPrime(int number)
    {
      if (number <= 1) return false; // remove negative numbers and 0 and 1
      if (number == 2) return true; // 2 is prime
      if (number == 3) return true; // 3 is prime
      if (number % 2 == 0) return false; // remove all even numbers
      if (number == 5) return true; // 5 is prime
      if (number % 3 == 0) return false; // remove all numbers divided by 3
      if (number % 5 == 0) return false; // remove all numbers divided by 5

      for (int i = 7; i <= Math.Abs(Math.Sqrt(number)); i += 2)
      {
        if ((number % i) == 0)
        {
          return false;
        }
      }

      return true;
    }

    /// <summary>
    /// Returns a list of all prime numbers from a minimum number to a maximum number.
    /// </summary>
    /// <param name="min">The first prime number.</param>
    /// <param name="max">The last prime number.</param>
    /// <returns>A list of int of all prime numbers between two numbers.</returns>
    public static List<int> GetListOfPrime(int min, int max)
    {
      var result = new List<int>();
      if (min >= max)
      {
        return result;
      }

      var array = Enumerable.Range(min, max);
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

    public static bool EstPuissanceDe2(int number)
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
      List<int> result = new List<int> { 1, number }; // a number is always divisible by 1 and itself
      for (int potentialDivisor = 2; potentialDivisor < number; potentialDivisor++)
      {
        if (number % potentialDivisor != 0)
        {
          continue;
        }

        if (!result.Contains(potentialDivisor))
        {
          result.Add(potentialDivisor);
        }
      }

      return result;
    }

    public static List<int> GetDivisorsSorted(int number)
    {
      var result1 = GetDivisors(number);
      var result2 = result1.OrderBy(nb => nb).ToList();
      return result2;
    }

    public static decimal ConvertDoublewithCultureInfo(string number)
    {
      var clone = (CultureInfo)CultureInfo.InvariantCulture.Clone();
      clone.NumberFormat.NumberDecimalSeparator = ",";
      clone.NumberFormat.NumberGroupSeparator = ".";
      decimal result = decimal.Parse(number, clone);
      return result;
    }

    public static decimal ConvertDoublewithCultureInfo2(string number)
    {
      decimal result = decimal.Parse(number, CultureInfo.GetCultureInfo("fr-FR"));
      return result;
    }

    public static int[] RepartitionDizaineTirage(int[] tirage)
    {
      int[] result = new int[tirage.Length];
      for (int i = 0; i < tirage.Length; i++)
      {
        result[i] = 0;
      }

      foreach (var number in result)
      {
        switch (number)
        {
          case int _ when number < 10:
            result[0]++;
            break;
          case int _ when number >= 10 && number <= 19:
            result[1]++;
            break;
          case int _ when number >= 20 && number <= 29:
            result[2]++;
            break;
          case int _ when number >= 30 && number <= 39:
            result[3]++;
            break;
          case int _ when number >= 40:
            result[4]++;
            break;
        }
      }

      return result;
    }

    public static int Dizaine(int nombre)
    {
      int result = 0;
      result = Math.Abs(nombre / 10);
      if (nombre == 50)
      {
        result = 4;
      }

      return result;
    }

    public static int Hundred(int number)
    {
      int result = 0;
      result = Math.Abs(number / 10);
      if (number == 50)
      {
        result = 4;
      }

      return result;
    }

    public static List<int> GetDivisor(int number)
    {
      // to be debugged
      List<int> result = new List<int>();
      if (number < 2)
      {
        return result;
      }

      int d = 2;
      while (number != 1)
      {
        while (number % d == 0)
        {
          result.Add(d);
          d = number / d;
        }

        d++;
      }

      return result;
    }

    public static int[] SortArray(int[] inputArray)
    {
      var orderedArray = from number in inputArray
                         orderby number
                         select number;
      return orderedArray.ToArray();
    }

    public static int[] IntersectionOfArrays(int[] arrayA, int[] arrayB)
    {
      return arrayA.Intersect(arrayB).ToArray();
    }

    public static int[] UnionOfArrays(int[] arrayA, int[] arrayB)
    {
      return arrayA.Union(arrayB).ToArray();
    }

    public static List<string> GetPrimeDivisor(int number)
    {
      var result = new List<string>();
      var possibleDivisors = GetListOfPrime(3, number);
      possibleDivisors.Sort();
      for (int i = 0; i < possibleDivisors.Count; i++)
      {
        for (int j = 0; j < possibleDivisors.Count; j++)
        {
          if (i == j)
          {
            continue;
          }

          if (possibleDivisors[i] * possibleDivisors[j] <= int.MaxValue && (possibleDivisors[i] * possibleDivisors[j]) == number && !result.Contains($"{possibleDivisors[j]}*{possibleDivisors[i]}={number}"))
          {
            result.Add($"{possibleDivisors[i]}*{possibleDivisors[j]}={number}");
          }
        }
      }

      result.Sort();
      return result;
    }

    public static bool EstImpair(int value)
    {
      return value % 2 != 0;
    }

    public static bool Estpair(int value)
    {
      return value % 2 == 0;
    }

    public static bool IsOdd(int value)
    {
      return value % 2 != 0;
    }

    public static bool IsEven(int value)
    {
      return value % 2 == 0;
    }

    public static bool CheckLoanApprovalRule(double amount)
    {
      switch (amount)
      {
        case double n when (n < 10_000):
          return false;
        case double n when (n > 10_000 && n < 1_000_000):
          return true;
        case double n when (n > 1_000_000):
          return false;
        default:
          return false;
      }
    }

    public static string Majorite(int age)
    {
      switch (age)
      {
        case int n when (n < 0):
          return "pas encore né";
        case int n when (n < 18):
          return "mineur";
        case int n when (n < 62):
          return "senior";
        case int n when (n >= 62):
          return "retraité";
        default:
          return "majorité inconnue";
      }
    }

    public static IEnumerable<int> GetListOfNumbers(int from, int to)
    {
      return Enumerable.Range(from, to);
    }

    /// <summary>
    /// Divides two numbers.
    /// </summary>
    /// <param name="dividend">Dividend value.</param>
    /// <param name="divisor">Divisor value.</param>
    /// <returns>division result or 0 if divisor is 0.</returns>
    public static decimal Divide(decimal dividend, decimal divisor)
    {
      return (divisor == 0m) ? 0m : decimal.Divide(dividend, divisor);
    }

    /// <summary>
    /// Divides two numbers.
    /// </summary>
    /// <param name="dividend">Dividend value.</param>
    /// <param name="divisor">Divisor value.</param>
    /// <param name="additionalValue">added tp division result.</param>
    /// <returns>division result or 0 if divisor is 0.</returns>
    public static decimal Divide(decimal dividend, decimal divisor, decimal additionalValue)
    {
      return (divisor == 0m) ? 0m : decimal.Divide(dividend, divisor) + additionalValue;
    }

    /// <summary>
    /// Divides two numbers and round result.
    /// </summary>
    /// <param name="dividend">Dividend value.</param>
    /// <param name="divisor">Divisor value.</param>
    /// <returns>division result or 0 if divisor is 0.</returns>
    public static decimal RoundedDivide(decimal dividend, decimal divisor, int decimalPrecision = 7)
    {
      return (divisor == 0m) ? 0m : Math.Round(Divide(dividend, divisor), decimalPrecision, MidpointRounding.ToEven);
    }

    /// <summary>
    /// Divides two numbers and round result.
    /// </summary>
    /// <param name="dividend">Dividend value.</param>
    /// <param name="divisor">Divisor value.</param>
    /// <param name="additionalValue">added tp division result.</param>
    /// <returns>division result or 0 if divisor is 0.</returns>
    public static decimal RoundedDivide(decimal dividend, decimal divisor, decimal additionalValue, int decimalPrecision = 7)
    {
      return (divisor == 0m) ? 0m : Math.Round(Divide(dividend, divisor) + additionalValue, decimalPrecision, MidpointRounding.ToEven);
    }

    public static int EuclideFunctionPgcd(int a, int b)
    {
      /*
       * https://fr.wikipedia.org/wiki/Algorithme_d%27Euclide
       * fonction euclide(a, b)
        tant que a ≠ b
        si a > b alors
            a := a − b;
        sinon
            b := b − a;
        renvoyer a;
       * */
      while (a != b)
      {
        if (a > b)
        {
          a -= b;
        }
        else
        {
          b -= a;
        }
      }

      return a;
    }

    public static int EuclideFunctionPgcdRecursive(int a, int b)
    {
      /*
       * https://fr.wikipedia.org/wiki/Algorithme_d%27Euclide
       * fonction euclide(a, b)
          si b = 0 alors renvoyer a;
          sinon renvoyer euclide(b, a modulo b);
       * */
      if (b == 0)
      {
        return a;
      }

      return EuclideFunctionPgcdRecursive(b, a % b);
    }

    public static int PgcdBinaireAlgorithme(int a, int b)
    {
      /*
       * https://fr.wikipedia.org/wiki/Algorithme_binaire_de_calcul_du_PGCD
       * Si 	                  alors
         a = 0 	                pgcd(0, b) = b
         a et b sont pairs 	    pgcd(a, b) = 2 × pgcd(a/2, b/2)
         a est impair, b pair 	pgcd(a, b) = pgcd(a, b/2)
         a est pair, b impair 	pgcd(a, b) = pgcd(a/2, b)
         a et b impairs 	      pgcd(a, b) = pgcd( (a - b)/2, b) 
       * */
      // si a = 0 	            alors pgcd(0, b) = b
      if (a == 0)
      {
        return b;
      }

      // si a et b sont pairs 	    alors pgcd(a, b) = 2 × pgcd(a/2, b/2)
      if ((a % 2 == 0) && (b % 2 == 0))
      {
        return 2 * PgcdBinaireAlgorithme(a / 2, b / 2);
      }

      // si a est impair, b pair 	alors pgcd(a, b) = pgcd(a, b/2)
      if ((a % 2 != 0) && (b % 2 == 0))
      {
        return PgcdBinaireAlgorithme(a, b / 2);
      }

      // si a est pair, b impair 	alors pgcd(a, b) = pgcd(a/2, b)
      if ((a % 2 == 0) && (b % 2 != 0))
      {
        return PgcdBinaireAlgorithme(a / 2, b);
      }

      // si a et b impairs 	      alors pgcd(a, b) = pgcd( (a - b)/2, b) 
      if ((a % 2 != 0) && (b % 2 != 0))
      {
        return PgcdBinaireAlgorithme((a - b) / 2, b);
      }

      return 0;
    }
  }
}
