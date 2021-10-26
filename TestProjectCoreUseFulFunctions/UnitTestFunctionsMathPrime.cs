using FonctionsUtiles.Fred.Csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectCoreUseFulFunctions
{
  [TestClass]
  public class UnitTestFunctionsMathPrime
  {
    [DataTestMethod]
    [TestCategory("Prime test")]
    [DataRow(2837)]
    [DataRow(2843)]
    [DataRow(2851)]
    [DataRow(2857)]
    [DataRow(2861)]
    [DataRow(2879)]
    [DataRow(2887)]
    [DataRow(2897)]
    [DataRow(2903)]
    [DataRow(2909)]
    [DataRow(2917)]
    [DataRow(2927)]
    [DataRow(2939)]
    [DataRow(2953)]
    [DataRow(2957)]
    [DataRow(2963)]
    [DataRow(2969)]
    [DataRow(2971)]
    [DataRow(2999)]
    public void TestMethod_IsPrime_All(int source)
    {
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }


    /*  Add unit test
     *  
      
      */
  }
}
