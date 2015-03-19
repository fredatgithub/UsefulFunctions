using System;

namespace CodeGeneration
{
  class Program
  {
    static void Main()
    {
      Action<string> Display = s => Console.WriteLine(s);
      Display("Generating code for Unit tests in a file");

      Console.ReadKey();
    }
  }
}