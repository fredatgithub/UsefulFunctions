using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FonctionsUtiles.Fred.Csharp
{
  public static class FunctionsExcel
  {
    /// <summary>
    /// Donne toutes les cellules de A jusqu'à la dernière colonne.
    /// </summary>
    /// <param name="lastColumnUsed">un entier donnant le numéro de la dernière colonne.</param>
    /// <returns>Une liste de string donnant tous les noms des colonnes de A jusqu'à la dernière colonne.</returns>
    public static List<string> AllColumnsNameUntil(int lastColumnUsed)
    {
      List<string> result = new List<string>();
      for (int i = 1; i <= lastColumnUsed; i++)
      {
        result.Add(NumeroColonneVersLettreColonne(i));
      }

      return result;
    }

    public static List<string> AlphabetLetters()
    {
      List<string> result = new List<string>();
      for (char letter = 'A'; letter <= 'Z'; letter++)
      {
        result.Add(letter.ToString());
      }

      return result;
    }

    /// <summary>
    /// Gets the column letter(s) corresponding to the given column number.
    /// </summary>
    /// <param name="numeroColonne">The one-based column index. Must be greater than zero.</param>
    /// <returns>The desired column letter, or an empty string if the column number was invalid.</returns>
    public static string NumeroColonneVersLettreColonne(int numeroColonne)
    {
      if (numeroColonne < 1)
      {
        return string.Empty;
      }

      return NumeroColonneVersLettreColonne((numeroColonne - 1) / 26) + (char)('A' + (numeroColonne - 1) % 26);
    }

    //http://stackoverflow.com/questions/181596/how-to-convert-a-column-number-eg-127-into-an-excel-column-eg-aa
    /// <summary>
    /// Convert Column Number into Column Name - Character(s) eg 1-A, 2-B
    /// </summary>
    /// <param name="columnNumber">Column Number</param>
    /// <returns>Column Name - Character(s)</returns>
    public static string GetExcelColumnName(int columnNumber)
    {
      int dividend = columnNumber;
      string columnName = string.Empty;
      int modulo;

      while (dividend > 0)
      {
        modulo = (dividend - 1) % 26;
        columnName = string.Concat(Convert.ToChar(65 + modulo), columnName);
        dividend = (int)((dividend - modulo) / 26);
      }

      return columnName;
    }

    //http://stackoverflow.com/questions/181596/how-to-convert-a-column-number-eg-127-into-an-excel-column-eg-aa
    /// <summary>
    /// Covert Column Name - Character(s) into a Column Number eg A-1, B-2, A1 - 1, B9 - 2
    /// </summary>
    /// <param name="columnName">Column Name - Character(s) optinally with the Row Number</param>
    /// <param name="includesRowNumber">Specify if the row number is included</param>
    /// <returns>Column Number</returns>
    public static int GetExcelColumnNumber(string columnName, bool includesRowNumber = true)
    {
      if (includesRowNumber)
      {
        columnName = Regex.Replace(columnName, @"\d", "");
      }

      int[] digits = new int[columnName.Length];
      for (int i = 0; i < columnName.Length; ++i)
      {
        digits[i] = Convert.ToInt32(columnName[i]) - 64;
      }
      int mul = 1; int res = 0;
      for (int pos = digits.Length - 1; pos >= 0; --pos)
      {
        res += digits[pos] * mul;
        mul *= 26;
      }

      return res;
    }
  }
}
