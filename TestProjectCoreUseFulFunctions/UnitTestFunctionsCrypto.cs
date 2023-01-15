using FonctionsUtiles.Fred.Csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace TestProjectCoreUseFulFunctions
{
  [TestClass]
  public class UnitTestFunctionsCrypto
  {
    [DataTestMethod]
    [TestCategory("Crypto")]
    public void TestMethod_Sha512_One_Word()
    {
      string source = "azerty";
      string expected = "df6b9fb15cfdbb7527be5a8a6e39f39e572c8ddb943fbc79a943438e9d3d85ebfc2ccf9e0eccd9346026c0b6876e0e01556fe56f135582c05fbdbb505d46755a";
      string result = FunctionsCrypto.Sha512(source);
      Assert.AreEqual(result, expected);
    }

    [DataTestMethod]
    [TestCategory("Crypto")]
    public void TestMethod_Sha512_One_Letter_a()
    {
      string source = "a";
      string expected = "1f40fc92da241694750979ee6cf582f2d5d7d28e18335de05abc54d0560e0f5302860c652bf08d560252aa5e74210546f369fbbbce8c12cfc7957b2652fe9a75";
      string result = FunctionsCrypto.Sha512(source);
      Assert.AreEqual(result, expected);
    }

    [DataTestMethod]
    [TestCategory("Crypto")]
    public void TestMethod_Sha256_One_Letter_a()
    {
      string source = "a";
      string expected = "ca978112ca1bbdcafac231b39a23dc4da786eff8147c4e72b9807785afee48bb";
      string result = FunctionsCrypto.Sha256(source);
      Assert.AreEqual(result, expected);
    }

    [DataTestMethod]
    [TestCategory("Crypto")]
    public void TestMethod_ComputeHashSha1()
    {
      string source0 = "azerty";
      byte[] source = Encoding.ASCII.GetBytes(source0);
      byte[] expected = new byte[] { 156, 249, 93, 172, 210, 38, 220, 244, 61, 163, 118, 205, 182, 203, 186, 112, 53, 33, 137, 33 };
      byte[] result = FunctionsCrypto.ComputeHashSha1(source);
      CollectionAssert.AreEqual(expected, result);
    }
  }
}
