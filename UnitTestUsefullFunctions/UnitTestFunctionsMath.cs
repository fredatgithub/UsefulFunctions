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
using MathFunc = FonctionsUtiles.Fred.Csharp.FunctionsMath;

namespace UnitTestUsefullFunctions
{
  public class UnitTestFunctionsMath
  {
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
  }
}