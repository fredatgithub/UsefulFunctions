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
namespace FonctionsUtiles.Fred.Csharp
{
  using System;
  using System.Collections;
  using System.Collections.Generic;
  using System.Globalization;
  using System.IO;
  using System.Linq;
  using System.Text;
  using System.Text.RegularExpressions;

  public class FunctionsString
  {
    public static bool HasDuplicate(params int[] liste)
    {
      if (liste == null)
      {
        return false;
      }

      return liste.Distinct().Count() != liste.Count();
    }
    public static bool HasNoDuplicate(params int[] liste)
    {
      if (liste == null)
      {
        return true;
      }

      return liste.Distinct().Count() == liste.Count();
    }

    public static string EndPadding(string chaine, byte blankLength)
    {
      if (chaine.Length == blankLength)
      {
        return chaine;
      }

      string blanc = string.Empty;
      for (int i = 0; i < blankLength - chaine.Length; i++)
      {
        blanc += " ";
      }

      return chaine + blanc;
    }

    public static string GetLastName(string chaine, char dernierCaractereRecherche)
    {
      int at = 0;
      int atBackup = 0;
      int start = 0;
      while ((start < chaine.Length) && (at > -1))
      {

        at = chaine.IndexOf(dernierCaractereRecherche, start);
        if (at == -1)
        {
          at = atBackup;
          break;
        }
        atBackup = at;
        start = at + 1;
      }

      return chaine.Substring(at + 1);
    }

    public static string GetFileNameAfterLastSlash(string longCheminFichier)
    {
      return Path.GetFileName(longCheminFichier);
    }

    public static string RemoveInString(string stringToBeRemoved, string inString, bool trimEnd = false)
    {
      string tmpString = inString.Replace(stringToBeRemoved, string.Empty);
      return trimEnd ? tmpString.TrimEnd() : tmpString;
    }

    public static string CamelCase(string p)
    {
      string chaine = string.Empty;
      bool estLettrePrecedente = false;
      foreach (var item in p)
      {
        if (estLettrePrecedente && IsLetter(item))
        {
          chaine += item.ToString(CultureInfo.InvariantCulture).ToLower();
        }
        else
        {
          chaine += item.ToString(CultureInfo.InvariantCulture).ToUpper();
        }

        estLettrePrecedente = IsLetter(item);
      }

      return chaine;
    }

    public static bool IsNumeric(char letter)
    {
      var digits = new List<int>();
      for (short digit = 0; digit < 10; digit++)
      {
        digits.Add(digit);
      }

      return digits.Contains(letter);
    }

    public static bool IsLetter(char lettre)
    {
      var alphabet = new List<char>();
      for (char letter = 'A'; letter <= 'Z'; letter++)
      {
        alphabet.Add(letter);
        alphabet.Add(letter.ToString(CultureInfo.InvariantCulture).ToLower().ToCharArray()[0]);
      }

      return alphabet.Contains(lettre);
    }

    public static string Plural(int number)
    {
      return number > 1 ? "s" : string.Empty;
    }

    public static int StringOccurrenceWithIndexOf(string chaineTotale, string chaineRecherchee)
    {
      int occurrence = 0;
      int str2Length = chaineRecherchee.Length;
      int index = 0;
      while ((index = chaineTotale.IndexOf(chaineRecherchee, index, StringComparison.Ordinal)) > -1)
      {
        occurrence++;
        index += str2Length;
      }

      return occurrence;
    }

    public static int StringOccurrenceWithContains(string chaineTotale, string chaineRecherchee)
    {
      if (chaineRecherchee == string.Empty || chaineTotale == string.Empty)
      {
        return 0;
      }

      int occurrence = 0;
      int chaineRechercheeLength = chaineRecherchee.Length;
      int index = 0;
      string chaineTempo = chaineTotale.Substring(index, chaineRechercheeLength);
      while (index < chaineTotale.Length)
      {
        if (chaineTempo.Contains(chaineRecherchee))
        {
          occurrence++;
        }

        if (index + chaineRechercheeLength > chaineTotale.Length)
        {
          return occurrence;
        }

        index += 1;
        if ((index + chaineRechercheeLength > chaineTotale.Length))
        {
          return occurrence;
        }

        chaineTempo = chaineTotale.Substring(index, chaineRechercheeLength);
      }

      return occurrence;
    }

