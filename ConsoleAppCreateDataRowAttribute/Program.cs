using FonctionsUtiles.Fred.Csharp;
using System;
using System.Collections.Generic;

namespace ConsoleAppCreateDataRowAttribute
{
  internal class Program
  {
    static void Main()
    {
      var start = 4_177;
      var end = 4_999;
      var result = new List<string>();
      for (int i = start; i <= end; i++)
      {
        if (FunctionsPrimes.IsPrime(i))
        {
          // [DataRow(4177)]
          result.Add($"[DataRow({i})]");
        }
      }

      foreach (var i in result)
      {
        Console.WriteLine(i);
      }

      Console.WriteLine();
      Console.WriteLine("Press any key to exit:");
      Console.ReadLine();
    }
  }
}
