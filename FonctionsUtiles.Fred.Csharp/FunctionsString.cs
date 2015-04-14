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
  using MathFunc = FunctionsMath;


  public class FunctionsString
  {
    /// <summary>
    /// List all the public methods available from this DLL
    /// </summary>
    /// <returns>
    /// Returns a list of all the methods used in this DLL with their signature.
    /// </returns>
    public static string Manifest()
    {
      const string newLine = "\n";
      StringBuilder result = new StringBuilder();
      result.Append(newLine + "Name= FonctionsUtiles.Fred.Csharp" + newLine);
      result.Append("Version= 1.0.0.0" + newLine);
      result.Append("Method= bool HasDuplicate(params int[] liste)" + newLine);
      result.Append("Method= bool HasNoDuplicate(params int[] liste)" + newLine);
      result.Append("Method= string EndPadding(string chaine, byte blankLength)" + newLine);
      result.Append("Method= string GetLastName(string chaine, char dernierCaractereRecherche)" + newLine);
      result.Append("Method= string GetFileNameAfterLastSlash(string longCheminFichier)" + newLine);
      result.Append("Method= string RemoveInString(string stringToBeRemoved, string inString, bool trimEnd = false)" + newLine);
      result.Append("Method= string CamelCase(string myString)" + newLine);
      result.Append("Method= bool IsNumeric(char letter)" + newLine);
      result.Append("Method= bool IsLetter(char myLetter)" + newLine);
      result.Append("Method= string Plural(int    number, string irregularNoun = \"\")" + newLine);
      result.Append("Method= string Plural(byte   number, string irregularNoun = \"\")" + newLine);
      result.Append("Method= string Plural(Int16  number, string irregularNoun = \"\")" + newLine);
      result.Append("Method= string Plural(Int64  number, string irregularNoun = \"\")" + newLine);
      result.Append("Method= string Plural(uint   number, string irregularNoun = \"\")" + newLine);
      result.Append("Method= string Plural(UInt16 number, string irregularNoun = \"\")" + newLine);
      result.Append("Method= string Plural(UInt64 number, string irregularNoun = \"\")" + newLine);
      result.Append("Method= int StringOccurrenceWithIndexOf(string wholeString, string searchedString)" + newLine);
      result.Append("Method= int StringOccurrenceWithContains(string myString, string searchedString)" + newLine);
      result.Append("Method= string ByteArrayToHexaString(byte[] bytes, bool oneDigitOnly = false)" + newLine);
      result.Append("Method= byte[] HexaStringToByteArray(string hexaString)" + newLine);
      result.Append("Method= string ReverseString(string strValue, bool removeSpace = false)" + newLine);
      result.Append("Method= bool IsPalindrome(string myString, bool spaceRemoval = false)" + newLine);
      result.Append("Method= string ReverseString2(string input, bool removeSpace = false)" + newLine);
      result.Append("Method= " + newLine);
      result.Append("Method= " + newLine);
      result.Append("Method= " + newLine);
      result.Append("Method= " + newLine);
      result.Append("Method= " + newLine);
      result.Append("Method= " + newLine);
      result.Append("Method= " + newLine);
      return result.ToString();
    }

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
    public static string CamelCase(string myString)
    {
      string result = string.Empty;
      bool isPreviousLetter = false;
      foreach (var item in myString)
      {
        if (isPreviousLetter && IsLetter(item))
        {
          result += item.ToString(CultureInfo.InvariantCulture).ToLower();
        }
        else
        {
          result += item.ToString(CultureInfo.InvariantCulture).ToUpper();
        }

        isPreviousLetter = IsLetter(item);
      }

      return result;
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
    public static bool IsLetter(char myLetter)
    {
      return char.IsLetter(myLetter);
    }
    public static string Plural(int number, string irregularNoun = "")
    {
      switch (irregularNoun)
      {
        case "":
          return number > 1 ? "s" : string.Empty;
        case "al":
          return number > 1 ? "aux" : "al";
        case "au":
          return number > 1 ? "aux" : "au";
        case "eau":
          return number > 1 ? "eaux" : "eau";
        case "eu":
          return number > 1 ? "eux" : "eu";
        case "landau":
          return number > 1 ? "landaus" : "landau";
        case "sarrau":
          return number > 1 ? "sarraus" : "sarrau";
        case "bleu":
          return number > 1 ? "bleus" : "bleu";
        case "émeu":
          return number > 1 ? "émeus" : "émeu";
        case "lieu":
          return number > 1 ? "lieux" : "lieu";
        case "pneu":
          return number > 1 ? "pneus" : "pneu";
        case "aval":
          return number > 1 ? "avals" : "aval";
        case "bal":
          return number > 1 ? "bals" : "bal";
        case "chacal":
          return number > 1 ? "chacals" : "chacal";
        case "carnaval":
          return number > 1 ? "carnavals" : "carnaval";
        case "festival":
          return number > 1 ? "festivals" : "festival";
        case "récital":
          return number > 1 ? "récitals" : "récital";
        case "régal":
          return number > 1 ? "régals" : "régal";
        case "cal":
          return number > 1 ? "cals" : "cal";
        case "serval":
          return number > 1 ? "servals" : "serval";
        case "choral":
          return number > 1 ? "chorals" : "choral";
        case "narval":
          return number > 1 ? "narvals" : "narval";
        case "bail":
          return number > 1 ? "baux" : "bail";
        case "corail":
          return number > 1 ? "coraux" : "corail";
        case "émail":
          return number > 1 ? "émaux" : "émail";
        case "soupirail":
          return number > 1 ? "soupiraux" : "soupirail";
        case "travail":
          return number > 1 ? "travaux" : "travail";
        case "vantail":
          return number > 1 ? "vantaux" : "vantail";
        case "vitrail":
          return number > 1 ? "vitraux" : "vitrail";
        case "bijou":
          return number > 1 ? "bijoux" : "bijou";
        case "caillou":
          return number > 1 ? "cailloux" : "caillou";
        case "chou":
          return number > 1 ? "choux" : "chou";
        case "genou":
          return number > 1 ? "genoux" : "genou";
        case "hibou":
          return number > 1 ? "hiboux" : "hibou";
        case "joujou":
          return number > 1 ? "joujoux" : "joujou";
        case "pou":
          return number > 1 ? "poux" : "pou";

        default:
          return number > 1 ? "s" : string.Empty;
      }

    }
    public static string Plural(byte number, string irregularNoun = "")
    {
      switch (irregularNoun)
      {
        case "":
          return number > 1 ? "s" : string.Empty;
        case "al":
          return number > 1 ? "aux" : "al";
        case "au":
          return number > 1 ? "aux" : "au";
        case "eau":
          return number > 1 ? "eaux" : "eau";
        case "eu":
          return number > 1 ? "eux" : "eu";
        case "landau":
          return number > 1 ? "landaus" : "landau";
        case "sarrau":
          return number > 1 ? "sarraus" : "sarrau";
        case "bleu":
          return number > 1 ? "bleus" : "bleu";
        case "émeu":
          return number > 1 ? "émeus" : "émeu";
        case "lieu":
          return number > 1 ? "lieux" : "lieu";
        case "pneu":
          return number > 1 ? "pneus" : "pneu";
        case "aval":
          return number > 1 ? "avals" : "aval";
        case "bal":
          return number > 1 ? "bals" : "bal";
        case "chacal":
          return number > 1 ? "chacals" : "chacal";
        case "carnaval":
          return number > 1 ? "carnavals" : "carnaval";
        case "festival":
          return number > 1 ? "festivals" : "festival";
        case "récital":
          return number > 1 ? "récitals" : "récital";
        case "régal":
          return number > 1 ? "régals" : "régal";
        case "cal":
          return number > 1 ? "cals" : "cal";
        case "serval":
          return number > 1 ? "servals" : "serval";
        case "choral":
          return number > 1 ? "chorals" : "choral";
        case "narval":
          return number > 1 ? "narvals" : "narval";
        case "bail":
          return number > 1 ? "baux" : "bail";
        case "corail":
          return number > 1 ? "coraux" : "corail";
        case "émail":
          return number > 1 ? "émaux" : "émail";
        case "soupirail":
          return number > 1 ? "soupiraux" : "soupirail";
        case "travail":
          return number > 1 ? "travaux" : "travail";
        case "vantail":
          return number > 1 ? "vantaux" : "vantail";
        case "vitrail":
          return number > 1 ? "vitraux" : "vitrail";
        case "bijou":
          return number > 1 ? "bojaux" : "bijou";
        case "caillou":
          return number > 1 ? "cailloux" : "caillou";
        case "chou":
          return number > 1 ? "choux" : "chou";
        case "genou":
          return number > 1 ? "genoux" : "genou";
        case "hibou":
          return number > 1 ? "hiboux" : "hibou";
        case "joujou":
          return number > 1 ? "joujoux" : "joujou";
        case "pou":
          return number > 1 ? "poux" : "pou";

        default:
          return number > 1 ? "s" : string.Empty;
      }
    }
    public static string Plural(Int16 number, string irregularNoun = "")
    {
      switch (irregularNoun)
      {
        case "":
          return number > 1 ? "s" : string.Empty;
        case "al":
          return number > 1 ? "aux" : "al";
        case "au":
          return number > 1 ? "aux" : "au";
        case "eau":
          return number > 1 ? "eaux" : "eau";
        case "eu":
          return number > 1 ? "eux" : "eu";
        case "landau":
          return number > 1 ? "landaus" : "landau";
        case "sarrau":
          return number > 1 ? "sarraus" : "sarrau";
        case "bleu":
          return number > 1 ? "bleus" : "bleu";
        case "émeu":
          return number > 1 ? "émeus" : "émeu";
        case "lieu":
          return number > 1 ? "lieux" : "lieu";
        case "pneu":
          return number > 1 ? "pneus" : "pneu";
        case "aval":
          return number > 1 ? "avals" : "aval";
        case "bal":
          return number > 1 ? "bals" : "bal";
        case "chacal":
          return number > 1 ? "chacals" : "chacal";
        case "carnaval":
          return number > 1 ? "carnavals" : "carnaval";
        case "festival":
          return number > 1 ? "festivals" : "festival";
        case "récital":
          return number > 1 ? "récitals" : "récital";
        case "régal":
          return number > 1 ? "régals" : "régal";
        case "cal":
          return number > 1 ? "cals" : "cal";
        case "serval":
          return number > 1 ? "servals" : "serval";
        case "choral":
          return number > 1 ? "chorals" : "choral";
        case "narval":
          return number > 1 ? "narvals" : "narval";
        case "bail":
          return number > 1 ? "baux" : "bail";
        case "corail":
          return number > 1 ? "coraux" : "corail";
        case "émail":
          return number > 1 ? "émaux" : "émail";
        case "soupirail":
          return number > 1 ? "soupiraux" : "soupirail";
        case "travail":
          return number > 1 ? "travaux" : "travail";
        case "vantail":
          return number > 1 ? "vantaux" : "vantail";
        case "vitrail":
          return number > 1 ? "vitraux" : "vitrail";
        case "bijou":
          return number > 1 ? "bojaux" : "bijou";
        case "caillou":
          return number > 1 ? "cailloux" : "caillou";
        case "chou":
          return number > 1 ? "choux" : "chou";
        case "genou":
          return number > 1 ? "genoux" : "genou";
        case "hibou":
          return number > 1 ? "hiboux" : "hibou";
        case "joujou":
          return number > 1 ? "joujoux" : "joujou";
        case "pou":
          return number > 1 ? "poux" : "pou";

        default:
          return number > 1 ? "s" : string.Empty;
      }
    }
    public static string Plural(Int64 number, string irregularNoun = "")
    {
      switch (irregularNoun)
      {
        case "":
          return number > 1 ? "s" : string.Empty;
        case "al":
          return number > 1 ? "aux" : "al";
        case "au":
          return number > 1 ? "aux" : "au";
        case "eau":
          return number > 1 ? "eaux" : "eau";
        case "eu":
          return number > 1 ? "eux" : "eu";
        case "landau":
          return number > 1 ? "landaus" : "landau";
        case "sarrau":
          return number > 1 ? "sarraus" : "sarrau";
        case "bleu":
          return number > 1 ? "bleus" : "bleu";
        case "émeu":
          return number > 1 ? "émeus" : "émeu";
        case "lieu":
          return number > 1 ? "lieux" : "lieu";
        case "pneu":
          return number > 1 ? "pneus" : "pneu";
        case "aval":
          return number > 1 ? "avals" : "aval";
        case "bal":
          return number > 1 ? "bals" : "bal";
        case "chacal":
          return number > 1 ? "chacals" : "chacal";
        case "carnaval":
          return number > 1 ? "carnavals" : "carnaval";
        case "festival":
          return number > 1 ? "festivals" : "festival";
        case "récital":
          return number > 1 ? "récitals" : "récital";
        case "régal":
          return number > 1 ? "régals" : "régal";
        case "cal":
          return number > 1 ? "cals" : "cal";
        case "serval":
          return number > 1 ? "servals" : "serval";
        case "choral":
          return number > 1 ? "chorals" : "choral";
        case "narval":
          return number > 1 ? "narvals" : "narval";
        case "bail":
          return number > 1 ? "baux" : "bail";
        case "corail":
          return number > 1 ? "coraux" : "corail";
        case "émail":
          return number > 1 ? "émaux" : "émail";
        case "soupirail":
          return number > 1 ? "soupiraux" : "soupirail";
        case "travail":
          return number > 1 ? "travaux" : "travail";
        case "vantail":
          return number > 1 ? "vantaux" : "vantail";
        case "vitrail":
          return number > 1 ? "vitraux" : "vitrail";
        case "bijou":
          return number > 1 ? "bojaux" : "bijou";
        case "caillou":
          return number > 1 ? "cailloux" : "caillou";
        case "chou":
          return number > 1 ? "choux" : "chou";
        case "genou":
          return number > 1 ? "genoux" : "genou";
        case "hibou":
          return number > 1 ? "hiboux" : "hibou";
        case "joujou":
          return number > 1 ? "joujoux" : "joujou";
        case "pou":
          return number > 1 ? "poux" : "pou";

        default:
          return number > 1 ? "s" : string.Empty;
      }
    }
    public static string Plural(uint number, string irregularNoun = "")
    {
      switch (irregularNoun)
      {
        case "":
          return number > 1 ? "s" : string.Empty;
        case "al":
          return number > 1 ? "aux" : "al";
        case "au":
          return number > 1 ? "aux" : "au";
        case "eau":
          return number > 1 ? "eaux" : "eau";
        case "eu":
          return number > 1 ? "eux" : "eu";
        case "landau":
          return number > 1 ? "landaus" : "landau";
        case "sarrau":
          return number > 1 ? "sarraus" : "sarrau";
        case "bleu":
          return number > 1 ? "bleus" : "bleu";
        case "émeu":
          return number > 1 ? "émeus" : "émeu";
        case "lieu":
          return number > 1 ? "lieux" : "lieu";
        case "pneu":
          return number > 1 ? "pneus" : "pneu";
        case "aval":
          return number > 1 ? "avals" : "aval";
        case "bal":
          return number > 1 ? "bals" : "bal";
        case "chacal":
          return number > 1 ? "chacals" : "chacal";
        case "carnaval":
          return number > 1 ? "carnavals" : "carnaval";
        case "festival":
          return number > 1 ? "festivals" : "festival";
        case "récital":
          return number > 1 ? "récitals" : "récital";
        case "régal":
          return number > 1 ? "régals" : "régal";
        case "cal":
          return number > 1 ? "cals" : "cal";
        case "serval":
          return number > 1 ? "servals" : "serval";
        case "choral":
          return number > 1 ? "chorals" : "choral";
        case "narval":
          return number > 1 ? "narvals" : "narval";
        case "bail":
          return number > 1 ? "baux" : "bail";
        case "corail":
          return number > 1 ? "coraux" : "corail";
        case "émail":
          return number > 1 ? "émaux" : "émail";
        case "soupirail":
          return number > 1 ? "soupiraux" : "soupirail";
        case "travail":
          return number > 1 ? "travaux" : "travail";
        case "vantail":
          return number > 1 ? "vantaux" : "vantail";
        case "vitrail":
          return number > 1 ? "vitraux" : "vitrail";
        case "bijou":
          return number > 1 ? "bojaux" : "bijou";
        case "caillou":
          return number > 1 ? "cailloux" : "caillou";
        case "chou":
          return number > 1 ? "choux" : "chou";
        case "genou":
          return number > 1 ? "genoux" : "genou";
        case "hibou":
          return number > 1 ? "hiboux" : "hibou";
        case "joujou":
          return number > 1 ? "joujoux" : "joujou";
        case "pou":
          return number > 1 ? "poux" : "pou";

        default:
          return number > 1 ? "s" : string.Empty;
      }
    }
    public static string Plural(UInt16 number, string irregularNoun = "")
    {
      switch (irregularNoun)
      {
        case "":
          return number > 1 ? "s" : string.Empty;
        case "al":
          return number > 1 ? "aux" : "al";
        case "au":
          return number > 1 ? "aux" : "au";
        case "eau":
          return number > 1 ? "eaux" : "eau";
        case "eu":
          return number > 1 ? "eux" : "eu";
        case "landau":
          return number > 1 ? "landaus" : "landau";
        case "sarrau":
          return number > 1 ? "sarraus" : "sarrau";
        case "bleu":
          return number > 1 ? "bleus" : "bleu";
        case "émeu":
          return number > 1 ? "émeus" : "émeu";
        case "lieu":
          return number > 1 ? "lieux" : "lieu";
        case "pneu":
          return number > 1 ? "pneus" : "pneu";
        case "aval":
          return number > 1 ? "avals" : "aval";
        case "bal":
          return number > 1 ? "bals" : "bal";
        case "chacal":
          return number > 1 ? "chacals" : "chacal";
        case "carnaval":
          return number > 1 ? "carnavals" : "carnaval";
        case "festival":
          return number > 1 ? "festivals" : "festival";
        case "récital":
          return number > 1 ? "récitals" : "récital";
        case "régal":
          return number > 1 ? "régals" : "régal";
        case "cal":
          return number > 1 ? "cals" : "cal";
        case "serval":
          return number > 1 ? "servals" : "serval";
        case "choral":
          return number > 1 ? "chorals" : "choral";
        case "narval":
          return number > 1 ? "narvals" : "narval";
        case "bail":
          return number > 1 ? "baux" : "bail";
        case "corail":
          return number > 1 ? "coraux" : "corail";
        case "émail":
          return number > 1 ? "émaux" : "émail";
        case "soupirail":
          return number > 1 ? "soupiraux" : "soupirail";
        case "travail":
          return number > 1 ? "travaux" : "travail";
        case "vantail":
          return number > 1 ? "vantaux" : "vantail";
        case "vitrail":
          return number > 1 ? "vitraux" : "vitrail";
        case "bijou":
          return number > 1 ? "bojaux" : "bijou";
        case "caillou":
          return number > 1 ? "cailloux" : "caillou";
        case "chou":
          return number > 1 ? "choux" : "chou";
        case "genou":
          return number > 1 ? "genoux" : "genou";
        case "hibou":
          return number > 1 ? "hiboux" : "hibou";
        case "joujou":
          return number > 1 ? "joujoux" : "joujou";
        case "pou":
          return number > 1 ? "poux" : "pou";

        default:
          return number > 1 ? "s" : string.Empty;
      }
    }
    public static string Plural(UInt64 number, string irregularNoun = "")
    {
      switch (irregularNoun)
      {
        case "":
          return number > 1 ? "s" : string.Empty;
        case "al":
          return number > 1 ? "aux" : "al";
        case "au":
          return number > 1 ? "aux" : "au";
        case "eau":
          return number > 1 ? "eaux" : "eau";
        case "eu":
          return number > 1 ? "eux" : "eu";
        case "landau":
          return number > 1 ? "landaus" : "landau";
        case "sarrau":
          return number > 1 ? "sarraus" : "sarrau";
        case "bleu":
          return number > 1 ? "bleus" : "bleu";
        case "émeu":
          return number > 1 ? "émeus" : "émeu";
        case "lieu":
          return number > 1 ? "lieux" : "lieu";
        case "pneu":
          return number > 1 ? "pneus" : "pneu";
        case "aval":
          return number > 1 ? "avals" : "aval";
        case "bal":
          return number > 1 ? "bals" : "bal";
        case "chacal":
          return number > 1 ? "chacals" : "chacal";
        case "carnaval":
          return number > 1 ? "carnavals" : "carnaval";
        case "festival":
          return number > 1 ? "festivals" : "festival";
        case "récital":
          return number > 1 ? "récitals" : "récital";
        case "régal":
          return number > 1 ? "régals" : "régal";
        case "cal":
          return number > 1 ? "cals" : "cal";
        case "serval":
          return number > 1 ? "servals" : "serval";
        case "choral":
          return number > 1 ? "chorals" : "choral";
        case "narval":
          return number > 1 ? "narvals" : "narval";
        case "bail":
          return number > 1 ? "baux" : "bail";
        case "corail":
          return number > 1 ? "coraux" : "corail";
        case "émail":
          return number > 1 ? "émaux" : "émail";
        case "soupirail":
          return number > 1 ? "soupiraux" : "soupirail";
        case "travail":
          return number > 1 ? "travaux" : "travail";
        case "vantail":
          return number > 1 ? "vantaux" : "vantail";
        case "vitrail":
          return number > 1 ? "vitraux" : "vitrail";
        case "bijou":
          return number > 1 ? "bijoux" : "bijou";
        case "caillou":
          return number > 1 ? "cailloux" : "caillou";
        case "chou":
          return number > 1 ? "choux" : "chou";
        case "genou":
          return number > 1 ? "genoux" : "genou";
        case "hibou":
          return number > 1 ? "hiboux" : "hibou";
        case "joujou":
          return number > 1 ? "joujoux" : "joujou";
        case "pou":
          return number > 1 ? "poux" : "pou";

        default:
          return number > 1 ? "s" : string.Empty;
      }
    }
    public static int StringOccurrenceWithIndexOf(string wholeString, string searchedString)
    {
      if (wholeString == string.Empty || searchedString == string.Empty)
      {
        return 0;
      }

      int occurrence = 0;
      int str2Length = searchedString.Length;
      int index = 0;
      while ((index = wholeString.IndexOf(searchedString, index, StringComparison.Ordinal)) > -1)
      {
        occurrence++;
        index += str2Length;
      }

      return occurrence;
    }
    public static int StringOccurrenceWithContains(string myString, string searchedString)
    {
      if (searchedString == string.Empty || myString == string.Empty)
      {
        return 0;
      }

      int occurrence = 0;
      int chaineRechercheeLength = searchedString.Length;
      int index = 0;
      string chaineTempo = myString.Substring(index, chaineRechercheeLength);
      while (index < myString.Length)
      {
        if (chaineTempo.Contains(searchedString))
        {
          occurrence++;
        }

        if (index + chaineRechercheeLength > myString.Length)
        {
          return occurrence;
        }

        index += 1;
        if ((index + chaineRechercheeLength > myString.Length))
        {
          return occurrence;
        }

        chaineTempo = myString.Substring(index, chaineRechercheeLength);
      }

      return occurrence;
    }
    public static string ByteArrayToHexaString(byte[] bytes, bool oneDigitOnly = false)
    {
      var sb = new StringBuilder();
      for (int i = 0; i < bytes.Length; i++)
      {
        sb.Append(oneDigitOnly ? bytes[i].ToString("X1") : bytes[i].ToString("X2"));
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
    public static string ReverseString2(string strValue, bool removeSpace = false)
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
    public static string ReverseString(string input, bool removeSpace = false)
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
    public static bool IsPalindrome(string myString, bool spaceRemoval = false)
    {
      if (spaceRemoval) // can you use ternary twice ?
      {
        return ReverseString(myString, spaceRemoval) == myString.Replace(" ", "");
      }
      
      return ReverseString(myString, spaceRemoval) == myString;
    }
    
    public static string CompletePrefixWithZero(string numberInString, byte numberOfZero = 1)
    {
      string numberOfZeroString = "";
      for (byte i = 0; i < numberOfZero; i++)
      {
        numberOfZeroString += "0";
      }

      return numberInString.Length == 1 ? numberOfZeroString + numberInString : numberInString;
    }

    public static string CompletePrefixWithZeroInt(int nombre)
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

    public static bool HasConsonants(string input)
    {
      // Returns whether a string contains any consonant letters
      if (string.IsNullOrEmpty(input))
      {
        return false;
      }

      return input.Any(t => t == 'b' || t == 'B' ||
      t == 'c' || t == 'C' ||
      t == 'd' || t == 'D' ||
      t == 'f' || t == 'F' ||
      t == 'g' || t == 'G' ||
      t == 'h' || t == 'H' ||
      t == 'j' || t == 'J' ||
      t == 'k' || t == 'K' ||
      t == 'l' || t == 'L' ||
      t == 'm' || t == 'M' ||
      t == 'n' || t == 'N' ||
      t == 'p' || t == 'P' ||
      t == 'q' || t == 'Q' ||
      t == 'r' || t == 'R' ||
      t == 's' || t == 'S' ||
      t == 't' || t == 'T' ||
      t == 'v' || t == 'V' ||
      t == 'w' || t == 'W' ||
      t == 'x' || t == 'X' ||
      t == 'z' || t == 'Z');
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

    /// <summary>
    /// Returns whether a string is composed of only letter characters.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsOnlyLetters(string input)
    {
      return !string.IsNullOrEmpty(input) && input.All(char.IsLetter);
    }

    public static bool HasSomeLetters(string input)
    {
      return !string.IsNullOrEmpty(input) && input.Any(char.IsLetter);
    }

    public static bool HasSomeLowerCaseLetters(string input)
    {
      return !string.IsNullOrEmpty(input) && input.Any(char.IsLower);
    }

    /// <summary>
    /// Returns whether a string has at least one upper case letter.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool HasSomeUpperCaseLetters(string input)
    {
      return !string.IsNullOrEmpty(input) && input.Any(char.IsUpper);
    }

    public static bool HasLettersOrDigits(string input)
    {
      return !string.IsNullOrEmpty(input) && input.Any(char.IsLetterOrDigit);
    }

    public static bool HasSymbols(string input)
    {
      return !string.IsNullOrEmpty(input) && input.Any(char.IsSymbol);
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

      if ((number / 1000000000) > 0)
      {
        words += NumberToEnglishWords(number / 1000000000) + " billion ";
        number %= 1000000000;
      }

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

      return words.Trim();
    }

    public static string NumberToEnglishWords(long number)
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

      if ((number / 1000000000000000000) > 0)
      {
        words += NumberToEnglishWords(number / 1000000000000000000) + " quintillion ";
        number %= 1000000000000000000;
      }

      if ((number / 1000000000000000) > 0)
      {
        words += NumberToEnglishWords(number / 1000000000000000) + " quadrillion ";
        number %= 1000000000000000;
      }

      if ((number / 1000000000000) > 0)
      {
        words += NumberToEnglishWords(number / 1000000000000) + " trillion ";
        number %= 1000000000000;
      }

      if ((number / 1000000000) > 0)
      {
        words += NumberToEnglishWords(number / 1000000000) + " billion ";
        number %= 1000000000;
      }

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

      return words.Trim();
    }

    public static string NumberToEnglishWords(ulong number)
    {
      // The value of ulong.MaxValue constant is 18,446,744,073,709,551,615
      if (number == 0)
      {
        return "zero";
      }

      string words = string.Empty;

      if ((number / 1000000000000000000) > 0)
      {
        words += NumberToEnglishWords(number / 1000000000000000000) + " quintillion ";
        number %= 1000000000000000000;
      }

      if ((number / 1000000000000000) > 0)
      {
        words += NumberToEnglishWords(number / 1000000000000000) + " quadrillion ";
        number %= 1000000000000000;
      }

      if ((number / 1000000000000) > 0)
      {
        words += NumberToEnglishWords(number / 1000000000000) + " trillion ";
        number %= 1000000000000;
      }

      if ((number / 1000000000) > 0)
      {
        words += NumberToEnglishWords(number / 1000000000) + " billion ";
        number %= 1000000000;
      }

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

      return words.Trim();
    }

    public static string NumberToFrenchWords(int number)
    {
      if (number == 0)
      {
        return "zéro";
      }

      if (number < 0)
      {
        return "moins " + NumberToFrenchWords(Math.Abs(number));
      }

      string words = string.Empty;

      if ((number / 1000000000) > 0)
      {
        words += NumberToFrenchWords(number / 1000000000) + " milliard ";
        number %= 1000000000;
      }

      if ((number / 1000000) > 0)
      {
        words += NumberToFrenchWords(number / 1000000) + " million ";
        number %= 1000000;
      }

      if ((number / 1000) > 0)
      {
        words += NumberToFrenchWords(number / 1000) + " mille ";
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

      return words.Trim();
    }

    public static string NumberToFrenchWords(long number)
    {
      if (number == 0)
      {
        return "zéro";
      }

      if (number < 0)
      {
        return "moins " + NumberToFrenchWords(Math.Abs(number));
      }

      string words = string.Empty;

      if ((number / 1000000000000000000) > 0)
      {
        words += NumberToFrenchWords(number / 1000000000000000000) + " trillion ";
        number %= 1000000000000000000;
      }

      if ((number / 1000000000000000) > 0)
      {
        words += NumberToFrenchWords(number / 1000000000000000) + " billiard ";
        number %= 1000000000000000;
      }

      if ((number / 1000000000000) > 0)
      {
        words += NumberToFrenchWords(number / 1000000000000) + " billion ";
        number %= 1000000000000;
      }

      if ((number / 1000000000) > 0)
      {
        words += NumberToFrenchWords(number / 1000000000) + " milliard ";
        number %= 1000000000;
      }

      if ((number / 1000000) > 0)
      {
        words += NumberToFrenchWords(number / 1000000) + " million ";
        number %= 1000000;
      }

      if ((number / 1000) > 0)
      {
        words += NumberToFrenchWords(number / 1000) + " mille ";
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

      return words.Trim();
    }

    public static string NumberToFrenchWords(ulong number)
    {
      if (number == 0)
      {
        return "zéro";
      }

      string words = string.Empty;

      if ((number / 1000000000000000000) > 0)
      {
        words += NumberToFrenchWords(number / 1000000000000000000) + " trillion ";
        number %= 1000000000000000000;
      }

      if ((number / 1000000000000000) > 0)
      {
        words += NumberToFrenchWords(number / 1000000000000000) + " billiard ";
        number %= 1000000000000000;
      }

      if ((number / 1000000000000) > 0)
      {
        words += NumberToFrenchWords(number / 1000000000000) + " billion ";
        number %= 1000000000000;
      }

      if ((number / 1000000000) > 0)
      {
        words += NumberToFrenchWords(number / 1000000000) + " milliard ";
        number %= 1000000000;
      }

      if ((number / 1000000) > 0)
      {
        words += NumberToFrenchWords(number / 1000000) + " million ";
        number %= 1000000;
      }

      if ((number / 1000) > 0)
      {
        words += NumberToFrenchWords(number / 1000) + " mille ";
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

      return words.Trim();
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
        break;
      }

      return found;
    }

    public static string ToTitleCase(string myString)
    {
      return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(myString.ToLower());
    }

    public static string UpperCaseFirstLetter(string value)
    {
      // Uppercase the first letter in the string this extension is called on.
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

    public static string ReplaceCharacters(string originalString, char oldChar = ' ', char newChar = ' ')
    {
      return originalString.Replace(oldChar, newChar);
    }

    public static string GenerateGuid()
    {
      return new Guid().ToString();
    }

    public static string GenerateUniqueFilename(string directoryPath,
      RandomCharacters rdnCharacters = RandomCharacters.LowerCase,
      byte length = 8,
      bool withFileExtension = false,
      string fileExtension = "txt")
    {
      if (directoryPath == string.Empty)
      {
        return string.Empty;
      }

      if (!Directory.Exists(directoryPath))
      {
        return string.Empty;
      }

      string result = string.Empty;
      do
      {
        result = GenerateRandomString(new[] { ' ' }, true, rdnCharacters, length, true);
        if (withFileExtension)
        {
          result += "." + fileExtension;
        }
      } while (File.Exists(Path.Combine(directoryPath, result)));

      return result;
    }

    public static string GenerateRandomString(char[] forbiddenCharacters,
      bool hasForbiddenCharacters = false,
      RandomCharacters rdnCharacters = RandomCharacters.LowerCase, byte length = 8,
      bool isWindowsFileName = false)
    {
      if (length > byte.MaxValue)
      {
        length = byte.MaxValue;
      }

      char[] forbiddenWindowsFilenameCharacters = { '\\', '/', ':', '*', '?', '\"', '<', '>', '|' };
      char[] upperCaseCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
      char[] lowerCaseCharacters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
      char[] digitCharacters = "0123456789".ToCharArray();
      char[] specialCharacters = ",.;:?!/@#$%^&()=+*-_{}[]|~".ToCharArray();
      char[] searchedCharacters = new char[26 + 26 + 10 + 26]; // max size

      // int numberOfCharactersToPickFrom = (int)rdnCharacters;
      if (isWindowsFileName)
      {
        forbiddenCharacters = AddCharArray(forbiddenCharacters, forbiddenWindowsFilenameCharacters, new[] { ' ' });
        char[] badWindowsFileName = { ',', '!', '.', ';', '@', '#', '$', '%', '^', '&', '(', ')', '=', '+', '{', '}', '~' };
        forbiddenCharacters = AddCharArray(forbiddenCharacters, badWindowsFileName, new[] { ' ' });
      }

      switch (rdnCharacters)
      {
        case RandomCharacters.LowerCase:
          searchedCharacters = FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters).ToCharArray();
          break;
        case RandomCharacters.UpperCase:
          searchedCharacters = FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters).ToCharArray();
          break;
        case RandomCharacters.Digit:
          searchedCharacters = FillSearchedCharWithoutForbiddenChar(digitCharacters, forbiddenCharacters).ToCharArray();
          break;
        case RandomCharacters.SpecialCharacter:
          searchedCharacters = FillSearchedCharWithoutForbiddenChar(specialCharacters, forbiddenCharacters).ToCharArray();
          break;
        case RandomCharacters.UpperLower:
          searchedCharacters = (FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters)).ToCharArray();
          break;
        case RandomCharacters.DigitSpecialChar:
          searchedCharacters = (FillSearchedCharWithoutForbiddenChar(digitCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(specialCharacters, forbiddenCharacters)).ToCharArray();
          break;
        case RandomCharacters.LowerDigit:
          searchedCharacters = (FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(digitCharacters, forbiddenCharacters)).ToCharArray();
          break;
        case RandomCharacters.LowerSpecialChar:
          searchedCharacters = (FillSearchedCharWithoutForbiddenChar(specialCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters)).ToCharArray();
          break;
        case RandomCharacters.UpperDigit:
          searchedCharacters = (FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(digitCharacters, forbiddenCharacters)).ToCharArray();
          break;
        case RandomCharacters.UpperLowerDigit:
          searchedCharacters = (FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(digitCharacters, forbiddenCharacters)).ToCharArray();
          break;
        case RandomCharacters.UpperSpecialChar:
          searchedCharacters = (FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(specialCharacters, forbiddenCharacters)).ToCharArray();
          break;
        case RandomCharacters.UpperLowerSpecial:
          searchedCharacters = (FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(specialCharacters, forbiddenCharacters)).ToCharArray();
          break;
        case RandomCharacters.UpperDigitSpecial:
          searchedCharacters = (FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(specialCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(digitCharacters, forbiddenCharacters)).ToCharArray();
          break;
        case RandomCharacters.UpperLowerDigitSpecial:
          searchedCharacters = (FillSearchedCharWithoutForbiddenChar(upperCaseCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(digitCharacters, forbiddenCharacters) +
            FillSearchedCharWithoutForbiddenChar(specialCharacters, forbiddenCharacters)).ToCharArray();
          break;

        default:
          searchedCharacters = FillSearchedCharWithoutForbiddenChar(lowerCaseCharacters, forbiddenCharacters).ToCharArray();
          break;
      }

      // once we have the SearchedCharacters filled out, we can select random characters from it
      string result = string.Empty;
      for (int i = 0; i < length; i++)
      {
        result += searchedCharacters[MathFunc.GenerateRandomNumberUsingCrypto(0, searchedCharacters.Length - 1)];
      }

      return result;
    }

    public static string FillSearchedCharWithoutForbiddenChar(char[] source, char[] forbiddenCharacters)
    {
      string result = string.Empty;
      foreach (char item in source)
      {
        if (forbiddenCharacters != null)
        {
          if (!forbiddenCharacters.Contains(item))
          {
            result += item.ToString();
          }
        }
        else
        {
          result += item.ToString();
        }
      }

      return result;
    }

    public static char[] AddCharArray(char[] source, char[] toBeAdded, char[] forbiddenCharacters)
    {
      List<char> tmpSource = source.ToList();
      List<char> tmpToBeAdded = toBeAdded.ToList();
      List<char> tmpforbiddenChar = forbiddenCharacters.ToList();
      foreach (char item in tmpToBeAdded)
      {
        if (!tmpforbiddenChar.Contains(item))
        {
          tmpSource.Add(item);
        }
      }

      return tmpSource.ToArray();
    }

    public enum RandomCharacters
    {
      LowerCase = 1,
      UpperCase = 2,
      Digit = 3,
      SpecialCharacter = 4,
      UpperLower = 5, //LowerCase & UpperCase,
      LowerDigit = 6, //LowerCase & Digit,
      UpperDigit = 7, //UpperCase & Digit,
      UpperLowerDigit = 8, //UpperLower & Digit,
      LowerSpecialChar = 9, //LowerCase & SpecialCharacter,
      UpperSpecialChar = 10, //UpperCase & SpecialCharacter,
      DigitSpecialChar = 11, //Digit & SpecialCharacter
      UpperLowerSpecial = 12,
      UpperDigitSpecial = 13,
      UpperLowerDigitSpecial = 14 // kept numbering because of a possible future change
    }

    public static string GenerateCharactersFromSource(List<string> source, int numberOfCharacters = 1)
    {
      if (source == null || source.Count == 0)
      {
        return string.Empty;
      }

      string result = string.Empty;
      for (int i = 0; i < numberOfCharacters; i++)
      {
        result += source[MathFunc.GenerateRandomNumberUsingCrypto(0, source.Count - 1)];
      }

      return result;
    }

    public static string ByteArrayToString(byte[] bytes)
    {
      StringBuilder sb = new StringBuilder();
      for (int i = 0; i < bytes.Length; i++)
      {
        sb.Append(bytes[i].ToString("X2"));
      }

      return sb.ToString();
    }

    /// Converts a hex string to a byte array
    /// <param name="hexaString">The hex string to convert</param>
    /// <returns>A byte array representing the hex string</returns>
    public static byte[] HexStringToByteArray(string hexaString)
    {
      if (hexaString.Length % 2 != 0)
      {
        return new byte[] { };
      }

      byte[] returnBytes = new byte[hexaString.Length / 2];
      for (int i = 0; i < returnBytes.Length; i++)
      {
        returnBytes[i] = Convert.ToByte(hexaString.Substring(i * 2, 2), 16);
      }

      return returnBytes;
    }
  }
}