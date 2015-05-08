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
using FonctionsUtiles.Fred.Csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using enumRnd = FonctionsUtiles.Fred.Csharp;

namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestFunctionsFiles
  {
    #region Files Methods
    //**************************GenerateUniqueFileName Methods****
    [TestMethod]
    public void TestMethod_GenerateUniqueFileName_true_length_eight()
    {
      string sourceDir = Path.GetTempPath();
      const int expected = 8;
      string result = FunctionsString.GenerateUniqueFilename(sourceDir, RandomCharacters.UpperLowerDigitSpecial);
      Assert.AreEqual(result.Length, expected);
    }

    [TestMethod]
    public void TestMethod_GenerateUniqueFileName_true_length_twelve()
    {
      string sourceDir = Path.GetTempPath();
      const int expected = 12;
      string result = FunctionsString.GenerateUniqueFilename(sourceDir, RandomCharacters.UpperLowerDigitSpecial, 8, true, "doc");
      Assert.AreEqual(result.Length, expected);
    }

    [TestMethod]
    public void TestMethod_GenerateUniqueFileName_true_length_thirteen()
    {
      string sourceDir = Path.GetTempPath();
      const int expected = 13;
      string result = FunctionsString.GenerateUniqueFilename(sourceDir, RandomCharacters.UpperLowerDigitSpecial, 8, true, "docx");
      Assert.AreEqual(result.Length, expected);
    }

    [TestMethod]
    public void TestMethod_GenerateUniqueFileName_false_file_does_not_exist_in_temp_dir()
    {
      string sourceDir = Path.GetTempPath();
      const bool expected = false;
      string result = FunctionsString.GenerateUniqueFilename(sourceDir, RandomCharacters.UpperLowerDigitSpecial);
      Assert.AreEqual(File.Exists(Path.Combine(sourceDir, result)), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateUniqueFileName_false_file_does_not_exist_in_document_dir()
    {
      string sourceDir = Environment.SpecialFolder.MyDocuments.ToString();
      const bool expected = false;
      string result = FunctionsString.GenerateUniqueFilename(sourceDir, RandomCharacters.UpperLowerDigitSpecial);
      Assert.AreEqual(File.Exists(Path.Combine(sourceDir, result)), expected);
    }

    #endregion Files Methods

  }
}