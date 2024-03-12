using FonctionsUtiles.Fred.Csharp;

namespace ConsoleAppTheoremeDeWilson
{
  internal class Program
  {
    static void Main()
    {
      //Console.Write("Entrez un nombre : ");
      //int nombre = Convert.ToInt32(Console.ReadLine());

      for (int nombre = 0; nombre < 1000; nombre++)
      {
        if (FunctionsPrimes.EstPremierSelonLeTheoremeDeWilson(nombre))
        {
          Console.WriteLine($"{nombre} est un nombre premier selon le théorème de Wilson.");
        }
        //else
        //{
        //  Console.WriteLine($"{nombre} n'est pas un nombre premier selon le théorème de Wilson.");
        //}
      }
    }
  }
}
