using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppFunc = FonctionsUtiles.Fred.Csharp.FunctionsApplicationFeatures;
namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestFunctionsApplicationFeatures
  {
    #region GetStartupPath
    [TestMethod]
    public void TestMethod_GetStartupPath()
    {
      string expected = "";
      string result = AppFunc.GetStartupPath();
      Assert.AreEqual(expected, result);
    }
    #endregion GetStartupPath
  }
}
