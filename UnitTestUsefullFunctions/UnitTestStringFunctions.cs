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
using StringFunc = FonctionsUtiles.Fred.Csharp.FonctionsString;

namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestStringFunctions
  {
    [TestMethod]
    public void TestMethod_HasDuplicate_no_on_One_item()
    {
      int[] source = new[] { 1 };
      bool result = StringFunc.HasDuplicate(source);
      Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_yes_on_Two_items()
    {
      int[] source = new[] { 1, 1 };
      bool result = StringFunc.HasDuplicate(source);
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_no_on_Two_items()
    {
      int[] source = new[] { 1, 2 };
      bool result = StringFunc.HasDuplicate(source);
      Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_none()
    {
      int[] source = new[] { 1, 2, 3, 4 };
      bool result = StringFunc.HasDuplicate(source);
      Assert.IsFalse(result);
    }
    
    [TestMethod]
    public void TestMethod_HasDuplicate_yes_on_Empty_list_because_all_items_equal_zero()
    {
      int[] source = new int[5] ;
      bool result = StringFunc.HasDuplicate(source);
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_null_list()
    {
      int[] source = null;
      bool result = StringFunc.HasDuplicate(source);
      Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod_HasDuplicate_no_on_several_items()
    {
      bool result = StringFunc.HasDuplicate(1, 2, 3, 4, 5, 6, 7, 8, 9);
      Assert.IsFalse(result);
    }


    [TestMethod]
    public void TestMethod_HasDuplicate_yes_on_several_items()
    {
      bool result = StringFunc.HasDuplicate(1, 2, 3, 4, 5, 6, 7, 8, 9, 1);
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void MyTestMethod()
    {

    }
  }
}