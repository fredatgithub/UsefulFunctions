﻿using ConsoleAppBigIntegerPrimeSearch.Properties;
using FonctionsUtiles.Fred.Csharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Numerics;

namespace ConsoleAppBigIntegerPrimeSearch
{
  internal class Program
  {
    static void Main()
    {
      while (true)
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
        Display($"Processing numbers until{FunctionsString.Tabulation(increment.ToString().Length)}{(startNumber + increment).ToString("N0", formatInfo)}");
        Display(string.Empty);
        var endNumber = startNumber + increment;
        var primes = new List<BigInteger>();
        var chrono = new Stopwatch();
        //var finalSearchedNumber = startNumber + increment;
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
          else
          {
            //Display($"{currentNumber.ToString("N0", formatInfo)} is not a prime number");
          }
        }

        chrono.Stop();
        string numberOfPrimefound;
        if (counter == 0)
        {
          numberOfPrimefound = "No prime found between: " + $"{startNumber.ToString("N0", formatInfo)} and " + $"{endNumber.ToString("N0", formatInfo)}";
          Display(numberOfPrimefound);
        }
        else
        {
          numberOfPrimefound = $"{counter} prime{Plural(counter)} found between: " + $"{startNumber.ToString("N0", formatInfo)} and " + $"{endNumber.ToString("N0", formatInfo)}";
          Display(numberOfPrimefound);
        }

        Display(string.Empty);
        WriteToFile("PrimeCounter.txt", numberOfPrimefound, true);
        Display($"To search for prime numbers within {increment} numbers, it took : {FormatElapseTime(chrono.Elapsed)}");
        //today = DateTime.Now;
        //todayFormatted = today.ToString().Replace('/', '-').Replace(' ', '_').Replace(':', '-');
        var filename = $"TimeTaken.txt";
        WriteToFile(filename, $"To search for prime numbers within {increment} numbers, it took : {FormatElapseTime(chrono.Elapsed)} starting at {startNumber} and ending at {endNumber}", true);
        filename = $"BigIntegerPrimes";
        WriteToFile(AddTimetoFilename(filename), primes);
        WriteToFile("lastNumber.txt", endNumber.ToString());
        Display("The result were written to a file on a disk: BigIntegerPrimes.txt");
        Display(string.Empty);
        Display($"End of processing on {DateTime.Now}");
      }

      //Console.WriteLine("Press any key to exit:");
      //Console.ReadKey();
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
      if (primes.Count == 0)
      {
        return;
      }

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
