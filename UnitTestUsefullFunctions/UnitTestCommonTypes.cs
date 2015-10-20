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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FonctionsUtiles.Fred.Csharp;
namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestCommonTypes
  {
    [TestMethod]
    public void TestMethodType_of_boolean()
    {
      const bool source = true;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfBoolean;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_string()
    {
      const string source = "something";
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfString;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_short()
    {
      const short source = short.MaxValue;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfShort;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_ushort()
    {
      const ushort source = ushort.MaxValue;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfUshort;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_int()
    {
      const int source = int.MaxValue;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfInt;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_uint()
    {
      const uint source = uint.MaxValue;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfUint;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_long()
    {
      const long source = long.MaxValue;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfLong;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_ulong()
    {
      const ulong source = ulong.MaxValue;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfUlong;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_decimal()
    {
      const decimal source = decimal.MaxValue;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfDecimal;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_float()
    {
      const float source = float.MaxValue;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfFloat;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_byte()
    {
      const byte source = byte.MaxValue;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfByte;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_char()
    {
      const byte source = byte.MaxValue;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfByte;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_double()
    {
      const double source = double.MaxValue;
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfdouble;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_object()
    {
      object source = new object();
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfObject;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodType_of_date_time()
    {
      DateTime source = new DateTime(2015, 10, 20);
      Type expected = source.GetType();
      Type result = CommonTypes.TypeOfDateTime;
      Assert.AreEqual(result, expected);
    }
  }
}