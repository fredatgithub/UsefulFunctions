using FonctionsUtiles.Fred.Csharp;
using System;

namespace ConsoleAppGetFactors
{
  internal class Program
  {
    static void Main()
    {
      Action<string> Display = Console.WriteLine;
      Display("Get factors of a number");
      for (int i = 2; i < 2_000; i++)
      {
        var factors = FunctionsPrimes.GetFactors(i);
        if (factors.Length != 0)
        {
          Display($"Les diviseurs de {i} sont : {string.Join(", ", factors)}");
        }
      }

      Display("End of program, press a key to exit");
      Console.ReadKey();
    }
  }
}
