using System;
using System.Globalization;
using System.Numerics;
using FonctionsUtiles.Fred.Csharp;

namespace ConsoleAppBigIntegerPrimeSearch
{
  internal class Program
  {
    static void Main()
    {
      Action<string> Display = Console.WriteLine;
      Display("Searching for big integer prime numbers");
      //var number = BigInteger.Parse("123456789012345678901234567890");
      // ulong MaxValue + 1 = 18446744073709551616uL

      var source = new BigInteger(ulong.MaxValue);
      var startNumber = source;
      var counter = 0;
      var increment = 100;
      var endNumber = startNumber + increment;
      for (int i = 0; i < increment; i++)
      {
        source += i;
        if (FunctionsPrimes.IsPrime(source))
        {
          Display($"{source} is prime");
          counter++;
        }
        else
        {
          Display(source.ToString());
        }
      }

      // Création d'un format personnalisé
      NumberFormatInfo formatInfo = new NumberFormatInfo
      {
        NumberGroupSeparator = " ", // Séparateur de milliers : espace
        NumberGroupSizes = new[] { 3 } // Groupes de 3 chiffres
      };

      if (counter == 0)
      {
        Display($"No prime found between:");
        Display($"{startNumber.ToString("N0", formatInfo)} and");
        Display($"{endNumber.ToString("N0", formatInfo)}");
      }
      else
      {
        Display($"{counter} prime{Plural(counter)} found between {startNumber.ToString("N0", formatInfo)} and {endNumber.ToString("N0", formatInfo)}");
      }

      Display("Press any key to exit:");
      Console.ReadKey();
    }

    private static string Plural(int counter)
    {
      return counter > 1 ? "s" : string.Empty;
    }
  }
}
