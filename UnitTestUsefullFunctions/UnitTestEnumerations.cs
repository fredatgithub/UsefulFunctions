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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using dllFuncs = FonctionsUtiles.Fred.Csharp;

namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestEnumerations
  {
    #region LetterCasingSequence
    // **********************LetterCasingSequence**************
    [TestMethod]
    public void TestMethod_LetterCasingSequence_true_all_enum_exists_no_deleted_item()
    {
      Assert.AreEqual(dllFuncs.LetterCasingSequence.DigitLowerUpper, dllFuncs.LetterCasingSequence.DigitLowerUpper);
      Assert.AreEqual(dllFuncs.LetterCasingSequence.DigitUpperLower, dllFuncs.LetterCasingSequence.DigitUpperLower);
      Assert.AreEqual(dllFuncs.LetterCasingSequence.LowerDigitUpper, dllFuncs.LetterCasingSequence.LowerDigitUpper);
      Assert.AreEqual(dllFuncs.LetterCasingSequence.LowerUpperDigit, dllFuncs.LetterCasingSequence.LowerUpperDigit);
      Assert.AreEqual(dllFuncs.LetterCasingSequence.UpperDigitLower, dllFuncs.LetterCasingSequence.UpperDigitLower);
      Assert.AreEqual(dllFuncs.LetterCasingSequence.UpperLowerDigit, dllFuncs.LetterCasingSequence.UpperLowerDigit);
    }

    [TestMethod]
    public void TestMethod_LetterCasingSequence_false_no_equality()
    {
      Assert.AreNotEqual(dllFuncs.LetterCasingSequence.DigitLowerUpper, dllFuncs.LetterCasingSequence.DigitUpperLower);
      Assert.AreNotEqual(dllFuncs.LetterCasingSequence.DigitUpperLower, dllFuncs.LetterCasingSequence.LowerDigitUpper);
      Assert.AreNotEqual(dllFuncs.LetterCasingSequence.LowerDigitUpper, dllFuncs.LetterCasingSequence.LowerUpperDigit);
      Assert.AreNotEqual(dllFuncs.LetterCasingSequence.LowerUpperDigit, dllFuncs.LetterCasingSequence.UpperDigitLower);
      Assert.AreNotEqual(dllFuncs.LetterCasingSequence.UpperDigitLower, dllFuncs.LetterCasingSequence.UpperLowerDigit);
      Assert.AreNotEqual(dllFuncs.LetterCasingSequence.UpperLowerDigit, dllFuncs.LetterCasingSequence.DigitLowerUpper);
    }

    [TestMethod]
    public void TestMethod_LetterCasingSequence_true_all_enum_exist_by_their_value_number()
    {
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.LetterCasingSequence), 0));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.LetterCasingSequence), 1));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.LetterCasingSequence), 2));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.LetterCasingSequence), 3));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.LetterCasingSequence), 4));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.LetterCasingSequence), 5));
    }

    [TestMethod]
    public void TestMethod_LetterCasingSequence_true_all_enum_exists_with_no_change_in_their_value()
    {
      Assert.AreEqual((int)dllFuncs.LetterCasingSequence.LowerUpperDigit, 0);
      Assert.AreEqual((int)dllFuncs.LetterCasingSequence.UpperLowerDigit, 1);
      Assert.AreEqual((int)dllFuncs.LetterCasingSequence.DigitLowerUpper, 2);
      Assert.AreEqual((int)dllFuncs.LetterCasingSequence.DigitUpperLower, 3);
      Assert.AreEqual((int)dllFuncs.LetterCasingSequence.LowerDigitUpper, 4);
      Assert.AreEqual((int)dllFuncs.LetterCasingSequence.UpperDigitLower, 5);
    }
    #endregion LetterCasingSequence
    #region DefaultCasing
    [TestMethod]
    public void TestMethod_DefaultCasing_true_all_enum_exists_no_deleted_item()
    {
      Assert.AreEqual(dllFuncs.DefaultCasing.defaultAsIs, dllFuncs.DefaultCasing.defaultAsIs);
      Assert.AreEqual(dllFuncs.DefaultCasing.defaultLowerCase, dllFuncs.DefaultCasing.defaultLowerCase);
      Assert.AreEqual(dllFuncs.DefaultCasing.defaultUpperCase, dllFuncs.DefaultCasing.defaultUpperCase);
    }

    [TestMethod]
    public void TestMethod_DefaultCasing_false_no_equality()
    {
      Assert.AreNotEqual(dllFuncs.DefaultCasing.defaultAsIs, dllFuncs.DefaultCasing.defaultUpperCase);
      Assert.AreNotEqual(dllFuncs.DefaultCasing.defaultLowerCase, dllFuncs.DefaultCasing.defaultAsIs);
      Assert.AreNotEqual(dllFuncs.DefaultCasing.defaultUpperCase, dllFuncs.DefaultCasing.defaultLowerCase);
    }

    [TestMethod]
    public void TestMethod_DefaultCasing_true_all_enum_exist_by_their_value_number()
    {
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.DefaultCasing), 0));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.DefaultCasing), 1));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.DefaultCasing), 2));
    }

    [TestMethod]
    public void TestMethod_DefaultCasing_true_all_enum_exists_with_no_change_in_their_value()
    {
      Assert.AreEqual((int)dllFuncs.DefaultCasing.defaultLowerCase, 0);
      Assert.AreEqual((int)dllFuncs.DefaultCasing.defaultUpperCase, 1);
      Assert.AreEqual((int)dllFuncs.DefaultCasing.defaultAsIs, 2);
    }
    #endregion DefaultCasing
    #region SearchedLanguage
    //**************************************************SearchedLanguage**************************************
    [TestMethod]
    public void TestMethod_SearchedLanguage_true_all_enum_exists_no_deleted_item()
    {
      Assert.AreEqual(dllFuncs.SearchedLanguage.English, dllFuncs.SearchedLanguage.English);
      Assert.AreEqual(dllFuncs.SearchedLanguage.French, dllFuncs.SearchedLanguage.French);
      Assert.AreEqual(dllFuncs.SearchedLanguage.FrenchAndEnglish, dllFuncs.SearchedLanguage.FrenchAndEnglish);
      Assert.AreEqual(dllFuncs.SearchedLanguage.NoLanguageChosen, dllFuncs.SearchedLanguage.NoLanguageChosen);
    }

    [TestMethod]
    public void TestMethod_SearchedLanguage_false_no_equality()
    {
      Assert.AreNotEqual(dllFuncs.SearchedLanguage.English, dllFuncs.SearchedLanguage.French);
      Assert.AreNotEqual(dllFuncs.SearchedLanguage.French, dllFuncs.SearchedLanguage.English);
      Assert.AreNotEqual(dllFuncs.SearchedLanguage.FrenchAndEnglish, dllFuncs.SearchedLanguage.NoLanguageChosen);
      Assert.AreNotEqual(dllFuncs.SearchedLanguage.NoLanguageChosen, dllFuncs.SearchedLanguage.FrenchAndEnglish);
    }

    [TestMethod]
    public void TestMethod_SearchedLanguage_true_all_enum_exist_by_their_value_number()
    {
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.SearchedLanguage), 0));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.SearchedLanguage), 1));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.SearchedLanguage), 2));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.SearchedLanguage), 3));
    }

    [TestMethod]
    public void TestMethod_SearchedLanguage_true_all_enum_exists_with_no_change_in_their_value()
    {
      Assert.AreEqual((int)dllFuncs.SearchedLanguage.NoLanguageChosen, 0);
      Assert.AreEqual((int)dllFuncs.SearchedLanguage.French, 1);
      Assert.AreEqual((int)dllFuncs.SearchedLanguage.English, 2);
      Assert.AreEqual((int)dllFuncs.SearchedLanguage.FrenchAndEnglish, 3);
    }
    #endregion SearchedLanguage

  }
}