    public static string ByteArrayToHexaString(byte[] bytes, bool oneDigitOnly = false)
    {
      var sb = new StringBuilder();
      for (int i = 0; i < bytes.Length; i++)
      {
        if (oneDigitOnly)
        {
          sb.Append(bytes[i].ToString("X1"));
        }
        else
        {
          sb.Append(bytes[i].ToString("X2"));
        }
      }

      return sb.ToString();
    }

    public static byte[] HexaStringToByteArray(string hexaString)
    {
      if (hexaString == string.Empty)
      {
        return new byte[0];
      }

      var returnBytes = new byte[hexaString.Length / 2];
      for (int i = 0; i < returnBytes.Length; i++)
      {
        returnBytes[i] = Convert.ToByte(hexaString.Substring(i * 2, 2));
      }

      return returnBytes;
    }

    public static string ReverseString(string strValue, bool removeSpace = false)
    {
      //  LINQ: return strValue.Aggregate(string.Empty, (current, caracter) => caracter + current);
      if (removeSpace)
      {
        strValue = strValue.Replace(" ", "");
      }

      string reversedString = string.Empty;
      foreach (char caracter in strValue)
      {
        reversedString = caracter + reversedString;
      }

      return reversedString;
    }

    public static string ReverseString2(string input, bool removeSpace = false)
    {
      //  Validate input
      if (string.IsNullOrEmpty(input))
      {
        return string.Empty;
      }

      if (removeSpace)
      {
        input = input.Replace(" ", "");
      }
      char[] outputChars = input.ToCharArray();

      //  Reverse
      Array.Reverse(outputChars);

      //  build a string from the processed characters and return it
      return new string(outputChars);
    }

    public static string CompletePrefixWithZero(string numberInString)
    {
      return numberInString.Length == 1 ? "0" + numberInString : numberInString;
    }

    public static string CompletePrefixeWithZeroInt(int nombre)
    {
      if (nombre.ToString(CultureInfo.InvariantCulture).Length == 1)
      {
        return "0" + nombre.ToString(CultureInfo.InvariantCulture);
      }

      return nombre.ToString(CultureInfo.InvariantCulture);
    }

    public static string ArrayToString(IList array)
    {
      //  Returns a string representation of an array. Each element is written on a new line.
      if (array == null || array.Count == 0)
      {
        return string.Empty;
      }

      string output = string.Empty;
      for (int i = 0; i < array.Count; i++)
      {
        output += array[i].ToString();
        //  don't add separator at the end of the list
        if (i != array.Count - 1)
        {
          output += Environment.NewLine;
        }
      }

      return output;
    }

    public static string ArrayToString(IList array, string separator)
    {
      //  Returns a string representation of an array. Each element is written on a new line.
      if (array == null || array.Count == 0)
      {
        return string.Empty;
      }

      string output = string.Empty;
      for (int i = 0; i < array.Count; i++)
      {
        output += array[i].ToString();

        //  don't add separator at the end of the list
        if (i != array.Count - 1)
        {
          output += separator;
        }
      }

      return output;
    }

    public static string ArrayToStringWithStringBuilder(IList array)
    {
      //  Returns a string representation of an array. Each element is written on a new line. Effective for large strings.
      if (array == null || array.Count == 0)
      {
        return string.Empty;
      }

      var output = new StringBuilder(array.Count * 2);
      for (int i = 0; i < array.Count; i++)
      {
        output.Append(array[i]);

        //  don't add separator at the end of the list
        if (i != array.Count - 1)
        {
          output.Append(Environment.NewLine);
        }
      }

      return output.ToString();
    }

    public static string ArrayToStringWithStringBuilder(IList array, string separator)
    {
      //  Returns a string representation of an array. Each element is separated by the specified string.
      if (array == null || array.Count == 0)
      {
        return string.Empty;
      }

      var output = new StringBuilder(array.Count * 2);
      for (int i = 0; i < array.Count; i++)
      {
        output.Append(array[i]);

        //  don't add separator at the end of the list
        if (i != array.Count - 1)
        {
          output.Append(separator);
        }
      }

      return output.ToString();
    }

    public static string InsertSeparatorForEachCharacter(string input, string separator = " ")
    {
      //  Validate string
      if (string.IsNullOrEmpty(input))
      {
        return string.Empty;
      }

      var outputChars = new List<char>(input.ToCharArray());
      char[] separatorChars = separator.ToCharArray();
      int i = 1;
      while (i < outputChars.Count)
      {
        if (i != outputChars.Count) // don't add separator to the end of string
        {
          outputChars.InsertRange(i, separatorChars);
        }

        i += 1 + separator.Length; // go up the interval amount plus separator
      }

      return new string(outputChars.ToArray());
    }

