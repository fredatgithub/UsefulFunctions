using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Numerics;
using ConsoleAppBigIntegerPrimeSearch.Properties;
using FonctionsUtiles.Fred.Csharp;

namespace ConsoleAppBigIntegerPrimeSearch
{
  internal class Program
  {
    static void Main()
    {
      Action<string> Display = Console.WriteLine;
      Display("Searching for big integer prime numbers");
      var today = DateTime.Now;
      string todayFormatted = today.ToString().Replace('/', '-').Replace(' ', '_').Replace(':', '-');
      Display($"Search started on {todayFormatted}");
      //var number = BigInteger.Parse("123456789012345678901234567890");
      // ulong MaxValue = 18446744073709551615uL
      // ulong MaxValue + 1 = 18446744073709551616uL
      // Création d'un format personnalisé
      NumberFormatInfo formatInfo = new NumberFormatInfo
      {
        NumberGroupSeparator = " ", // Séparateur de milliers : espace
        NumberGroupSizes = new[] { 3 } // Groupes de 3 chiffres
      };

      //var source = new BigInteger(ulong.MaxValue);
      // continuing search from the last prime number found
      var source = BigInteger.Parse(Settings.Default.StartingNumber);
      var startNumber = source;
      Display(string.Empty);
      Display($"Starting searching from ulong.MaxValue which is: {startNumber.ToString("N0", formatInfo)}");
      Display(string.Empty);
      var currentNumber = source;
      var counter = 0;
      var increment = Settings.Default.IncrementNumber;
      Display($"Searching for {increment} numbers after {startNumber.ToString("N0", formatInfo)}");
      Display(string.Empty);
      var endNumber = startNumber + increment;
      var primes = new List<BigInteger>();
      var chrono = new Stopwatch();
      chrono.Start();
      for (int i = 0; i < increment; i += 2)
      {
        currentNumber = startNumber + i;
        if (FunctionsPrimes.IsPrime(currentNumber))
        {
          Display($"{currentNumber.ToString("N0", formatInfo)} is prime");
          counter++;
          primes.Add(currentNumber);
        }
      }

      chrono.Stop();
      if (counter == 0)
      {
        Display($"No prime found between:");
        Display($"{startNumber.ToString("N0", formatInfo)} and");
        Display($"{endNumber.ToString("N0", formatInfo)}");
      }
      else
      {
        Display($"{counter} prime{Plural(counter)} found between:");
        Display($"{startNumber.ToString("N0", formatInfo)} and");
        Display($"{endNumber.ToString("N0", formatInfo)}");
      }

      Display(string.Empty);
      Display($"To search for prime numbers within {increment} numbers, it took : {FormatElapseTime(chrono.Elapsed)}");
      WriteToFile("TimeTaken", $"To search for prime numbers within {increment} numbers, it took : {FormatElapseTime(chrono.Elapsed)} starting at {startNumber}");
      WriteToFile("BigIntegerPrimes", primes);
      Display("The result were written to a file on a disk: BigIntegerPrimes.txt");

      Display("Press any key to exit:");
      Console.ReadKey();
    }

    private static void WriteToFile(string filename, string message)
    {
      try
      {
        var today = DateTime.Now;
        string todayFormatted = today.ToString().Replace('/', '-').Replace(' ', '_').Replace(':', '-');
        using (StreamWriter sw = new StreamWriter($"{filename}-{todayFormatted}.txt"))
        {
          sw.WriteLine(message);
        }
      }
      catch (Exception)
      {
        throw;
      }
    }

    private static string FormatElapseTime(TimeSpan timeSpan)
    {
      var result = string.Empty;
      if (timeSpan.Hours > 0)
      {
        result += $"{timeSpan.Hours} heure{Plural(timeSpan.Hours)} ";
      }

      if (timeSpan.Minutes > 0)
      {
        result += $"{timeSpan.Minutes} minute{Plural(timeSpan.Minutes)} ";
      }

      result += $"{timeSpan.Seconds} seconde{Plural(timeSpan.Seconds)}";
      return result;
    }

    private static void WriteToFile(string filename, List<BigInteger> primes)
    {
      try
      {
        var today = DateTime.Now;
        string todayFormatted = today.ToString().Replace('/', '-').Replace(' ', '_').Replace(':', '-');
        using (StreamWriter sw = new StreamWriter($"{filename}-{todayFormatted}.txt"))
        {
          sw.WriteLine("Prime numbers");
          foreach (var number in primes)
          {
            sw.WriteLine(number);
          }
        }
      }
      catch (Exception)
      {
        throw;
      }
    }

    private static string Plural(int counter)
    {
      return counter > 1 ? "s" : string.Empty;
    }
  }
}
