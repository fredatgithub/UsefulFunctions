using System.Collections.Generic;

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
  }
}
