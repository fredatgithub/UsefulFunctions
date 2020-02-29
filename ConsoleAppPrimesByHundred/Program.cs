using System;
using FonctionsUtiles.Fred.Csharp;


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

      int count = 0;
      for (int i = 3; i <= int.MaxValue - 4; i += 2)
      {
        if (FunctionsPrimes.IsPrimeTriplet(i))
        {
          count++;
        }

        display($"Number of prime found: {count} and i: {i}");
      }

      display("Press any key to exit");
      Console.ReadKey();
    }
  }
}
