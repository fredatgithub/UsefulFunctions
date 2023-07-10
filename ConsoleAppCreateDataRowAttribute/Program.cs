using FonctionsUtiles.Fred.Csharp;
using System;
using System.Collections.Generic;

namespace ConsoleAppCreateDataRowAttribute
{
  internal class Program
  {
    static void Main()
    {
      var start = 5_000;
      var end = 6_000;
      var result = new List<string>();
      for (int i = start; i <= end; i++)
      {
        if (FunctionsPrimes.IsPrime(i))
        {
          // [DataRow(4177)]
          result.Add($"[DataRow({i})]");
        }
      }

      foreach (var number in result)
      {
        Console.WriteLine(number);
      }

      Console.WriteLine();
      Console.WriteLine("Press any key to exit:");
      Console.ReadLine();
    }
  }
}
