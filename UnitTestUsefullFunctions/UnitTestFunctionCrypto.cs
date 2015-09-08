/*
The MIT License(MIT)
Copyright(c) 2015 Freddy Juhel
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringFunc = FonctionsUtiles.Fred.Csharp.FunctionsString;
using CryptoFunc = FonctionsUtiles.Fred.Csharp.FunctionsCrypto;
using dllFuncs = FonctionsUtiles.Fred.Csharp;

namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestFunctionCrypto
  {
    #region Crypto
    [TestMethod]
    public void TestMethod_RsaEncryption_source_and_encryption_are_different()
    {
      const string source = "A long long time ago in a galawy far far away";
      string result = CryptoFunc.RsaEncryption(source);
      Assert.AreNotEqual(result, source);
    }

    [TestMethod]
    public void TestMethod_RsaEncryption_encryption_not_null()
    {
      const string source = "A long long time ago in a galawy far far away";
      string result = CryptoFunc.RsaEncryption(source);
      Assert.IsNotNull(result);
    }

    [TestMethod]
    public void TestMethod_RsaEncryption_encryption_not_empty()
    {
      const string source = "A long long time ago in a galawy far far away";
      string result = CryptoFunc.RsaEncryption(source);
      Assert.IsTrue(result.Length != 0);
      Assert.AreNotEqual(result.Length, 0);
    }
    #endregion Crypto
  }
}