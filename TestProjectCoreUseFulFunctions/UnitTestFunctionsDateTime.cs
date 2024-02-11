using FonctionsUtiles.Fred.Csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectCoreUseFulFunctions
{
  [TestClass]
  public class UnitTestFunctionsDateTime
  {
    [DataTestMethod]
    [TestCategory("Bissextile tests")]
    [DataRow(2024, true)]
    public void TestMethod_Est_bissextile_2024(int year, bool expected)
    {
      bool result = FunctionsDateTime.EstBissextile(year);
      Assert.AreEqual(result, expected);
    }
  }
}
