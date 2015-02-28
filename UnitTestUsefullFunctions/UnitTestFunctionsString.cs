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
using StringFunc = FonctionsUtiles.Fred.Csharp.FunctionsString;
using MathFunc = FonctionsUtiles.Fred.Csharp.FunctionsMath;


namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestFunctionsString
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
      Assert.IsFalse(false);
    }

    [TestMethod]
    public void TestMethod_Factorial_one()
    {
      long result = MathFunc.Factorial(1);
      Assert.IsTrue(result == 1);
    }

    [TestMethod]
    public void TestMethod_Factorial_two()
    {
      long result = MathFunc.Factorial(2);
      Assert.IsTrue(result == 2);
    }

    [TestMethod]
    public void TestMethod_Factorial_three()
    {
      long result = MathFunc.Factorial(3);
      Assert.IsTrue(result == 6);
    }

    [TestMethod]
    public void TestMethod_Factorial_four()
    {
      long result = MathFunc.Factorial(4);
      Assert.IsTrue(result == 24);
    }

    [TestMethod]
    public void TestMethod_Factorial_five()
    {
      long result = MathFunc.Factorial(5);
      Assert.IsTrue(result == 120);
    }

    [TestMethod]
    public void TestMethod_Factorial_six()
    {
      long result = MathFunc.Factorial(6);
      Assert.IsTrue(result == 720);
    }

    [TestMethod]
    public void TestMethod_Factorial_seven()
    {
      long result = MathFunc.Factorial(7);
      Assert.IsTrue(result == 5040);
    }

    [TestMethod]
    public void TestMethod_Factorial_eight()
    {
      long result = MathFunc.Factorial(8);
      Assert.IsTrue(result == 40320);
    }

    [TestMethod]
    public void TestMethod_Factorial_nine()
    {
      long result = MathFunc.Factorial(9);
      Assert.IsTrue(result == 362880);
    }

    [TestMethod]
    public void TestMethod_Factorial_ten()
    {
      long result = MathFunc.Factorial(10);
      Assert.IsTrue(result == 3628800);
    }
  }
}