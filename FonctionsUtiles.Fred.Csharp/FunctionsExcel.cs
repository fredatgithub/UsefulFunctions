using System.Collections.Generic;

namespace FonctionsUtiles.Fred.Csharp
{
  public static class FunctionsExcel
  {
    public static List<string> AllColumnsNameUntil(int lastColumnUsed)
    {
      List<string> result = new List<string>();
      if (lastColumnUsed < 1)
      {
        return result;
      }

      if (lastColumnUsed <= 26)
      {
        for (int i = 65; i <= 65 + 26; i++)
        {
          result.Add(((char)i).ToString());
          if (i - 64 == lastColumnUsed)
          {
            break;
          }
        }

        return result;
      }

      if (lastColumnUsed >= 27 && lastColumnUsed <= 52)
      {
        result = new List<string>(AllColumnsNameUntil(26));
        for (char letter = 'A'; letter <= lastColumnUsed - 26; letter++)
        {
          result.Add($"A{letter}");
        }

        return result;
      }

      if (lastColumnUsed >= 53 && lastColumnUsed <= 79)
      {
        result = new List<string>(AllColumnsNameUntil(52));
        for (char letter = 'A'; letter < lastColumnUsed - 52; letter++)
        {
          result.Add($"B{letter}");
        }

        return result;
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
  }
}