    public static string InsertSeparatorAtInterval(string input, string separator, int interval)
    {
      // Validate string
      if (string.IsNullOrEmpty(input))
      {
        return string.Empty;
      }

      List<char> outputChars = new List<char>(input.ToCharArray());
      char[] separatorChars = separator.ToCharArray();
      int i = interval;
      while (i < outputChars.Count)
      {
        if (i != outputChars.Count) // don't add separator to the end of string
        {
          outputChars.InsertRange(i, separatorChars);
        }

        i += interval + separator.Length; // go up the interval amount plus separator
      }

      return new string(outputChars.ToArray());
    }

    public static string RemoveVowels(string input)
    {
      // Validate input
      if (string.IsNullOrEmpty(input))
      {
        return string.Empty;
      }

      List<char> outputChars = new List<char>(input.ToCharArray());
      // Iterate backwards to avoid problems from removing characters
      for (int i = outputChars.Count - 1; i >= 0; i--)
      {
        if (outputChars[i] == 'a' || outputChars[i] == 'A' ||
            outputChars[i] == 'e' || outputChars[i] == 'E' ||
            outputChars[i] == 'i' || outputChars[i] == 'I' ||
            outputChars[i] == 'o' || outputChars[i] == 'O' ||
            outputChars[i] == 'u' || outputChars[i] == 'U' ||
            outputChars[i] == 'y' || outputChars[i] == 'Y')
          // not a vowel, remove it
          outputChars.RemoveAt(i);
      }

      return new string(outputChars.ToArray());
    }

    public static string KeepVowels(string input)
    {
      // Validate input
      if (string.IsNullOrEmpty(input))
      {
        return string.Empty;
      }

      List<char> outputChars = new List<char>(input.ToCharArray());
      // Iterate backwards to avoid problems from removing characters
      for (int i = outputChars.Count - 1; i >= 0; i--)
      {
        if (!(outputChars[i] == 'a' || outputChars[i] == 'A' ||
              outputChars[i] == 'e' || outputChars[i] == 'E' ||
              outputChars[i] == 'i' || outputChars[i] == 'I' ||
              outputChars[i] == 'o' || outputChars[i] == 'O' ||
              outputChars[i] == 'u' || outputChars[i] == 'U' ||
              outputChars[i] == 'y' || outputChars[i] == 'Y'))
          // a vowel, remove it
          outputChars.RemoveAt(i);
      }

      return new string(outputChars.ToArray());
    }

    public static string AlternateCases(string input)
    {
      if (string.IsNullOrEmpty(input)) return string.Empty;
      if (input.Length == 1) return input; // Nothing to alternate
      char[] inputChars = input.ToCharArray(); // character array representing the string
      bool toUpper = !char.IsUpper(inputChars[0]);
      for (int i = 1; i < inputChars.Length; i++) // start with the section character
      {
        if (toUpper)
        {
          inputChars[i] = char.ToUpper(inputChars[i]);
        }
        else
        {
          inputChars[i] = char.ToLower(inputChars[i]);
        }

        toUpper = !toUpper; // alternate
      }

      return new string(inputChars);
    }

    public static string SwapCases(string input)
    {
      // Returns a string with the opposite letter casing for each character.
      if (string.IsNullOrEmpty(input))
      {
        return string.Empty;
      }

      char[] inputChars = input.ToCharArray();
      for (int i = 0; i < inputChars.Length; i++)
      {
        // Apply the opposite letter casing
        if (char.IsUpper(inputChars[i]))
        {
          inputChars[i] = char.ToLower(inputChars[i]);
        }
        else
        {
          inputChars[i] = char.ToUpper(inputChars[i]);
        }
      }

      return new string(inputChars);
    }

    public static string Capitalize(string input)
    {
      //  Capitalizes the first character in a string.
      if (string.IsNullOrEmpty(input)) return string.Empty;
      if (input.Length == 1) return input.ToUpper();

      return input[0].ToString(CultureInfo.CurrentCulture).ToUpper() + input.Substring(1);
    }

