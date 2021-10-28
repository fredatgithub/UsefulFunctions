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
  }
}
