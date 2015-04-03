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
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using FonctionsUtiles.Fred.Csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestMethodsString
  {
    #region Math Methods
    #region Math Methods - Factorial
    [TestMethod]
    public void TestMethod_Factorial_one()
    {
      TestFactorial(1, 1);
    }

    public void TestFactorial(long numberToBeTested, long resultExpected)
    {
      long testedNumber = numberToBeTested;
      long expected = resultExpected;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_two()
    {
      TestFactorial(2, 2);
    }

    [TestMethod]
    public void TestMethod_Factorial_three()
    {
      TestFactorial(3, 6);
    }

    [TestMethod]
    public void TestMethod_Factorial_four()
    {
      TestFactorial(4, 24);
    }

    [TestMethod]
    public void TestMethod_Factorial_five()
    {
      const long testedNumber = 5;
      const long expected = 120;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_six()
    {
      const long testedNumber = 6;
      const long expected = 720;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_seven()
    {
      const long testedNumber = 7;
      const long expected = 5040;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_eight()
    {
      const long testedNumber = 8;
      const long expected = 40320;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_nine()
    {
      const long testedNumber = 9;
      const long expected = 362880;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_ten()
    {
      const long testedNumber = 10;
      const long expected = 3628800;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_eleven()
    {
      const long testedNumber = 11;
      const long expected = 39916800;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_twelve()
    {
      const long testedNumber = 12;
      const long expected = 479001600;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_thirteen()
    {
      const long testedNumber = 13;
      const long expected = 6227020800;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_fourteen()
    {
      const long testedNumber = 14;
      const long expected = 87178291200;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_fifteen()
    {
      const long testedNumber = 15;
      const long expected = 1307674368000;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_sixteen()
    {
      const long testedNumber = 16;
      const long expected = 20922789888000;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_seventeen()
    {
      const long testedNumber = 17;
      const long expected = 355687428096000;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_eighteen()
    {
      const long testedNumber = 18;
      const long expected = 6402373705728000;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_nineteen()
    {
      const long testedNumber = 19;
      const long expected = 121645100408832000;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_twenty()
    {
      const long testedNumber = 20;
      const long expected = 2432902008176640000;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_twentyOne()
    {
      long result = FunctionsMath.Factorial(21);
      Assert.IsTrue(result < 0); // negative number
    }

    [TestMethod]
    public void TestMethod_Factorial_Negative_number()
    {
      const long testedNumber = -3;
      const long expected = 0;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_zero()
    {
      const long testedNumber = 0;
      const long expected = 0;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_lowerBound_one_step()
    {
      const long testedNumber1 = 10;
      const long testedNumber2 = 9;
      const long expected = 10;
      long result = FunctionsMath.Factorial(testedNumber1, testedNumber2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_lowerBound_two_step()
    {
      const long testedNumber1 = 10;
      const long testedNumber2 = 8;
      const long expected = 90;
      long result = FunctionsMath.Factorial(testedNumber1, testedNumber2);
      Assert.AreEqual(result, expected);
    }

    // *******************************BigInt Method******
    [TestMethod]
    public void TestMethod_Factorial_BigInt_one()
    {
      BigInt source = 1;
      BigInt expected = 1;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_two()
    {
      BigInt source = 2;
      BigInt expected = 2;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }
    #endregion Math Methods - Factorial


    #region Math Methods - Recursive Factorial
    // **********************Recursive Factorial****************
    [TestMethod]
    public void TestMethod_RecursiveFactorial_one()
    {
      ulong result = FunctionsMath.RecursiveFactorial(1);
      Assert.IsTrue(result == 1);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_two()
    {
      ulong result = FunctionsMath.RecursiveFactorial(2);
      Assert.IsTrue(result == 2);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_three()
    {
      ulong result = FunctionsMath.RecursiveFactorial(3);
      Assert.IsTrue(result == 6);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_four()
    {
      ulong result = FunctionsMath.RecursiveFactorial(4);
      Assert.IsTrue(result == 24);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_five()
    {
      ulong result = FunctionsMath.RecursiveFactorial(5);
      Assert.IsTrue(result == 120);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_six()
    {
      ulong result = FunctionsMath.RecursiveFactorial(6);
      Assert.IsTrue(result == 720);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_seven()
    {
      ulong result = FunctionsMath.RecursiveFactorial(7);
      Assert.IsTrue(result == 5040);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_eight()
    {
      ulong result = FunctionsMath.RecursiveFactorial(8);
      Assert.IsTrue(result == 40320);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_nine()
    {
      ulong result = FunctionsMath.RecursiveFactorial(9);
      Assert.IsTrue(result == 362880);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_ten()
    {
      ulong result = FunctionsMath.RecursiveFactorial(10);
      Assert.IsTrue(result == 3628800);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_eleven()
    {
      ulong result = FunctionsMath.RecursiveFactorial(11);
      Assert.IsTrue(result == 39916800);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_twelve()
    {
      ulong result = FunctionsMath.RecursiveFactorial(12);
      Assert.IsTrue(result == 479001600);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_thirteen()
    {
      ulong result = FunctionsMath.RecursiveFactorial(13);
      Assert.IsTrue(result == 6227020800);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_fourteen()
    {
      ulong result = FunctionsMath.RecursiveFactorial(14);
      Assert.IsTrue(result == 87178291200);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_fifteen()
    {
      ulong result = FunctionsMath.RecursiveFactorial(15);
      Assert.IsTrue(result == 1307674368000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_sixteen()
    {
      ulong result = FunctionsMath.RecursiveFactorial(16);
      Assert.IsTrue(result == 20922789888000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_seventeen()
    {
      ulong result = FunctionsMath.RecursiveFactorial(17);
      Assert.IsTrue(result == 355687428096000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_eighteen()
    {
      ulong result = FunctionsMath.RecursiveFactorial(18);
      Assert.IsTrue(result == 6402373705728000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_nineteen()
    {
      ulong result = FunctionsMath.RecursiveFactorial(19);
      Assert.IsTrue(result == 121645100408832000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_twenty()
    {
      ulong result = FunctionsMath.RecursiveFactorial(20);
      Assert.IsTrue(result == 2432902008176640000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_twentyOne()
    {
      ulong result = FunctionsMath.RecursiveFactorial(21);
      Assert.IsTrue(result == 14197454024290336768);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_Negative_number()
    {
      ulong result = FunctionsMath.RecursiveFactorial(-3);
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_zero()
    {
      ulong result = FunctionsMath.RecursiveFactorial(0);
      Assert.IsTrue(result == 0);
    }
    #endregion Math Methods - Recursive Factorial
    #region Math Methods - Sommielle
    // **********************Sommielle****************
    [TestMethod]
    public void TestMethod_Sommielle_zero()
    {
      long result = FunctionsMath.Sommielle(0, 0);
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_Sommielle_one_interval()
    {
      long result = FunctionsMath.Sommielle(0, 1);
      Assert.IsTrue(result == 1);
    }

    [TestMethod]
    public void TestMethod_Sommielle_two_interval()
    {
      long result = FunctionsMath.Sommielle(1, 3);
      Assert.IsTrue(result == 6);
    }

    [TestMethod]
    public void TestMethod_Sommielle_inverted_max_min()
    {
      long result = FunctionsMath.Sommielle(3, 1);
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_Sommielle_zero_ten()
    {
      long result = FunctionsMath.Sommielle(0, 10);
      Assert.IsTrue(result == 55);
    }

    [TestMethod]
    public void TestMethod_Sommielle_zero_twentyFour()
    {
      long result = FunctionsMath.Sommielle(0, 24);
      Assert.IsTrue(result == 300);
    }

    [TestMethod]
    public void TestMethod_Sommielle_zero_fifty()
    {
      long result = FunctionsMath.Sommielle(0, 50);
      Assert.IsTrue(result == 1275);
    }

    [TestMethod]
    public void TestMethod_Sommielle_ten_ten()
    {
      long result = FunctionsMath.Sommielle(10, 10);
      Assert.IsTrue(result == 10);
    }

    [TestMethod]
    public void TestMethod_Sommielle_zero_hundred()
    {
      long result = FunctionsMath.Sommielle(0, 100);
      Assert.IsTrue(result == 5050);
    }

    [TestMethod]
    public void TestMethod_Sommielle_zero_hundredAndFifty()
    {
      long result = FunctionsMath.Sommielle(0, 150);
      Assert.IsTrue(result == 11325);
    }
    #endregion Math Methods - Sommielle
    #region Math Methods - Sommielle Recursive
    // **********************Sommielle Recursive****************
    [TestMethod]
    public void TestMethod_SommielleRecursive_zero()
    {
      long result = FunctionsMath.SommielleRecursive(0, 0);
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_one_interval()
    {
      long result = FunctionsMath.SommielleRecursive(0, 1);
      Assert.IsTrue(result == 1);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_two_interval()
    {
      long result = FunctionsMath.SommielleRecursive(1, 3);
      Assert.IsTrue(result == 6);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_inverted_max_min()
    {
      long result = FunctionsMath.SommielleRecursive(3, 1);
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_zero_ten()
    {
      long result = FunctionsMath.SommielleRecursive(0, 10);
      Assert.IsTrue(result == 55);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_zero_twentyFour()
    {
      long result = FunctionsMath.SommielleRecursive(0, 24);
      Assert.IsTrue(result == 300);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_zero_fifty()
    {
      long result = FunctionsMath.SommielleRecursive(0, 50);
      Assert.IsTrue(result == 1275);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_ten_ten()
    {
      long result = FunctionsMath.SommielleRecursive(10, 10);
      Assert.IsTrue(result == 10);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_zero_hundred()
    {
      long result = FunctionsMath.SommielleRecursive(0, 100);
      Assert.IsTrue(result == 5050);
    }
    #endregion Math Methods - Sommielle Recursive

    #endregion Math Methods
    #region String Methods

    //**********************String Methods***************
    [TestMethod]
    public void TestMethod_HasDuplicate_no_on_One_item()
    {
      int[] source = { 1 };
      bool result = FunctionsString.HasDuplicate(source);
      Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_yes_on_Two_items()
    {
      int[] source = { 1, 1 };
      bool result = FunctionsString.HasDuplicate(source);
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_no_on_Two_items()
    {
      int[] source = { 1, 2 };
      bool result = FunctionsString.HasDuplicate(source);
      Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_none()
    {
      int[] source = { 1, 2, 3, 4 };
      bool result = FunctionsString.HasDuplicate(source);
      Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_yes_on_Empty_list_because_all_items_equal_zero()
    {
      int[] source = new int[5];
      bool result = FunctionsString.HasDuplicate(source);
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_null_list()
    {
      int[] source = null;
      bool result = FunctionsString.HasDuplicate(source);
      Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_no_on_several_items()
    {
      bool result = FunctionsString.HasDuplicate(1, 2, 3, 4, 5, 6, 7, 8, 9);
      Assert.IsFalse(result);
    }


    [TestMethod]
    public void TestMethod_HasDuplicate_yes_on_several_items()
    {
      bool result = FunctionsString.HasDuplicate(1, 2, 3, 4, 5, 6, 7, 8, 9, 1);
      Assert.IsTrue(result);
    }
    
    // **********************EndPadding****************
    [TestMethod]
    public void TestMethod_EndPadding()
    {
      string result = FunctionsString.EndPadding("azerty", 8);
      Assert.IsTrue(result == "azerty  ");
    }

    [TestMethod]
    public void TestMethod_EndPadding_length()
    {
      string result = FunctionsString.EndPadding("azerty", 8);
      Assert.IsTrue(result.Length == 8);
    }

    [TestMethod]
    public void TestMethod_EndPadding_none_length()
    {
      string result = FunctionsString.EndPadding("azerty", 6);
      Assert.IsTrue(result.Length == 6);
    }

    [TestMethod]
    public void TestMethod_EndPadding_none_string()
    {
      string result = FunctionsString.EndPadding("azerty", 6);
      Assert.IsTrue(result == "azerty");
    }

    // **********************GetFileNameAfterLastSlash****************
    [TestMethod]
    public void TestMethod_GetFileNameAfterLastSlash()
    {
      string result = FunctionsString.GetFileNameAfterLastSlash(@"C:\tmp\texte.txt");
      Assert.IsTrue(result == "texte.txt");
    }

    [TestMethod]
    public void TestMethod_GetFileNameAfterLastSlash_empty_string()
    {
      string result = FunctionsString.GetFileNameAfterLastSlash(@"");
      Assert.IsTrue(result == "");
    }

    [TestMethod]
    public void TestMethod_GetFileNameAfterLastSlash_no_path()
    {
      string result = FunctionsString.GetFileNameAfterLastSlash(@"texte.txt");
      Assert.IsTrue(result == "texte.txt");
    }

    // **********************RemoveInString****************
    [TestMethod]
    public void TestMethod_RemoveInString()
    {
      string result = FunctionsString.RemoveInString("azerty", "azertyuiop");
      Assert.IsTrue(result == "uiop");
    }

    [TestMethod]
    public void TestMethod_RemoveInString_with_trim_end_equal_to_true()
    {
      string result = FunctionsString.RemoveInString("azerty", "azertyuiop ", true);
      Assert.IsTrue(result == "uiop");
    }

    [TestMethod]
    public void TestMethod_RemoveInString_with_trim_end_equal_to_false()
    {
      string result = FunctionsString.RemoveInString("azerty", "azertyuiop ");
      Assert.IsTrue(result == "uiop ");
    }

    [TestMethod]
    public void TestMethod_RemoveInString__nothing()
    {
      string result = FunctionsString.RemoveInString("azerty", "uiop");
      Assert.IsTrue(result == "uiop");
    }

    // **********************CamelCase****************
    [TestMethod]
    public void TestMethod_CamelCase_a_sentence()
    {
      string result = FunctionsString.CamelCase("once upon a time");
      Assert.IsTrue(result == "Once Upon A Time");
    }

    [TestMethod]
    public void TestMethod_CamelCase_one_word()
    {
      string result = FunctionsString.CamelCase("azerty");
      Assert.IsTrue(result == "Azerty");
    }

    [TestMethod]
    public void TestMethod_CamelCase_string_empty()
    {
      string result = FunctionsString.CamelCase("");
      Assert.IsTrue(result == "");
    }

    // **********************IsNumeric****************
    [TestMethod]
    public void TestMethod_IsNumeric_A_character()
    {
      bool result = FunctionsString.IsNumeric('a');
      Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod_IsNumeric_a_digit()
    {
      bool result = FunctionsString.IsNumeric("4");
      Assert.IsTrue(result);
    }

    // **********************IsLetter****************
    [TestMethod]
    public void TestMethod_IsLetter_()
    {
      bool result = FunctionsString.IsLetter('a');
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestMethod_IsLetter_upperCase()
    {
      bool result = FunctionsString.IsLetter('A');
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestMethod_IsLetter_upperCase_blank()
    {
      bool result = FunctionsString.IsLetter(' ');
      Assert.IsFalse(result);
    }

    // **********************Plural****************
    [TestMethod]
    public void TestMethod_Plural_zero()
    {
      string expected = string.Empty;
      string result = FunctionsString.Plural(0);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_one()
    {
      string expected = string.Empty;
      string result = FunctionsString.Plural(1);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Plural_two()
    {
      string expected = "s";
      string result = FunctionsString.Plural(2);
      Assert.AreEqual(result, expected);
    }

    // **********************StringOccurrenceWithContains****************
    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains()
    {
      int result = FunctionsString.StringOccurrenceWithContains("azerty", "zer");
      Assert.IsTrue(result == 1);
    }

    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains_search_empty_string()
    {
      int result = FunctionsString.StringOccurrenceWithContains("azerty", "");
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains_with_empty_string()
    {
      int result = FunctionsString.StringOccurrenceWithContains("", "azerty");
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains_both_empty_string()
    {
      int result = FunctionsString.StringOccurrenceWithContains("", "");
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains_two_occurences()
    {
      int result = FunctionsString.StringOccurrenceWithContains("azertyqwerty", "erty");
      Assert.IsTrue(result == 2);
    }

    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains_three_occurences()
    {
      int result = FunctionsString.StringOccurrenceWithContains("azertyqwertyandanyothererty", "erty");
      Assert.IsTrue(result == 3);
    }

    // **********************ByteArrayToHexaString****************
    [TestMethod]
    public void TestMethod_ByteArrayToHexaString_two_elements()
    {
      byte[] source = new byte[2];
      source[0] = 0x01;
      source[1] = 0x02;
      string result = FunctionsString.ByteArrayToHexaString(source);
      Assert.IsTrue(result == "0102");
    }

    [TestMethod]
    public void TestMethod_ByteArrayToHexaString_two_elements_OneDigitOnly()
    {
      byte[] source = new byte[2];
      source[0] = 0x01;
      source[1] = 0x02;
      string result = FunctionsString.ByteArrayToHexaString(source, true);
      Assert.IsTrue(result == "12");
    }

    [TestMethod]
    public void TestMethod_ByteArrayToHexaString_three_elements()
    {
      byte[] source = { 0x01, 0x02, 0x03 };
      string result = FunctionsString.ByteArrayToHexaString(source);
      Assert.IsTrue(result == "010203");
    }

    [TestMethod]
    public void TestMethod_ByteArrayToHexaString_three_elements_OneDigitOnly()
    {
      byte[] source = { 0x01, 0x02, 0x03 };
      string result = FunctionsString.ByteArrayToHexaString(source, true);
      Assert.IsTrue(result == "123");
    }

    [TestMethod]
    public void TestMethod_ByteArrayToHexaString_empty_source()
    {
      byte[] source = { };
      string result = FunctionsString.ByteArrayToHexaString(source);
      Assert.IsTrue(result == "");
    }

    [TestMethod]
    public void TestMethod_ByteArrayToHexaString_empty_source_OneDigitOnly()
    {
      byte[] source = { };
      string result = FunctionsString.ByteArrayToHexaString(source, true);
      Assert.IsTrue(result == "");
    }

    // **********************HexaStringToByteArray****************
    [TestMethod]
    public void TestMethod_HexaStringToByteArray_three_elements()
    {
      const string source = "010203";
      byte[] result2 = new byte[3];
      result2[0] = 0x01;
      result2[1] = 0x02;
      result2[2] = 0x03;
      byte[] result = FunctionsString.HexaStringToByteArray(source);
      Assert.AreEqual(result[0], result2[0]);
      Assert.AreEqual(result[1], result2[1]);
      Assert.AreEqual(result[2], result2[2]);
    }

    [TestMethod]
    public void TestMethod_HexaStringToByteArray_one_element()
    {
      const string source = "01";
      byte[] result2 = new byte[1];
      result2[0] = 0x01;
      byte[] result = FunctionsString.HexaStringToByteArray(source);
      Assert.AreEqual(result[0], result2[0]);
    }

    [TestMethod]
    public void TestMethod_HexaStringToByteArray_empty_string()
    {
      // TODO debug
      //const string source = "";
      //byte[] expected = new byte[0];
      //byte[] result = StringFunc.HexaStringToByteArray(source);
      //Assert.AreEqual(result, expected);
    }

    // **********************ReverseString****************
    [TestMethod]
    public void TestMethod_ReverseString()
    {
      const string source = "123456789";
      string result = FunctionsString.ReverseString(source);
      Assert.IsTrue(result == "987654321");
    }

    [TestMethod]
    public void TestMethod_ReverseString_on_an_empty_string()
    {
      const string source = "";
      string result = FunctionsString.ReverseString(source);
      Assert.IsTrue(result == "");
    }

    [TestMethod]
    public void TestMethod_ReverseString_one_element()
    {
      const string source = "1";
      string result = FunctionsString.ReverseString(source);
      Assert.IsTrue(result == "1");
    }

    [TestMethod]
    public void TestMethod_ReverseString_palindrome()
    {
      const string source = "laval";
      string result = FunctionsString.ReverseString(source);
      Assert.IsTrue(result == source);
    }

    [TestMethod]
    public void TestMethod_ReverseString_several_palindromes()
    {
      List<string> sourceWords = new List<string> { "laval", "lol", "ete", "lieur à rueil" };
      foreach (string source in sourceWords)
      {
        string result = FunctionsString.ReverseString(source);
        Assert.IsTrue(result == source);
      }
    }

    [TestMethod]
    public void TestMethod_ReverseString_several_palindromes_with_removal_of_space()
    {
      List<string> sourceWords = new List<string> { "esope reste ici et se repose", "éric notre valet alla te laver ton ciré" };
      foreach (string source in sourceWords)
      {
        string result = FunctionsString.ReverseString(source, true);
        Assert.IsTrue(result == source.Replace(" ", ""));
      }
    }

    // **********************ReverseString2****************
    [TestMethod]
    public void TestMethod_ReverseString2()
    {
      const string source = "123456789";
      string result = FunctionsString.ReverseString2(source);
      Assert.IsTrue(result == "987654321");
    }

    [TestMethod]
    public void TestMethod_ReverseString2_on_an_empty_string()
    {
      const string source = "";
      string result = FunctionsString.ReverseString2(source);
      Assert.IsTrue(result == "");
    }

    [TestMethod]
    public void TestMethod_ReverseString2_one_element()
    {
      const string source = "1";
      string result = FunctionsString.ReverseString2(source);
      Assert.IsTrue(result == "1");
    }

    [TestMethod]
    public void TestMethod_ReverseString2_palindrome()
    {
      const string source = "laval";
      string result = FunctionsString.ReverseString2(source);
      Assert.IsTrue(result == source);
    }

    [TestMethod]
    public void TestMethod_ReverseString2_several_palindromes()
    {
      List<string> sourceWords = new List<string> { "laval", "lol", "ete", "lieur à rueil" };
      foreach (string source in sourceWords)
      {
        string result = FunctionsString.ReverseString2(source);
        Assert.IsTrue(result == source);
      }
    }

    [TestMethod]
    public void TestMethod_ReverseString2_several_palindromes_with_removal_of_space()
    {
      List<string> sourceWords = new List<string> { "esope reste ici et se repose", "éric notre valet alla te laver ton ciré" };
      foreach (string source in sourceWords)
      {
        string result = FunctionsString.ReverseString2(source, true);
        Assert.IsTrue(result == source.Replace(" ", ""));
      }
    }

    // **********************CompletePrefixWithZero****************
    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_one()
    {
      const string source = "1";
      string result = FunctionsString.CompletePrefixWithZero(source);
      Assert.IsTrue(result == "01");
    }

    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_nine()
    {
      const string source = "9";
      string result = FunctionsString.CompletePrefixWithZero(source);
      Assert.IsTrue(result == "09");
    }

    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_two_digits()
    {
      const string source = "12";
      string result = FunctionsString.CompletePrefixWithZero(source);
      Assert.IsTrue(result == "12");
    }

    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_one_integer()
    {
      const int source = 1;
      string result = FunctionsString.CompletePrefixeWithZeroInt(source);
      Assert.IsTrue(result == "01");
    }

    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_nine_integer()
    {
      const int source = 9;
      string result = FunctionsString.CompletePrefixeWithZeroInt(source);
      Assert.IsTrue(result == "09");
    }

    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_two_digits_integer()
    {
      const int source = 12;
      string result = FunctionsString.CompletePrefixeWithZeroInt(source);
      Assert.IsTrue(result == "12");
    }


    // **********************ArrayToString****************
    [TestMethod]
    public void TestMethod_ArrayToString_one_element()
    {
      byte[] source = new byte[1];
      source[0] = 0x01;
      const string result2 = "1";
      string result = FunctionsString.ArrayToString(source);
      Assert.AreEqual(result, result2);
    }

    [TestMethod]
    public void TestMethod_ArrayToString_two_elements()
    {
      byte[] source = new byte[2];
      source[0] = 0x01;
      source[1] = 0x02;
      string result2 = "1" + Environment.NewLine + "2";
      string result = FunctionsString.ArrayToString(source);
      Assert.AreEqual(result, result2);
    }

    [TestMethod]
    public void TestMethod_ArrayToString_three_elements()
    {
      byte[] source = new byte[3];
      source[0] = 0x01;
      source[1] = 0x02;
      source[2] = 0x03;
      string result2 = "1" + Environment.NewLine + "2" + Environment.NewLine + "3";
      string result = FunctionsString.ArrayToString(source);
      Assert.AreEqual(result, result2);
    }

    // **********************ArrayToStringWithStringBuilder****************
    [TestMethod]
    public void TestMethod_ArrayToStringWithStringBuilder_one_element()
    {
      byte[] source = new byte[1];
      source[0] = 0x01;
      const string result2 = "1";
      string result = FunctionsString.ArrayToStringWithStringBuilder(source);
      Assert.AreEqual(result, result2);
    }

    [TestMethod]
    public void TestMethod_ArrayToStringWithStringBuilder_two_elements()
    {
      byte[] source = new byte[2];
      source[0] = 0x01;
      source[1] = 0x02;
      string result2 = "1" + Environment.NewLine + "2";
      string result = FunctionsString.ArrayToString(source);
      Assert.AreEqual(result, result2);
    }

    [TestMethod]
    public void TestMethod_ArrayToStringWithStringBuilder_three_elements()
    {
      byte[] source = new byte[3];
      source[0] = 0x01;
      source[1] = 0x02;
      source[2] = 0x03;
      string result2 = "1" + Environment.NewLine + "2" + Environment.NewLine + "3";
      string result = FunctionsString.ArrayToString(source);
      Assert.AreEqual(result, result2);
    }

    // **********************InsertSeparatorForEachCharacter****************
    [TestMethod]
    public void TestMethod_InsertSeparatorForEachCharacter_one_string()
    {
      const string source = "azerty";
      const string expected = "a z e r t y";
      string result = FunctionsString.InsertSeparatorForEachCharacter(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_InsertSeparatorForEachCharacter_empty_string()
    {
      const string source = "";
      const string expected = "";
      string result = FunctionsString.InsertSeparatorForEachCharacter(source);
      Assert.AreEqual(result, expected);
    }

    // **********************InsertSeparatorAtInterval****************
    [TestMethod]
    public void TestMethod_InsertSeparatorAtInterval_one_element()
    {
      const string source = "azerty";
      const string expected = "az er ty";
      string result = FunctionsString.InsertSeparatorAtInterval(source, " ", 2);
      Assert.AreEqual(result, expected);
    }

    // **********************RemoveVowels****************
    [TestMethod]
    public void TestMethod_RemoveVowels_one_string()
    {
      const string source = "azerty";
      const string expected = "zrt";
      string result = FunctionsString.RemoveVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemoveVowels_empty_string()
    {
      const string source = "";
      const string expected = "";
      string result = FunctionsString.RemoveVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemoveVowels_only_vowels()
    {
      const string source = "aeiouy";
      const string expected = "";
      string result = FunctionsString.RemoveVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemoveVowels_only_consonant()
    {
      const string source = "qsdfghjklm";
      const string expected = "qsdfghjklm";
      string result = FunctionsString.RemoveVowels(source);
      Assert.AreEqual(result, expected);
    }

    // **********************KeepVowels****************
    [TestMethod]
    public void TestMethod_KeepVowels_one_string()
    {
      const string source = "azerty";
      const string expected = "aey";
      string result = FunctionsString.KeepVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_KeepVowels_empty_string()
    {
      const string source = "";
      const string expected = "";
      string result = FunctionsString.KeepVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_KeepVowels_only_vowels()
    {
      const string source = "aeiouy";
      const string expected = "aeiouy";
      string result = FunctionsString.KeepVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_KeepVowels_only_consonant()
    {
      const string source = "qsdfghjklm";
      const string expected = "";
      string result = FunctionsString.KeepVowels(source);
      Assert.AreEqual(result, expected);
    }

    // **********************AlternateCases****************
    [TestMethod]
    public void TestMethod_AlternateCases_one_string()
    {
      const string source = "TheWonderfulMethodThatDoesALotOfThings";
      const string expected = "ThEwOnDeRfUlMeThOdThAtDoEsAlOtOfThInGs";
      string result = FunctionsString.AlternateCases(source);
      Assert.AreEqual(result, expected);
    }

    // **********************Capitalize****************
    [TestMethod]
    public void TestMethod_Capitalize_one_string()
    {
      const string source = "once upon a time in a galaxy far far away";
      const string expected = "Once upon a time in a galaxy far far away";
      string result = FunctionsString.Capitalize(source);
      Assert.AreEqual(result, expected);
    }

    // **********************GetInitials****************
    [TestMethod]
    public void TestMethod_GetInitials_one_string()
    {
      const string source = "once upon a time in a galaxy far far away";
      const string expected = "ouatiagffa";
      string result = FunctionsString.GetInitials(source, " ", false, false, false);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetInitials_empty_string()
    {
      const string source = "";
      const string expected = "";
      string result = FunctionsString.GetInitials(source, " ", false, false, false);
      Assert.AreEqual(result, expected);
    }

    // **********************GetTitle****************
    [TestMethod]
    public void TestMethod_GetTitle_one_string()
    {
      const string source = "once upon a time in a galaxy far far away";
      const string expected = "Once Upon A Time In A Galaxy Far Far Away";
      string result = FunctionsString.GetTitle(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetTitleGetInitials_empty_string()
    {
      const string source = "";
      const string expected = "";
      string result = FunctionsString.GetTitle(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetTitle_one_string_with_separator()
    {
      const string source = "once upon a time in a galaxy far far away";
      const string expected = "Once Upon A Time In A Galaxy Far Far Away";
      string result = FunctionsString.GetTitle(source, " ");
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetTitle_one_string_with_underscore_separator()
    {
      const string source = "once_upon_a_time_in_a_galaxy_far_far_away";
      const string expected = "Once_Upon_A_Time_In_A_Galaxy_Far_Far_Away";
      string result = FunctionsString.GetTitle(source, "_");
      Assert.AreEqual(result, expected);
    }

    // **********************SubstringEnd****************
    [TestMethod]
    public void TestMethod_SubstringEnd_first_character()
    {
      const string source = "once upon a time in a galaxy far far away";
      const string expected = "o";
      string result = FunctionsString.SubstringEnd(source, 0, 1);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_SubstringEnd_start_equals_end()
    {
      const string source = "once upon a time in a galaxy far far away";
      const string expected = "";
      string result = FunctionsString.SubstringEnd(source, 0, 0);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_SubstringEnd_two_characters()
    {
      const string source = "once upon a time in a galaxy far far away";
      const string expected = "nc";
      string result = FunctionsString.SubstringEnd(source, 1, 2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_SubstringEnd_four_characters()
    {
      const string source = "once upon a time in a galaxy far far away";
      const string expected = "time";
      string result = FunctionsString.SubstringEnd(source, 12, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_SubstringEnd_end_character()
    {
      const string source = "azerty";
      const string expected = "y";
      string result = FunctionsString.SubstringEnd(source, source.Length - 1, 1);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_SubstringEnd_one_character()
    {
      const string source = "azerty";
      const string expected = "e";
      string result = FunctionsString.SubstringEnd(source, 2, 1);
      Assert.AreEqual(result, expected);
    }

    // **********************CharRight****************
    [TestMethod]
    public void TestMethod_CharRight()
    {
      const string source = "once upon a time in a galaxy far far away";
      const char expected = 'y';
      char result = FunctionsString.CharRight(source, 0);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CharRight_empty_character()
    {
      const string source = "";
      const char expected = new char();
      char result = FunctionsString.CharRight(source, 0);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CharRight_one_character()
    {
      const string source = "qwerty";
      const char expected = 'e';
      char result = FunctionsString.CharRight(source, 3);
      Assert.AreEqual(result, expected);
    }

    // **********************CharMid****************
    [TestMethod]
    public void TestMethod_CharMid()
    {
      const string source = "once upon a time in a galaxy far far away";
      const char expected = 'n';
      char result = FunctionsString.CharMid(source, 0, 1);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CharMid_empty_string()
    {
      const string source = "";
      const char expected = new char();
      char result = FunctionsString.CharMid(source, 0, 0);
      Assert.AreEqual(result, expected);
    }

    // **********************CountString****************
    [TestMethod]
    public void TestMethod_CountString()
    {
      const string source = "once upon a time in a galaxy far far away";
      const int expected = 2;
      int result = FunctionsString.CountString(source, "far", true);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountString_do_not_ignore_case()
    {
      const string source = "once upon a time in a galaxy far far away";
      const int expected = 2;
      int result = FunctionsString.CountString(source, "far", false);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountString_empty_string()
    {
      const string source = "";
      const int expected = 0;
      int result = FunctionsString.CountString(source, "far", true);
      Assert.AreEqual(result, expected);
    }

    // **********************IndexOfAll****************
    [TestMethod]
    public void TestMethod_IndexOfAll()
    {
      const string source = "once upon a time in a galaxy far far away";
      int[] expected = new int[2];
      expected[0] = 29;
      expected[1] = 33;
      int[] result = FunctionsString.IndexOfAll(source, "far", true);
      Assert.AreEqual(result[0], expected[0]);
      Assert.AreEqual(result[1], expected[1]);
    }

    [TestMethod]
    public void TestMethod_IndexOfAll_ignore_case()
    {
      const string source = "once upon a time in a galaxy far far away";
      int[] expected = new int[2];
      expected[0] = 29;
      expected[1] = 33;
      int[] result = FunctionsString.IndexOfAll(source, "far", false);
      Assert.AreEqual(result[0], expected[0]);
      Assert.AreEqual(result[1], expected[1]);
    }

    [TestMethod]
    public void TestMethod_IndexOfAll_ignore_case_upper_source()
    {
      const string source = "once upon a time in a galaxy FAR FAR away";
      int[] expected = new int[2];
      expected[0] = 29;
      expected[1] = 33;
      int[] result = FunctionsString.IndexOfAll(source, "far", true);
      Assert.AreEqual(result[0], expected[0]);
      Assert.AreEqual(result[1], expected[1]);
    }

    [TestMethod]
    public void TestMethod_IndexOfAll_no_matching()
    {
      // TODO debug
      //const string source = "once upon a time in a galaxy far far away";
      //int[] expected = new int[0];
      //int[] result = StringFunc.IndexOfAll(source, "toto", true);
      //Assert.AreEqual(result[0], expected[0]);
    }

    // **********************IsAlternateCases****************
    [TestMethod]
    public void TestMethod_IsAlternateCases()
    {
      const string source = "once upon a time in a galaxy far far away";
      const bool expected = false;
      bool result = FunctionsString.IsAlternateCases(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAlternateCases_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = FunctionsString.IsAlternateCases(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAlternateCases_True()
    {
      const string source = "OnCe";
      const bool expected = true;
      bool result = FunctionsString.IsAlternateCases(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAlternateCases_True_two_words()
    {
      const string source = "OnCe uPoN";
      const bool expected = true;
      bool result = FunctionsString.IsAlternateCases(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAlternateCases_True_four_words()
    {
      const string source = "OnCe uPoN A TiMe";
      const bool expected = true;
      bool result = FunctionsString.IsAlternateCases(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsCapitalized****************
    [TestMethod]
    public void TestMethod_IsCapitalized_true()
    {
      const string source = "Once upon a time in a galaxy far far away";
      const bool expected = true;
      bool result = FunctionsString.IsCapitalized(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsCapitalized_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = FunctionsString.IsCapitalized(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsCapitalized_false()
    {
      const string source = "once upon a time in a galaxy far far away";
      const bool expected = false;
      bool result = FunctionsString.IsCapitalized(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsLowerCase****************
    [TestMethod]
    public void TestMethod_IsLowerCase_true()
    {
      const string source = "once upon a time in a galaxy far far away";
      const bool expected = true;
      bool result = FunctionsString.IsLowerCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsLowerCase_false()
    {
      const string source = "Once upon a time in a galaxy far far away";
      const bool expected = false;
      bool result = FunctionsString.IsLowerCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsLowerCase_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = FunctionsString.IsLowerCase(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsLowerCase2****************
    [TestMethod]
    public void TestMethod_IsLowerCase2_true()
    {
      const string source = "once upon a time in a galaxy far far away";
      const bool expected = true;
      bool result = FunctionsString.IsLowerCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsLowerCase2_false()
    {
      const string source = "Once upon a time in a galaxy far far away";
      const bool expected = false;
      bool result = FunctionsString.IsLowerCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsLowerCase2_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = FunctionsString.IsLowerCase2(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsUpperCase****************
    [TestMethod]
    public void TestMethod_IsUpperCase_true()
    {
      string source = "once upon a time in a galaxy far far away";
      source = source.ToUpper();
      const bool expected = true;
      bool result = FunctionsString.IsUpperCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsUpperCase_false()
    {
      const string source = "Once upon a time in a galaxy far far away";
      const bool expected = false;
      bool result = FunctionsString.IsUpperCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsUpperCase_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = FunctionsString.IsUpperCase(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsLowerCase2****************
    [TestMethod]
    public void TestMethod_IsUpperCase2_true()
    {
      string source = "once upon a time in a galaxy far far away";
      source = source.ToUpper();
      const bool expected = true;
      bool result = FunctionsString.IsUpperCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsUpperCase2_false()
    {
      const string source = "Once upon a time in a galaxy far far away";
      const bool expected = false;
      bool result = FunctionsString.IsUpperCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsUpperCase2_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = FunctionsString.IsUpperCase2(source);
      Assert.AreEqual(result, expected);
    }

    // **********************HasVowels****************
    [TestMethod]
    public void TestMethod_HasVowels_true()
    {
      const string source = "azerty";
      const bool expected = true;
      bool result = FunctionsString.HasVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasVowels_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = FunctionsString.HasVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasVowels_only_vowels()
    {
      const string source = "aeiouy";
      const bool expected = true;
      bool result = FunctionsString.HasVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasVowels_false()
    {
      const string source = "qsdfghjklm";
      const bool expected = false;
      bool result = FunctionsString.HasVowels(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsSpaces****************
    [TestMethod]
    public void TestMethod_IsSpaces_true()
    {
      const string source = "       ";
      const bool expected = true;
      bool result = FunctionsString.IsSpaces(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsSpaces_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = FunctionsString.HasVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsSpaces_false()
    {
      const string source = "qwerty";
      const bool expected = false;
      bool result = FunctionsString.IsSpaces(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsRepeatedChar****************
    [TestMethod]
    public void TestMethod_IsRepeatedChar_true()
    {
      const string source = "aaaaaaa";
      const bool expected = true;
      bool result = FunctionsString.IsRepeatedChar(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsRepeatedChars_empty_string()
    {
      const string source = "";
      const bool expected = true;
      bool result = FunctionsString.IsRepeatedChar(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsRepeatedChar_false()
    {
      const string source = "qwerty";
      const bool expected = false;
      bool result = FunctionsString.IsRepeatedChar(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsRepeatedChar_false_on_a_sentence()
    {
      const string source = "Once upon a time in a galaxy far far away";
      const bool expected = false;
      bool result = FunctionsString.IsRepeatedChar(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsNumeric on a string****************
    [TestMethod]
    public void TestMethod_IsNumeric_false()
    {
      const string source = "azerty";
      const bool expected = false;
      bool result = FunctionsString.IsNumeric(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsNumeric_true()
    {
      const string source = "123456";
      const bool expected = true;
      bool result = FunctionsString.IsNumeric(source);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_IsNumeric_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = FunctionsString.IsNumeric(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsNumeric2 on a string****************
    [TestMethod]
    public void TestMethod_IsNumeric2_false()
    {
      const string source = "azerty";
      const bool expected = false;
      bool result = FunctionsString.IsNumeric2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsNumeric2_true()
    {
      const string source = "123456";
      const bool expected = true;
      bool result = FunctionsString.IsNumeric2(source);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_IsNumeric2_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = FunctionsString.IsNumeric2(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsNumeric3 with NumberStyles****************
    [TestMethod]
    public void TestMethod_IsNumeric3_false()
    {
      const string source = "azerty";
      const NumberStyles numberStyle = NumberStyles.Number;
      const bool expected = false;
      bool result = FunctionsString.IsNumeric3(source, numberStyle);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsNumeric3_true()
    {
      const string source = "123456";
      const NumberStyles numberStyle = NumberStyles.Number;
      const bool expected = true;
      bool result = FunctionsString.IsNumeric3(source, numberStyle);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_IsNumeric3_empty_string()
    {
      const string source = "";
      const NumberStyles numberStyle = NumberStyles.Number;
      const bool expected = false;
      bool result = FunctionsString.IsNumeric3(source, numberStyle);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsNumeric3_true_Allow_trailing_white()
    {
      const string source = "123456  ";
      const NumberStyles numberStyle = NumberStyles.AllowTrailingWhite;
      const bool expected = true;
      bool result = FunctionsString.IsNumeric3(source, numberStyle);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsNumeric3_true_Allow_leading_white()
    {
      const string source = "  123456";
      const NumberStyles numberStyle = NumberStyles.AllowLeadingWhite;
      const bool expected = true;
      bool result = FunctionsString.IsNumeric3(source, numberStyle);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsNumeric3_true_Allow_decimal_white()
    {
      const string source = "1234,56";
      const NumberStyles numberStyle = NumberStyles.AllowDecimalPoint;
      const bool expected = true;
      bool result = FunctionsString.IsNumeric3(source, numberStyle);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsNumeric3_true_integer()
    {
      const string source = "123456";
      const NumberStyles numberStyle = NumberStyles.Integer;
      const bool expected = true;
      bool result = FunctionsString.IsNumeric3(source, numberStyle);
      Assert.AreEqual(result, expected);
    }

    // **********************IsAlphaNumeric****************
    [TestMethod]
    public void TestMethod_IsAlphaNumeric_false()
    {
      const string source = "1+azerty";
      const bool expected = false;
      bool result = FunctionsString.IsAlphaNumeric(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAlphaNumeric_true()
    {
      const string source = "1azerty";
      const bool expected = true;
      bool result = FunctionsString.IsAlphaNumeric(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAlphaNumeric_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = FunctionsString.IsAlphaNumeric(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsLetters****************
    [TestMethod]
    public void TestMethod_IsLetters_false()
    {
      const string source = "123456789";
      const bool expected = false;
      bool result = FunctionsString.IsOnlyLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsLetters_true()
    {
      const string source = "qwertyAndazerty";
      const bool expected = true;
      bool result = FunctionsString.IsOnlyLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsLetters_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = FunctionsString.IsOnlyLetters(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsTitle**************
    [TestMethod]
    public void TestMethod_IsTitle_false()
    {
      const string source = "once upon a time";
      const bool expected = false;
      bool result = FunctionsString.IsTitle(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsTitle_true()
    {
      const string source = "Once A Upon A Time";
      const bool expected = true;
      bool result = FunctionsString.IsTitle(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsTitle_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = FunctionsString.IsTitle(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsTitle with a separator**************
    [TestMethod]
    public void TestMethod_IsTitle_with_separator_false()
    {
      const string source = "once upon a time";
      const string separator = " ";
      const bool expected = false;
      bool result = FunctionsString.IsTitle(source, separator);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsTitle_with_separator_true()
    {
      const string source = "Once A Upon A Time";
      const string separator = " ";
      const bool expected = true;
      bool result = FunctionsString.IsTitle(source, separator);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsTitle_with_one_separator_false()
    {
      const string source = "once A Upon A Time_in a galaxy far far away";
      const string separator = "_";
      const bool expected = false;
      bool result = FunctionsString.IsTitle(source, separator);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsTitle_with_one_separator_true()
    {
      const string source = "Once A Upon A Time_In a galaxy far far away";
      const string separator = "_";
      const bool expected = true;
      bool result = FunctionsString.IsTitle(source, separator);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsTitle_with_separator_empty_string()
    {
      const string source = "";
      const string separator = "_";
      const bool expected = false;
      bool result = FunctionsString.IsTitle(source, separator);
      Assert.AreEqual(result, expected);
    }

    // **********************IsEmailAddress**************
    [TestMethod]
    public void TestMethod_IsEmailAddress_false()
    {
      const string source = "this is certainly not a valid email address";
      const bool expected = false;
      bool result = FunctionsString.IsEmailAddress(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddress_true()
    {
      const string source = "someone@aol.com";
      const bool expected = true;
      bool result = FunctionsString.IsEmailAddress(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddress_2_true()
    {
      const string source = "someone@somefai.com";
      const bool expected = true;
      bool result = FunctionsString.IsEmailAddress(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddress_dot_before_arobase_true()
    {
      const string source = "firstName.LastName@someFAI.com";
      const bool expected = true;
      bool result = FunctionsString.IsEmailAddress(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddress_minimum_length_true()
    {
      const string source = "me@f2.fr";
      const bool expected = true;
      bool result = FunctionsString.IsEmailAddress(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddress_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = FunctionsString.IsEmailAddress(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsEmailAddressValid**************
    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true()
    {
      const string source = "someone@someFAI.com";
      const bool expected = true;
      bool result = FunctionsString.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = FunctionsString.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_false_because_no_arobase()
    {
      const string source = "someoneatsomeFAI.com";
      const bool expected = false;
      bool result = FunctionsString.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_false_because_no_dot()
    {
      const string source = "someone@someFAIdotcom";
      const bool expected = false;
      bool result = FunctionsString.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_false_because_too_short()
    {
      const string source = "s@I.c";
      const bool expected = false;
      bool result = FunctionsString.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_dot_before_arobase()
    {
      const string source = "firstName.lastName@free.fr";
      const bool expected = true;
      bool result = FunctionsString.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_five_letter_TLD()
    {
      const string source = "firstName.lastName@mairie.paris";
      const bool expected = true;
      bool result = FunctionsString.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_seven_letter_TLD()
    {
      const string source = "firstName.lastName@mywonderful.website";
      const bool expected = true;
      bool result = FunctionsString.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_eight_letter_TLD()
    {
      const string source = "firstName.lastName@mywonderful.memorial";
      const bool expected = true;
      bool result = FunctionsString.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_nine_letter_TLD()
    {
      const string source = "firstName.lastName@supersite.solutions";
      const bool expected = true;
      bool result = FunctionsString.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_ten_letter_TLD()
    {
      const string source = "firstName.lastName@maysupersite.consulting";
      const bool expected = true;
      bool result = FunctionsString.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_two_dots_in_TLD()
    {
      const string source = "firstName.lastName@mywonderful.co.com";
      const bool expected = true;
      bool result = FunctionsString.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_two_dots_in_tld_co_uk()
    {
      const string source = "firstName.lastName@site.co.uk";
      const bool expected = true;
      bool result = FunctionsString.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_eleven_letter_TLD()
    {
      const string source = "firstName.lastName@mysupersite.accountants";
      const bool expected = true;
      bool result = FunctionsString.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_eleven_letter_TLD_blackfriday()
    {
      const string source = "firstName.lastName@mysupersite.blackfriday";
      const bool expected = true;
      bool result = FunctionsString.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_twelve_letter_TLD_construction()
    {
      const string source = "firstName.lastName@mysupersite.construction";
      const bool expected = true;
      bool result = FunctionsString.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_twelve_letter_TLD_contractors()
    {
      const string source = "firstName.lastName@mysupersite.contractors";
      const bool expected = true;
      bool result = FunctionsString.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_thirteen_letter_TLD_international()
    {
      const string source = "firstName.lastName@supersite.international";
      const bool expected = true;
      bool result = FunctionsString.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    // **********************LoadAlphabetInList**************
    [TestMethod]
    public void TestMethod_LoadAlphabetInList_false_empty_source_array()
    {
      char[] expected = new char[62];
      char[] result = FunctionsString.LoadAlphabetInList(false, false);
      Assert.AreEqual(result.Length, expected.Length);
      Assert.AreEqual(result[0], expected[0]); 
      Assert.AreEqual(result[5], expected[5]);
      Assert.AreEqual(result[9], expected[9]);
    }

    [TestMethod]
    public void TestMethod_LoadAlphabetInList_false_empty_source_array_give_sixty_two_length_array()
    {
      char[] result = FunctionsString.LoadAlphabetInList(false, false);
      Assert.IsTrue(result.Length == 26 + 26 + 10);
    }

    [TestMethod]
    public void TestMethod_LoadAlphabetInList_true_only_digits()
    {
      char[] expected = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
      char[] result = FunctionsString.LoadAlphabetInList(true, false);
      Assert.AreEqual(result[0], expected[0]); // '0'
      Assert.AreEqual(result[5], expected[5]); // '5'
      Assert.AreEqual(result[9], expected[9]); // '9'
    }

    [TestMethod]
    public void TestMethod_LoadAlphabetInList_true_only_lower_case_letters()
    {
      char[] expected = new char[62];
      expected = FunctionsString.GetAlphabet();
      char[] result = FunctionsString.LoadAlphabetInList(false);
      Assert.AreEqual(result[0], expected[0]); // 'a'
      Assert.AreEqual(result[5], expected[5]);
      Assert.AreEqual(result[9], expected[9]);
      Assert.AreEqual(result[25], expected[25]); // 'z'
    }

    [TestMethod]
    public void TestMethod_LoadAlphabetInList_true_only_upper_case_letters()
    {
      char[] expected = new char[62];
      expected = FunctionsString.GetAlphabet(false);
      char[] result = FunctionsString.LoadAlphabetInList(false, false, true);
      Assert.AreEqual(result[0], expected[0]); // 'A'
      Assert.AreEqual(result[5], expected[5]);
      Assert.AreEqual(result[9], expected[9]);
      Assert.AreEqual(result[25], expected[25]); // 'Z'
    }

    [TestMethod]
    public void TestMethod_LoadAlphabetInList_true_lower_and_upper_case_letters()
    {
      char[] expected = new char[62];
      char[] lower = FunctionsString.GetAlphabet();
      char[] upper = FunctionsString.GetAlphabet(false);
      int counter = 0;
      for (int i = 0; i < lower.Length; i++)
      {
        expected[counter] = lower[i];
        counter++;
      }

      for (int i = 0; i < upper.Length; i++)
      {
        expected[counter] = upper[i];
        counter++;
      }

      char[] result = FunctionsString.LoadAlphabetInList(false, true, true);
      Assert.AreEqual(result[0], expected[0]); // 'a'
      Assert.AreEqual(result[5], expected[5]);
      Assert.AreEqual(result[9], expected[9]);
      Assert.AreEqual(result[25], expected[25]); // 'z'
      Assert.AreEqual(result[26], expected[26]); // 'A'
      Assert.AreEqual(result[51], expected[51]); // 'Z'
    }

    [TestMethod]
    public void TestMethod_LoadAlphabetInList_true_digit_lower_and_upper_case_letters()
    {
      char[] expected = new char[62];
      char[] lower = FunctionsString.GetAlphabet();
      char[] upper = FunctionsString.GetAlphabet(false);
      int counter = 0;
      for (int i = 0; i < lower.Length; i++)
      {
        expected[counter] = lower[i];
        counter++;
      }

      for (int i = 0; i < upper.Length; i++)
      {
        expected[counter] = upper[i];
        counter++;
      }
      for (short chiffre = 48; chiffre < 58; chiffre++) // 48 = asc('0')
      {
        expected[counter] = (char)chiffre;
        counter++;
      }

      char[] result = FunctionsString.LoadAlphabetInList(true, true, true);
      Assert.AreEqual(result[0], expected[0]); // 'a'
      Assert.AreEqual(result[5], expected[5]);
      Assert.AreEqual(result[9], expected[9]);
      Assert.AreEqual(result[25], expected[25]); // 'z'
      Assert.AreEqual(result[26], expected[26]); // 'A'
      Assert.AreEqual(result[51], expected[51]); // 'Z'
      Assert.AreEqual(result[52], expected[52]); // '0'
      Assert.AreEqual(result[61], expected[61]); // '9'
    }

    [TestMethod]
    public void TestMethod_LoadAlphabetInList_true_lower_case_letters_and_digit()
    {
      char[] expected = new char[62];
      char[] lower = FunctionsString.GetAlphabet();
      int counter = 0;
      for (int i = 0; i < lower.Length; i++)
      {
        expected[counter] = lower[i];
        counter++;
      }

      for (short chiffre = 48; chiffre < 58; chiffre++) // 48 = asc('0')
      {
        expected[counter] = (char)chiffre;
        counter++;
      }

      char[] result = FunctionsString.LoadAlphabetInList();
      Assert.AreEqual(result[0], expected[0]); // 'a'
      Assert.AreEqual(result[5], expected[5]);
      Assert.AreEqual(result[9], expected[9]);
      Assert.AreEqual(result[25], expected[25]); // 'z'
      Assert.AreEqual(result[26], expected[26]); // '0'
      Assert.AreEqual(result[35], expected[35]); // '9'
    }

    [TestMethod]
    public void TestMethod_LoadAlphabetInList_true_upper_case_letters_and_digit()
    {
      char[] expected = new char[62];
      char[] upper = FunctionsString.GetAlphabet(false);
      int counter = 0;
      for (int i = 0; i < upper.Length; i++)
      {
        expected[counter] = upper[i];
        counter++;
      }

      for (short chiffre = 48; chiffre < 58; chiffre++) // 48 = asc('0')
      {
        expected[counter] = (char)chiffre;
        counter++;
      }

      char[] result = FunctionsString.LoadAlphabetInList(true, false, true);
      Assert.AreEqual(result[0], expected[0]); // 'a'
      Assert.AreEqual(result[5], expected[5]);
      Assert.AreEqual(result[9], expected[9]);
      Assert.AreEqual(result[25], expected[25]); // 'z'
      Assert.AreEqual(result[26], expected[26]); // '0'
      Assert.AreEqual(result[35], expected[35]); // '9'
    }

    // LoadAlphabetInStringArray TODO tests to write

    // **********************LetterCasingSequence**************
    [TestMethod]
    public void TestMethod_LetterCasingSequence_true_all_enum_exists_no_deleted_item()
    {
      Assert.AreEqual(FunctionsString.LetterCasingSequence.DigitLowerUpper, FunctionsString.LetterCasingSequence.DigitLowerUpper);
      Assert.AreEqual(FunctionsString.LetterCasingSequence.DigitUpperLower, FunctionsString.LetterCasingSequence.DigitUpperLower);
      Assert.AreEqual(FunctionsString.LetterCasingSequence.LowerDigitUpper, FunctionsString.LetterCasingSequence.LowerDigitUpper);
      Assert.AreEqual(FunctionsString.LetterCasingSequence.LowerUpperDigit, FunctionsString.LetterCasingSequence.LowerUpperDigit);
      Assert.AreEqual(FunctionsString.LetterCasingSequence.UpperDigitLower, FunctionsString.LetterCasingSequence.UpperDigitLower);
      Assert.AreEqual(FunctionsString.LetterCasingSequence.UpperLowerDigit, FunctionsString.LetterCasingSequence.UpperLowerDigit);
    }

    [TestMethod]
    public void TestMethod_LetterCasingSequence_false_no_equality()
    {
      Assert.AreNotEqual(FunctionsString.LetterCasingSequence.DigitLowerUpper, FunctionsString.LetterCasingSequence.DigitUpperLower);
      Assert.AreNotEqual(FunctionsString.LetterCasingSequence.DigitUpperLower, FunctionsString.LetterCasingSequence.LowerDigitUpper);
      Assert.AreNotEqual(FunctionsString.LetterCasingSequence.LowerDigitUpper, FunctionsString.LetterCasingSequence.LowerUpperDigit);
      Assert.AreNotEqual(FunctionsString.LetterCasingSequence.LowerUpperDigit, FunctionsString.LetterCasingSequence.UpperDigitLower);
      Assert.AreNotEqual(FunctionsString.LetterCasingSequence.UpperDigitLower, FunctionsString.LetterCasingSequence.UpperLowerDigit);
      Assert.AreNotEqual(FunctionsString.LetterCasingSequence.UpperLowerDigit, FunctionsString.LetterCasingSequence.DigitLowerUpper);
    }

    [TestMethod]
    public void TestMethod_LetterCasingSequence_true_all_enum_exist_by_their_value_number()
    {
      Assert.IsTrue(Enum.IsDefined(typeof(FunctionsString.LetterCasingSequence), 0));
      Assert.IsTrue(Enum.IsDefined(typeof(FunctionsString.LetterCasingSequence), 1));
      Assert.IsTrue(Enum.IsDefined(typeof(FunctionsString.LetterCasingSequence), 2));
      Assert.IsTrue(Enum.IsDefined(typeof(FunctionsString.LetterCasingSequence), 3));
      Assert.IsTrue(Enum.IsDefined(typeof(FunctionsString.LetterCasingSequence), 4));
      Assert.IsTrue(Enum.IsDefined(typeof(FunctionsString.LetterCasingSequence), 5));
    }

    [TestMethod]
    public void TestMethod_LetterCasingSequence_true_all_enum_exists_with_no_change_in_their_value()
    {
      Assert.AreEqual((int)FunctionsString.LetterCasingSequence.LowerUpperDigit, 0);
      Assert.AreEqual((int)FunctionsString.LetterCasingSequence.UpperLowerDigit, 1);
      Assert.AreEqual((int) FunctionsString.LetterCasingSequence.DigitLowerUpper, 2);
      Assert.AreEqual((int) FunctionsString.LetterCasingSequence.DigitUpperLower, 3);
      Assert.AreEqual((int) FunctionsString.LetterCasingSequence.LowerDigitUpper, 4);
      Assert.AreEqual((int) FunctionsString.LetterCasingSequence.UpperDigitLower, 5);
    }

    // **********************NumberToWordsEnglish**************
    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_zero()
    {
      const string expected = "zero";
      string result = FunctionsString.NumberToEnglishWords(0);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one()
    {
      const string expected = "one";
      string result = FunctionsString.NumberToEnglishWords(1);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_one()
    {
      const string expected = "minus one";
      string result = FunctionsString.NumberToEnglishWords(-1);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_two()
    {
      const string expected = "two";
      string result = FunctionsString.NumberToEnglishWords(2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_two()
    {
      const string expected = "minus two";
      string result = FunctionsString.NumberToEnglishWords(-2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_three()
    {
      const string expected = "three";
      string result = FunctionsString.NumberToEnglishWords(3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_three()
    {
      const string expected = "minus three";
      string result = FunctionsString.NumberToEnglishWords(-3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_four()
    {
      const string expected = "four";
      string result = FunctionsString.NumberToEnglishWords(4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_four()
    {
      const string expected = "minus four";
      string result = FunctionsString.NumberToEnglishWords(-4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_five()
    {
      const string expected = "five";
      string result = FunctionsString.NumberToEnglishWords(5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_five()
    {
      const string expected = "minus five";
      string result = FunctionsString.NumberToEnglishWords(-5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_six()
    {
      const string expected = "six";
      string result = FunctionsString.NumberToEnglishWords(6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_six()
    {
      const string expected = "minus six";
      string result = FunctionsString.NumberToEnglishWords(-6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_seven()
    {
      const string expected = "seven";
      string result = FunctionsString.NumberToEnglishWords(7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_eight()
    {
      const string expected = "eight";
      string result = FunctionsString.NumberToEnglishWords(8);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_nine()
    {
      const string expected = "nine";
      string result = FunctionsString.NumberToEnglishWords(9);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_ten()
    {
      const string expected = "ten";
      string result = FunctionsString.NumberToEnglishWords(10);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_eleven()
    {
      const string expected = "eleven";
      string result = FunctionsString.NumberToEnglishWords(11);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_twelve()
    {
      const string expected = "twelve";
      string result = FunctionsString.NumberToEnglishWords(12);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_thirteen()
    {
      const string expected = "thirteen";
      string result = FunctionsString.NumberToEnglishWords(13);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_fourteen()
    {
      const string expected = "fourteen";
      string result = FunctionsString.NumberToEnglishWords(14);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_fifteen()
    {
      const string expected = "fifteen";
      string result = FunctionsString.NumberToEnglishWords(15);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_sixteen()
    {
      const string expected = "sixteen";
      string result = FunctionsString.NumberToEnglishWords(16);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_seventeen()
    {
      const string expected = "seventeen";
      string result = FunctionsString.NumberToEnglishWords(17);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_eighteen()
    {
      const string expected = "eighteen";
      string result = FunctionsString.NumberToEnglishWords(18);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_nineteen()
    {
      const string expected = "nineteen";
      string result = FunctionsString.NumberToEnglishWords(19);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_twenty()
    {
      const string expected = "twenty";
      string result = FunctionsString.NumberToEnglishWords(20);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_twenty_one()
    {
      const string expected = "twenty-one";
      string result = FunctionsString.NumberToEnglishWords(21);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_twenty_five()
    {
      const string expected = "twenty-five";
      string result = FunctionsString.NumberToEnglishWords(25);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_thirty()
    {
      const string expected = "thirty";
      string result = FunctionsString.NumberToEnglishWords(30);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_thirty_one()
    {
      const string expected = "thirty-one";
      string result = FunctionsString.NumberToEnglishWords(31);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_thirty_five()
    {
      const string expected = "thirty-five";
      string result = FunctionsString.NumberToEnglishWords(35);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_forty()
    {
      const string expected = "forty";
      string result = FunctionsString.NumberToEnglishWords(40);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_fifty()
    {
      const string expected = "fifty";
      string result = FunctionsString.NumberToEnglishWords(50);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_sixty()
    {
      const string expected = "sixty";
      string result = FunctionsString.NumberToEnglishWords(60);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_seventy()
    {
      const string expected = "seventy";
      string result = FunctionsString.NumberToEnglishWords(70);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_eighty()
    {
      const string expected = "eighty";
      string result = FunctionsString.NumberToEnglishWords(80);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_ninety()
    {
      const string expected = "ninety";
      string result = FunctionsString.NumberToEnglishWords(90);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_hundred()
    {
      const string expected = "one hundred";
      string result = FunctionsString.NumberToEnglishWords(100);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_five_hundred()
    {
      const string expected = "five hundred";
      string result = FunctionsString.NumberToEnglishWords(500);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_seven_hundred_fifty()
    {
      const string expected = "seven hundred and fifty";
      string result = FunctionsString.NumberToEnglishWords(750);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_seven_hundred_and_fourty_seven()
    {
      const string expected = "seven hundred and forty-seven";
      string result = FunctionsString.NumberToEnglishWords(747);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_nine_hundred_and_nine()
    {
      const string expected = "nine hundred and nine";
      string result = FunctionsString.NumberToEnglishWords(909);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_thousand()
    {
      const string expected = "one thousand";
      string result = FunctionsString.NumberToEnglishWords(1000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_thousand_five_hundred()
    {
      const string expected = "one thousand five hundred";
      string result = FunctionsString.NumberToEnglishWords(1500);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_thousand_seven_hundred_and_eighty_nine()
    {
      const string expected = "one thousand seven hundred and eighty-nine";
      string result = FunctionsString.NumberToEnglishWords(1789);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_two_thousand_and_fifteen()
    {
      const string expected = "two thousand and fifteen";
      string result = FunctionsString.NumberToEnglishWords(2015);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_nine_thousand_nine_hundred_and_ninety_nine()
    {
      const string expected = "nine thousand nine hundred and ninety-nine";
      string result = FunctionsString.NumberToEnglishWords(9999);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_nine_hundred_ninety_nine_thousand_nine_hundred_and_ninety_nine()
    {
      const string expected = "nine hundred and ninety-nine thousand nine hundred and ninety-nine";
      string result = FunctionsString.NumberToEnglishWords(999999);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_million()
    {
      const string expected = "one million";
      string result = FunctionsString.NumberToEnglishWords(1000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToEnglishWords_two_million()
    {
      const string expected = "two million";
      string result = FunctionsString.NumberToEnglishWords(2000000);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_million_five_hundred_thousand()
    {
      const string expected = "one million five hundred thousand";
      string result = FunctionsString.NumberToEnglishWords(1500000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_million_five_hundred_thousand_and_one()
    {
      const string expected = "one million five hundred thousand and one";
      string result = FunctionsString.NumberToEnglishWords(1500001);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_million_five_hundred_thousand_and_twenty()
    {
      const string expected = "one million five hundred thousand and twenty";
      string result = FunctionsString.NumberToEnglishWords(1500020);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_million_five_hundred_thousand_and_two_hundred()
    {
      const string expected = "one million five hundred thousand two hundred";
      string result = FunctionsString.NumberToEnglishWords(1500200);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_two_billion()
    {
      const string expected = "two billion";
      string result = FunctionsString.NumberToEnglishWords(2000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_int_maxvalue()
    {
      const string expected = "two billion one hundred and forty-seven million four hundred and eighty-three thousand six hundred and forty-seven";
      // The value of int.MaxValue constant is 2,147,483,647
      string result = FunctionsString.NumberToEnglishWords(int.MaxValue);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_three_billion()
    {
      const string expected = "three billion";
      string result = FunctionsString.NumberToEnglishWords(3000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_trillion()
    {
      const string expected = "one trillion";
      string result = FunctionsString.NumberToEnglishWords(1000000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_nine_hundred_trillion()
    {
      const string expected = "nine hundred trillion";
      string result = FunctionsString.NumberToEnglishWords(900000000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_long_maxvalue()
    {
      const string expected = "nine quintillion two hundred and twenty-three quadrillion three hundred and seventy-two trillion thirty-six billion eight hundred and fifty-four million seven hundred and seventy-five thousand eight hundred and seven";
      // The value of long.MaxValue constant is 9,223,372,036,854,775,807
      string result = FunctionsString.NumberToEnglishWords(long.MaxValue);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_ulong_maxvalue()
    {
      const string expected = "eighteen quintillion four hundred and forty-six quadrillion seven hundred and forty-four trillion seventy-three billion seven hundred and nine million five hundred and fifty-one thousand six hundred and fifteen";
      // The value of ulong.MaxValue constant is 18,446,744,073,709,551,615
      string result = FunctionsString.NumberToEnglishWords(ulong.MaxValue);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_eighteen_quintillion()
    {
      const string expected = "eighteen quintillion";
      // The value of ulong.MaxValue constant is 18,446,744,073,709,551,615
      string result = FunctionsString.NumberToEnglishWords(18000000000000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_eighteen_quintillion_and_twenty_two()
    {
      const string expected = "eighteen quintillion and twenty-two";
      string result = FunctionsString.NumberToEnglishWords(18000000000000000022);
      Assert.AreEqual(result, expected);
    }

    // **********************NumberToFrenchWords**************
    [TestMethod]
    public void TestMethod_NumberToFrenchWords_zero()
    {
      const string expected = "zéro";
      string result = FunctionsString.NumberToFrenchWords(0);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one()
    {
      const string expected = "un";
      string result = FunctionsString.NumberToFrenchWords(1);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_minus_one()
    {
      const string expected = "moins un";
      string result = FunctionsString.NumberToFrenchWords(-1);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_two()
    {
      const string expected = "deux";
      string result = FunctionsString.NumberToFrenchWords(2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_minus_two()
    {
      const string expected = "moins deux";
      string result = FunctionsString.NumberToFrenchWords(-2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_three()
    {
      const string expected = "trois";
      string result = FunctionsString.NumberToFrenchWords(3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_moins_three()
    {
      const string expected = "moins trois";
      string result = FunctionsString.NumberToFrenchWords(-3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_four()
    {
      const string expected = "quatre";
      string result = FunctionsString.NumberToFrenchWords(4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_moins_four()
    {
      const string expected = "moins quatre";
      string result = FunctionsString.NumberToFrenchWords(-4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_five()
    {
      const string expected = "cinq";
      string result = FunctionsString.NumberToFrenchWords(5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_moins_five()
    {
      const string expected = "moins cinq";
      string result = FunctionsString.NumberToFrenchWords(-5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_six()
    {
      const string expected = "six";
      string result = FunctionsString.NumberToFrenchWords(6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_moins_six()
    {
      const string expected = "moins six";
      string result = FunctionsString.NumberToFrenchWords(-6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_seven()
    {
      const string expected = "sept";
      string result = FunctionsString.NumberToFrenchWords(7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_eight()
    {
      const string expected = "huit";
      string result = FunctionsString.NumberToFrenchWords(8);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_nine()
    {
      const string expected = "neuf";
      string result = FunctionsString.NumberToFrenchWords(9);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_ten()
    {
      const string expected = "dix";
      string result = FunctionsString.NumberToFrenchWords(10);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_eleven()
    {
      const string expected = "onze";
      string result = FunctionsString.NumberToFrenchWords(11);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_twelve()
    {
      const string expected = "douze";
      string result = FunctionsString.NumberToFrenchWords(12);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_moins_thirteen()
    {
      const string expected = "treize";
      string result = FunctionsString.NumberToFrenchWords(13);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_fourteen()
    {
      const string expected = "quatorze";
      string result = FunctionsString.NumberToFrenchWords(14);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_moins_fifteen()
    {
      const string expected = "quinze";
      string result = FunctionsString.NumberToFrenchWords(15);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_sixteen()
    {
      const string expected = "seize";
      string result = FunctionsString.NumberToFrenchWords(16);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_seventeen()
    {
      const string expected = "dix-sept";
      string result = FunctionsString.NumberToFrenchWords(17);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_eighteen()
    {
      const string expected = "dix-huit";
      string result = FunctionsString.NumberToFrenchWords(18);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_nineteen()
    {
      const string expected = "dix-neuf";
      string result = FunctionsString.NumberToFrenchWords(19);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_twenty()
    {
      const string expected = "vingt";
      string result = FunctionsString.NumberToFrenchWords(20);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_twenty_one()
    {
      const string expected = "vingt-un";
      string result = FunctionsString.NumberToFrenchWords(21);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_twenty_five()
    {
      const string expected = "vingt-cinq";
      string result = FunctionsString.NumberToFrenchWords(25);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_thirty()
    {
      const string expected = "trente";
      string result = FunctionsString.NumberToFrenchWords(30);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_thirty_one()
    {
      const string expected = "trente-un";
      string result = FunctionsString.NumberToFrenchWords(31);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_thirty_five()
    {
      const string expected = "trente-cinq";
      string result = FunctionsString.NumberToFrenchWords(35);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_forty()
    {
      const string expected = "quarante";
      string result = FunctionsString.NumberToFrenchWords(40);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_fifty()
    {
      const string expected = "cinquante";
      string result = FunctionsString.NumberToFrenchWords(50);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_sixty()
    {
      const string expected = "soixante";
      string result = FunctionsString.NumberToFrenchWords(60);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_seventy()
    {
      const string expected = "soixante-dix";
      string result = FunctionsString.NumberToFrenchWords(70);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_eighty()
    {
      const string expected = "quatre-vingt";
      string result = FunctionsString.NumberToFrenchWords(80);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_ninety()
    {
      const string expected = "quatre-vingt-dix";
      string result = FunctionsString.NumberToFrenchWords(90);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_hundred()
    {
      const string expected = "un cent";
      string result = FunctionsString.NumberToFrenchWords(100);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_five_hundred()
    {
      const string expected = "cinq cent";
      string result = FunctionsString.NumberToFrenchWords(500);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_seven_hundred_fifty()
    {
      const string expected = "sept cent et cinquante";
      string result = FunctionsString.NumberToFrenchWords(750);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_seven_hundred_and_fourty_seven()
    {
      const string expected = "sept cent et quarante-sept";
      string result = FunctionsString.NumberToFrenchWords(747);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_nine_hundred_and_nine()
    {
      const string expected = "neuf cent et neuf";
      string result = FunctionsString.NumberToFrenchWords(909);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_thousand()
    {
      const string expected = "un mille";
      string result = FunctionsString.NumberToFrenchWords(1000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_thousand_five_hundred()
    {
      const string expected = "un mille cinq cent";
      string result = FunctionsString.NumberToFrenchWords(1500);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_thousand_seven_hundred_and_eighty_nine()
    {
      const string expected = "un mille sept cent et quatre-vingt-neuf";
      string result = FunctionsString.NumberToFrenchWords(1789);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_two_thousand_and_fifteen()
    {
      const string expected = "deux mille et quinze";
      string result = FunctionsString.NumberToFrenchWords(2015);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_nine_thousand_nine_hundred_and_ninety_nine()
    {
      const string expected = "neuf mille neuf cent et quatre-vingt-dix-neuf";
      string result = FunctionsString.NumberToFrenchWords(9999);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_nine_hundred_ninety_nine_thousand_nine_hundred_and_ninety_nine()
    {
      const string expected = "neuf cent et quatre-vingt-dix-neuf mille neuf cent et quatre-vingt-dix-neuf";
      string result = FunctionsString.NumberToFrenchWords(999999);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_million()
    {
      const string expected = "un million";
      string result = FunctionsString.NumberToFrenchWords(1000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_two_million()
    {
      const string expected = "deux million";
      string result = FunctionsString.NumberToFrenchWords(2000000);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_million_five_hundred_thousand()
    {
      const string expected = "un million cinq cent mille";
      string result = FunctionsString.NumberToFrenchWords(1500000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_million_five_hundred_thousand_and_one()
    {
      const string expected = "un million cinq cent mille et un";
      string result = FunctionsString.NumberToFrenchWords(1500001);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_million_five_hundred_thousand_and_twenty()
    {
      const string expected = "un million cinq cent mille et vingt";
      string result = FunctionsString.NumberToFrenchWords(1500020);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_million_five_hundred_thousand_and_two_hundred()
    {
      const string expected = "un million cinq cent mille deux cent";
      string result = FunctionsString.NumberToFrenchWords(1500200);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_two_billion()
    {
      const string expected = "deux milliard";
      string result = FunctionsString.NumberToFrenchWords(2000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_int_maxvalue()
    {
      const string expected = "deux milliard un cent et quarante-sept million quatre cent et quatre-vingt-trois mille six cent et quarante-sept";
      // The value of int.MaxValue constant is 2,147,483,647
      string result = FunctionsString.NumberToFrenchWords(int.MaxValue);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_three_billion()
    {
      const string expected = "trois milliard";
      string result = FunctionsString.NumberToFrenchWords(3000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_trillion()
    {
      const string expected = "un billion";
      string result = FunctionsString.NumberToFrenchWords(1000000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_nine_hundred_billion()
    {
      const string expected = "neuf cent billion";
      string result = FunctionsString.NumberToFrenchWords(900000000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_long_maxvalue()
    {
      const string expected = "neuf trillion deux cent et vingt-trois billiard trois cent et soixante-dix-deux billion trente-six milliard huit cent et cinquante-quatre million sept cent et soixante-dix-cinq mille huit cent et sept";
      // The value of long.MaxValue constant is 9,223,372,036,854,775,807
      string result = FunctionsString.NumberToFrenchWords(long.MaxValue);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_ulong_maxvalue()
    {
      const string expected = "dix-huit trillion quatre cent et quarante-six billiard sept cent et quarante-quatre billion soixante-dix-trois milliard sept cent et neuf million cinq cent et cinquante-un mille six cent et quinze";
      // The value of ulong.MaxValue constant is 18,446,744,073,709,551,615
      string result = FunctionsString.NumberToFrenchWords(ulong.MaxValue);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_eighteen_trillion()
    {
      const string expected = "dix-huit trillion";
      // The value of ulong.MaxValue constant is 18,446,744,073,709,551,615
      string result = FunctionsString.NumberToFrenchWords(18000000000000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_eighteen_quintillion_and_twenty_two()
    {
      const string expected = "dix-huit trillion et vingt-deux";
      string result = FunctionsString.NumberToFrenchWords(18000000000000000022);
      Assert.AreEqual(result, expected);
    }

    #region Random Unit tests generated
    // ********************************Unit tests Random code generated Methods****************************
    [TestMethod]
    public void TestMethod_one_hundred_and_twenty_three_million_four_hundred_and_twenty_seven_thousand_three_hundred_and_thirty_nine()
    {
      const string expected = "one hundred and twenty-three million four hundred and twenty-seven thousand three hundred and thirty-nine";
      string result = FunctionsString.NumberToEnglishWords(123427339);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_un_cent_et_vingt_trois_million_quatre_cent_et_vingt_sept_mille_trois_cent_et_trente_neuf()
    {
      const string expected = "un cent et vingt-trois million quatre cent et vingt-sept mille trois cent et trente-neuf";
      string result = FunctionsString.NumberToFrenchWords(123427339);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_three_hundred_and_seventeen_million_four_hundred_and_seventy_six_thousand_one_hundred_and_twenty_seven()
    {
      const string expected = "three hundred and seventeen million four hundred and seventy-six thousand one hundred and twenty-seven";
      string result = FunctionsString.NumberToEnglishWords(317476127);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_trois_cent_et_dix_sept_million_quatre_cent_et_soixante_dix_six_mille_un_cent_et_vingt_sept()
    {
      const string expected = "trois cent et dix-sept million quatre cent et soixante-dix-six mille un cent et vingt-sept";
      string result = FunctionsString.NumberToFrenchWords(317476127);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_five_hundred_and_fifteen_million_six_hundred_and_seventeen_thousand_seven_hundred_and_twenty_nine()
    {
      const string expected = "five hundred and fifteen million six hundred and seventeen thousand seven hundred and twenty-nine";
      string result = FunctionsString.NumberToEnglishWords(515617729);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_cinq_cent_et_quinze_million_six_cent_et_dix_sept_mille_sept_cent_et_vingt_neuf()
    {
      const string expected = "cinq cent et quinze million six cent et dix-sept mille sept cent et vingt-neuf";
      string result = FunctionsString.NumberToFrenchWords(515617729);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_three_hundred_and_sixty_three_million_four_hundred_and_seventy_one_thousand_six_hundred_and_twenty_four()
    {
      const string expected = "three hundred and sixty-three million four hundred and seventy-one thousand six hundred and twenty-four";
      string result = FunctionsString.NumberToEnglishWords(363471624);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_trois_cent_et_soixante_trois_million_quatre_cent_et_soixante_dix_un_mille_six_cent_et_vingt_quatre()
    {
      const string expected = "trois cent et soixante-trois million quatre cent et soixante-dix-un mille six cent et vingt-quatre";
      string result = FunctionsString.NumberToFrenchWords(363471624);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_seven_hundred_and_eighty_three_million_three_hundred_and_sixty_one_thousand_six_hundred_and_twenty_five()
    {
      const string expected = "seven hundred and eighty-three million three hundred and sixty-one thousand six hundred and twenty-five";
      string result = FunctionsString.NumberToEnglishWords(783361625);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_sept_cent_et_quatre_vingt_trois_million_trois_cent_et_soixante_un_mille_six_cent_et_vingt_cinq()
    {
      const string expected = "sept cent et quatre-vingt-trois million trois cent et soixante-un mille six cent et vingt-cinq";
      string result = FunctionsString.NumberToFrenchWords(783361625);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_four_hundred_and_fifty_seven_million_one_hundred_and_thirty_one_thousand_three_hundred_and_twenty_eight()
    {
      const string expected = "four hundred and fifty-seven million one hundred and thirty-one thousand three hundred and twenty-eight";
      string result = FunctionsString.NumberToEnglishWords(457131328);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_quatre_cent_et_cinquante_sept_million_un_cent_et_trente_un_mille_trois_cent_et_vingt_huit()
    {
      const string expected = "quatre cent et cinquante-sept million un cent et trente-un mille trois cent et vingt-huit";
      string result = FunctionsString.NumberToFrenchWords(457131328);
      Assert.AreEqual(expected, result);
    }
    #endregion Random Unit tests generated
    #region GenerateString method Unit tests
    //**************************GenerateRandomString Method****
    [TestMethod]
    public void TestMethod_GenerateRandomString_true_LowerCase_default_length()
    {
      char[] source = new char[] { };
      const byte stringLength = 8;
      string result = FunctionsString.GenerateRandomString(source, false, 
        FunctionsString.RandomCharacters.LowerCase);
      Assert.AreEqual(result.Length, stringLength);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_true_LowerCase_length_of_20()
    {
      char[] source = new char[] { };
      const byte stringLength = 20;
      string result = FunctionsString.GenerateRandomString(source, false,
        FunctionsString.RandomCharacters.LowerCase, stringLength);
      Assert.AreEqual(result.Length, stringLength);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_true_LowerCase_length_of_byte_MaxValue()
    {
      char[] source = new char[] { };
      const byte stringLength = byte.MaxValue;
      string result = FunctionsString.GenerateRandomString(source, false,
        FunctionsString.RandomCharacters.LowerCase, stringLength);
      Assert.AreEqual(result.Length, stringLength);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_true_lower_case()
    {
      char[] source = new char[] { };
      string result = FunctionsString.GenerateRandomString(source, false,
        FunctionsString.RandomCharacters.LowerCase);
      Assert.AreEqual(result.ToLower(), result);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperCase_true_upper_case()
    {
      char[] source = new char[] { };
      string result = FunctionsString.GenerateRandomString(source, false,
        FunctionsString.RandomCharacters.UpperCase);
      Assert.AreEqual(result.ToUpper(), result);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_digit_true()
    {
      const bool expected = true;
      char[] source = new char[] { };
      string result = FunctionsString.GenerateRandomString(source, false,
        FunctionsString.RandomCharacters.Digit);
      Assert.AreEqual(FunctionsString.IsNumeric2(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_false_SpecialCharacter_no_digit()
    {
      const bool expected = false;
      char[] source = new char[] { };
      string result = FunctionsString.GenerateRandomString(source, false,
        FunctionsString.RandomCharacters.SpecialCharacter);
      Assert.AreEqual(FunctionsString.IsNumeric2(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_false_SpecialCharacter_no_vowel()
    {
      const bool expected = false;
      char[] source = new char[] { };
      string result = FunctionsString.GenerateRandomString(source, false,
        FunctionsString.RandomCharacters.SpecialCharacter);
      Assert.AreEqual(FunctionsString.HasVowels(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_false_SpecialCharacter_no_consonant()
    {
      const bool expected = false;
      char[] source = new char[] { };
      string result = FunctionsString.GenerateRandomString(source, false,
        FunctionsString.RandomCharacters.SpecialCharacter);
      Assert.AreEqual(FunctionsString.HasConsonants(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_true_DigitSpecialChar_length_default()
    {
      char[] source = new char[] { };
      const byte stringLength = 250;
      string result = FunctionsString.GenerateRandomString(source, false,
        FunctionsString.RandomCharacters.DigitSpecialChar, stringLength);
      Assert.AreEqual(result.Length, stringLength);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_true_DigitSpecialChar_has_digit()
    {
      const bool expected = true;
      char[] source = new char[] { };
      const byte stringLength = 254;
      string result = FunctionsString.GenerateRandomString(source, false,
        FunctionsString.RandomCharacters.DigitSpecialChar, stringLength);
      Assert.AreEqual(FunctionsString.HasNumeric(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLower_true_has_consonant()
    {
      const bool expected = true;
      char[] source = new char[] { };
      const byte stringLength = 254;
      string result = FunctionsString.GenerateRandomString(source, false,
        FunctionsString.RandomCharacters.UpperLower, stringLength);
      Assert.AreEqual(FunctionsString.HasConsonants(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperLower_true_has_vowel()
    {
      const bool expected = true;
      char[] source = new char[] { };
      const byte stringLength = 254;
      string result = FunctionsString.GenerateRandomString(source, false,
        FunctionsString.RandomCharacters.UpperLower, stringLength);
      Assert.AreEqual(FunctionsString.HasVowels(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_LowerDigit_true_has_digit()
    {
      const bool expected = true;
      char[] source = new char[] { };
      const byte stringLength = 254;
      string result = FunctionsString.GenerateRandomString(source, false,
        FunctionsString.RandomCharacters.LowerDigit, stringLength);
      Assert.AreEqual(FunctionsString.HasVowels(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_LowerDigit_true_has_letters()
    {
      const bool expected = true;
      char[] source = new char[] { };
      const byte stringLength = 254;
      string result = FunctionsString.GenerateRandomString(source, false,
        FunctionsString.RandomCharacters.LowerDigit, stringLength);
      Assert.AreEqual(FunctionsString.HasSomeLetters(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_LowerDigit_true_has_lower_case_letters()
    {
      const bool expected = true;
      char[] source = new char[] { };
      const byte stringLength = 254;
      string result = FunctionsString.GenerateRandomString(source, false,
        FunctionsString.RandomCharacters.LowerDigit, stringLength);
      Assert.AreEqual(FunctionsString.HasSomeLowerCaseLetters(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperDigit_true_has_digit()
    {
      const bool expected = true;
      char[] source = new char[] { };
      const byte stringLength = 254;
      string result = FunctionsString.GenerateRandomString(source, false,
        FunctionsString.RandomCharacters.UpperDigit, stringLength);
      Assert.AreEqual(FunctionsString.HasVowels(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperDigit_true_has_letters()
    {
      const bool expected = true;
      char[] source = new char[] { };
      const byte stringLength = 254;
      string result = FunctionsString.GenerateRandomString(source, false,
        FunctionsString.RandomCharacters.UpperDigit, stringLength);
      Assert.AreEqual(FunctionsString.HasSomeLetters(result), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateRandomString_UpperDigit_true_has_Upper_case_letters()
    {
      const bool expected = true;
      char[] source = new char[] { };
      const byte stringLength = 254;
      string result = FunctionsString.GenerateRandomString(source, false,
        FunctionsString.RandomCharacters.UpperDigit, stringLength);
      Assert.AreEqual(FunctionsString.HasSomeUpperCaseLetters(result), expected);
    }

    #endregion GenerateString method Unit tests
    #region HasSomeLowerCaseLetters method Unit tests
    //*********************HasSomeLowerCaseLetters*******
    [TestMethod]
    public void TestMethod_HasSomeLowerCaseLetters_true()
    {
      string source = "azerty and qwerty";
      const bool expected = true;
      bool result = FunctionsString.HasSomeLowerCaseLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasSomeLowerCaseLetters_false()
    {
      string source = "AZERTY AND QWERTY";
      const bool expected = false;
      bool result = FunctionsString.HasSomeLowerCaseLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasSomeLowerCaseLetters_true_one_letter()
    {
      string source = "AZERTY AND QWERTy";
      const bool expected = true;
      bool result = FunctionsString.HasSomeLowerCaseLetters(source);
      Assert.AreEqual(result, expected);
    }
    #endregion HasSomeLowerCaseLetters method Unit tests
    #region HasSomeUpperCaseLetters method Unit tests
    //*********************HasSomeUpperCaseLetters*******
    [TestMethod]
    public void TestMethod_HasSomeUpperCaseLetters_false()
    {
      string source = "azerty and qwerty";
      const bool expected = false;
      bool result = FunctionsString.HasSomeUpperCaseLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasSomeUpperCaseLetters_true()
    {
      string source = "AZERTY AND QWERTY";
      const bool expected = true;
      bool result = FunctionsString.HasSomeUpperCaseLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasSomeUpperCaseLetters_true_one_letter()
    {
      string source = "azerty and qwertY";
      const bool expected = true;
      bool result = FunctionsString.HasSomeUpperCaseLetters(source);
      Assert.AreEqual(result, expected);
    }
    #endregion HasSomeUpperCaseLetters method Unit tests
    #endregion

    #region Files Methods
    //**************************GenerateUniqueFileName Methods****
    [TestMethod]
    public void TestMethod_GenerateUniqueFileName_true_file_does_not_exist()
    {
      const string sourceDir = @"c:\temp\UnitTestVS\";
      FunctionsFiles.CreateDirectory(sourceDir);
      const string sourceFile = @"c:\temp\UnitTestVS\test.txt";
      const string expected =   @"c:\temp\UnitTestVS\test.txt";
      string result = FunctionsFiles.GenerateUniqueFileName(sourceFile);
      Assert.AreEqual(result, expected);
      FunctionsFiles.DeleteDirectory(sourceDir);
    }

    [TestMethod]
    public void TestMethod_GenerateUniqueFileName_true_increment_filename_by_one()
    {
      const string sourceDir = @"c:\temp\UnitTestVS\";
      FunctionsFiles.CreateDirectory(sourceDir);
      const string sourceFile = @"c:\temp\UnitTestVS\test.txt";
      FunctionsFiles.CreateFile(sourceFile);
      const string expected = @"c:\temp\UnitTestVS\test1.txt";
      string result = FunctionsFiles.GenerateUniqueFileName(sourceFile);
      Assert.AreEqual(result, expected);
      Thread.Sleep(5000);
      FunctionsFiles.Deletefile(sourceFile);
      FunctionsFiles.DeleteDirectory(sourceDir);
    }

    [TestMethod]
    public void TestMethod_GenerateUniqueFileName_true_increment_filename_by_one_one()
    {
      const string sourceDir = @"c:\temp\UnitTestVS\";
      FunctionsFiles.CreateDirectory(sourceDir);
      const string sourceFile = @"c:\temp\UnitTestVS\test1.txt";
      FunctionsFiles.CreateFile(sourceFile);
      const string expected = @"c:\temp\UnitTestVS\test11.txt";
      string result = FunctionsFiles.GenerateUniqueFileName(sourceFile);
      Assert.AreEqual(result, expected);
      FunctionsFiles.Deletefile(sourceFile);
      FunctionsFiles.DeleteDirectory(sourceDir);
    }

    [TestMethod]
    public void TestMethod_GenerateUniqueFileName_true_increment_filename_by_two()
    {
      const string sourceDir = @"c:\temp\UnitTestVS\";
      FunctionsFiles.CreateDirectory(sourceDir);
      const string sourceFile = @"c:\temp\UnitTestVS\test.txt";
      FunctionsFiles.CreateFile(sourceFile);
      FunctionsFiles.CreateFile(@"c:\temp\UnitTestVS\test1.txt");
      const string expected = @"c:\temp\UnitTestVS\test2.txt";
      string result = FunctionsFiles.GenerateUniqueFileName(sourceFile);
      Assert.AreEqual(result, expected);
      FunctionsFiles.Deletefile(sourceFile);
      FunctionsFiles.CreateFile(@"c:\temp\UnitTestVS\test1.txt");
      FunctionsFiles.DeleteDirectory(sourceDir);
    }

    
    #endregion Files Methods

    #region Useful Methods
    #region IsMorning Methods
    //**********************IsMorning Methods***************
    [TestMethod]
    public void TestMethod_IsMorning_true()
    {
      DateTime source = new DateTime(2015, 03, 22, 11, 58, 00);
      const bool expected = true;
      bool result = FunctionsDateTime.IsMorning(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsMorning_false()
    {
      DateTime source = new DateTime(2015, 03, 22, 14, 58, 00);
      const bool expected = false;
      bool result = FunctionsDateTime.IsMorning(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsMorning_noon_is_false()
    {
      DateTime source = new DateTime(2015, 03, 22, 12, 00, 00);
      const bool expected = false;
      bool result = FunctionsDateTime.IsMorning(source);
      Assert.AreEqual(result, expected);
    }
    #endregion IsMorning Methods
    #region OutsideWeekEnd Methods
    //**********************OutsideWeekEnd Methods***************

    [TestMethod]
    public void TestMethod_OutsideWeekEnd_false()
    {
      DateTime source = new DateTime(2015, 03, 22, 11, 58, 00);
      const bool expected = false;
      bool result = FunctionsDateTime.OutsideWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_OutsideWeekEnd_true()
    {
      DateTime source = new DateTime(2015, 03, 23, 14, 58, 00);
      const bool expected = true;
      bool result = FunctionsDateTime.OutsideWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_OutsideWeekEnd_false_January_first_2000()
    {
      DateTime source = new DateTime(2000, 01, 01, 14, 58, 00);
      const bool expected = false;
      bool result = FunctionsDateTime.OutsideWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_OutsideWeekEnd_true_nine_eleven_2001()
    {
      DateTime source = new DateTime(2001, 09, 11, 10, 11, 00);
      const bool expected = true;
      bool result = FunctionsDateTime.OutsideWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_OutsideWeekEnd_true_Jesus_birth()
    {
      DateTime source = new DateTime(1, 12, 25, 1, 0, 0);
      const bool expected = true;
      bool result = FunctionsDateTime.OutsideWeekEnd(source);
      Assert.AreEqual(result, expected);
    }
    #endregion OutsideWeekEnd Methods
    //**********************IsWeekEnd Methods*********************
    #region IsWeekEnd Methods
    [TestMethod]
    public void TestMethod_IsWeekEnd_true()
    {
      DateTime source = new DateTime(2015, 03, 22, 11, 58, 00);
      const bool expected = true;
      bool result = FunctionsDateTime.IsWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsWeekEnd_false()
    {
      DateTime source = new DateTime(2015, 03, 23, 14, 58, 00);
      const bool expected = false;
      bool result = FunctionsDateTime.IsWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsWeekEnd_true_January_first_2000()
    {
      DateTime source = new DateTime(2000, 01, 01, 14, 58, 00);
      const bool expected = true;
      bool result = FunctionsDateTime.IsWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsWeekEnd_false_nine_eleven_2001()
    {
      DateTime source = new DateTime(2001, 09, 11, 10, 11, 00);
      const bool expected = false;
      bool result = FunctionsDateTime.IsWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsWeekEnd_false_Jesus_birth()
    {
      DateTime source = new DateTime(1, 12, 25, 1, 0, 0);
      const bool expected = false;
      bool result = FunctionsDateTime.IsWeekEnd(source);
      Assert.AreEqual(result, expected);
    }
    #endregion IsWeekEnd Methods
    //**********************DateToByteArray Methods***************
    #region DateToByteArray Methods
    //**********************DateToByteArray Methods***************
    [TestMethod]
    public void TestMethod_DateToByteArray_true()
    {
      byte[] source = { 0x20, 0x15, 0x03, 0x27, 0x13, 0x30, 0x00, 0x00, 0x00 };
      DateTime expected = new DateTime(01, 01, 01, 00, 00, 00, DateTimeKind.Local);
      DateTime result = FunctionsDateTime.ByteArrayToDate(source);
      Assert.IsTrue(result == expected);
    }

    [TestMethod]
    public void TestMethod_DateToByteArray_false()
    {
      byte[] source = { 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01 };
      DateTime expected = new DateTime(1601, 03, 03, 05, 18, 01);
      DateTime result = FunctionsDateTime.ByteArrayToDate(source);
      Assert.AreNotEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DateToByteArray_false_length_not_equal_to_eight()
    {
      byte[] source = { 0x01, 0x01, 0x01, 0x01};
      DateTime expected = new DateTime();
      DateTime result = FunctionsDateTime.ByteArrayToDate(source);
      Assert.AreEqual(result, expected);
    }
    #endregion DateToByteArray Methods
    #region ByteArrayToString Methods
    //**********************ByteArrayToString Methods***************
    [TestMethod]
    public void TestMethod_ByteArrayToHexString_true()
    {
      byte[] source = { 0x01, 0x02, 0x03, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17 };
      const string expected = "010203091011121314151617";
      string result = FunctionsDateTime.ByteArrayToString(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ByteArrayToString_true_one()
    {
      byte[] source = { 0x01};
      const string expected = "01";
      string result = FunctionsDateTime.ByteArrayToString(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ByteArrayToHexString_false()
    {
      byte[] source = { 0x01, 0x02, 0x03, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17 };
      const string expected = "01";
      string result = FunctionsDateTime.ByteArrayToString(source);
      Assert.AreNotEqual(result, expected);
    }

    #endregion ByteArrayToString Methods

    #region HexStringToByteArray Methods
    [TestMethod]
    public void TestMethod_HexStringToByteArray_true()
    {
      string source = "010203091011121314151617";
      byte[] expected = { 0x01, 0x02, 0x03, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17 };
      byte[] result = FunctionsDateTime.HexStringToByteArray(source);
      for (int i = 0; i < expected.Length; i++)
      {
        Assert.IsTrue(result[i] == expected[i]);
      }
    }

    [TestMethod]
    public void TestMethod_HexStringToByteArray_true_two_values()
    {
      string source = "0102";
      byte[] expected = { 0x01, 0x02 };
      byte[] result = FunctionsDateTime.HexStringToByteArray(source);
      Assert.IsTrue(result[0] == expected[0]);
      Assert.IsTrue(result[1] == expected[1]);
    }

    [TestMethod]
    public void TestMethod_HexStringToByteArray_false()
    {
      string source = "010203091011121314151617";
      byte[] expected = { 0x01 };
      byte[] result = FunctionsDateTime.HexStringToByteArray(source);
      Assert.AreNotEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HexStringToByteArray_false_not_even_length()
    {
      string source = "01020";
      byte[] expected = { 0x01, 0x02 };
      byte[] result = FunctionsDateTime.HexStringToByteArray(source);
      Assert.AreNotEqual(result, expected);
    }

    #endregion HexStringToByteArray Methods

    #endregion Useful Methods
  }
}