    public static string GetInitials(string input, bool capitalizeInitials, bool preserveSpaces, bool includePeriod)
    {
      // Returns the initials of each word in a string. Words must be separated with spaces.
      //  <param name="capitalizeInitials">True to capitalize each initial in the output string.
      //  <param name="preserveSpaces">True to preserver the spaces between initials in the output string.
      //  <param name="includePeriod">True to include a '.' after each intialize
      if (string.IsNullOrEmpty(input))
      {
        return string.Empty;
      }

      string[] words = input.Split(' ');
      for (int i = 0; i < words.Length; i++)
      {
        if (words[i].Length > 0)
        {
          if (capitalizeInitials)
          {
            words[i] = char.ToUpper(words[i][0]).ToString(CultureInfo.CurrentCulture); // only keep the first letter
          }
          else
          {
            words[i] = words[i][0].ToString(CultureInfo.CurrentCulture); // only keep the first letter
          }

          if (includePeriod)
          {
            words[i] += ".";
          }
        }
      }

      if (preserveSpaces)
      {
        return string.Join(" ", words);
      }

      return string.Join(string.Empty, words);
    }

    public static string GetInitials(string input, string separator, bool capitalizeInitials, bool preserveSeparator, bool includePeriod)
    {
      // Returns the initials of each word in a string. Words are separated according to the sepecified string sequence.
      // //  <param name="input">The original string.</param>
      // //  <param name="separator">The string sequence that separates words.</param>
      // //  <param name="capitalizeInitials">True to capitalize each initial in the output string.</param>
      // //  <param name="preserveSeparator">True to preserver the spaces between initials in the output string.</param>
      if (string.IsNullOrEmpty(input))
        return string.Empty;
      string[] words = input.Split(separator.ToCharArray());
      for (int i = 0; i < words.Length; i++)
      {
        if (words[i].Length > 0)
        {
          if (capitalizeInitials)
            words[i] = char.ToUpper(words[i][0]).ToString(CultureInfo.CurrentCulture); // only keep the first letter
          else
            words[i] = words[i][0].ToString(CultureInfo.CurrentCulture); // only keep the first letter
          if (includePeriod)
            words[i] += ".";
        }
      }

      return string.Join(preserveSeparator ? separator : string.Empty, words);
    }

    public static string GetTitle(string input)
    {
      // Returns a string with each word's first character capitalized. Words must be separated by spaces.
      if (string.IsNullOrEmpty(input))
        return string.Empty;
      string[] words = input.Split(' ');
      for (int i = 0; i < words.Length; i++)
      {
        // Capitalize each word
        if (words[i].Length > 0)
          words[i] = char.ToUpper(words[i][0]).ToString(CultureInfo.CurrentCulture) + words[i].Substring(1);
      }

      return string.Join(" ", words);
    }

    public static string GetTitle(string input, string separator)
    {
      //  Returns a string with each word's first character capitalized. Words are separated according to the sepecified string sequence.
      if (string.IsNullOrEmpty(input))
      {
        return string.Empty;
      }

      string[] words = input.Split(separator.ToCharArray());
      for (int i = 0; i < words.Length; i++)
      {
        // Capitalize each word
        if (words[i].Length > 0)
        {
          words[i] = char.ToUpper(words[i][0]).ToString(CultureInfo.CurrentCulture) + words[i].Substring(1);
        }
      }

      return string.Join(separator, words);
    }

    public static string SubstringEnd(string input, int start, int end)
    {
      //  Returns a segment of a string, marked by the start and end index (exclusive).
      if (string.IsNullOrEmpty(input) || start == end)
        return string.Empty;
      if (start == 0 && end == input.Length)
        return input; // entire string
      if (start < 0) return string.Empty;
      if (start > input.Length) return string.Empty;
      if (end < 0) return string.Empty;
      if (end > input.Length) return string.Empty;

      return input.Substring(start, end);
    }

    public static char CharRight(string input, int index)
    {
      //  Returns the character in a string at a given index counting from the right.
      // //  <param name="index">The starting position from the right. (Index 0 = last character)</param>
      if (string.IsNullOrEmpty(input)) return new char();
      if (input.Length - index - 1 >= input.Length) return new char();
      if (input.Length - index - 1 < 0) return new char();

      return input[input.Length - index - 1];
    }

