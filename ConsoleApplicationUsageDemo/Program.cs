﻿/*
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
using System;
using System.IO;
using StringFunc = FonctionsUtiles.Fred.Csharp.FunctionsString;
using MathFunc = FonctionsUtiles.Fred.Csharp.FunctionsMath;

namespace ConsoleApplicationUsageDemo
{
  class Program
  {
    static void Main()
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

      Char[] tmpNull = null;
      string rdnString = StringFunc.GenerateRandomString(tmpNull);
      display(string.Empty);
      display("Generation of a random string: " + rdnString);
      display(string.Empty);
      display("Manifest of the DLL: " + StringFunc.Manifest());
      display(string.Empty);
      display("Generation of a 10 random filename strings: ");
      for (int i = 0; i < 10; i++)
      {
        rdnString = StringFunc.GenerateRandomString(new []{' '}, true, StringFunc.RandomCharacters.UpperLowerDigitSpecial, 8, true);
        display("Random filename: " + rdnString);
      }

      string test = Path.GetRandomFileName();
      display(string.Empty);
      display("Generation of a 10 Path.GetRandomFileName: ");
      for (int i = 0; i < 10; i++)
      {
        display("Random filename: " + Path.GetRandomFileName());
      }
      Console.ReadKey();
    }
  }
}