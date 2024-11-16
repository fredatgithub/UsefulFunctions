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
      // Création d'un format personnalisé
      NumberFormatInfo formatInfo = new NumberFormatInfo
      {
        NumberGroupSeparator = " ", // Séparateur de milliers : espace
        NumberGroupSizes = new[] { 3 } // Groupes de 3 chiffres
      };

      // continuing search from the last prime number found
      string lastNumberComputed = ReadFile("lastNumber.txt");
      var source = BigInteger.Parse(lastNumberComputed);
      if (source % 2 == 0)
      {
        source++;
      }

      var startNumber = source;
      Display(string.Empty);
      Display($"Starting searching from: {startNumber.ToString("N0", formatInfo)}");
      Display(string.Empty);
      var counter = 0;
      var increment = Settings.Default.IncrementNumber;
      Display($"Searching for {increment} numbers after {startNumber.ToString("N0", formatInfo)}");
      Display($"Processing numbers until         {(startNumber + increment).ToString("N0", formatInfo)}");
      Display(string.Empty);
      var endNumber = startNumber + increment;
      var primes = new List<BigInteger>();
      var chrono = new Stopwatch();
      chrono.Start();
      for (int i = 0; i < increment; i += 2)
      {
        var currentNumber = startNumber + i;
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
      today = DateTime.Now;
      todayFormatted = today.ToString().Replace('/', '-').Replace(' ', '_').Replace(':', '-');
      var filename = $"TimeTaken-{todayFormatted}.txt";
      WriteToFile(filename, $"To search for prime numbers within {increment} numbers, it took : {FormatElapseTime(chrono.Elapsed)} starting at {startNumber} and ending at {endNumber}");
      filename = $"BigIntegerPrimes";
      WriteToFile(AddTimetoFilename(filename), primes);
      WriteToFile("lastNumber.txt", endNumber.ToString());
      Display("The result were written to a file on a disk: BigIntegerPrimes.txt");
      Display(string.Empty);
      Display($"End of processing on {DateTime.Now}");
      Display("Press any key to exit:");
      Console.ReadKey();
    }

    private static string ReadFile(string filename)
    {
      string result = "2";
      try
      {
        using (StreamReader sr = new StreamReader(filename))
        {
          result = sr.ReadLine();
        }
      }
      catch (Exception)
      {
      }

      return result;
    }

    private static string AddTimetoFilename(string filename)
    {
      var today = DateTime.Now;
      string todayFormatted = today.ToString().Replace('/', '-').Replace(' ', '_').Replace(':', '-');
      return $"{filename}-{todayFormatted}.txt";
    }
    private static void WriteToFile(string filename, string message, bool append = false)
    {
      try
      {
        using (StreamWriter sw = new StreamWriter(filename, append))
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
        using (StreamWriter sw = new StreamWriter(filename))
        {
          sw.WriteLine($"Prime numbers between {primes[0]} and {primes[primes.Count - 1]}");
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
