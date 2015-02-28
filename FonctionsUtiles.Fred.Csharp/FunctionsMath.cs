/*
The MIT License(MIT)
Copyright(c) 2015 Freddy Juhel
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
namespace FonctionsUtiles.Fred.Csharp
{
  public class FunctionsMath
  {
    public static long Factorial(long x)
    {
      if (x < 1 || x > long.MaxValue)
      {
        return 0;
      }

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
      if (x < 1 || x > long.MaxValue)
      {
        return 0;
      }

      long fact = 1;
      while (x >= 1 && x > lowerBound)
      {
        fact *= x;
        x--;
      }

      return fact;
    }

    public static ulong RecursiveFactorial(int number)
    {
      if (number == 1)
      {
        return 1;
      }

      return (ulong)number * RecursiveFactorial(number - 1);
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