using FonctionsUtiles.Fred.Csharp;
using System;
using System.Collections.Generic;

namespace ConsoleAppNTLM
{
  class Program
  {
    static void Main()
    {
      Action<string> display = Console.WriteLine;
      ulong count = 0;
      bool addToListe = false;
      List<string> liste = new List<string>();
      string alphabet = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ&é'(-è_çà)=$£*%âêîôûù,;:!?./\\§%µä+°€@<>";
      for (int i = 0; i < alphabet.Length; i++)
      {
        count++;
        string ntlm = FunctionsCrypto.Ntlm(alphabet[i].ToString());
        display($"{alphabet[i]} = {ntlm}");
        if (addToListe)
        {
          liste.Add($"{alphabet[i]};{ntlm}");
        }
      }

      // 101 NTLM calculated so far with 1 character
      for (int i = 0; i < alphabet.Length; i++)
      {
        for (int j = 0; j < alphabet.Length; j++)
        {
          count++;
          string ntlm = FunctionsCrypto.Ntlm(alphabet[i].ToString() + alphabet[j].ToString());
          display($"{alphabet[i]}{alphabet[j]} = {ntlm}");
          if (addToListe)
          {
            liste.Add($"{alphabet[i]}{alphabet[j]};{ntlm}");
          }
        }
      }

      //// 10 302 NTLM calculated so far with 2 characters
      for (int i = 0; i < alphabet.Length; i++)
      {
        for (int j = 0; j < alphabet.Length; j++)
        {
          for (int k = 0; k < alphabet.Length; k++)
          {
            count++;
            string ntlm = FunctionsCrypto.Ntlm(alphabet[i].ToString() + alphabet[j].ToString() + alphabet[k].ToString());
            display($"{alphabet[i]}{alphabet[j]}{alphabet[k]} = {ntlm}");
            if (addToListe)
            {
              liste.Add($"{alphabet[i]}{alphabet[j]}{alphabet[k]};{ntlm}");
            }
          }
        }
      }

      //// 1 040 603 NTLM calculated so far with 3 characters
      for (int i = 0; i < alphabet.Length; i++)
      {
        for (int j = 0; j < alphabet.Length; j++)
        {
          for (int k = 0; k < alphabet.Length; k++)
          {
            for (int l = 0; l < alphabet.Length; l++)
            {
              count++;
              string ntlm = FunctionsCrypto.Ntlm(alphabet[i].ToString() + alphabet[j].ToString() + alphabet[k].ToString() + alphabet[l].ToString());
              display($"{alphabet[i]}{alphabet[j]}{alphabet[k]}{alphabet[l]} = {ntlm}");
              if (addToListe)
              {
                liste.Add($"{alphabet[i]}{alphabet[j]}{alphabet[k]}{alphabet[l]} = {ntlm}");
              }
            }
          }
        }
      }

      // 105 101 004 NTLM calculated so far with 4 characters //out of memory error at 3.6 GB console app if addToListe = true

      for (int i = 0; i < alphabet.Length; i++)
      {
        for (int j = 0; j < alphabet.Length; j++)
        {
          for (int k = 0; k < alphabet.Length; k++)
          {
            for (int l = 0; l < alphabet.Length; l++)
            {
              for (int m = 0; m < alphabet.Length; m++)
              {
                count++;
                string ntlm = FunctionsCrypto.Ntlm(alphabet[i].ToString() + alphabet[j].ToString() + alphabet[k].ToString() + alphabet[l].ToString() + alphabet[m].ToString());
                display($"{alphabet[i]}{alphabet[j]}{alphabet[k]}{alphabet[l]}{alphabet[m]} = {ntlm}");
                if (addToListe)
                {
                  liste.Add($"{alphabet[i]}{alphabet[j]}{alphabet[k]}{alphabet[l]} = {ntlm}");
                }
              }
            }
          }
        }
      }

      // ? NTLM calculated so far with 4 characters

      display(string.Empty);
      display($"There are {count} NTLM hash calculated.");
      display(string.Empty);
      display("Press any key to exit:");
      Console.ReadKey();
    }
  }
}
