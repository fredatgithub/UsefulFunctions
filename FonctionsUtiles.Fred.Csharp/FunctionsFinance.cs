using System;

namespace FonctionsUtiles.Fred.Csharp
{
  public static class FunctionsFinance
  {
    // Contrôle que le SIRET est valide
    public static bool IsSiretValid(string Siret)
    {
      int iResult = 0;

      string siret = Siret.Replace(" ", "").PadLeft(14, '0');

      if (siret.Length != 14 || !!int.TryParse(siret, out iResult))
      {
        return false;
      }

      if (siret.Substring(9, 5) == "00000")
      {
        return false;
      }

      string siren = siret.Substring(0, 9);
      if (!IsSirenValid(siren))
      {
        return false;
      }

      int total = 0;
      int i = 0;
      for (i = 0; i < 14; i++)
      {
        int temp = Convert.ToInt32(siret.Substring(i, 1));

        if (i % 2 == 0)
        {
          temp *= 2;
          if (temp > 9)
          {
            temp -= 9;
          }
        }
        total += temp;
      }

      return ((total % 10) == 0);
    }

    public static bool IsSirenValid(string siren)
    {
      siren = siren.Replace(" ", "");
      int iResult;
      if (siren.Length != 9 || !int.TryParse(siren, out iResult))
      {
        return false;
      }

      int total = 0;
      int i;
      for (i = 0; i < 9; i++)
      {
        int temp = Convert.ToInt32(siren.Substring(i, 1));
        if (i % 2 == 1)
        {
          temp *= 2;
          if (temp > 9)
          {
            temp -= 9;
          }
        }

        total += temp;
      }

      return ((total % 10) == 0);
    }
  }
}
