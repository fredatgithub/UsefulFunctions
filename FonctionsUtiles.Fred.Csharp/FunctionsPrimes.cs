using System;
using System.Collections.Generic;
using System.Numerics;

namespace FonctionsUtiles.Fred.Csharp
{
  public static class FunctionsPrimes
  {
    public static int NumberOfPrimeUnder(int number)
    {
      int result = 0;
      for (int i = 2; i <= number; i++)
      {
        if (FunctionsMath.IsPrime(i))
        {
          result++;
        }
      }

      return result;
    }

    public static List<int> GetPrimesBefore(int number)
    {
      List<int> result = new List<int>();
      for (int i = 2; i <= number; i++)
      {
        if (FunctionsMath.IsPrime(i))
        {
          result.Add(i);
        }
      }

      return result;
    }

    public static Dictionary<int, int> NumberOfPrimesByNthHundred(int number, int nth = 100)
    {
      Dictionary<int, int> result = new Dictionary<int, int>();
      for (int i = 2; i <= number; i++)
      {
        if (FunctionsMath.IsPrime(i))
        {
          int index = (Math.Abs(i / nth) + 1) * nth;
          if (result.ContainsKey(index))
          {
            result[index]++;
          }
          else
          {
            result.Add(index, 1);
          }
        }
      }

      return result;
    }

    public static Dictionary<int, int> NumberOfPrimesByHundred(int number)
    {
      Dictionary<int, int> result = new Dictionary<int, int>();
      for (int i = 2; i <= number; i++)
      {
        if (FunctionsMath.IsPrime(i))
        {
          int index = (Math.Abs(i / 100) + 1) * 100;
          if (result.ContainsKey(index))
          {
            result[index]++;
          }
          else
          {
            result.Add(index, 1);
          }
        }
      }

      return result;
    }

    public static Dictionary<int, int> GetAbsoluteValues()
    {
      Dictionary<int, int> result = new Dictionary<int, int>();
      for (int i = 0; i < 300; i++)
      {
        int index = (Math.Abs(i / 100) + 1) * 100;
        if (result.ContainsKey(index))
        {
          result[index]++;
        }
        else
        {
          result.Add(index, 1);
        }
      }

      return result;
    }

    public static bool IsTwinPrime(int number)
    {
      return FunctionsMath.IsPrime(number) && FunctionsMath.IsPrime(number + 2);
    }

    public static List<int> GetTwinPrimeBefore(int number)
    {
      List<int> result = new List<int>();
      if (number <= 2)
      {
        return result;
      }

      result.Add(2);
      result.Add(3);
      if (number <= 3)
      {
        return result;
      }

      result.Add(5);
      result.Add(7);
      if (number <= 7)
      {
        return result;
      }

      for (int i = 7; i <= number; i++)
      {
        if (IsTwinPrime(number))
        {
          result.Add(number);
          result.Add(number + 2);
        }
      }

      return result;
    }

    public static string Negate(string verb, bool positive)
    {
      return positive ? verb : $"n'{verb} pas";
    }

    public static bool IsPrime(ulong number)
    {
      if (number <= 1)
      {
        return false;
      }

      if (number == 2 || number == 3 || number == 5)
      {
        return true;
      }

      if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0)
      {
        return false;
      }

      for (ulong divisor = 7; divisor < Math.Sqrt(number); divisor += 2)
      {
        if (number % divisor == 0)
        {
          return false;
        }
      }

      return true;
    }

    public static bool IsPrime(BigInteger number)
    {
      if (number.IsEven)
      {
        return false;
      }

      if (number.Sign == 0 || number.Sign == -1)
      {
        return false;
      }

      if (number == 2 || number == 3 || number == 5)
      {
        return true;
      }

      if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0)
      {
        return false;
      }

      var squareRoot = Math.Exp(BigInteger.Log(number) / 2);
      for (ulong divisor = 7; divisor < squareRoot; divisor += 2)
      {
        if (number % divisor == 0)
        {
          return false;
        }
      }

      return true;
    }
  }
}