    public static char CharMid(string input, int startingIndex, int count)
    {
      //  Returns the character at a position given by the startingIndex plus the given count.
      // //  <param name="countIndex">The number of characters to count from the starting position.</param>
      if (string.IsNullOrEmpty(input)) return new char();
      if (startingIndex < 0) return new char();
      if (startingIndex >= input.Length) return new char();
      if (startingIndex + count < 0) return new char();
      if (startingIndex + count >= input.Length) return new char();
      return input[startingIndex + count];
    }

    public static int CountString(string input, string sequence, bool ignoreCase)
    {
      //  Returns the total number of times a given sequence appears in a string.
      // //  <param name="ignoreCase">True, to ignore the difference in case between the sequence and the original string.</param>
      if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(sequence)) return 0;
      int count = 0;
      for (int i = 0; i < input.Length; i++)
      {
        if (i + sequence.Length > input.Length)
        {
          break; // sequence doesn't fit anymore
        }

        string inputSegment = input.Substring(i, sequence.Length); // holds the current segment being compared
        if (string.Compare(inputSegment, sequence, ignoreCase) == 0)
        {
          count++; // another match found
        }
      }

      return count;
    }

    public static int[] IndexOfAll(string input, string sequence, bool ignoreCase)
    {
      //  Returns an array of every index where a sequence is found on the specified string. Note: Overlaps will be counted.
      // //  <param name="ignoreCase">True, to ignore the difference in case between the sequence and the original string.</param>
      if (string.IsNullOrEmpty(input)) return new int[0]; // empty array
      var indices = new List<int>();
      for (int i = 0; i < input.Length; i++)
      {
        if (i + sequence.Length > input.Length) break; // sequence doesn't fit anymore
        string inputSegment = input.Substring(i, sequence.Length); // holds the current segment being compared
        if (string.Compare(inputSegment, sequence, ignoreCase) == 0) indices.Add(i);
      }

      // Copy entries over to an array
      int[] output = indices.ToArray();
      indices.Clear();
      return output;
    }

    public static int[] IndexOfAll(string input, string sequence, int startIndex, bool ignoreCase)
    {
      // Returns an array of every index where a sequence is found on the specified string. Note: Overlaps will be counted.
      // //  <param name="input">The original string.</param>
      // //  <param name="sequence">The string sequence to seek.</param>
      // //  <param name="startIndex">Index from which to start seeking.</param>
      // //  <param name="ignoreCase">True, to ignore the difference in case between the sequence and the original string.</param>
      if (string.IsNullOrEmpty(input))
        return new int[0]; // empty array
      var indices = new List<int>();
      for (int i = startIndex; i < input.Length; i++)
      {
        if (i + sequence.Length > input.Length)
          break; // sequence doesn't fit anymore
        string inputSegment = input.Substring(i, sequence.Length); // holds the current segment being compared
        if (string.Compare(inputSegment, sequence, ignoreCase) == 0)
        {
          indices.Add(i);
        }
      }

      // Copy entries over to an array
      int[] output = indices.ToArray();
      indices.Clear();
      return output;
    }

    public static bool IsAlternateCases(string input)
    {
      //  Returns whether the letter casing in a string is alternating.
      if (string.IsNullOrEmpty(input) || input.Length == 1) return false;
      bool isLastUpper = char.IsUpper(input[0]);
      for (int i = 1; i < input.Length; i++)
      {
        if (isLastUpper)
        {
          if (char.IsUpper(input[i]))
          {
            return false; // two upper-cases in a row
          }
        }
        else
        {
          if (char.IsLower(input[i]))
          {
            return false; // two lower-cases in a row
          }
        }

        isLastUpper = !isLastUpper; // alternate
      }

      return true;
    }

    public static bool IsCapitalized(string input)
    {
      //  Returns true if the first character in a string is upper case.
      return !string.IsNullOrEmpty(input) && char.IsUpper(input[0]);
    }

    public static bool IsLowerCase(string input)
    {
      //  Returns whether a string is in all lower case.
      if (string.IsNullOrEmpty(input)) return false;
      for (int i = 0; i < input.Length; i++)
      {
        // A single non-lower case character makes function false,
        // unless it is a chracter other than a letter
        if (!char.IsLower(input[i]) && char.IsLetter(input[i]))
          return false;
      }

      return true;
    }

    public static bool IsLowerCase2(string input)
    {
      //  Returns whether a string is in all lower case.
      if (string.IsNullOrEmpty(input)) return false;
      return input.ToLower() == input;
    }

