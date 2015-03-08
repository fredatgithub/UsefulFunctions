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

namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestFunctionsString
  {
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
      int[] source = new int[5] ;
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

    // **********************Sommielle Recursive****************
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
      //byte[] result2 = new byte[0];
      //byte[] result = StringFunc.HexaStringToByteArray(source);
      //Assert.AreEqual(result, result2);
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
      List<string> sourceWords = new List<string> { "laval", "lol", "ete", "lieur à rueil"};
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
      string source = "azerty";
      string result2 = "a z e r t y";
      string result = StringFunc.InsertSeparatorForEachCharacter(source, " ");
      Assert.AreEqual(result, result2);
    }

    [TestMethod]
    public void TestMethod_InsertSeparatorForEachCharacter_empty_string()
    {
      string source = "";
      string result2 = "";
      string result = StringFunc.InsertSeparatorForEachCharacter(source, " ");
      Assert.AreEqual(result, result2);
    }

    // **********************InsertSeparatorAtInterval****************
    [TestMethod]
    public void TestMethod_InsertSeparatorAtInterval_one_element()
    {
      string source = "azerty";
      string result2 = "az er ty";
      string result = StringFunc.InsertSeparatorAtInterval(source, " ", 2);
      Assert.AreEqual(result, result2);
    }

    // **********************RemoveVowels****************
    [TestMethod]
    public void TestMethod_RemoveVowels_one_string()
    {
      string source = "azerty";
      string expected = "zrt";
      string result = StringFunc.RemoveVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemoveVowels_empty_string()
    {
      string source = "";
      string expected = "";
      string result = StringFunc.RemoveVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemoveVowels_only_vowels()
    {
      string source = "aeiouy";
      string expected = "";
      string result = StringFunc.RemoveVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemoveVowels_only_consonant()
    {
      string source = "qsdfghjklm";
      string expected = "qsdfghjklm";
      string result = StringFunc.RemoveVowels(source);
      Assert.AreEqual(result, expected);
    }

    // **********************KeepVowels****************
    [TestMethod]
    public void TestMethod_KeepVowels_one_string()
    {
      string source = "azerty";
      string expected = "aey";
      string result = StringFunc.KeepVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_KeepVowels_empty_string()
    {
      string source = "";
      string expected = "";
      string result = StringFunc.KeepVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_KeepVowels_only_vowels()
    {
      string source = "aeiouy";
      string expected = "aeiouy";
      string result = StringFunc.KeepVowels(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_KeepVowels_only_consonant()
    {
      string source = "qsdfghjklm";
      string expected = "";
      string result = StringFunc.KeepVowels(source);
      Assert.AreEqual(result, expected);
    }

    // **********************AlternateCases****************
    [TestMethod]
    public void TestMethod_AlternateCases_one_string()
    {
      string source = "TheWonderfulMethodThatDoesALotOfThings";
      string expected = "ThEwOnDeRfUlMeThOdThAtDoEsAlOtOfThInGs";
      string result = StringFunc.AlternateCases(source);
      Assert.AreEqual(result, expected);
    }

    // **********************Capitalize****************
    [TestMethod]
    public void TestMethod_Capitalize_one_string()
    {
      string source = "once upon a time in a galaxy far far away";
      string expected = "Once upon a time in a galaxy far far away";
      string result = StringFunc.Capitalize(source);
      Assert.AreEqual(result, expected);
    }

    // **********************GetInitials****************
    [TestMethod]
    public void TestMethod_GetInitials_one_string()
    {
      string source = "once upon a time in a galaxy far far away";
      string expected = "ouatiagffa";
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
      string source = "once upon a time in a galaxy far far away";
      bool expected = false;
      bool result = StringFunc.IsAlternateCases(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsAlternateCases_empty_string()
    {
      string source = "";
      bool expected = false;
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
  }
}