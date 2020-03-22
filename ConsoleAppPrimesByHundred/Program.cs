using FonctionsUtiles.Fred.Csharp;
using System;
using System.Collections.Generic;
using System.Numerics;


namespace ConsoleAppPrimesByHundred
{
  internal class Program
  {
    private static void Main()
    {
      Action<string> display = Console.WriteLine;
      display("Prime numbers by hundred:");
      foreach (var kvp in FunctionsPrimes.NumberOfPrimesByHundred(1000))
      {
        display($"{kvp.Key} - {kvp.Value}");
      }

      display(string.Empty);
      display("Prime numbers by thousand:");
      display(string.Empty);
      foreach (var kvp in FunctionsPrimes.NumberOfPrimesByNthHundred(9000, 1000))
      {
        display($"{kvp.Key} - {kvp.Value}");
      }

      //int count = 0;
      //for (int i = 3; i <= int.MaxValue - 4; i += 2)
      //{
      //  if (FunctionsPrimes.IsPrimeTriplet(i))
      //  {
      //    count++;
      //  }

      //  display($"Number of prime found: {count} and i: {i}");
      //}

      display("no triplet prime from 3 to 2147483643");
      for (BigInteger i = BigInteger.Parse("2147483643"); i <= BigInteger.Parse("2147483699"); i += 2)
      {
        BigInteger squareRoot = BigInteger.Pow(i, (int)BigInteger.Log(i)); // wrong square root
        display($"Big Integer is : {i} and square root is = {squareRoot}");
      }

      display("Pas de prime triplet between 2147483643 and 3147483643");
      int count = 0;
      List<string> result = new List<string>();
      for (BigInteger i = BigInteger.Parse("3147483643"); i <= BigInteger.Parse("4147483643"); i += 2)
      {
        if (FunctionsPrimes.IsPrimeTriplet(i))
        {
          count++;
          result.Add(i.ToString());
        }

        display($"Number of prime found: {count} and i = {i}");
      }

      if (result.Count > 0)
      {
        foreach (string number in result)
        {
          display($"Prime triplet found : {number}");
        }
      }

      var timestamp = DateTime.Now.ToFileTime();
      display($"time stamp using ToFileTime : {timestamp.ToString()}");

      string timeStamp = GetTimestamp(DateTime.Now);
      display($"time stamp yyyymmddhh : {timestamp.ToString()}");

      display("Press any key to exit");
      Console.ReadKey();
    }

    public static String GetTimestamp(DateTime value)
    {
      return value.ToString("yyyyMMddHHmmssffff");
    }
  }
}