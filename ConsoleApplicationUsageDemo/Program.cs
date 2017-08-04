using System;
using System.IO;
using StringFunc = FonctionsUtiles.Fred.Csharp.FunctionsString;
using enumRnd = FonctionsUtiles.Fred.Csharp.RandomCharacters;
using MathFunc = FonctionsUtiles.Fred.Csharp.FunctionsMath;
using FileFunc = FonctionsUtiles.Fred.Csharp.FunctionsFiles;
using System.Collections.Generic;
using FonctionsUtiles.Fred.Csharp;

namespace ConsoleApplicationUsageDemo
{
  internal class Program
  {
    private static void Main()
    {
      Action<string> display = Console.WriteLine;
      Action<string> displayOnOneLine = Console.Write;
      display("Demo to use the useful functions DLL");
      int[] list = { 1, 2, 3, 1 };
      bool result = StringFunc.HasDuplicate(list);
      display("The array: {1, 2, 3, 1 } has duplicate: " + result);
      display(string.Empty);
      displayOnOneLine("Factorial 3 with lowerBound 2 is ");
      displayOnOneLine(MathFunc.Factorial(3, 2).ToString());
      display(string.Empty);
      displayOnOneLine("IsNumeric of '4' ");
      displayOnOneLine(StringFunc.IsNumeric("4").ToString());

      char[] tmpNull = null;
      // ReSharper disable once ExpressionIsAlwaysNull
      string rdnString = StringFunc.GenerateRandomString(tmpNull);
      display(string.Empty);
      display("Generation of a random string: " + rdnString);
      display(string.Empty);
      display("Manifest of the DLL: " + StringFunc.Manifest());
      display(string.Empty);
      display("Generation of a 10 random filename strings: ");
      for (int i = 0; i < 10; i++)
      {
        rdnString = StringFunc.GenerateRandomString(new[] { ' ' }, true, enumRnd.UpperLowerDigitSpecial, 8, true);
        display("Random filename: " + rdnString);
      }

      string test = Path.GetRandomFileName();
      display(string.Empty);
      display("Generation of a 10 Path.GetRandomFileName: ");
      for (int i = 0; i < 10; i++)
      {
        display("Random filename: " + Path.GetRandomFileName());
      }

      display("Listing all drives:");
      List<DriveInfo> allDir = FileFunc.GetAllDrives(new[] { DriveType.CDRom, DriveType.Network,
      DriveType.Removable});
      foreach (var dirName in allDir)
      {
        display(dirName.ToString());
      }

      display("displaying all directories:");
      var allfilesAndFolders = FileFunc.GetAllDirectories(@"C:\");
      var count = 0;
      foreach (var item in allfilesAndFolders)
      {
        display(item);
        count++;
      }

      display(count + " directories were found");
      display("");
      display("Punctuation characters:");
      display("Period: " + Punctuation.Period);
      display("Backslash: " + Punctuation.Backslash);
      display("Colon: " + Punctuation.Colon);

      Livre dune = new Livre();
      dune.Auteur = "Frank Herbert";
      dune.Prix = 20.00M;
      dune.Titre = "Les enfants de Dune";

      display("Press any key to exit:");
      Console.ReadKey();
    }

    public struct Livre
    {
      public decimal Prix;
      public string Titre;
      public string Auteur;
    }
  }
}