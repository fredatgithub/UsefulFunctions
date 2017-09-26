using System.Collections.Generic;

namespace FonctionsUtiles.Fred.Csharp
{
  public class FunctionsSort
  {
    public static List<int> bubble_sort(List<int> v)
    {
      List<int> result = v;
      while (true)
      {
        bool swapped = false;
        for (int i = 0; i < v.Count - 1; ++i)
        {
          if (v[i] > v[i + 1])
          {
            int tmp = v[i];
            v[i] = v[i + 1];
            v[i + 1] = tmp;
            swapped = true;
          }
        }
        if (!swapped){break;}
      }

      return result;
    }
  }
}