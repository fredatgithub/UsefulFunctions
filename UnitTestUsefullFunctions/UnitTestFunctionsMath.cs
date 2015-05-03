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
using FonctionsUtiles.Fred.Csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestFunctionsMath
  {
    #region Math Methods
    #region Math Methods - Factorial
    [TestMethod]
    public void TestMethod_Factorial_one()
    {
      TestFactorial(1, 1);
    }

    public void TestFactorial(long numberToBeTested, long resultExpected)
    {
      long testedNumber = numberToBeTested;
      long expected = resultExpected;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_two()
    {
      TestFactorial(2, 2);
    }

    [TestMethod]
    public void TestMethod_Factorial_three()
    {
      TestFactorial(3, 6);
    }

    [TestMethod]
    public void TestMethod_Factorial_four()
    {
      TestFactorial(4, 24);
    }

    [TestMethod]
    public void TestMethod_Factorial_five()
    {
      const long testedNumber = 5;
      const long expected = 120;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_six()
    {
      const long testedNumber = 6;
      const long expected = 720;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_seven()
    {
      const long testedNumber = 7;
      const long expected = 5040;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_eight()
    {
      const long testedNumber = 8;
      const long expected = 40320;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_nine()
    {
      const long testedNumber = 9;
      const long expected = 362880;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_ten()
    {
      const long testedNumber = 10;
      const long expected = 3628800;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_eleven()
    {
      const long testedNumber = 11;
      const long expected = 39916800;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_twelve()
    {
      const long testedNumber = 12;
      const long expected = 479001600;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_thirteen()
    {
      const long testedNumber = 13;
      const long expected = 6227020800;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_fourteen()
    {
      const long testedNumber = 14;
      const long expected = 87178291200;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_fifteen()
    {
      const long testedNumber = 15;
      const long expected = 1307674368000;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_sixteen()
    {
      const long testedNumber = 16;
      const long expected = 20922789888000;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_seventeen()
    {
      const long testedNumber = 17;
      const long expected = 355687428096000;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_eighteen()
    {
      const long testedNumber = 18;
      const long expected = 6402373705728000;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_nineteen()
    {
      const long testedNumber = 19;
      const long expected = 121645100408832000;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_twenty()
    {
      const long testedNumber = 20;
      const long expected = 2432902008176640000;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_twentyOne()
    {
      long result = FunctionsMath.Factorial(21);
      Assert.IsTrue(result < 0); // negative number
    }

    [TestMethod]
    public void TestMethod_Factorial_Negative_number()
    {
      const long testedNumber = -3;
      const long expected = 0;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_zero()
    {
      const long testedNumber = 0;
      const long expected = 0;
      long result = FunctionsMath.Factorial(testedNumber);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_lowerBound_one_step()
    {
      const long testedNumber1 = 10;
      const long testedNumber2 = 9;
      const long expected = 10;
      long result = FunctionsMath.Factorial(testedNumber1, testedNumber2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_lowerBound_two_step()
    {
      const long testedNumber1 = 10;
      const long testedNumber2 = 8;
      const long expected = 90;
      long result = FunctionsMath.Factorial(testedNumber1, testedNumber2);
      Assert.AreEqual(result, expected);
    }

    #region Math Methods - BigInt Factorial
    // *******************************BigInt Method******
    [TestMethod]
    public void TestMethod_Factorial_BigInt_one()
    {
      BigInt source = 1;
      BigInt expected = 1;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_two()
    {
      BigInt source = 2;
      BigInt expected = 2;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_three()
    {
      BigInt source = 3;
      BigInt expected = 6;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_four()
    {
      BigInt source = 4;
      BigInt expected = 24;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_five()
    {
      BigInt source = 5;
      BigInt expected = 120;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_six()
    {
      BigInt source = 6;
      BigInt expected = 720;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_seven()
    {
      BigInt source = 7;
      BigInt expected = 5040;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_eight()
    {
      BigInt source = 8;
      BigInt expected = 40320;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_nine()
    {
      BigInt source = 9;
      BigInt expected = 362880;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_ten()
    {
      BigInt source = 10;
      BigInt expected = 3628800;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_eleven()
    {
      BigInt source = 11;
      BigInt expected = 39916800;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_twelve()
    {
      BigInt source = 12;
      BigInt expected = 479001600;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_thirteen()
    {
      BigInt source = 13;
      BigInt expected = 6227020800;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_fourteen()
    {
      BigInt source = 14;
      BigInt expected = 87178291200;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_fifteen()
    {
      BigInt source = 15;
      BigInt expected = 1307674368000;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_sixteen()
    {
      BigInt source = 16;
      BigInt expected = 20922789888000;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_seventeen()
    {
      BigInt source = 17;
      BigInt expected = 355687428096000;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_eighteen()
    {
      BigInt source = 18;
      BigInt expected = 6402373705728000;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_nineteen()
    {
      BigInt source = 19;
      BigInt expected = 121645100408832000;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Factorial_BigInt_twenty()
    {
      BigInt source = 20;
      BigInt expected = 2432902008176640000;
      BigInt result = FunctionsMath.Factorial(source);
      Assert.AreEqual(result, expected);
    }



    #endregion Math Methods - BigInt Factorial
    #endregion Math Methods - Factorial
    #region Math Methods - Recursive Factorial
    // **********************Recursive Factorial****************
    [TestMethod]
    public void TestMethod_RecursiveFactorial_one()
    {
      ulong result = FunctionsMath.RecursiveFactorial(1);
      Assert.IsTrue(result == 1);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_two()
    {
      ulong result = FunctionsMath.RecursiveFactorial(2);
      Assert.IsTrue(result == 2);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_three()
    {
      ulong result = FunctionsMath.RecursiveFactorial(3);
      Assert.IsTrue(result == 6);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_four()
    {
      ulong result = FunctionsMath.RecursiveFactorial(4);
      Assert.IsTrue(result == 24);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_five()
    {
      ulong result = FunctionsMath.RecursiveFactorial(5);
      Assert.IsTrue(result == 120);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_six()
    {
      ulong result = FunctionsMath.RecursiveFactorial(6);
      Assert.IsTrue(result == 720);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_seven()
    {
      ulong result = FunctionsMath.RecursiveFactorial(7);
      Assert.IsTrue(result == 5040);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_eight()
    {
      ulong result = FunctionsMath.RecursiveFactorial(8);
      Assert.IsTrue(result == 40320);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_nine()
    {
      ulong result = FunctionsMath.RecursiveFactorial(9);
      Assert.IsTrue(result == 362880);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_ten()
    {
      ulong result = FunctionsMath.RecursiveFactorial(10);
      Assert.IsTrue(result == 3628800);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_eleven()
    {
      ulong result = FunctionsMath.RecursiveFactorial(11);
      Assert.IsTrue(result == 39916800);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_twelve()
    {
      ulong result = FunctionsMath.RecursiveFactorial(12);
      Assert.IsTrue(result == 479001600);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_thirteen()
    {
      ulong result = FunctionsMath.RecursiveFactorial(13);
      Assert.IsTrue(result == 6227020800);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_fourteen()
    {
      ulong result = FunctionsMath.RecursiveFactorial(14);
      Assert.IsTrue(result == 87178291200);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_fifteen()
    {
      ulong result = FunctionsMath.RecursiveFactorial(15);
      Assert.IsTrue(result == 1307674368000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_sixteen()
    {
      ulong result = FunctionsMath.RecursiveFactorial(16);
      Assert.IsTrue(result == 20922789888000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_seventeen()
    {
      ulong result = FunctionsMath.RecursiveFactorial(17);
      Assert.IsTrue(result == 355687428096000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_eighteen()
    {
      ulong result = FunctionsMath.RecursiveFactorial(18);
      Assert.IsTrue(result == 6402373705728000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_nineteen()
    {
      ulong result = FunctionsMath.RecursiveFactorial(19);
      Assert.IsTrue(result == 121645100408832000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_twenty()
    {
      ulong result = FunctionsMath.RecursiveFactorial(20);
      Assert.IsTrue(result == 2432902008176640000);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_twentyOne()
    {
      ulong result = FunctionsMath.RecursiveFactorial(21);
      Assert.IsTrue(result == 14197454024290336768);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_Negative_number()
    {
      ulong result = FunctionsMath.RecursiveFactorial(-3);
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_RecursiveFactorial_zero()
    {
      ulong result = FunctionsMath.RecursiveFactorial(0);
      Assert.IsTrue(result == 0);
    }
    #endregion Math Methods - Recursive Factorial
    #region Math Methods - Sommielle
    // **********************Sommielle****************
    [TestMethod]
    public void TestMethod_Sommielle_zero()
    {
      long result = FunctionsMath.Sommielle(0, 0);
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_Sommielle_one_interval()
    {
      long result = FunctionsMath.Sommielle(0, 1);
      Assert.IsTrue(result == 1);
    }

    [TestMethod]
    public void TestMethod_Sommielle_two_interval()
    {
      long result = FunctionsMath.Sommielle(1, 3);
      Assert.IsTrue(result == 6);
    }

    [TestMethod]
    public void TestMethod_Sommielle_inverted_max_min()
    {
      long result = FunctionsMath.Sommielle(3, 1);
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_Sommielle_zero_ten()
    {
      long result = FunctionsMath.Sommielle(0, 10);
      Assert.IsTrue(result == 55);
    }

    [TestMethod]
    public void TestMethod_Sommielle_zero_twentyFour()
    {
      long result = FunctionsMath.Sommielle(0, 24);
      Assert.IsTrue(result == 300);
    }

    [TestMethod]
    public void TestMethod_Sommielle_zero_fifty()
    {
      long result = FunctionsMath.Sommielle(0, 50);
      Assert.IsTrue(result == 1275);
    }

    [TestMethod]
    public void TestMethod_Sommielle_ten_ten()
    {
      long result = FunctionsMath.Sommielle(10, 10);
      Assert.IsTrue(result == 10);
    }

    [TestMethod]
    public void TestMethod_Sommielle_zero_hundred()
    {
      long result = FunctionsMath.Sommielle(0, 100);
      Assert.IsTrue(result == 5050);
    }

    [TestMethod]
    public void TestMethod_Sommielle_zero_hundredAndFifty()
    {
      long result = FunctionsMath.Sommielle(0, 150);
      Assert.IsTrue(result == 11325);
    }
    #endregion Math Methods - Sommielle
    #region Math Methods - Sommielle Recursive
    // **********************Sommielle Recursive****************
    [TestMethod]
    public void TestMethod_SommielleRecursive_zero()
    {
      long result = FunctionsMath.SommielleRecursive(0, 0);
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_one_interval()
    {
      long result = FunctionsMath.SommielleRecursive(0, 1);
      Assert.IsTrue(result == 1);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_two_interval()
    {
      long result = FunctionsMath.SommielleRecursive(1, 3);
      Assert.IsTrue(result == 6);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_inverted_max_min()
    {
      long result = FunctionsMath.SommielleRecursive(3, 1);
      Assert.IsTrue(result == 0);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_zero_ten()
    {
      long result = FunctionsMath.SommielleRecursive(0, 10);
      Assert.IsTrue(result == 55);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_zero_twentyFour()
    {
      long result = FunctionsMath.SommielleRecursive(0, 24);
      Assert.IsTrue(result == 300);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_zero_fifty()
    {
      long result = FunctionsMath.SommielleRecursive(0, 50);
      Assert.IsTrue(result == 1275);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_ten_ten()
    {
      long result = FunctionsMath.SommielleRecursive(10, 10);
      Assert.IsTrue(result == 10);
    }

    [TestMethod]
    public void TestMethod_SommielleRecursive_zero_hundred()
    {
      long result = FunctionsMath.SommielleRecursive(0, 100);
      Assert.IsTrue(result == 5050);
    }
    #endregion Math Methods - Sommielle Recursive

    #endregion Math Methods
  }
}