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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StringFunc = FonctionsUtiles.Fred.Csharp.FunctionsString;
using DateFunc = FonctionsUtiles.Fred.Csharp.FunctionsDateTime;

namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestFunctionsUseful
  {
    #region Useful Methods
    #region IsMorning Methods
    //**********************IsMorning Methods***************
    [TestMethod]
    public void TestMethod_IsMorning_true()
    {
      DateTime source = new DateTime(2015, 03, 22, 11, 58, 00);
      const bool expected = true;
      bool result = DateFunc.IsMorning(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsMorning_false()
    {
      DateTime source = new DateTime(2015, 03, 22, 14, 58, 00);
      const bool expected = false;
      bool result = DateFunc.IsMorning(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsMorning_noon_is_false()
    {
      DateTime source = new DateTime(2015, 03, 22, 12, 00, 00);
      const bool expected = false;
      bool result = DateFunc.IsMorning(source);
      Assert.AreEqual(result, expected);
    }
    #endregion IsMorning Methods
    #region OutsideWeekEnd Methods
    //**********************OutsideWeekEnd Methods***************

    [TestMethod]
    public void TestMethod_OutsideWeekEnd_false()
    {
      DateTime source = new DateTime(2015, 03, 22, 11, 58, 00);
      const bool expected = false;
      bool result = DateFunc.OutsideWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_OutsideWeekEnd_true()
    {
      DateTime source = new DateTime(2015, 03, 23, 14, 58, 00);
      const bool expected = true;
      bool result = DateFunc.OutsideWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_OutsideWeekEnd_false_January_first_2000()
    {
      DateTime source = new DateTime(2000, 01, 01, 14, 58, 00);
      const bool expected = false;
      bool result = DateFunc.OutsideWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_OutsideWeekEnd_true_nine_eleven_2001()
    {
      DateTime source = new DateTime(2001, 09, 11, 10, 11, 00);
      const bool expected = true;
      bool result = DateFunc.OutsideWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_OutsideWeekEnd_true_Jesus_birth()
    {
      DateTime source = new DateTime(1, 12, 25, 1, 0, 0);
      const bool expected = true;
      bool result = DateFunc.OutsideWeekEnd(source);
      Assert.AreEqual(result, expected);
    }
    #endregion OutsideWeekEnd Methods
    #region IsWeekEnd Methods
    //**********************IsWeekEnd Methods*********************
    [TestMethod]
    public void TestMethod_IsWeekEnd_true()
    {
      DateTime source = new DateTime(2015, 03, 22, 11, 58, 00);
      const bool expected = true;
      bool result = DateFunc.IsWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsWeekEnd_false()
    {
      DateTime source = new DateTime(2015, 03, 23, 14, 58, 00);
      const bool expected = false;
      bool result = DateFunc.IsWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsWeekEnd_true_January_first_2000()
    {
      DateTime source = new DateTime(2000, 01, 01, 14, 58, 00);
      const bool expected = true;
      bool result = DateFunc.IsWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsWeekEnd_false_nine_eleven_2001()
    {
      DateTime source = new DateTime(2001, 09, 11, 10, 11, 00);
      const bool expected = false;
      bool result = DateFunc.IsWeekEnd(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsWeekEnd_false_Jesus_birth()
    {
      DateTime source = new DateTime(1, 12, 25, 1, 0, 0);
      const bool expected = false;
      bool result = DateFunc.IsWeekEnd(source);
      Assert.AreEqual(result, expected);
    }
    #endregion IsWeekEnd Methods
    #region DateToByteArray Methods
    //**********************DateToByteArray Methods***************
    [TestMethod]
    public void TestMethod_DateToByteArray_true()
    {
      byte[] source = { 0x20, 0x15, 0x03, 0x27, 0x13, 0x30, 0x00, 0x00, 0x00 };
      DateTime expected = new DateTime(01, 01, 01, 00, 00, 00, DateTimeKind.Local);
      DateTime result = DateFunc.ByteArrayToDate(source);
      Assert.IsTrue(result == expected);
    }

    [TestMethod]
    public void TestMethod_DateToByteArray_false()
    {
      byte[] source = { 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01 };
      DateTime expected = new DateTime(1601, 03, 03, 05, 18, 01);
      DateTime result = DateFunc.ByteArrayToDate(source);
      Assert.AreNotEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DateToByteArray_false_length_not_equal_to_eight()
    {
      byte[] source = { 0x01, 0x01, 0x01, 0x01 };
      DateTime expected = new DateTime();
      DateTime result = DateFunc.ByteArrayToDate(source);
      Assert.AreEqual(result, expected);
    }
    #endregion DateToByteArray Methods
    #region ByteArrayToString Methods
    //**********************ByteArrayToString Methods***************
    [TestMethod]
    public void TestMethod_ByteArrayToHexString_true()
    {
      byte[] source = { 0x01, 0x02, 0x03, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17 };
      const string expected = "010203091011121314151617";
      string result = StringFunc.ByteArrayToString(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ByteArrayToString_true_one()
    {
      byte[] source = { 0x01 };
      const string expected = "01";
      string result = StringFunc.ByteArrayToString(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ByteArrayToHexString_false()
    {
      byte[] source = { 0x01, 0x02, 0x03, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17 };
      const string expected = "01";
      string result = StringFunc.ByteArrayToString(source);
      Assert.AreNotEqual(result, expected);
    }

    #endregion ByteArrayToString Methods
    #region HexStringToByteArray Methods
    [TestMethod]
    public void TestMethod_HexStringToByteArray_true()
    {
      string source = "010203091011121314151617";
      byte[] expected = { 0x01, 0x02, 0x03, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17 };
      byte[] result = StringFunc.HexStringToByteArray(source);
      for (int i = 0; i < expected.Length; i++)
      {
        Assert.IsTrue(result[i] == expected[i]);
      }
    }

    [TestMethod]
    public void TestMethod_HexStringToByteArray_true_two_values()
    {
      string source = "0102";
      byte[] expected = { 0x01, 0x02 };
      byte[] result = StringFunc.HexStringToByteArray(source);
      Assert.IsTrue(result[0] == expected[0]);
      Assert.IsTrue(result[1] == expected[1]);
    }

    [TestMethod]
    public void TestMethod_HexStringToByteArray_false()
    {
      string source = "010203091011121314151617";
      byte[] expected = { 0x01 };
      byte[] result = StringFunc.HexStringToByteArray(source);
      Assert.AreNotEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HexStringToByteArray_false_not_even_length()
    {
      string source = "01020";
      byte[] expected = { 0x01, 0x02 };
      byte[] result = StringFunc.HexStringToByteArray(source);
      Assert.AreNotEqual(result, expected);
    }

    #endregion HexStringToByteArray Methods
    #endregion Useful Methods
  }
}