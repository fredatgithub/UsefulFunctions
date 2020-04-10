using FonctionsUtiles.Fred.Csharp;
using System;

namespace ConsoleAppNTLM
{
  class Program
  {
    static void Main(string[] args)
    {
      Action<string> display = Console.WriteLine;
      string alphabet = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ&é'(-è_çà)=$£*%â";
      for (int i = 0; i < alphabet.Length; i++)
      {
        display($"{alphabet[i]} = {FunctionsCrypto.Ntlm(alphabet[i].ToString())}");
      }

      display("Press any key to exit:");
      Console.ReadKey();
    }
  }
}
