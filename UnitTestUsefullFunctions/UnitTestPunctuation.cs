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

using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringFunc = FonctionsUtiles.Fred.Csharp.FunctionsString;
using dllFuncs = FonctionsUtiles.Fred.Csharp;
namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestPunctuation
  {
    #region CreateSentence
    [TestMethod]
    public void TestMethod_Punctuation_no_argument()
    {
      string[] source = {};
      const string expected = "";
      string result = dllFuncs.Punctuation.CreateSentence(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_one_argument()
    {
      string[] source = { dllFuncs.Punctuation.Comma};
      const string expected = ",";
      string result = dllFuncs.Punctuation.CreateSentence(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_two_argument()
    {
      string[] source = { dllFuncs.Punctuation.Comma, dllFuncs.Punctuation.Dash };
      const string expected = ",-";
      string result = dllFuncs.Punctuation.CreateSentence(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Punctuation_three_argument()
    {
      string[] source = { dllFuncs.Punctuation.SemiColon, dllFuncs.Punctuation.Backslash, "notepad.exe" };
      const string expected = ";\\notepad.exe";
      string result = dllFuncs.Punctuation.CreateSentence(source);
      Assert.AreEqual(result, expected);
    }

    #endregion
  }
}