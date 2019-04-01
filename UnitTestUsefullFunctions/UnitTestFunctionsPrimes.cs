using FonctionsUtiles.Fred.Csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestFunctionsPrimes
  {
    [TestMethod]
    public void TestMethod_GetPrimesBefore_18()
    {
      //const int source = 18;
      //List<int> expected = new List<int> { 2, 3, 5, 7, 11, 13, 17 };
      //List<int> result = FunctionsPrimes.GetPrimesBefore(source);
      //Assert.IsTrue(AssertListAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_NumberOfPrimeUnder_2()
    {
      const int source = 2;
      int expected = 1;
      int result = FunctionsPrimes.NumberOfPrimeUnder(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfPrimeUnder_3()
    {
      const int source = 3;
      int expected = 2;
      int result = FunctionsPrimes.NumberOfPrimeUnder(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfPrimeUnder_5()
    {
      const int source = 5;
      int expected = 3;
      int result = FunctionsPrimes.NumberOfPrimeUnder(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfPrimeUnder_7()
    {
      const int source = 7;
      int expected = 4;
      int result = FunctionsPrimes.NumberOfPrimeUnder(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfPrimeUnder_11()
    {
      const int source = 11;
      int expected = 5;
      int result = FunctionsPrimes.NumberOfPrimeUnder(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfPrimesByHundred_100()
    {
      const int source = 100;
      Dictionary<int, int> expected = new Dictionary<int, int> { { 100, 25 } };
      Dictionary<int, int> result = FunctionsPrimes.NumberOfPrimesByHundred(source);
      Assert.IsTrue(AssertDictionaryAreEqualed(result, expected));
    }

    public static bool AssertDictionaryAreEqualed(Dictionary<int, int> source, Dictionary<int, int> target)
    {
      bool result = true;
      if (source.Count != target.Count)
      {
        return false;
      }

      foreach (KeyValuePair<int, int> keyValuePair in source)
      {
        if (keyValuePair.Value == target[keyValuePair.Key])
        {
          result = false;
          break;
        }
      }
      
      return result;
    }

    public static bool AssertListAreEqualed(List<int> source, List<int> target)
    {
      bool result = true;
      if (source.Count != target.Count)
      {
        return false;
      }

      for (int i = 0; i < source.Count; i++)
      {
        if (source[i] != target[i])
        {
          result = false;
          break;
        }
      }

      return result;
    }
  }
}
