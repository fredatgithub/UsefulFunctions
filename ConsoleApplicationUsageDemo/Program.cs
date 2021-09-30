using FonctionsUtiles.Fred.Csharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using enumRnd = FonctionsUtiles.Fred.Csharp.RandomCharacters;
using FileFunc = FonctionsUtiles.Fred.Csharp.FunctionsFiles;
using MathFunc = FonctionsUtiles.Fred.Csharp.FunctionsMath;
using StringFunc = FonctionsUtiles.Fred.Csharp.FunctionsString;

namespace ConsoleApplicationUsageDemo
{
  internal class Program
  {
    private static void Main()
    {
      Action<string> display = Console.WriteLine;
      Action<string> displayOnOneLine = Console.Write;
      display("Demo to use the useful functions DLL");
      int[] list = { 1, 2, 3, 1 };
      bool result = StringFunc.HasDuplicate(list);
      display("The array: {1, 2, 3, 1 } has duplicate: " + result);
      display(string.Empty);
      displayOnOneLine("Factorial 3 with lowerBound 2 is ");
      displayOnOneLine(MathFunc.Factorial(3, 2).ToString());
      display(string.Empty);
      displayOnOneLine("IsNumeric of '4' ");
      displayOnOneLine(StringFunc.IsNumeric("4").ToString());

      char[] tmpNull = null;
      // ReSharper disable once ExpressionIsAlwaysNull
      string rdnString = StringFunc.GenerateRandomString(tmpNull);
      display(string.Empty);
      display("Generation of a random string: " + rdnString);
      display(string.Empty);
      display("Manifest of the DLL: " + StringFunc.Manifest());
      display(string.Empty);
      display("Generation of a 10 random filename strings: ");
      for (int i = 0; i < 10; i++)
      {
        rdnString = StringFunc.GenerateRandomString(new[] { ' ' }, true, enumRnd.UpperLowerDigitSpecial, 8, true);
        display("Random filename: " + rdnString);
      }

      string test = Path.GetRandomFileName();
      display(string.Empty);
      display("Generation of a 10 Path.GetRandomFileName: ");
      for (int i = 0; i < 10; i++)
      {
        display("Random filename: " + Path.GetRandomFileName());
      }

      display("Listing all drives:");
      List<DriveInfo> allDir = FileFunc.GetAllDrives(new[] { DriveType.CDRom, DriveType.Network,
      DriveType.Removable});
      foreach (var dirName in allDir)
      {
        display(dirName.ToString());
      }

      display("displaying all directories:");
      var allfilesAndFolders = FileFunc.GetAllDirectories(@"C:\");
      var count = 0;
      foreach (var item in allfilesAndFolders)
      {
        display(item);
        count++;
      }

      display(count + " directories were found");
      display("");
      display("Punctuation characters:");
      display("Period: " + Punctuation.Period);
      display("Backslash: " + Punctuation.Backslash);
      display("Colon: " + Punctuation.Colon);

      Livre dune = new Livre
      {
        Auteur = "Frank Herbert",
        Prix = 20.00M,
        Titre = "Les enfants de Dune"
      };

      // search for twin primes
      display("Searching for twin primes:");
      foreach (int twin in FunctionsPrimes.GetTwinPrimeBefore(500))
      {
        Console.Write($"{twin} ");
      }

      Stopwatch chrono2 = new Stopwatch();
      chrono2.Start();
      var allTwinPrimes = FunctionsPrimes.GetTwinPrimeBefore(int.MaxValue - 2);
      chrono2.Stop();
      TimeSpan ts2 = chrono2.Elapsed;
      string elapsedTime2 = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
          ts2.Hours, ts2.Minutes, ts2.Seconds,
          ts2.Milliseconds / 10);
      try
      {
        using (StreamWriter sw2 = new StreamWriter("twinPrimes.txt"))
        {
          sw2.WriteLine(string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts2.Hours, ts2.Minutes, ts2.Seconds, ts2.Milliseconds / 10));
          sw2.WriteLine("RunTime with chrono: " + elapsedTime2);
          foreach (int twin in allTwinPrimes)
          {
            sw2.WriteLine(twin);
          }
        }
      }
      catch (Exception)
      {
        display("There were an error while trying to write to a file all twin primes before int.max");
      }

      // calculating the time necessary to go through all numbers until int.max about billions
      var startTime = DateTime.Now;
      Stopwatch chrono = new Stopwatch();
      chrono.Start();
      for (int i = 0; i < int.MaxValue; i++)
      {

      }

      var endTime = DateTime.Now;
      chrono.Stop();
      TimeSpan ts = chrono.Elapsed;
      string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
          ts.Hours, ts.Minutes, ts.Seconds,
          ts.Milliseconds / 10);
      Console.WriteLine("RunTime " + elapsedTime);
      using (StreamWriter sw = new StreamWriter("timeToIntMax.txt"))
      {
        sw.WriteLine($"start time is {startTime}");
        sw.WriteLine($"End time is {endTime}");
        sw.WriteLine(string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10));
        sw.WriteLine("RunTime with chrono: " + elapsedTime);
      }

      //for (int i = 0; i < FunctionsPrimes.GetTwinPrimeBefore(500).Count; i +=2) 
      //{
      //  Console.Write($"{twin} ");
      //}

      /* twin primes
        2-3
        11-13
        17-19
        41-43
        71-73
        101-103
        107-109
        197-199
        227-229
        281-283
        311-313
        431-433
        461-463
       * */

      display("");
      //display("primes:");
      //for (int i = 3; i < 500; i = i + 2)
      //{
      //  if (FunctionsMath.IsPrime(i))
      //  {
      //    Console.Write($"{i} ");
      //  }
      //}


      display("");
      display("Press any key to exit:");
      Console.ReadKey();
    }

    public struct Livre
    {
      public decimal Prix;
      public string Titre;
      public string Auteur;
    }

    public static void PrintList<T>(IEnumerable<T> list)
    {
      foreach (var item in list)
      {
        Console.WriteLine(item);
      }
    }
  }
}