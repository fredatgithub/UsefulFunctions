﻿using System;
using System.Collections.Generic;

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
        if (FunctionsMath.IsPrime(number))
        {
          result.Add(number);
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
          int index = Math.Abs(number / 100) * 100;
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
  }
}
