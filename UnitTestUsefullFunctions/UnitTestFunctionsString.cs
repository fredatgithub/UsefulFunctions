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
using StringFunc = FonctionsUtiles.Fred.Csharp.FunctionsString;
using MathFunc = FonctionsUtiles.Fred.Csharp.FunctionsMath;
using System.Collections.Generic;
using System;
using System.Globalization;

namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestFunctionsString
  {
    
    #region Math functions
    #region Math functions - Factorial
    [TestMethod]
    public void TestMethod_Factorial_one()
    {
      long result = MathFunc.Factorial(1);
      Assert.IsTrue(result == 1);
    }

    [TestMethod]
    public void TestMethod_Factorial_two()
    {
      long result = MathFunc.Factorial(2);
      Assert.IsTrue(result == 2);
    }

    [TestMethod]
    public void TestMethod_Factorial_three()
    {
      long result = MathFunc.Factorial(3);
      Assert.IsTrue(result == 6);
    }

    [TestMethod]
    public void TestMethod_Factorial_four()
    {
      long result = MathFunc.Factorial(4);
      Assert.IsTrue(result == 24);
    }

    [TestMethod]
    public void TestMethod_Factorial_five()
    {
      long result = MathFunc.Factorial(5);
      Assert.IsTrue(result == 120);
    }

    [TestMethod]
    public void TestMethod_Factorial_six()
    {
      long result = MathFunc.Factorial(6);
      Assert.IsTrue(result == 720);
    }

    [TestMethod]
    public void TestMethod_Factorial_seven()
    {
      long result = MathFunc.Factorial(7);
      Assert.IsTrue(result == 5040);
    }

    [TestMethod]
    public void TestMethod_Factorial_eight()
    {
      long result = MathFunc.Factorial(8);
      Assert.IsTrue(result == 40320);
    }

    [TestMethod]
    public void TestMethod_Factorial_nine()
    {
      long result = MathFunc.Factorial(9);
      Assert.IsTrue(result == 362880);
    }

    [TestMethod]
    public void TestMethod_Factorial_ten()
    {
      long result = MathFunc.Factorial(10);
      Assert.IsTrue(result == 3628800);
    }

    [TestMethod]
    public void TestMethod_Factorial_eleven()
    {
      long result = MathFunc.Factorial(11);
      Assert.IsTrue(result == 39916800);
    }

    [TestMethod]
    public void TestMethod_Factorial_twelve()
    {
      long result = MathFunc.Factorial(12);
      Assert.IsTrue(result == 479001600);
    }

    [TestMethod]
    public void TestMethod_Factorial_thirteen()
    {
      long result = MathFunc.Factorial(13);
      Assert.IsTrue(result == 6227020800);
    }

    [TestMethod]
    public void TestMethod_Factorial_fourteen()
    {
      long result = MathFunc.Factorial(14);
      Assert.IsTrue(result == 87178291200);
    }

    [TestMethod]
    public void TestMethod_Factorial_fifteen()
    {
      long result = MathFunc.Factorial(15);
      Assert.IsTrue(result == 1307674368000);
    }

    [TestMethod]
    public void TestMethod_Factorial_sixteen()
    {
      long result = MathFunc.Factorial(16);
      Assert.IsTrue(result == 20922789888000);
    }

    [TestMethod]
    public void TestMethod_Factorial_seventeen()
    {
      long result = MathFunc.Factorial(17);
      Assert.IsTrue(result == 355687428096000);
    }

    [TestMethod]
    public void TestMethod_Factorial_eighteen()
    {
      long result = MathFunc.Factorial(18);
      Assert.IsTrue(result == 6402373705728000);
    }

    [TestMethod]
    public void TestMethod_Factorial_nineteen()
    {
      long result = MathFunc.Factorial(19);
      Assert.IsTrue(result == 121645100408832000);
    }

    [TestMethod]
    public void TestMethod_Factorial_twenty()
    {
      long result = MathFunc.Factorial(20);
      Assert.IsTrue(result == 2432902008176640000);
    }

    [TestMethod]
    public void TestMethod_Factorial_twentyOne()
    {
      long result = MathFunc.Factorial(21);
      Assert.IsTrue(result < 0); // negative number
    }

    [TestMethod]
    public void TestMethod_Factorial_Negative_number()
    {
      long result = MathFunc.Factorial(-3);
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_Factorial_zero()
    {
      long result = MathFunc.Factorial(0);
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_Factorial_lowerBound_one_step()
    {
      long result = MathFunc.Factorial(10, 9);
      Assert.IsTrue(result == 10);
    }

    [TestMethod]
    public void TestMethod_Factorial_lowerBound_two_step()
    {
      long result = MathFunc.Factorial(10, 8);
      Assert.IsTrue(result == 90);
    }
    #endregion Math functions - Factorial
    #region Math functions - Recursive Factorial
    // **********************Recursive Factorial****************
    [TestMethod]
    public void TestMethod_RecursiveFactorial_one()
    {
      ulong result = MathFunc.RecursiveFactorial(1);
      Assert.IsTrue(result == 1);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_two()
    {
      ulong result = MathFunc.RecursiveFactorial(2);
      Assert.IsTrue(result == 2);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_three()
    {
      ulong result = MathFunc.RecursiveFactorial(3);
      Assert.IsTrue(result == 6);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_four()
    {
      ulong result = MathFunc.RecursiveFactorial(4);
      Assert.IsTrue(result == 24);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_five()
    {
      ulong result = MathFunc.RecursiveFactorial(5);
      Assert.IsTrue(result == 120);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_six()
    {
      ulong result = MathFunc.RecursiveFactorial(6);
      Assert.IsTrue(result == 720);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_seven()
    {
      ulong result = MathFunc.RecursiveFactorial(7);
      Assert.IsTrue(result == 5040);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_eight()
    {
      ulong result = MathFunc.RecursiveFactorial(8);
      Assert.IsTrue(result == 40320);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_nine()
    {
      ulong result = MathFunc.RecursiveFactorial(9);
      Assert.IsTrue(result == 362880);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_ten()
    {
      ulong result = MathFunc.RecursiveFactorial(10);
      Assert.IsTrue(result == 3628800);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_eleven()
    {
      ulong result = MathFunc.RecursiveFactorial(11);
      Assert.IsTrue(result == 39916800);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_twelve()
    {
      ulong result = MathFunc.RecursiveFactorial(12);
      Assert.IsTrue(result == 479001600);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_thirteen()
    {
      ulong result = MathFunc.RecursiveFactorial(13);
      Assert.IsTrue(result == 6227020800);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_fourteen()
    {
      ulong result = MathFunc.RecursiveFactorial(14);
      Assert.IsTrue(result == 87178291200);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_fifteen()
    {
      ulong result = MathFunc.RecursiveFactorial(15);
      Assert.IsTrue(result == 1307674368000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_sixteen()
    {
      ulong result = MathFunc.RecursiveFactorial(16);
      Assert.IsTrue(result == 20922789888000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_seventeen()
    {
      ulong result = MathFunc.RecursiveFactorial(17);
      Assert.IsTrue(result == 355687428096000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_eighteen()
    {
      ulong result = MathFunc.RecursiveFactorial(18);
      Assert.IsTrue(result == 6402373705728000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_nineteen()
    {
      ulong result = MathFunc.RecursiveFactorial(19);
      Assert.IsTrue(result == 121645100408832000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_twenty()
    {
      ulong result = MathFunc.RecursiveFactorial(20);
      Assert.IsTrue(result == 2432902008176640000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_twentyOne()
    {
      ulong result = MathFunc.RecursiveFactorial(21);
      Assert.IsTrue(result == 14197454024290336768);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_Negative_number()
    {
      ulong result = MathFunc.RecursiveFactorial(-3);
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_zero()
    {
      ulong result = MathFunc.RecursiveFactorial(0);
      Assert.IsTrue(result == 0);
    }
    #endregion Math functions - Recursive Factorial
    #region Math functions - Sommielle
    // **********************Sommielle****************
    [TestMethod]
    public void TestMethod_Sommielle_zero()
    {
      long result = MathFunc.Sommielle(0, 0);
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_Sommielle_one_interval()
    {
      long result = MathFunc.Sommielle(0, 1);
      Assert.IsTrue(result == 1);
    }

    [TestMethod]
    public void TestMethod_Sommielle_two_interval()
    {
      long result = MathFunc.Sommielle(1, 3);
      Assert.IsTrue(result == 6);
    }

    [TestMethod]
    public void TestMethod_Sommielle_inverted_max_min()
    {
      long result = MathFunc.Sommielle(3, 1);
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_Sommielle_zero_ten()
    {
      long result = MathFunc.Sommielle(0, 10);
      Assert.IsTrue(result == 55);
    }

    [TestMethod]
    public void TestMethod_Sommielle_zero_twentyFour()
    {
      long result = MathFunc.Sommielle(0, 24);
      Assert.IsTrue(result == 300);
    }

    [TestMethod]
    public void TestMethod_Sommielle_zero_fifty()
    {
      long result = MathFunc.Sommielle(0, 50);
      Assert.IsTrue(result == 1275);
    }

    [TestMethod]
    public void TestMethod_Sommielle_ten_ten()
    {
      long result = MathFunc.Sommielle(10, 10);
      Assert.IsTrue(result == 10);
    }

    [TestMethod]
    public void TestMethod_Sommielle_zero_hundred()
    {
      long result = MathFunc.Sommielle(0, 100);
      Assert.IsTrue(result == 5050);
    }

    [TestMethod]
    public void TestMethod_Sommielle_zero_hundredAndFifty()
    {
      long result = MathFunc.Sommielle(0, 150);
      Assert.IsTrue(result == 11325);
    }
    #endregion Math functions - Sommielle
    #region Math functions - Sommielle Recursive
    // **********************Sommielle Recursive****************
    [TestMethod]
    public void TestMethod_SommielleRecursive_zero()
    {
      long result = MathFunc.SommielleRecursive(0, 0);
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_one_interval()
    {
      long result = MathFunc.SommielleRecursive(0, 1);
      Assert.IsTrue(result == 1);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_two_interval()
    {
      long result = MathFunc.SommielleRecursive(1, 3);
      Assert.IsTrue(result == 6);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_inverted_max_min()
    {
      long result = MathFunc.SommielleRecursive(3, 1);
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_zero_ten()
    {
      long result = MathFunc.SommielleRecursive(0, 10);
      Assert.IsTrue(result == 55);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_zero_twentyFour()
    {
      long result = MathFunc.SommielleRecursive(0, 24);
      Assert.IsTrue(result == 300);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_zero_fifty()
    {
      long result = MathFunc.SommielleRecursive(0, 50);
      Assert.IsTrue(result == 1275);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_ten_ten()
    {
      long result = MathFunc.SommielleRecursive(10, 10);
      Assert.IsTrue(result == 10);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_zero_hundred()
    {
      long result = MathFunc.SommielleRecursive(0, 100);
      Assert.IsTrue(result == 5050);
    }
    #endregion Math functions - Sommielle Recursive
    #endregion
    #region String Functions

    //**********************String Functions***************
    [TestMethod]
    public void TestMethod_HasDuplicate_no_on_One_item()
    {
      int[] source = { 1 };
      bool result = StringFunc.HasDuplicate(source);
      Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_yes_on_Two_items()
    {
      int[] source = { 1, 1 };
      bool result = StringFunc.HasDuplicate(source);
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_no_on_Two_items()
    {
      int[] source = { 1, 2 };
      bool result = StringFunc.HasDuplicate(source);
      Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_none()
    {
      int[] source = { 1, 2, 3, 4 };
      bool result = StringFunc.HasDuplicate(source);
      Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_yes_on_Empty_list_because_all_items_equal_zero()
    {
      int[] source = new int[5];
      bool result = StringFunc.HasDuplicate(source);
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_null_list()
    {
      int[] source = null;
      bool result = StringFunc.HasDuplicate(source);
      Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_no_on_several_items()
    {
      bool result = StringFunc.HasDuplicate(1, 2, 3, 4, 5, 6, 7, 8, 9);
      Assert.IsFalse(result);
    }


    [TestMethod]
    public void TestMethod_HasDuplicate_yes_on_several_items()
    {
      bool result = StringFunc.HasDuplicate(1, 2, 3, 4, 5, 6, 7, 8, 9, 1);
      Assert.IsTrue(result);
    }
    
    // **********************EndPadding****************
    [TestMethod]
    public void TestMethod_EndPadding()
    {
      string result = StringFunc.EndPadding("azerty", 8);
      Assert.IsTrue(result == "azerty  ");
    }

    [TestMethod]
    public void TestMethod_EndPadding_length()
    {
      string result = StringFunc.EndPadding("azerty", 8);
      Assert.IsTrue(result.Length == 8);
    }

    [TestMethod]
    public void TestMethod_EndPadding_none_length()
    {
      string result = StringFunc.EndPadding("azerty", 6);
      Assert.IsTrue(result.Length == 6);
    }

    [TestMethod]
    public void TestMethod_EndPadding_none_string()
    {
      string result = StringFunc.EndPadding("azerty", 6);
      Assert.IsTrue(result == "azerty");
    }

    // **********************GetFileNameAfterLastSlash****************
    [TestMethod]
    public void TestMethod_GetFileNameAfterLastSlash()
    {
      string result = StringFunc.GetFileNameAfterLastSlash(@"C:\tmp\texte.txt");
      Assert.IsTrue(result == "texte.txt");
    }

    [TestMethod]
    public void TestMethod_GetFileNameAfterLastSlash_empty_string()
    {
      string result = StringFunc.GetFileNameAfterLastSlash(@"");
      Assert.IsTrue(result == "");
    }

    [TestMethod]
    public void TestMethod_GetFileNameAfterLastSlash_no_path()
    {
      string result = StringFunc.GetFileNameAfterLastSlash(@"texte.txt");
      Assert.IsTrue(result == "texte.txt");
    }

    // **********************RemoveInString****************
    [TestMethod]
    public void TestMethod_RemoveInString()
    {
      string result = StringFunc.RemoveInString("azerty", "azertyuiop");
      Assert.IsTrue(result == "uiop");
    }

    [TestMethod]
    public void TestMethod_RemoveInString_with_trim_end_equal_to_true()
    {
      string result = StringFunc.RemoveInString("azerty", "azertyuiop ", true);
      Assert.IsTrue(result == "uiop");
    }

    [TestMethod]
    public void TestMethod_RemoveInString_with_trim_end_equal_to_false()
    {
      string result = StringFunc.RemoveInString("azerty", "azertyuiop ");
      Assert.IsTrue(result == "uiop ");
    }

    [TestMethod]
    public void TestMethod_RemoveInString__nothing()
    {
      string result = StringFunc.RemoveInString("azerty", "uiop");
      Assert.IsTrue(result == "uiop");
    }

    // **********************CamelCase****************
    [TestMethod]
    public void TestMethod_CamelCase_a_sentence()
    {
      string result = StringFunc.CamelCase("once upon a time");
      Assert.IsTrue(result == "Once Upon A Time");
    }

    [TestMethod]
    public void TestMethod_CamelCase_one_word()
    {
      string result = StringFunc.CamelCase("azerty");
      Assert.IsTrue(result == "Azerty");
    }

    [TestMethod]
    public void TestMethod_CamelCase_string_empty()
    {
      string result = StringFunc.CamelCase("");
      Assert.IsTrue(result == "");
    }

    // **********************IsNumeric****************
    [TestMethod]
    public void TestMethod_IsNumeric_A_character()
    {
      bool result = StringFunc.IsNumeric('a');
      Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod_IsNumeric_a_digit()
    {
      bool result = StringFunc.IsNumeric("4");
      Assert.IsTrue(result);
    }

    // **********************IsLetter****************
    [TestMethod]
    public void TestMethod_IsLetter_()
    {
      bool result = StringFunc.IsLetter('a');
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestMethod_IsLetter_upperCase()
    {
      bool result = StringFunc.IsLetter('A');
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestMethod_IsLetter_upperCase_blank()
    {
      bool result = StringFunc.IsLetter(' ');
      Assert.IsFalse(result);
    }

    // **********************Plural****************
    [TestMethod]
    public void TestMethod_Plural_zero()
    {
      string result = StringFunc.Plural(0);
      Assert.IsTrue(result == string.Empty);
    }

    [TestMethod]
    public void TestMethod_Plural_one()
    {
      string result = StringFunc.Plural(1);
      Assert.IsTrue(result == string.Empty);
    }

    [TestMethod]
    public void TestMethod_Plural_two()
    {
      string result = StringFunc.Plural(2);
      Assert.IsTrue(result == "s");
    }

    // **********************StringOccurrenceWithContains****************
    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains()
    {
      int result = StringFunc.StringOccurrenceWithContains("azerty", "zer");
      Assert.IsTrue(result == 1);
    }

    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains_search_empty_string()
    {
      int result = StringFunc.StringOccurrenceWithContains("azerty", "");
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains_with_empty_string()
    {
      int result = StringFunc.StringOccurrenceWithContains("", "azerty");
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains_both_empty_string()
    {
      int result = StringFunc.StringOccurrenceWithContains("", "");
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains_two_occurences()
    {
      int result = StringFunc.StringOccurrenceWithContains("azertyqwerty", "erty");
      Assert.IsTrue(result == 2);
    }

    [TestMethod]
    public void TestMethod_StringOccurrenceWithContains_three_occurences()
    {
      int result = StringFunc.StringOccurrenceWithContains("azertyqwertyandanyothererty", "erty");
      Assert.IsTrue(result == 3);
    }

    // **********************ByteArrayToHexaString****************
    [TestMethod]
    public void TestMethod_ByteArrayToHexaString_two_elements()
    {
      byte[] source = new byte[2];
      source[0] = 0x01;
      source[1] = 0x02;
      string result = StringFunc.ByteArrayToHexaString(source);
      Assert.IsTrue(result == "0102");
    }

    [TestMethod]
    public void TestMethod_ByteArrayToHexaString_two_elements_OneDigitOnly()
    {
      byte[] source = new byte[2];
      source[0] = 0x01;
      source[1] = 0x02;
      string result = StringFunc.ByteArrayToHexaString(source, true);
      Assert.IsTrue(result == "12");
    }

    [TestMethod]
    public void TestMethod_ByteArrayToHexaString_three_elements()
    {
      byte[] source = { 0x01, 0x02, 0x03 };
      string result = StringFunc.ByteArrayToHexaString(source);
      Assert.IsTrue(result == "010203");
    }

    [TestMethod]
    public void TestMethod_ByteArrayToHexaString_three_elements_OneDigitOnly()
    {
      byte[] source = { 0x01, 0x02, 0x03 };
      string result = StringFunc.ByteArrayToHexaString(source, true);
      Assert.IsTrue(result == "123");
    }

    [TestMethod]
    public void TestMethod_ByteArrayToHexaString_empty_source()
    {
      byte[] source = { };
      string result = StringFunc.ByteArrayToHexaString(source);
      Assert.IsTrue(result == "");
    }

    [TestMethod]
    public void TestMethod_ByteArrayToHexaString_empty_source_OneDigitOnly()
    {
      byte[] source = { };
      string result = StringFunc.ByteArrayToHexaString(source, true);
      Assert.IsTrue(result == "");
    }

    // **********************HexaStringToByteArray****************
    [TestMethod]
    public void TestMethod_HexaStringToByteArray_three_elements()
    {
      string source = "010203";
      byte[] result2 = new byte[3];
      result2[0] = 0x01;
      result2[1] = 0x02;
      result2[2] = 0x03;
      byte[] result = StringFunc.HexaStringToByteArray(source);
      Assert.AreEqual(result[0], result2[0]);
      Assert.AreEqual(result[1], result2[1]);
      Assert.AreEqual(result[2], result2[2]);
    }

    [TestMethod]
    public void TestMethod_HexaStringToByteArray_one_element()
    {
      string source = "01";
      byte[] result2 = new byte[1];
      result2[0] = 0x01;
      byte[] result = StringFunc.HexaStringToByteArray(source);
      Assert.AreEqual(result[0], result2[0]);
    }

    [TestMethod]
    public void TestMethod_HexaStringToByteArray_empty_string()
    {
      // TODO debug
      //string source = "";
      //byte[] expected = new byte[0];
      //byte[] result = StringFunc.HexaStringToByteArray(source);
      //Assert.AreEqual(result, expected);
    }

    // **********************ReverseString****************
    [TestMethod]
    public void TestMethod_ReverseString()
    {
      string source = "123456789";
      string result = StringFunc.ReverseString(source);
      Assert.IsTrue(result == "987654321");
    }

    [TestMethod]
    public void TestMethod_ReverseString_on_an_empty_string()
    {
      string source = "";
      string result = StringFunc.ReverseString(source);
      Assert.IsTrue(result == "");
    }

    [TestMethod]
    public void TestMethod_ReverseString_one_element()
    {
      string source = "1";
      string result = StringFunc.ReverseString(source);
      Assert.IsTrue(result == "1");
    }

    [TestMethod]
    public void TestMethod_ReverseString_palindrome()
    {
      string source = "laval";
      string result = StringFunc.ReverseString(source);
      Assert.IsTrue(result == source);
    }

    [TestMethod]
    public void TestMethod_ReverseString_several_palindromes()
    {
      List<string> sourceWords = new List<string> { "laval", "lol", "ete", "lieur à rueil" };
      foreach (string source in sourceWords)
      {
        string result = StringFunc.ReverseString(source);
        Assert.IsTrue(result == source);
      }
    }

    [TestMethod]
    public void TestMethod_ReverseString_several_palindromes_with_removal_of_space()
    {
      List<string> sourceWords = new List<string> { "esope reste ici et se repose", "éric notre valet alla te laver ton ciré" };
      foreach (string source in sourceWords)
      {
        string result = StringFunc.ReverseString(source, true);
        Assert.IsTrue(result == source.Replace(" ", ""));
      }
    }

    // **********************ReverseString2****************
    [TestMethod]
    public void TestMethod_ReverseString2()
    {
      string source = "123456789";
      string result = StringFunc.ReverseString2(source);
      Assert.IsTrue(result == "987654321");
    }

    [TestMethod]
    public void TestMethod_ReverseString2_on_an_empty_string()
    {
      string source = "";
      string result = StringFunc.ReverseString2(source);
      Assert.IsTrue(result == "");
    }

    [TestMethod]
    public void TestMethod_ReverseString2_one_element()
    {
      string source = "1";
      string result = StringFunc.ReverseString2(source);
      Assert.IsTrue(result == "1");
    }

    [TestMethod]
    public void TestMethod_ReverseString2_palindrome()
    {
      string source = "laval";
      string result = StringFunc.ReverseString2(source);
      Assert.IsTrue(result == source);
    }

    [TestMethod]
    public void TestMethod_ReverseString2_several_palindromes()
    {
      List<string> sourceWords = new List<string> { "laval", "lol", "ete", "lieur à rueil" };
      foreach (string source in sourceWords)
      {
        string result = StringFunc.ReverseString2(source);
        Assert.IsTrue(result == source);
      }
    }

    [TestMethod]
    public void TestMethod_ReverseString2_several_palindromes_with_removal_of_space()
    {
      List<string> sourceWords = new List<string> { "esope reste ici et se repose", "éric notre valet alla te laver ton ciré" };
      foreach (string source in sourceWords)
      {
        string result = StringFunc.ReverseString2(source, true);
        Assert.IsTrue(result == source.Replace(" ", ""));
      }
    }

    // **********************CompletePrefixWithZero****************
    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_one()
    {
      string source = "1";
      string result = StringFunc.CompletePrefixWithZero(source);
      Assert.IsTrue(result == "01");
    }

    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_nine()
    {
      string source = "9";
      string result = StringFunc.CompletePrefixWithZero(source);
      Assert.IsTrue(result == "09");
    }

    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_two_digits()
    {
      string source = "12";
      string result = StringFunc.CompletePrefixWithZero(source);
      Assert.IsTrue(result == "12");
    }

    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_one_integer()
    {
      int source = 1;
      string result = StringFunc.CompletePrefixeWithZeroInt(source);
      Assert.IsTrue(result == "01");
    }

    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_nine_integer()
    {
      int source = 9;
      string result = StringFunc.CompletePrefixeWithZeroInt(source);
      Assert.IsTrue(result == "09");
    }

    [TestMethod]
    public void TestMethod_CompletePrefixWithZero_on_two_digits_integer()
    {
      int source = 12;
      string result = StringFunc.CompletePrefixeWithZeroInt(source);
      Assert.IsTrue(result == "12");
    }


    // **********************ArrayToString****************
    [TestMethod]
    public void TestMethod_ArrayToString_one_element()
    {
      byte[] source = new byte[1];
      source[0] = 0x01;
      string result2 = "1";
      string result = StringFunc.ArrayToString(source);
      Assert.AreEqual(result, result2);
    }

    [TestMethod]
    public void TestMethod_ArrayToString_two_elements()
    {
      byte[] source = new byte[2];
      source[0] = 0x01;
      source[1] = 0x02;
      string result2 = "1" + Environment.NewLine + "2";
      string result = StringFunc.ArrayToString(source);
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
      string result = StringFunc.ArrayToString(source);
      Assert.AreEqual(result, result2);
    }

    // **********************ArrayToStringWithStringBuilder****************
    [TestMethod]
    public void TestMethod_ArrayToStringWithStringBuilder_one_element()
    {
      byte[] source = new byte[1];
      source[0] = 0x01;
      string result2 = "1";
      string result = StringFunc.ArrayToStringWithStringBuilder(source);
      Assert.AreEqual(result, result2);
    }

    [TestMethod]
    public void TestMethod_ArrayToStringWithStringBuilder_two_elements()
    {
      byte[] source = new byte[2];
      source[0] = 0x01;
      source[1] = 0x02;
      string result2 = "1" + Environment.NewLine + "2";
      string result = StringFunc.ArrayToString(source);
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
      string result = StringFunc.ArrayToString(source);
      Assert.AreEqual(result, result2);
    }

    // **********************InsertSeparatorForEachCharacter****************
    [TestMethod]
    public void TestMethod_InsertSeparatorForEachCharacter_one_string()
    {
      const string source = "azerty";
      const string expected = "a z e r t y";
      string result = StringFunc.InsertSeparatorForEachCharacter(source, " ");
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_InsertSeparatorForEachCharacter_empty_string()
    {
      const string source = "";
      const string expected = "";
      string result = StringFunc.InsertSeparatorForEachCharacter(source, " ");
      Assert.AreEqual(result, expected);
    }

    // **********************InsertSeparatorAtInterval****************
    [TestMethod]
    public void TestMethod_InsertSeparatorAtInterval_one_element()
    {
      const string source = "azerty";
      const string expected = "az er ty";
      string result = StringFunc.InsertSeparatorAtInterval(source, " ", 2);
      Assert.AreEqual(result, expected);
    }

    // **********************RemoveVowels****************
    [TestMethod]
    public void TestMethod_RemoveVowels_one_string()
    {
      const string source = "azerty";
      const string expected = "zrt";
      string result = StringFunc.RemoveVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemoveVowels_empty_string()
    {
      const string source = "";
      const string expected = "";
      string result = StringFunc.RemoveVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemoveVowels_only_vowels()
    {
      const string source = "aeiouy";
      const string expected = "";
      string result = StringFunc.RemoveVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemoveVowels_only_consonant()
    {
      const string source = "qsdfghjklm";
      const string expected = "qsdfghjklm";
      string result = StringFunc.RemoveVowels(source);
      Assert.AreEqual(result, expected);
    }

    // **********************KeepVowels****************
    [TestMethod]
    public void TestMethod_KeepVowels_one_string()
    {
      const string source = "azerty";
      const string expected = "aey";
      string result = StringFunc.KeepVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_KeepVowels_empty_string()
    {
      const string source = "";
      const string expected = "";
      string result = StringFunc.KeepVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_KeepVowels_only_vowels()
    {
      const string source = "aeiouy";
      const string expected = "aeiouy";
      string result = StringFunc.KeepVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_KeepVowels_only_consonant()
    {
      const string source = "qsdfghjklm";
      const string expected = "";
      string result = StringFunc.KeepVowels(source);
      Assert.AreEqual(result, expected);
    }

    // **********************AlternateCases****************
    [TestMethod]
    public void TestMethod_AlternateCases_one_string()
    {
      const string source = "TheWonderfulMethodThatDoesALotOfThings";
      const string expected = "ThEwOnDeRfUlMeThOdThAtDoEsAlOtOfThInGs";
      string result = StringFunc.AlternateCases(source);
      Assert.AreEqual(result, expected);
    }

    // **********************Capitalize****************
    [TestMethod]
    public void TestMethod_Capitalize_one_string()
    {
      const string source = "once upon a time in a galaxy far far away";
      const string expected = "Once upon a time in a galaxy far far away";
      string result = StringFunc.Capitalize(source);
      Assert.AreEqual(result, expected);
    }

    // **********************GetInitials****************
    [TestMethod]
    public void TestMethod_GetInitials_one_string()
    {
      const string source = "once upon a time in a galaxy far far away";
      const string expected = "ouatiagffa";
      string result = StringFunc.GetInitials(source, " ", false, false, false);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetInitials_empty_string()
    {
      string source = "";
      string expected = "";
      string result = StringFunc.GetInitials(source, " ", false, false, false);
      Assert.AreEqual(result, expected);
    }

    // **********************GetTitle****************
    [TestMethod]
    public void TestMethod_GetTitle_one_string()
    {
      string source = "once upon a time in a galaxy far far away";
      string expected = "Once Upon A Time In A Galaxy Far Far Away";
      string result = StringFunc.GetTitle(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetTitleGetInitials_empty_string()
    {
      string source = "";
      string expected = "";
      string result = StringFunc.GetTitle(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetTitle_one_string_with_separator()
    {
      string source = "once upon a time in a galaxy far far away";
      string expected = "Once Upon A Time In A Galaxy Far Far Away";
      string result = StringFunc.GetTitle(source, " ");
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetTitle_one_string_with_underscore_separator()
    {
      string source = "once_upon_a_time_in_a_galaxy_far_far_away";
      string expected = "Once_Upon_A_Time_In_A_Galaxy_Far_Far_Away";
      string result = StringFunc.GetTitle(source, "_");
      Assert.AreEqual(result, expected);
    }

    // **********************SubstringEnd****************
    [TestMethod]
    public void TestMethod_SubstringEnd_first_character()
    {
      string source = "once upon a time in a galaxy far far away";
      string expected = "o";
      string result = StringFunc.SubstringEnd(source, 0, 1);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_SubstringEnd_start_equals_end()
    {
      string source = "once upon a time in a galaxy far far away";
      string expected = "";
      string result = StringFunc.SubstringEnd(source, 0, 0);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_SubstringEnd_two_characters()
    {
      string source = "once upon a time in a galaxy far far away";
      string expected = "nc";
      string result = StringFunc.SubstringEnd(source, 1, 2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_SubstringEnd_four_characters()
    {
      string source = "once upon a time in a galaxy far far away";
      string expected = "time";
      string result = StringFunc.SubstringEnd(source, 12, 4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_SubstringEnd_end_character()
    {
      string source = "azerty";
      string expected = "y";
      string result = StringFunc.SubstringEnd(source, source.Length - 1, 1);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_SubstringEnd_one_character()
    {
      string source = "azerty";
      string expected = "e";
      string result = StringFunc.SubstringEnd(source, 2, 1);
      Assert.AreEqual(result, expected);
    }

    // **********************CharRight****************
    [TestMethod]
    public void TestMethod_CharRight()
    {
      string source = "once upon a time in a galaxy far far away";
      char expected = 'y';
      char result = StringFunc.CharRight(source, 0);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CharRight_empty_character()
    {
      string source = "";
      char expected = new char();
      char result = StringFunc.CharRight(source, 0);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CharRight_one_character()
    {
      string source = "qwerty";
      char expected = 'e';
      char result = StringFunc.CharRight(source, 3);
      Assert.AreEqual(result, expected);
    }

    // **********************CharMid****************
    [TestMethod]
    public void TestMethod_CharMid()
    {
      string source = "once upon a time in a galaxy far far away";
      char expected = 'n';
      char result = StringFunc.CharMid(source, 0, 1);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CharMid_empty_string()
    {
      string source = "";
      char expected = new char();
      char result = StringFunc.CharMid(source, 0, 0);
      Assert.AreEqual(result, expected);
    }

    // **********************CountString****************
    [TestMethod]
    public void TestMethod_CountString()
    {
      string source = "once upon a time in a galaxy far far away";
      int expected = 2;
      int result = StringFunc.CountString(source, "far", true);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountString_do_not_ignore_case()
    {
      string source = "once upon a time in a galaxy far far away";
      int expected = 2;
      int result = StringFunc.CountString(source, "far", false);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountString_empty_string()
    {
      string source = "";
      int expected = 0;
      int result = StringFunc.CountString(source, "far", true);
      Assert.AreEqual(result, expected);
    }

    // **********************IndexOfAll****************
    [TestMethod]
    public void TestMethod_IndexOfAll()
    {
      string source = "once upon a time in a galaxy far far away";
      int[] expected = new int[2];
      expected[0] = 29;
      expected[1] = 33;
      int[] result = StringFunc.IndexOfAll(source, "far", true);
      Assert.AreEqual(result[0], expected[0]);
      Assert.AreEqual(result[1], expected[1]);
    }

    [TestMethod]
    public void TestMethod_IndexOfAll_ignore_case()
    {
      string source = "once upon a time in a galaxy far far away";
      int[] expected = new int[2];
      expected[0] = 29;
      expected[1] = 33;
      int[] result = StringFunc.IndexOfAll(source, "far", false);
      Assert.AreEqual(result[0], expected[0]);
      Assert.AreEqual(result[1], expected[1]);
    }

    [TestMethod]
    public void TestMethod_IndexOfAll_ignore_case_upper_source()
    {
      string source = "once upon a time in a galaxy FAR FAR away";
      int[] expected = new int[2];
      expected[0] = 29;
      expected[1] = 33;
      int[] result = StringFunc.IndexOfAll(source, "far", true);
      Assert.AreEqual(result[0], expected[0]);
      Assert.AreEqual(result[1], expected[1]);
    }

    [TestMethod]
    public void TestMethod_IndexOfAll_no_matching()
    {
      // TODO debug
      //string source = "once upon a time in a galaxy far far away";
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
      bool result = StringFunc.IsAlternateCases(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAlternateCases_empty_string()
    {
      const string source = "";
      const bool expected = false;
      bool result = StringFunc.IsAlternateCases(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAlternateCases_True()
    {
      string source = "OnCe";
      bool expected = true;
      bool result = StringFunc.IsAlternateCases(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAlternateCases_True_two_words()
    {
      string source = "OnCe uPoN";
      bool expected = true;
      bool result = StringFunc.IsAlternateCases(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAlternateCases_True_four_words()
    {
      string source = "OnCe uPoN A TiMe";
      bool expected = true;
      bool result = StringFunc.IsAlternateCases(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsCapitalized****************
    [TestMethod]
    public void TestMethod_IsCapitalized_true()
    {
      string source = "Once upon a time in a galaxy far far away";
      bool expected = true;
      bool result = StringFunc.IsCapitalized(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsCapitalized_empty_string()
    {
      string source = "";
      bool expected = false;
      bool result = StringFunc.IsCapitalized(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsCapitalized_false()
    {
      string source = "once upon a time in a galaxy far far away";
      bool expected = false;
      bool result = StringFunc.IsCapitalized(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsLowerCase****************
    [TestMethod]
    public void TestMethod_IsLowerCase_true()
    {
      string source = "once upon a time in a galaxy far far away";
      bool expected = true;
      bool result = StringFunc.IsLowerCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsLowerCase_false()
    {
      string source = "Once upon a time in a galaxy far far away";
      bool expected = false;
      bool result = StringFunc.IsLowerCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsLowerCase_empty_string()
    {
      string source = "";
      bool expected = false;
      bool result = StringFunc.IsLowerCase(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsLowerCase2****************
    [TestMethod]
    public void TestMethod_IsLowerCase2_true()
    {
      string source = "once upon a time in a galaxy far far away";
      bool expected = true;
      bool result = StringFunc.IsLowerCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsLowerCase2_false()
    {
      string source = "Once upon a time in a galaxy far far away";
      bool expected = false;
      bool result = StringFunc.IsLowerCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsLowerCase2_empty_string()
    {
      string source = "";
      bool expected = false;
      bool result = StringFunc.IsLowerCase2(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsUpperCase****************
    [TestMethod]
    public void TestMethod_IsUpperCase_true()
    {
      string source = "once upon a time in a galaxy far far away";
      source = source.ToUpper();
      bool expected = true;
      bool result = StringFunc.IsUpperCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsUpperCase_false()
    {
      string source = "Once upon a time in a galaxy far far away";
      bool expected = false;
      bool result = StringFunc.IsUpperCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsUpperCase_empty_string()
    {
      string source = "";
      bool expected = false;
      bool result = StringFunc.IsUpperCase(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsLowerCase2****************
    [TestMethod]
    public void TestMethod_IsUpperCase2_true()
    {
      string source = "once upon a time in a galaxy far far away";
      source = source.ToUpper();
      bool expected = true;
      bool result = StringFunc.IsUpperCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsUpperCase2_false()
    {
      string source = "Once upon a time in a galaxy far far away";
      bool expected = false;
      bool result = StringFunc.IsUpperCase2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsUpperCase2_empty_string()
    {
      string source = "";
      bool expected = false;
      bool result = StringFunc.IsUpperCase2(source);
      Assert.AreEqual(result, expected);
    }

    // **********************HasVowels****************
    [TestMethod]
    public void TestMethod_HasVowels_true()
    {
      string source = "azerty";
      bool expected = true;
      bool result = StringFunc.HasVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasVowels_empty_string()
    {
      string source = "";
      bool expected = false;
      bool result = StringFunc.HasVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasVowels_only_vowels()
    {
      string source = "aeiouy";
      bool expected = true;
      bool result = StringFunc.HasVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasVowels_false()
    {
      string source = "qsdfghjklm";
      bool expected = false;
      bool result = StringFunc.HasVowels(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsSpaces****************
    [TestMethod]
    public void TestMethod_IsSpaces_true()
    {
      string source = "       ";
      bool expected = true;
      bool result = StringFunc.IsSpaces(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsSpaces_empty_string()
    {
      string source = "";
      bool expected = false;
      bool result = StringFunc.HasVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsSpaces_false()
    {
      string source = "qwerty";
      bool expected = false;
      bool result = StringFunc.IsSpaces(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsRepeatedChar****************
    [TestMethod]
    public void TestMethod_IsRepeatedChar_true()
    {
      string source = "aaaaaaa";
      bool expected = true;
      bool result = StringFunc.IsRepeatedChar(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsRepeatedChars_empty_string()
    {
      string source = "";
      bool expected = true;
      bool result = StringFunc.IsRepeatedChar(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsRepeatedChar_false()
    {
      string source = "qwerty";
      bool expected = false;
      bool result = StringFunc.IsRepeatedChar(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsRepeatedChar_false_on_a_sentence()
    {
      string source = "Once upon a time in a galaxy far far away";
      bool expected = false;
      bool result = StringFunc.IsRepeatedChar(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsNumeric on a string****************
    [TestMethod]
    public void TestMethod_IsNumeric_false()
    {
      string source = "azerty";
      bool expected = false;
      bool result = StringFunc.IsNumeric(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsNumeric_true()
    {
      string source = "123456";
      bool expected = true;
      bool result = StringFunc.IsNumeric(source);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_IsNumeric_empty_string()
    {
      string source = "";
      bool expected = false;
      bool result = StringFunc.IsNumeric(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsNumeric2 on a string****************
    [TestMethod]
    public void TestMethod_IsNumeric2_false()
    {
      string source = "azerty";
      bool expected = false;
      bool result = StringFunc.IsNumeric2(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsNumeric2_true()
    {
      string source = "123456";
      bool expected = true;
      bool result = StringFunc.IsNumeric2(source);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_IsNumeric2_empty_string()
    {
      string source = "";
      bool expected = false;
      bool result = StringFunc.IsNumeric2(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsNumeric3 with NumberStyles****************
    [TestMethod]
    public void TestMethod_IsNumeric3_false()
    {
      string source = "azerty";
      NumberStyles numberStyle = NumberStyles.Number;
      bool expected = false;
      bool result = StringFunc.IsNumeric3(source, numberStyle);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsNumeric3_true()
    {
      string source = "123456";
      NumberStyles numberStyle = NumberStyles.Number;
      bool expected = true;
      bool result = StringFunc.IsNumeric3(source, numberStyle);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_IsNumeric3_empty_string()
    {
      string source = "";
      NumberStyles numberStyle = NumberStyles.Number;
      bool expected = false;
      bool result = StringFunc.IsNumeric3(source, numberStyle);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsNumeric3_true_Allow_trailing_white()
    {
      string source = "123456  ";
      NumberStyles numberStyle = NumberStyles.AllowTrailingWhite;
      bool expected = true;
      bool result = StringFunc.IsNumeric3(source, numberStyle);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsNumeric3_true_Allow_leading_white()
    {
      string source = "  123456";
      NumberStyles numberStyle = NumberStyles.AllowLeadingWhite;
      bool expected = true;
      bool result = StringFunc.IsNumeric3(source, numberStyle);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsNumeric3_true_Allow_decimal_white()
    {
      string source = "1234,56";
      NumberStyles numberStyle = NumberStyles.AllowDecimalPoint;
      bool expected = true;
      bool result = StringFunc.IsNumeric3(source, numberStyle);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsNumeric3_true_integer()
    {
      string source = "123456";
      NumberStyles numberStyle = NumberStyles.Integer;
      bool expected = true;
      bool result = StringFunc.IsNumeric3(source, numberStyle);
      Assert.AreEqual(result, expected);
    }

    // **********************IsAlphaNumeric****************
    [TestMethod]
    public void TestMethod_IsAlphaNumeric_false()
    {
      string source = "1+azerty";
      bool expected = false;
      bool result = StringFunc.IsAlphaNumeric(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAlphaNumeric_true()
    {
      string source = "1azerty";
      bool expected = true;
      bool result = StringFunc.IsAlphaNumeric(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAlphaNumeric_empty_string()
    {
      string source = "";
      bool expected = false;
      bool result = StringFunc.IsAlphaNumeric(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsLetters****************
    [TestMethod]
    public void TestMethod_IsLetters_false()
    {
      string source = "123456789";
      bool expected = false;
      bool result = StringFunc.IsLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsLetters_true()
    {
      string source = "qwertyAndazerty";
      bool expected = true;
      bool result = StringFunc.IsLetters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsLetters_empty_string()
    {
      string source = "";
      bool expected = false;
      bool result = StringFunc.IsLetters(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsTitle**************
    [TestMethod]
    public void TestMethod_IsTitle_false()
    {
      string source = "once upon a time";
      bool expected = false;
      bool result = StringFunc.IsTitle(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsTitle_true()
    {
      string source = "Once A Upon A Time";
      bool expected = true;
      bool result = StringFunc.IsTitle(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsTitle_empty_string()
    {
      string source = "";
      bool expected = false;
      bool result = StringFunc.IsTitle(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsTitle with a separator**************
    [TestMethod]
    public void TestMethod_IsTitle_with_separator_false()
    {
      string source = "once upon a time";
      string separator = " ";
      bool expected = false;
      bool result = StringFunc.IsTitle(source, separator);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsTitle_with_separator_true()
    {
      string source = "Once A Upon A Time";
      string separator = " ";
      bool expected = true;
      bool result = StringFunc.IsTitle(source, separator);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsTitle_with_one_separator_false()
    {
      string source = "once A Upon A Time_in a galaxy far far away";
      string separator = "_";
      bool expected = false;
      bool result = StringFunc.IsTitle(source, separator);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsTitle_with_one_separator_true()
    {
      string source = "Once A Upon A Time_In a galaxy far far away";
      string separator = "_";
      bool expected = true;
      bool result = StringFunc.IsTitle(source, separator);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsTitle_with_separator_empty_string()
    {
      string source = "";
      string separator = "_";
      bool expected = false;
      bool result = StringFunc.IsTitle(source, separator);
      Assert.AreEqual(result, expected);
    }

    // **********************IsEmailAddress**************
    [TestMethod]
    public void TestMethod_IsEmailAddress_false()
    {
      string source = "this is certainly not a valid email address";
      bool expected = false;
      bool result = StringFunc.IsEmailAddress(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddress_true()
    {
      string source = "someone@aol.com";
      bool expected = true;
      bool result = StringFunc.IsEmailAddress(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddress_2_true()
    {
      string source = "someone@somefai.com";
      bool expected = true;
      bool result = StringFunc.IsEmailAddress(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddress_dot_before_arobase_true()
    {
      string source = "firstName.LastName@someFAI.com";
      bool expected = true;
      bool result = StringFunc.IsEmailAddress(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddress_minimum_length_true()
    {
      string source = "me@f2.fr";
      bool expected = true;
      bool result = StringFunc.IsEmailAddress(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddress_empty_string()
    {
      string source = "";
      bool expected = false;
      bool result = StringFunc.IsEmailAddress(source);
      Assert.AreEqual(result, expected);
    }

    // **********************IsEmailAddressValid**************
    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true()
    {
      string source = "someone@someFAI.com";
      bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_empty_string()
    {
      string source = "";
      bool expected = false;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_false_because_no_arobase()
    {
      string source = "someoneatsomeFAI.com";
      bool expected = false;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_false_because_no_dot()
    {
      string source = "someone@someFAIdotcom";
      bool expected = false;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_false_because_too_short()
    {
      string source = "s@I.c";
      bool expected = false;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_dot_before_arobase()
    {
      string source = "firstName.lastName@free.fr";
      bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_five_letter_TLD()
    {
      string source = "firstName.lastName@mairie.paris";
      bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_seven_letter_TLD()
    {
      string source = "firstName.lastName@mywonderful.website";
      bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_eight_letter_TLD()
    {
      string source = "firstName.lastName@mywonderful.memorial";
      bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_nine_letter_TLD()
    {
      string source = "firstName.lastName@supersite.solutions";
      bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_ten_letter_TLD()
    {
      string source = "firstName.lastName@maysupersite.consulting";
      bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_two_dots_in_TLD()
    {
      string source = "firstName.lastName@mywonderful.co.com";
      bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_two_dots_in_tld_co_uk()
    {
      string source = "firstName.lastName@site.co.uk";
      bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_eleven_letter_TLD()
    {
      string source = "firstName.lastName@mysupersite.accountants";
      bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_eleven_letter_TLD_blackfriday()
    {
      string source = "firstName.lastName@mysupersite.blackfriday";
      bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_twelve_letter_TLD_construction()
    {
      string source = "firstName.lastName@mysupersite.construction";
      bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_twelve_letter_TLD_contractors()
    {
      string source = "firstName.lastName@mysupersite.contractors";
      bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsEmailAddressValid_true_with_thirteen_letter_TLD_international()
    {
      string source = "firstName.lastName@supersite.international";
      bool expected = true;
      bool result = StringFunc.IsEmailAddressValid(source);
      Assert.AreEqual(result, expected);
    }

    // **********************LoadAlphabetInList**************
    [TestMethod]
    public void TestMethod_LoadAlphabetInList_false_empty_source_array()
    {
      char[] expected = new char[62];
      char[] result = StringFunc.LoadAlphabetInList(false, false, false);
      Assert.AreEqual(result.Length, expected.Length);
      Assert.AreEqual(result[0], expected[0]); 
      Assert.AreEqual(result[5], expected[5]);
      Assert.AreEqual(result[9], expected[9]);
    }

    [TestMethod]
    public void TestMethod_LoadAlphabetInList_false_empty_source_array_give_sixty_two_length_array()
    {
      char[] result = StringFunc.LoadAlphabetInList(false, false, false);
      Assert.IsTrue(result.Length == 26 + 26 + 10);
    }

    [TestMethod]
    public void TestMethod_LoadAlphabetInList_true_only_digits()
    {
      char[] expected = new [] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
      char[] result = StringFunc.LoadAlphabetInList(true, false, false);
      Assert.AreEqual(result[0], expected[0]); // '0'
      Assert.AreEqual(result[5], expected[5]); // '5'
      Assert.AreEqual(result[9], expected[9]); // '9'
    }

    [TestMethod]
    public void TestMethod_LoadAlphabetInList_true_only_lower_case_letters()
    {
      char[] expected = new char[62];
      expected = StringFunc.GetAlphabet();
      char[] result = StringFunc.LoadAlphabetInList(false, true, false);
      Assert.AreEqual(result[0], expected[0]); // 'a'
      Assert.AreEqual(result[5], expected[5]);
      Assert.AreEqual(result[9], expected[9]);
      Assert.AreEqual(result[25], expected[25]); // 'z'
    }

    [TestMethod]
    public void TestMethod_LoadAlphabetInList_true_only_upper_case_letters()
    {
      char[] expected = new char[62];
      expected = StringFunc.GetAlphabet(false);
      char[] result = StringFunc.LoadAlphabetInList(false, false, true);
      Assert.AreEqual(result[0], expected[0]); // 'A'
      Assert.AreEqual(result[5], expected[5]);
      Assert.AreEqual(result[9], expected[9]);
      Assert.AreEqual(result[25], expected[25]); // 'Z'
    }

    [TestMethod]
    public void TestMethod_LoadAlphabetInList_true_lower_and_upper_case_letters()
    {
      char[] expected = new char[62];
      char[] lower = StringFunc.GetAlphabet();
      char[] upper = StringFunc.GetAlphabet(false);
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
      char[] result = StringFunc.LoadAlphabetInList(false, true, true);
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
      char[] lower = StringFunc.GetAlphabet();
      char[] upper = StringFunc.GetAlphabet(false);
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

      char[] result = StringFunc.LoadAlphabetInList(true, true, true);
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
      char[] lower = StringFunc.GetAlphabet();
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

      char[] result = StringFunc.LoadAlphabetInList(true, true, false);
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
      char[] upper = StringFunc.GetAlphabet(false);
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

      char[] result = StringFunc.LoadAlphabetInList(true, false, true);
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
      Assert.AreEqual(StringFunc.LetterCasingSequence.DigitLowerUpper, StringFunc.LetterCasingSequence.DigitLowerUpper);
      Assert.AreEqual(StringFunc.LetterCasingSequence.DigitUpperLower, StringFunc.LetterCasingSequence.DigitUpperLower);
      Assert.AreEqual(StringFunc.LetterCasingSequence.LowerDigitUpper, StringFunc.LetterCasingSequence.LowerDigitUpper);
      Assert.AreEqual(StringFunc.LetterCasingSequence.LowerUpperDigit, StringFunc.LetterCasingSequence.LowerUpperDigit);
      Assert.AreEqual(StringFunc.LetterCasingSequence.UpperDigitLower, StringFunc.LetterCasingSequence.UpperDigitLower);
      Assert.AreEqual(StringFunc.LetterCasingSequence.UpperLowerDigit, StringFunc.LetterCasingSequence.UpperLowerDigit);
    }

    [TestMethod]
    public void TestMethod_LetterCasingSequence_false_no_equality()
    {
      Assert.AreNotEqual(StringFunc.LetterCasingSequence.DigitLowerUpper, StringFunc.LetterCasingSequence.DigitUpperLower);
      Assert.AreNotEqual(StringFunc.LetterCasingSequence.DigitUpperLower, StringFunc.LetterCasingSequence.LowerDigitUpper);
      Assert.AreNotEqual(StringFunc.LetterCasingSequence.LowerDigitUpper, StringFunc.LetterCasingSequence.LowerUpperDigit);
      Assert.AreNotEqual(StringFunc.LetterCasingSequence.LowerUpperDigit, StringFunc.LetterCasingSequence.UpperDigitLower);
      Assert.AreNotEqual(StringFunc.LetterCasingSequence.UpperDigitLower, StringFunc.LetterCasingSequence.UpperLowerDigit);
      Assert.AreNotEqual(StringFunc.LetterCasingSequence.UpperLowerDigit, StringFunc.LetterCasingSequence.DigitLowerUpper);
    }

    [TestMethod]
    public void TestMethod_LetterCasingSequence_true_all_enum_exist_by_their_value_number()
    {
      Assert.IsTrue(Enum.IsDefined(typeof(StringFunc.LetterCasingSequence), 0));
      Assert.IsTrue(Enum.IsDefined(typeof(StringFunc.LetterCasingSequence), 1));
      Assert.IsTrue(Enum.IsDefined(typeof(StringFunc.LetterCasingSequence), 2));
      Assert.IsTrue(Enum.IsDefined(typeof(StringFunc.LetterCasingSequence), 3));
      Assert.IsTrue(Enum.IsDefined(typeof(StringFunc.LetterCasingSequence), 4));
      Assert.IsTrue(Enum.IsDefined(typeof(StringFunc.LetterCasingSequence), 5));
    }

    [TestMethod]
    public void TestMethod_LetterCasingSequence_true_all_enum_exists_with_no_change_in_their_value()
    {
      Assert.AreEqual((int)StringFunc.LetterCasingSequence.LowerUpperDigit, 0);
      Assert.AreEqual((int)StringFunc.LetterCasingSequence.UpperLowerDigit, 1);
      Assert.AreEqual((int) StringFunc.LetterCasingSequence.DigitLowerUpper, 2);
      Assert.AreEqual((int) StringFunc.LetterCasingSequence.DigitUpperLower, 3);
      Assert.AreEqual((int) StringFunc.LetterCasingSequence.LowerDigitUpper, 4);
      Assert.AreEqual((int) StringFunc.LetterCasingSequence.UpperDigitLower, 5);
    }

    // **********************NumberToWordsEnglish**************
    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_zero()
    {
      string expected = "zero";
      string result = StringFunc.NumberToEnglishWords(0);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one()
    {
      string expected = "one";
      string result = StringFunc.NumberToEnglishWords(1);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_one()
    {
      string expected = "minus one";
      string result = StringFunc.NumberToEnglishWords(-1);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_two()
    {
      string expected = "two";
      string result = StringFunc.NumberToEnglishWords(2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_two()
    {
      string expected = "minus two";
      string result = StringFunc.NumberToEnglishWords(-2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_three()
    {
      string expected = "three";
      string result = StringFunc.NumberToEnglishWords(3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_three()
    {
      string expected = "minus three";
      string result = StringFunc.NumberToEnglishWords(-3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_four()
    {
      string expected = "four";
      string result = StringFunc.NumberToEnglishWords(4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_four()
    {
      string expected = "minus four";
      string result = StringFunc.NumberToEnglishWords(-4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_five()
    {
      string expected = "five";
      string result = StringFunc.NumberToEnglishWords(5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_five()
    {
      string expected = "minus five";
      string result = StringFunc.NumberToEnglishWords(-5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_six()
    {
      string expected = "six";
      string result = StringFunc.NumberToEnglishWords(6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_six()
    {
      string expected = "minus six";
      string result = StringFunc.NumberToEnglishWords(-6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_seven()
    {
      string expected = "seven";
      string result = StringFunc.NumberToEnglishWords(7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_eight()
    {
      string expected = "eight";
      string result = StringFunc.NumberToEnglishWords(8);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_nine()
    {
      string expected = "nine";
      string result = StringFunc.NumberToEnglishWords(9);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_ten()
    {
      string expected = "ten";
      string result = StringFunc.NumberToEnglishWords(10);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_eleven()
    {
      string expected = "eleven";
      string result = StringFunc.NumberToEnglishWords(11);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_twelve()
    {
      string expected = "twelve";
      string result = StringFunc.NumberToEnglishWords(12);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_thirteen()
    {
      string expected = "thirteen";
      string result = StringFunc.NumberToEnglishWords(13);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_fourteen()
    {
      string expected = "fourteen";
      string result = StringFunc.NumberToEnglishWords(14);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_minus_fifteen()
    {
      string expected = "fifteen";
      string result = StringFunc.NumberToEnglishWords(15);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_sixteen()
    {
      string expected = "sixteen";
      string result = StringFunc.NumberToEnglishWords(16);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_seventeen()
    {
      string expected = "seventeen";
      string result = StringFunc.NumberToEnglishWords(17);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_eighteen()
    {
      string expected = "eighteen";
      string result = StringFunc.NumberToEnglishWords(18);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_nineteen()
    {
      string expected = "nineteen";
      string result = StringFunc.NumberToEnglishWords(19);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_twenty()
    {
      string expected = "twenty";
      string result = StringFunc.NumberToEnglishWords(20);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_twenty_one()
    {
      string expected = "twenty-one";
      string result = StringFunc.NumberToEnglishWords(21);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_twenty_five()
    {
      string expected = "twenty-five";
      string result = StringFunc.NumberToEnglishWords(25);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_thirty()
    {
      string expected = "thirty";
      string result = StringFunc.NumberToEnglishWords(30);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_thirty_one()
    {
      string expected = "thirty-one";
      string result = StringFunc.NumberToEnglishWords(31);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_thirty_five()
    {
      string expected = "thirty-five";
      string result = StringFunc.NumberToEnglishWords(35);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_forty()
    {
      string expected = "forty";
      string result = StringFunc.NumberToEnglishWords(40);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_fifty()
    {
      string expected = "fifty";
      string result = StringFunc.NumberToEnglishWords(50);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_sixty()
    {
      string expected = "sixty";
      string result = StringFunc.NumberToEnglishWords(60);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_seventy()
    {
      const string expected = "seventy";
      string result = StringFunc.NumberToEnglishWords(70);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_eighty()
    {
      const string expected = "eighty";
      string result = StringFunc.NumberToEnglishWords(80);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_ninety()
    {
      const string expected = "ninety";
      string result = StringFunc.NumberToEnglishWords(90);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_hundred()
    {
      const string expected = "one hundred";
      string result = StringFunc.NumberToEnglishWords(100);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_five_hundred()
    {
      const string expected = "five hundred";
      string result = StringFunc.NumberToEnglishWords(500);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_seven_hundred_fifty()
    {
      const string expected = "seven hundred and fifty";
      string result = StringFunc.NumberToEnglishWords(750);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_seven_hundred_and_fourty_seven()
    {
      const string expected = "seven hundred and forty-seven";
      string result = StringFunc.NumberToEnglishWords(747);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_nine_hundred_and_nine()
    {
      const string expected = "nine hundred and nine";
      string result = StringFunc.NumberToEnglishWords(909);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_thousand()
    {
      const string expected = "one thousand";
      string result = StringFunc.NumberToEnglishWords(1000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_thousand_five_hundred()
    {
      const string expected = "one thousand five hundred";
      string result = StringFunc.NumberToEnglishWords(1500);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_thousand_seven_hundred_and_eighty_nine()
    {
      const string expected = "one thousand seven hundred and eighty-nine";
      string result = StringFunc.NumberToEnglishWords(1789);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_two_thousand_and_fifteen()
    {
      const string expected = "two thousand and fifteen";
      string result = StringFunc.NumberToEnglishWords(2015);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_nine_thousand_nine_hundred_and_ninety_nine()
    {
      const string expected = "nine thousand nine hundred and ninety-nine";
      string result = StringFunc.NumberToEnglishWords(9999);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_nine_hundred_ninety_nine_thousand_nine_hundred_and_ninety_nine()
    {
      const string expected = "nine hundred and ninety-nine thousand nine hundred and ninety-nine";
      string result = StringFunc.NumberToEnglishWords(999999);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_million()
    {
      const string expected = "one million";
      string result = StringFunc.NumberToEnglishWords(1000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToEnglishWords_two_million()
    {
      const string expected = "two million";
      string result = StringFunc.NumberToEnglishWords(2000000);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_million_five_hundred_thousand()
    {
      const string expected = "one million five hundred thousand";
      string result = StringFunc.NumberToEnglishWords(1500000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_million_five_hundred_thousand_and_one()
    {
      const string expected = "one million five hundred thousand and one";
      string result = StringFunc.NumberToEnglishWords(1500001);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_million_five_hundred_thousand_and_twenty()
    {
      const string expected = "one million five hundred thousand and twenty";
      string result = StringFunc.NumberToEnglishWords(1500020);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_million_five_hundred_thousand_and_two_hundred()
    {
      const string expected = "one million five hundred thousand two hundred";
      string result = StringFunc.NumberToEnglishWords(1500200);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_two_billion()
    {
      const string expected = "two billion";
      string result = StringFunc.NumberToEnglishWords(2000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_int_maxvalue()
    {
      const string expected = "two billion one hundred and forty-seven million four hundred and eighty-three thousand six hundred and forty-seven";
      // The value of int.MaxValue constant is 2,147,483,647
      string result = StringFunc.NumberToEnglishWords(int.MaxValue);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_three_billion()
    {
      const string expected = "three billion";
      string result = StringFunc.NumberToEnglishWords(3000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_one_trillion()
    {
      const string expected = "one trillion";
      string result = StringFunc.NumberToEnglishWords(1000000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_nine_hundred_trillion()
    {
      const string expected = "nine hundred trillion";
      string result = StringFunc.NumberToEnglishWords(900000000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_long_maxvalue()
    {
      const string expected = "nine quintillion two hundred and twenty-three quadrillion three hundred and seventy-two trillion thirty-six billion eight hundred and fifty-four million seven hundred and seventy-five thousand eight hundred and seven";
      // The value of long.MaxValue constant is 9,223,372,036,854,775,807
      string result = StringFunc.NumberToEnglishWords(long.MaxValue);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_ulong_maxvalue()
    {
      const string expected = "eighteen quintillion four hundred and forty-six quadrillion seven hundred and forty-four trillion seventy-three billion seven hundred and nine million five hundred and fifty-one thousand six hundred and fifteen";
      // The value of ulong.MaxValue constant is 18,446,744,073,709,551,615
      string result = StringFunc.NumberToEnglishWords(ulong.MaxValue);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_eighteen_quintillion()
    {
      const string expected = "eighteen quintillion";
      // The value of ulong.MaxValue constant is 18,446,744,073,709,551,615
      string result = StringFunc.NumberToEnglishWords(18000000000000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToWordsEnglish_eighteen_quintillion_and_twenty_two()
    {
      const string expected = "eighteen quintillion and twenty-two";
      string result = StringFunc.NumberToEnglishWords(18000000000000000022);
      Assert.AreEqual(result, expected);
    }

    // **********************NumberToFrenchWords**************
    [TestMethod]
    public void TestMethod_NumberToFrenchWords_zero()
    {
      string expected = "zéro";
      string result = StringFunc.NumberToFrenchWords(0);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one()
    {
      string expected = "un";
      string result = StringFunc.NumberToFrenchWords(1);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_minus_one()
    {
      string expected = "moins un";
      string result = StringFunc.NumberToFrenchWords(-1);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_two()
    {
      string expected = "deux";
      string result = StringFunc.NumberToFrenchWords(2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_minus_two()
    {
      string expected = "moins deux";
      string result = StringFunc.NumberToFrenchWords(-2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_three()
    {
      string expected = "trois";
      string result = StringFunc.NumberToFrenchWords(3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_moins_three()
    {
      string expected = "moins trois";
      string result = StringFunc.NumberToFrenchWords(-3);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_four()
    {
      string expected = "quatre";
      string result = StringFunc.NumberToFrenchWords(4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_moins_four()
    {
      string expected = "moins quatre";
      string result = StringFunc.NumberToFrenchWords(-4);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_five()
    {
      string expected = "cinq";
      string result = StringFunc.NumberToFrenchWords(5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_moins_five()
    {
      string expected = "moins cinq";
      string result = StringFunc.NumberToFrenchWords(-5);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_six()
    {
      string expected = "six";
      string result = StringFunc.NumberToFrenchWords(6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_moins_six()
    {
      string expected = "moins six";
      string result = StringFunc.NumberToFrenchWords(-6);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_seven()
    {
      string expected = "sept";
      string result = StringFunc.NumberToFrenchWords(7);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_eight()
    {
      string expected = "huit";
      string result = StringFunc.NumberToFrenchWords(8);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_nine()
    {
      string expected = "neuf";
      string result = StringFunc.NumberToFrenchWords(9);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_ten()
    {
      string expected = "dix";
      string result = StringFunc.NumberToFrenchWords(10);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_eleven()
    {
      string expected = "onze";
      string result = StringFunc.NumberToFrenchWords(11);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_twelve()
    {
      string expected = "douze";
      string result = StringFunc.NumberToFrenchWords(12);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_moins_thirteen()
    {
      string expected = "treize";
      string result = StringFunc.NumberToFrenchWords(13);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_fourteen()
    {
      string expected = "quatorze";
      string result = StringFunc.NumberToFrenchWords(14);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_moins_fifteen()
    {
      string expected = "quinze";
      string result = StringFunc.NumberToFrenchWords(15);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_sixteen()
    {
      string expected = "seize";
      string result = StringFunc.NumberToFrenchWords(16);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_seventeen()
    {
      string expected = "dix-sept";
      string result = StringFunc.NumberToFrenchWords(17);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_eighteen()
    {
      string expected = "dix-huit";
      string result = StringFunc.NumberToFrenchWords(18);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_nineteen()
    {
      string expected = "dix-neuf";
      string result = StringFunc.NumberToFrenchWords(19);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_twenty()
    {
      string expected = "vingt";
      string result = StringFunc.NumberToFrenchWords(20);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_twenty_one()
    {
      string expected = "vingt-un";
      string result = StringFunc.NumberToFrenchWords(21);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_twenty_five()
    {
      string expected = "vingt-cinq";
      string result = StringFunc.NumberToFrenchWords(25);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_thirty()
    {
      string expected = "trente";
      string result = StringFunc.NumberToFrenchWords(30);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_thirty_one()
    {
      string expected = "trente-un";
      string result = StringFunc.NumberToFrenchWords(31);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_thirty_five()
    {
      string expected = "trente-cinq";
      string result = StringFunc.NumberToFrenchWords(35);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_forty()
    {
      string expected = "quarante";
      string result = StringFunc.NumberToFrenchWords(40);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_fifty()
    {
      string expected = "cinquante";
      string result = StringFunc.NumberToFrenchWords(50);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_sixty()
    {
      string expected = "soixante";
      string result = StringFunc.NumberToFrenchWords(60);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_seventy()
    {
      const string expected = "soixante-dix";
      string result = StringFunc.NumberToFrenchWords(70);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_eighty()
    {
      const string expected = "quatre-vingt";
      string result = StringFunc.NumberToFrenchWords(80);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_ninety()
    {
      const string expected = "quatre-vingt-dix";
      string result = StringFunc.NumberToFrenchWords(90);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_hundred()
    {
      const string expected = "un cent";
      string result = StringFunc.NumberToFrenchWords(100);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_five_hundred()
    {
      const string expected = "cinq cent";
      string result = StringFunc.NumberToFrenchWords(500);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_seven_hundred_fifty()
    {
      const string expected = "sept cent et cinquante";
      string result = StringFunc.NumberToFrenchWords(750);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_seven_hundred_and_fourty_seven()
    {
      const string expected = "sept cent et quarante-sept";
      string result = StringFunc.NumberToFrenchWords(747);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_nine_hundred_and_nine()
    {
      const string expected = "neuf cent et neuf";
      string result = StringFunc.NumberToFrenchWords(909);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_thousand()
    {
      const string expected = "un mille";
      string result = StringFunc.NumberToFrenchWords(1000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_thousand_five_hundred()
    {
      const string expected = "un mille cinq cent";
      string result = StringFunc.NumberToFrenchWords(1500);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_thousand_seven_hundred_and_eighty_nine()
    {
      const string expected = "un mille sept cent et quatre-vingt-neuf";
      string result = StringFunc.NumberToFrenchWords(1789);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_two_thousand_and_fifteen()
    {
      const string expected = "deux mille et quinze";
      string result = StringFunc.NumberToFrenchWords(2015);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_nine_thousand_nine_hundred_and_ninety_nine()
    {
      const string expected = "neuf mille neuf cent et quatre-vingt-dix-neuf";
      string result = StringFunc.NumberToFrenchWords(9999);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_nine_hundred_ninety_nine_thousand_nine_hundred_and_ninety_nine()
    {
      const string expected = "neuf cent et quatre-vingt-dix-neuf mille neuf cent et quatre-vingt-dix-neuf";
      string result = StringFunc.NumberToFrenchWords(999999);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_million()
    {
      const string expected = "un million";
      string result = StringFunc.NumberToFrenchWords(1000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_two_million()
    {
      const string expected = "deux million";
      string result = StringFunc.NumberToFrenchWords(2000000);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_million_five_hundred_thousand()
    {
      const string expected = "un million cinq cent mille";
      string result = StringFunc.NumberToFrenchWords(1500000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_million_five_hundred_thousand_and_one()
    {
      const string expected = "un million cinq cent mille et un";
      string result = StringFunc.NumberToFrenchWords(1500001);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_million_five_hundred_thousand_and_twenty()
    {
      const string expected = "un million cinq cent mille et vingt";
      string result = StringFunc.NumberToFrenchWords(1500020);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_million_five_hundred_thousand_and_two_hundred()
    {
      const string expected = "un million cinq cent mille deux cent";
      string result = StringFunc.NumberToFrenchWords(1500200);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_two_billion()
    {
      const string expected = "deux milliard";
      string result = StringFunc.NumberToFrenchWords(2000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_int_maxvalue()
    {
      const string expected = "deux milliard un cent et quarante-sept million quatre cent et quatre-vingt-trois mille six cent et quarante-sept";
      // The value of int.MaxValue constant is 2,147,483,647
      string result = StringFunc.NumberToFrenchWords(int.MaxValue);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_three_billion()
    {
      const string expected = "trois milliard";
      string result = StringFunc.NumberToFrenchWords(3000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_one_trillion()
    {
      const string expected = "un billion";
      string result = StringFunc.NumberToFrenchWords(1000000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_nine_hundred_billion()
    {
      const string expected = "neuf cent billion";
      string result = StringFunc.NumberToFrenchWords(900000000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_long_maxvalue()
    {
      const string expected = "neuf trillion deux cent et vingt-trois billiard trois cent et soixante-dix-deux billion trente-six milliard huit cent et cinquante-quatre million sept cent et soixante-dix-cinq mille huit cent et sept";
      // The value of long.MaxValue constant is 9,223,372,036,854,775,807
      string result = StringFunc.NumberToFrenchWords(long.MaxValue);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_ulong_maxvalue()
    {
      const string expected = "dix-huit trillion quatre cent et quarante-six billiard sept cent et quarante-quatre billion soixante-dix-trois milliard sept cent et neuf million cinq cent et cinquante-un mille six cent et quinze";
      // The value of ulong.MaxValue constant is 18,446,744,073,709,551,615
      string result = StringFunc.NumberToFrenchWords(ulong.MaxValue);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_eighteen_trillion()
    {
      const string expected = "dix-huit trillion";
      // The value of ulong.MaxValue constant is 18,446,744,073,709,551,615
      string result = StringFunc.NumberToFrenchWords(18000000000000000000);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberToFrenchWords_eighteen_quintillion_and_twenty_two()
    {
      const string expected = "dix-huit trillion et vingt-deux";
      string result = StringFunc.NumberToFrenchWords(18000000000000000022);
      Assert.AreEqual(result, expected);
    }
    #endregion
  }
}