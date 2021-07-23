using FonctionsUtiles.Fred.Csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestUsefullFunctions
{
  /// <summary>
  /// Description résumée pour UnitTestFunctionsExcel
  /// </summary>
  [TestClass]
  public class UnitTestFunctionsExcel
  {
    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_0()
    {
      const int source = 0;
      List<string> expected = new List<string>();
      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEqual(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_1()
    {
      const int source = 1;
      List<string> expected = new List<string>
      {
        "A"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_2()
    {
      const int source = 2;
      List<string> expected = new List<string>
      {
        "A", "B"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_26()
    {
      const int source = 26;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_27()
    {
      const int source = 27;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_28()
    {
      const int source = 28;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }
  }
}
