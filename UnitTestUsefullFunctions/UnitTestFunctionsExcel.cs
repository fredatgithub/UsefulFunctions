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

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_40()
    {
      const int source = 40;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_41()
    {
      const int source = 41;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_42()
    {
      const int source = 42;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_43()
    {
      const int source = 43;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_44()
    {
      const int source = 44;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_45()
    {
      const int source = 45;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_46()
    {
      const int source = 46;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_47()
    {
      const int source = 47;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_48()
    {
      const int source = 48;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_49()
    {
      const int source = 49;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_50()
    {
      const int source = 50;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_51()
    {
      const int source = 51;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_52()
    {
      const int source = 52;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_53()
    {
      const int source = 53;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_54()
    {
      const int source = 54;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_55()
    {
      const int source = 55;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_56()
    {
      const int source = 56;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_57()
    {
      const int source = 57;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_58()
    {
      const int source = 58;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_59()
    {
      const int source = 59;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_60()
    {
      const int source = 60;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_61()
    {
      const int source = 61;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_62()
    {
      const int source = 62;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_63()
    {
      const int source = 63;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_64()
    {
      const int source = 64;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_65()
    {
      const int source = 65;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_66()
    {
      const int source = 66;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_67()
    {
      const int source = 67;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_68()
    {
      const int source = 68;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_69()
    {
      const int source = 69;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    [TestCategory("Excel")]
    public void TestMethod_AllColumnsUntil_70()
    {
      const int source = 70;
      List<string> expected = new List<string>
      {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ"
      };

      List<string> result = FunctionsExcel.AllColumnsNameUntil(source);
      CollectionAssert.AreEquivalent(result, expected);
    }
  }
}