    public static bool IsUpperCase(string input)
    {
      // Returns whether a string is in all upper case.
      if (string.IsNullOrEmpty(input))
      {
        return false;
      }

      for (int i = 0; i < input.Length; i++)
      {
        // A single non-upper case character makes function false,
        // unless it is a chracter other than a letter
        if (!char.IsUpper(input[i]) && char.IsLetter(input[i]))
        {
          return false;
        }
      }

      return true;
    }

    public static bool IsUpperCase2(string input)
    {
      // Returns whether a string is in all upper case.
      if (string.IsNullOrEmpty(input))
      {
        return false;
      }

      return input.ToUpper() == input;
    }

    public static bool HasVowels(string input)
    {
      // Returns whether a string contains any vowel letters
      if (string.IsNullOrEmpty(input))
      {
        return false;
      }

      return input.Any(t => t == 'a' || t == 'A' || t == 'e' || t == 'E' || t == 'i' || t == 'I' || t == 'o' || t == 'O' || t == 'u' || t == 'U' || t == 'y' || t == 'Y');
    }

    public static bool IsSpaces(string input)
    {
      // //  Returns whether a string is all empty spaces
      return string.IsNullOrEmpty(input) || input.Replace(" ", string.Empty).Length == 0;
    }

    public static bool IsRepeatedChar(string input)
    {
      // //  Returns whether a string is composed of only a single character.
      return string.IsNullOrEmpty(input) || input.Replace(input[0].ToString(CultureInfo.InvariantCulture), string.Empty).Length == 0;
    }

    public static bool IsNumeric2(string input)
    {
      // Returns whether a string is composed of only numeric characters.
      if (string.IsNullOrEmpty(input))
      {
        return false;
      }

      for (int i = 0; i < input.Length; i++)
      {
        if (!char.IsNumber(input[i]))
        {
          // single non-numeric integer makes function false
          return false;
        }
      }

      return true;
    }

    public static bool IsNumeric(string valueInNumeric)
    {
      if (valueInNumeric == string.Empty)
      {
        return false;
      }

      bool isFine = true;
      foreach (char caracter in valueInNumeric)
      {
        if (!(caracter >= '0' && caracter <= '9'))
        {
          isFine = false;
        }
      }

      return isFine;
    }

    public static bool IsNumeric3(string val, NumberStyles numberStyle)
    {
      double result;
      return double.TryParse(val, numberStyle, CultureInfo.CurrentCulture, out result);
    }

    public static bool HasNumeric(string input)
    {
      // Returns whether a string contains any numberic characters.
      if (string.IsNullOrEmpty(input))
      {
        return false;
      }

      for (int i = 0; i < input.Length; i++)
      {
        if (char.IsNumber(input[i]))
        {
          return true; //  single numeric integer makes function true
        }
      }

      return false;
    }

    public static bool IsAlphaNumeric(string input)
    {
      //  Returns whether a string is composed of only letter and digit characters.
      if (string.IsNullOrEmpty(input)) return false;
      for (int i = 0; i < input.Length; i++)
      {
        if (!char.IsLetter(input[i]) && !char.IsNumber(input[i]))
          return false;
      }

      return true;
    }

    public static bool IsLetters(string input)
    {
      //  Returns whether a string is composed of all letter characters.
      return !string.IsNullOrEmpty(input) && input.All(char.IsLetter);
      // was :
      //  return input.All(t => char.IsLetter(t));
    }

    public static bool IsTitle(string input)
    {
      // //  Returns whether a string is formatted like a title, ie the first chracter of each word is capitalized. 
      // //  Words must be separated by spaces.
      if (string.IsNullOrEmpty(input))
      {
        return false;
      }

      string[] words = input.Split(' ');
      for (int i = 0; i < words.Length; i++)
      {
        if (words[i].Length > 0)
        {
          if (!char.IsUpper(words[i][0]))
          {
            return false;
          }
        }
      }

      return true;
    }

    public static bool IsTitle(string input, string separator)
    {
      //  Returns whether a string is formatted like a title, ie the first chracter of each word is capitalized. 
      //  Words are separated according to the sepecified string sequence.
      //  <param name="input">The original string.</param>
      //  <param name="separator">The string sequence that separates words.</param>
      if (string.IsNullOrEmpty(input))
      {
        return false;
      }

      string[] words = input.Split(separator.ToCharArray());
      for (int i = 0; i < words.Length; i++)
      {
        if (words[i].Length > 0)
        {
          if (!char.IsUpper(words[i][0]))
          {
            return false;
          }
        }
      }

      return true;
    }

