using System;
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

    public static IEnumerable<T> InsertionSort<T>(IEnumerable<T> list) where T : IComparable
    {
      T[] sortedList = list.ToArray();
      int listLength = sortedList.Length;
      for (int i = 1; i < listLength; i++)
      {
        for (int previousItemIndex = i - 1; previousItemIndex > -1; previousItemIndex--)
        {
          int currentItemIndex = previousItemIndex + 1;
          T currentItem = sortedList[currentItemIndex];
          T previousItem = sortedList[previousItemIndex];
          var comparison = previousItem.CompareTo(currentItem);
          if (comparison > 0)
          {
            sortedList[previousItemIndex] = currentItem;
            sortedList[currentItemIndex] = previousItem;
          }
          else
          {
            break;
          }
        }
      }

      return sortedList;
    }

    public static int LinearSearchSequence<T>(IEnumerable<T> list, IEnumerable<T> needle) where T : IComparable
    {
      var needleArray = needle.ToArray();
      var needleLength = needleArray.Length;
      var listLength = list.Count();
      for (int i = 0; i <= listLength - needleLength; i++)
      {
        for (int matchIndex = 0; matchIndex < needleLength; matchIndex++)
        {
          var item = list.ElementAt(i + matchIndex);
          var needleItem = needleArray[matchIndex];
          if (item.CompareTo(needleItem) != 0)
          {
            break;
          }

          if (matchIndex == needleLength - 1)
          {
            return i;
          }
        }
      }

      return -1;
    }
  }
}