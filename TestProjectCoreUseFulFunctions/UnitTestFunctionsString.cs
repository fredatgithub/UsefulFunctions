using FonctionsUtiles.Fred.Csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestProjectCoreUseFulFunctions
{
  [TestClass]
  public class UnitTestFunctionsString
  {
    [DataTestMethod]
    [TestCategory("String")]
    
    public void TestMethod_SplitString_One_Word()
    {
      string source = "azerty";
      const int source2 = 3;
      List<string> expected = new List<string>() { "az", "rt", "" };
      List<string> result = (List<string>)FunctionsString.SplitString(source, source2);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetUniqueFileName()
    {
      string source = "filename.xlsx";
      int source2 = 1;
      string expected = "filename1.xlsx";
      string result = FunctionsString.GetUniquefileName(source, source2);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_InjectNumber_1()
    {
      string source = "filename.xlsx";
      int source2 = 1;
      string expected = "filename1.xlsx";
      string result = FunctionsString.InjectNumberIntoFileName(source, source2);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_InjectNumber_10()
    {
      string source = "filename.xlsx";
      int source2 = 10;
      string expected = "filename10.xlsx";
      string result = FunctionsString.InjectNumberIntoFileName(source, source2);
      Assert.AreEqual(expected, result);
    }
  }
}
