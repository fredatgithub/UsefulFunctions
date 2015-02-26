namespace FonctionsUtiles.Fred.Csharp
{
  public class FonctionsMath
  {
    public static long Factorial(long x)
    {
      long fact = 1;
      long i = 1;
      while (i <= x)
      {
        fact = fact * i;
        i++;
      }

      return fact;
    }
    
    public static long Factorial(long x, long lowerBound)
    {
      long fact = 1;
      while (x >= 1 && x > lowerBound)
      {
        fact *= x;
        x--;
      }

      return fact;
    }
    
    public static long Factorielle(long x)
    {
      long fact = 1;
      long i = 1;
      while (i <= x)
      {
        fact = fact * i;
        i++;
      }

      return fact;
    }
    
    public static ulong Factorielle(int nombre)
    {
      if (nombre == 1)
      {
        return 1;
      }

      return (ulong)nombre * Factorielle(nombre - 1);
    }

    public static long Factoriel(long x, long lowerBound)
    {
      long fact = 1;
      while (x >= 1 && x > lowerBound)
      {
        fact *= x;
        x--;
      }

      return fact;
    }
    
    public static long Sommielle(long nombreDebut, long nombreFin)
    {
      long sommeIterative = 0;
      for (long i = nombreDebut; i <= nombreFin; i++)
      {
        sommeIterative += i;
      }

      return sommeIterative;
    }
    
    public static long SommielleRecursive(long nombreDebut, long nombreFin)
    {
      if (nombreDebut == nombreFin)
      {
        return nombreDebut;
      }

      return nombreDebut + SommielleRecursive(nombreDebut + 1, nombreFin);
    }
  }
}