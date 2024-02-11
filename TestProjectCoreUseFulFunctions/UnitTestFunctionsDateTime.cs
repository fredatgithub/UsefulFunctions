using FonctionsUtiles.Fred.Csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectCoreUseFulFunctions
{
  [TestClass]
  public class UnitTestFunctionsDateTime
  {
    [DataTestMethod]
    [TestCategory("Bissextile leap year tests")]
    [DataRow(1900, false)]
    [DataRow(2000, true)]
    [DataRow(2020, true)]
    [DataRow(2024, true)]
    [DataRow(2028, true)]
    [DataRow(2100, false)]
    [DataRow(2200, false)]
    [DataRow(2300, false)]
    [DataRow(2400, true)]
    public void TestMethod_Est_bissextile_2024(int year, bool expected)
    {
      bool result = FunctionsDateTime.EstBissextile(year);
      Assert.AreEqual(result, expected);
    }
  }
}
