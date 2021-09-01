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

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_29()
    {
      const int source = 29;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_30()
    {
      const int source = 30;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_31()
    {
      const int source = 31;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_32()
    {
      const int source = 32;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_33()
    {
      const int source = 33;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_34()
    {
      const int source = 34;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_35()
    {
      const int source = 35;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_36()
    {
      const int source = 36;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_37()
    {
      const int source = 37;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_38()
    {
      const int source = 38;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_39()
    {
      const int source = 39;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }
  }
}
