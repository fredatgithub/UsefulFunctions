using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortFunc = FonctionsUtiles.Fred.Csharp.FunctionsSort;

namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestFunctionsSort
  {
    [TestMethod]
    public void TestMethod_sort_list_1()
    {
      List<int> source = new List<int> {9, 8, 7 };
      List<int> expected = new List<int> { 7, 8, 9 };
      List<int> result = SortFunc.bubble_sort(source);
      foreach (int number in result)
      {
        Assert.AreEqual(result[number], expected[number]);
      }
    }
  }
}