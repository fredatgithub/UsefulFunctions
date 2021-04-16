using System.Collections.Generic;
using System.Linq;

namespace FonctionsUtiles.Fred.Csharp
{
  public static class FunctionsSort
  {
    public static List<int> BubbleSort(List<int> myList)
    {
      List<int> result = myList;
      while (true)
      {
        bool swapped = false;
        for (int i = 0; i < myList.Count - 1; ++i)
        {
          if (myList[i] > myList[i + 1])
          {
            int tmp = myList[i];
            myList[i] = myList[i + 1];
            myList[i + 1] = tmp;
            swapped = true;
          }
        }

        if (!swapped) { break; }
      }

      return result;
    }

    public static IEnumerable<int> Intersection(int[] array1, int[] array2)
    {
      return array1.Intersect(array2);
    }
  }
}