    public static bool IsEmailAddress(string input)
    {
      // //  Returns whether a string is in a valid email address format.
      if (string.IsNullOrEmpty(input))
      {
        return false;
      }

      //  any email address will be at least 5 characters (a@a.fr)
      if (input.IndexOf('@') != -1 && input.Length >= 8)
      {
        int indexOfDot = input.LastIndexOf('.');

        //  last period must be after the @ 
        //  valid for a firstName.LastName@someFAI.com
        if (indexOfDot > input.IndexOf('@'))
        {
          return true;
        }
      }

      return false;
    }

    public static bool IsEmailAddressValid(string s)
    {
      Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,13}$"); // 13 characters since .international
      return regex.IsMatch(s);
    }

    public static char[] LoadAlphabetInList(bool addDigit = true, bool addLowerCaseLetters = true, bool addUpperCaseLetters = false)
    {
      char[] list = new char[26 + 26 + 10]; // lower case + upper case letters + 10 digits
      int counter = 0;
      if (addLowerCaseLetters)
      {
        for (char letter = 'a'; letter <= 'z'; letter++)
        {
          list[counter] = letter;
          counter++;
        }
      }

      if (addUpperCaseLetters)
      {
        for (char letter = 'A'; letter <= 'Z'; letter++)
        {
          list[counter] = letter;
          counter++;
        }
      }

      if (addDigit)
      {
        for (short digit = 48; digit < 58; digit++) // 48 = asc('0')
        {
          list[counter] = (char)digit;
          counter++;
        }
      }

      return list;
    }

    public static string[] LoadAlphabetInStringArray(string[] list)
    {
      if (list.Length == 0)
      {
        return new string[0];
      }

      int counter = 0;
      for (char letter = 'a'; letter <= 'z'; letter++)
      {
        list[counter] = letter.ToString(CultureInfo.InvariantCulture);
        counter++;
      }

      for (short digit = 0; digit < 10; digit++)
      {
        list[counter] = digit.ToString(CultureInfo.InvariantCulture);
        counter++;
      }

      return list;
    }

    public static List<string> GetAlphabetToList(bool addLowerCaseLetters = true, bool addUpperCaseLetters = false,
      bool addDigit = true, LetterCasingSequence letterSequence = LetterCasingSequence.LowerUpperDigit)
    {
      List<string> list = new List<string>();
      switch (letterSequence)
      {
        case LetterCasingSequence.LowerUpperDigit:
          list = AddLowerCaseLetters(list);
          list = AddUpperCaseLetters(list);
          list = AddDigits(list);
          break;
        case LetterCasingSequence.UpperLowerDigit:
          list = AddUpperCaseLetters(list);
          list = AddLowerCaseLetters(list);
          list = AddDigits(list);
          break;
        case LetterCasingSequence.DigitLowerUpper:
          list = AddDigits(list);
          list = AddLowerCaseLetters(list);
          list = AddUpperCaseLetters(list);
          break;
        case LetterCasingSequence.DigitUpperLower:
          list = AddDigits(list);
          list = AddUpperCaseLetters(list);
          list = AddLowerCaseLetters(list);
          break;
        case LetterCasingSequence.LowerDigitUpper:
          list = AddLowerCaseLetters(list);
          list = AddDigits(list);
          list = AddUpperCaseLetters(list);
          break;
        case LetterCasingSequence.UpperDigitLower:
          list = AddUpperCaseLetters(list);
          list = AddDigits(list);
          list = AddLowerCaseLetters(list);
          break;
      }

      return list;
    }

    public static List<string> AddDigits(List<string> startingList)
    {
      for (short digit = 0; digit < 10; digit++)
      {
        startingList.Add(digit.ToString(CultureInfo.InvariantCulture));
      }

      return startingList;
    }

    public static List<string> AddLowerCaseLetters(List<string> startingList)
    {
      for (char letter = 'a'; letter <= 'z'; letter++)
      {
        startingList.Add(letter.ToString(CultureInfo.InvariantCulture));
      }

      return startingList;
    }

    public static List<string> AddUpperCaseLetters(List<string> startingList)
    {
      for (char letter = 'A'; letter <= 'Z'; letter++)
      {
        startingList.Add(letter.ToString(CultureInfo.InvariantCulture));
      }

      return startingList;
    }

    public enum LetterCasingSequence
    {
      LowerUpperDigit,
      UpperLowerDigit,
      DigitLowerUpper,
      DigitUpperLower,
      LowerDigitUpper,
      UpperDigitLower
    }
    public static string NumberToEnglishWords(int number)
    {
      if (number == 0)
      {
        return "zero";
      }

      if (number < 0)
      {
        return "minus " + NumberToEnglishWords(Math.Abs(number));
      }

      string words = string.Empty;

      if ((number / 1000000) > 0)
      {
        words += NumberToEnglishWords(number / 1000000) + " million ";
        number %= 1000000;
      }

      if ((number / 1000) > 0)
      {
        words += NumberToEnglishWords(number / 1000) + " thousand ";
        number %= 1000;
      }

      if ((number / 100) > 0)
      {
        words += NumberToEnglishWords(number / 100) + " hundred ";
        number %= 100;
      }

      if (number > 0)
      {
        if (words != string.Empty)
        {
          words += "and ";
        }

        var unitsMap = new[]
          {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve",
            "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
          };
        var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        if (number < 20)
        {
          words += unitsMap[number];
        }
        else
        {
          words += tensMap[number / 10];
          if ((number % 10) > 0)
          {
            words += "-" + unitsMap[number % 10];
          }
        }
      }

      return words;
    }

    public static string NumberToFrenchWords(int number)
    {
      if (number == 0)
      {
        return "zero";
      }

      if (number < 0)
      {
        return "moins " + NumberToFrenchWords(Math.Abs(number));
      }

      string words = string.Empty;
      if ((number / 1000000) > 0)
      {
        words += NumberToFrenchWords(number / 1000000) + " million ";
        number %= 1000000;
      }

      if ((number / 1000) > 0)
      {
        words += NumberToFrenchWords(number / 1000) + " millier ";
        number %= 1000;
      }

      if ((number / 100) > 0)
      {
        words += NumberToFrenchWords(number / 100) + " cent ";
        number %= 100;
      }

      if (number > 0)
      {
        if (words != string.Empty)
        {
          words += "et ";
        }

        var unitsMap = new[]
          {
            "zéro", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix", "onze", "douze",
            "treize", "quatorze", "quinze", "seize", "dix-sept", "dix-huit", "dix-neuf"
          };
        var tensMap = new[]
          {
            "zéro", "dix", "vingt", "trente", "quarante", "cinquante", "soixante", "soixante-dix", "quatre-vingt",
            "quatre-vingt-dix"
          };
        if (number < 20)
        {
          words += unitsMap[number];
        }
        else
        {
          words += tensMap[number / 10];
          if ((number % 10) > 0)
          {
            words += "-" + unitsMap[number % 10];
          }
        }
      }

      return words;
    }

    public static Dictionary<int, string> DicoNumberToWordsFrench(int startNumber, int endNumber)
    {
      Dictionary<int, string> result = new Dictionary<int, string>();
      for (int i = startNumber; i < endNumber; i++)
      {
        result.Add(i, NumberToFrenchWords(i));
      }

      return result;
    }

    public static Dictionary<int, string> DicoNumberToEnglishWords(int startNumber, int endNumber)
    {
      Dictionary<int, string> result = new Dictionary<int, string>();
      for (int i = startNumber; i < endNumber; i++)
      {
        result.Add(i, NumberToEnglishWords(i));
      }

      return result;
    }

    public static bool IsInside(int number, params int[] array)
    {
      bool found = false;
      foreach (var item in array.Where(item => number == item))
      {
        found = true;
      }

      return found;
    }

    public static string ToTitleCase(string myString)
    {
      return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(myString.ToLower());
    }

    public static string UpperCaseFirstLetter(string value)
    {
      //
      // Uppercase the first letter in the string this extension is called on.
      //
      if (value.Length > 0)
      {
        char[] array = value.ToCharArray();
        array[0] = char.ToUpper(array[0]);
        return new string(array);
      }
      return value;
    }

    public static char[] GetAlphabet(bool lowerCase = true)
    {
      char[] list = new char[26];
      int counter = 0;
      for (char letter = 'a'; letter <= 'z'; letter++)
      {
        list[counter] = lowerCase ? letter : char.ToUpper(letter);
        counter++;
      }

      return list;
    }
  }
}