using FonctionsUtiles.Fred.Csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestFunctionsMathPrimes
  {
    #region Math Methods
    #region IsPrime
    [TestMethod]
    public void TestMethod_IsPrime_0()
    {
      const int source = 0;
      const bool expected = false;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1()
    {
      const int source = 1;
      const bool expected = false;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2()
    {
      const int source = 2;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_3()
    {
      const int source = 3;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_4()
    {
      const int source = 4;
      const bool expected = false;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_5()
    {
      const int source = 5;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_6()
    {
      const int source = 6;
      const bool expected = false;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_7()
    {
      const int source = 7;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_8()
    {
      const int source = 8;
      const bool expected = false;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_9()
    {
      const int source = 9;
      const bool expected = false;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_10()
    {
      const int source = 10;
      const bool expected = false;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_11()
    {
      const int source = 11;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_12()
    {
      const int source = 12;
      const bool expected = false;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_13()
    {
      const int source = 13;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_14()
    {
      const int source = 14;
      const bool expected = false;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_15()
    {
      const int source = 15;
      const bool expected = false;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_16()
    {
      const int source = 16;
      const bool expected = false;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_17()
    {
      const int source = 17;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_18()
    {
      const int source = 18;
      const bool expected = false;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_19()
    {
      const int source = 19;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_20()
    {
      const int source = 20;
      const bool expected = false;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_21()
    {
      const int source = 21;
      const bool expected = false;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_22()
    {
      const int source = 22;
      const bool expected = false;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_23()
    {
      const int source = 23;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_24()
    {
      const int source = 24;
      const bool expected = false;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_25()
    {
      const int source = 25;
      const bool expected = false;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_26()
    {
      const int source = 26;
      const bool expected = false;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_27()
    {
      const int source = 27;
      const bool expected = false;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_28()
    {
      const int source = 28;
      const bool expected = false;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_29()
    {
      const int source = 29;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_30()
    {
      const int source = 30;
      const bool expected = false;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_31()
    {
      const int source = 31;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_37()
    {
      const int source = 37;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_41()
    {
      const int source = 41;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_43()
    {
      const int source = 43;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_47()
    {
      const int source = 47;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_53()
    {
      const int source = 53;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_59()
    {
      const int source = 59;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_61()
    {
      const int source = 61;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_67()
    {
      const int source = 67;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_71()
    {
      const int source = 71;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_73()
    {
      const int source = 73;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_79()
    {
      const int source = 79;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_83()
    {
      const int source = 83;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_89()
    {
      const int source = 89;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_97()
    {
      const int source = 97;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_101()
    {
      const int source = 101;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_103()
    {
      const int source = 103;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_107()
    {
      const int source = 107;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_109()
    {
      const int source = 109;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_113()
    {
      const int source = 113;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_127()
    {
      const int source = 127;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_131()
    {
      const int source = 131;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_137()
    {
      const int source = 137;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_139()
    {
      const int source = 139;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_149()
    {
      const int source = 149;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_151()
    {
      const int source = 151;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_157()
    {
      const int source = 157;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_163()
    {
      const int source = 163;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_167()
    {
      const int source = 167;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_173()
    {
      const int source = 173;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_179()
    {
      const int source = 179;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_181()
    {
      const int source = 181;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_191()
    {
      const int source = 191;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_193()
    {
      const int source = 193;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_197()
    {
      const int source = 197;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_199()
    {
      const int source = 199;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_211()
    {
      const int source = 211;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_223()
    {
      const int source = 223;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_227()
    {
      const int source = 227;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_229()
    {
      const int source = 229;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_233()
    {
      const int source = 233;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_239()
    {
      const int source = 239;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_241()
    {
      const int source = 241;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_251()
    {
      const int source = 251;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_257()
    {
      const int source = 257;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_263()
    {
      const int source = 263;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_269()
    {
      const int source = 269;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_271()
    {
      const int source = 271;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_277()
    {
      const int source = 277;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_281()
    {
      const int source = 281;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_283()
    {
      const int source = 283;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_293()
    {
      const int source = 293;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_307()
    {
      const int source = 307;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_311()
    {
      const int source = 311;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_313()
    {
      const int source = 313;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_317()
    {
      const int source = 317;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_331()
    {
      const int source = 331;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_337()
    {
      const int source = 337;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_347()
    {
      const int source = 347;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_349()
    {
      const int source = 349;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_353()
    {
      const int source = 353;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_359()
    {
      const int source = 359;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_367()
    {
      const int source = 367;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_373()
    {
      const int source = 373;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_379()
    {
      const int source = 379;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_383()
    {
      const int source = 383;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_389()
    {
      const int source = 389;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_397()
    {
      const int source = 397;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_401()
    {
      const int source = 401;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_409()
    {
      const int source = 409;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_419()
    {
      const int source = 419;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_421()
    {
      const int source = 421;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_431()
    {
      const int source = 431;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_433()
    {
      const int source = 433;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_439()
    {
      const int source = 439;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_443()
    {
      const int source = 443;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_449()
    {
      const int source = 449;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_457()
    {
      const int source = 457;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_461()
    {
      const int source = 461;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_463()
    {
      const int source = 463;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_467()
    {
      const int source = 467;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_479()
    {
      const int source = 479;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_487()
    {
      const int source = 487;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_491()
    {
      const int source = 491;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_499()
    {
      const int source = 499;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_503()
    {
      const int source = 503;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_509()
    {
      const int source = 509;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_521()
    {
      const int source = 521;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_523()
    {
      const int source = 523;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_541()
    {
      const int source = 541;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_547()
    {
      const int source = 547;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_557()
    {
      const int source = 557;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_563()
    {
      const int source = 563;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_569()
    {
      const int source = 569;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_571()
    {
      const int source = 571;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_577()
    {
      const int source = 577;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_587()
    {
      const int source = 587;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_593()
    {
      const int source = 593;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_599()
    {
      const int source = 599;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_601()
    {
      const int source = 601;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_607()
    {
      const int source = 607;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_613()
    {
      const int source = 613;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_617()
    {
      const int source = 617;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_619()
    {
      const int source = 619;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_631()
    {
      const int source = 631;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_641()
    {
      const int source = 641;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_643()
    {
      const int source = 643;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_647()
    {
      const int source = 647;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_653()
    {
      const int source = 653;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_659()
    {
      const int source = 659;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_661()
    {
      const int source = 661;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_673()
    {
      const int source = 673;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_677()
    {
      const int source = 677;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_683()
    {
      const int source = 683;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_691()
    {
      const int source = 691;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_701()
    {
      const int source = 701;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_709()
    {
      const int source = 709;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_719()
    {
      const int source = 719;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_727()
    {
      const int source = 727;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_733()
    {
      const int source = 733;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_739()
    {
      const int source = 739;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_743()
    {
      const int source = 743;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_751()
    {
      const int source = 751;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_757()
    {
      const int source = 757;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_761()
    {
      const int source = 761;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_769()
    {
      const int source = 769;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_773()
    {
      const int source = 773;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_787()
    {
      const int source = 787;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_797()
    {
      const int source = 797;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_809()
    {
      const int source = 809;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_811()
    {
      const int source = 811;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_821()
    {
      const int source = 821;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_823()
    {
      const int source = 823;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_827()
    {
      const int source = 827;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_829()
    {
      const int source = 829;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_839()
    {
      const int source = 839;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_853()
    {
      const int source = 853;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_857()
    {
      const int source = 857;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_859()
    {
      const int source = 859;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_863()
    {
      const int source = 863;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_877()
    {
      const int source = 877;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_881()
    {
      const int source = 881;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_883()
    {
      const int source = 883;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_887()
    {
      const int source = 887;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_907()
    {
      const int source = 907;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_911()
    {
      const int source = 911;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_919()
    {
      const int source = 919;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_929()
    {
      const int source = 929;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_937()
    {
      const int source = 937;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_941()
    {
      const int source = 941;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_947()
    {
      const int source = 947;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_953()
    {
      const int source = 953;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_967()
    {
      const int source = 967;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_IsPrime_971()
    {
      const int source = 971;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_977()
    {
      const int source = 977;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_983()
    {
      const int source = 983;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_991()
    {
      const int source = 991;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_997()
    {
      const int source = 997;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1009()
    {
      const int source = 1009;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1013()
    {
      const int source = 1013;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1019()
    {
      const int source = 1019;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1021()
    {
      const int source = 1021;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1031()
    {
      const int source = 1031;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1033()
    {
      const int source = 1033;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1039()
    {
      const int source = 1039;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1049()
    {
      const int source = 1049;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1051()
    {
      const int source = 1051;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1061()
    {
      const int source = 1061;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1063()
    {
      const int source = 1063;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1069()
    {
      const int source = 1069;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1087()
    {
      const int source = 1087;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1091()
    {
      const int source = 1091;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1093()
    {
      const int source = 1093;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1097()
    {
      const int source = 1097;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1109()
    {
      const int source = 1109;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1117()
    {
      const int source = 1117;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1123()
    {
      const int source = 1123;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1129()
    {
      const int source = 1129;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1151()
    {
      const int source = 1151;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1153()
    {
      const int source = 1153;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1163()
    {
      const int source = 1163;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1171()
    {
      const int source = 1171;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1181()
    {
      const int source = 1181;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1187()
    {
      const int source = 1187;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1193()
    {
      const int source = 1193;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1201()
    {
      const int source = 1201;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1213()
    {
      const int source = 1213;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1217()
    {
      const int source = 1217;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1223()
    {
      const int source = 1223;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1229()
    {
      const int source = 1229;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1231()
    {
      const int source = 1231;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1237()
    {
      const int source = 1237;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1249()
    {
      const int source = 1249;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1259()
    {
      const int source = 1259;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1277()
    {
      const int source = 1277;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1279()
    {
      const int source = 1279;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1283()
    {
      const int source = 1283;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1289()
    {
      const int source = 1289;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1291()
    {
      const int source = 1291;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1297()
    {
      const int source = 1297;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1301()
    {
      const int source = 1301;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1303()
    {
      const int source = 1303;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1307()
    {
      const int source = 1307;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1319()
    {
      const int source = 1319;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1321()
    {
      const int source = 1321;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1327()
    {
      const int source = 1327;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1361()
    {
      const int source = 1361;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1367()
    {
      const int source = 1367;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1373()
    {
      const int source = 1373;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1381()
    {
      const int source = 1381;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1399()
    {
      const int source = 1399;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1409()
    {
      const int source = 1409;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1423()
    {
      const int source = 1423;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1427()
    {
      const int source = 1427;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1429()
    {
      const int source = 1429;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1433()
    {
      const int source = 1433;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1439()
    {
      const int source = 1439;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1447()
    {
      const int source = 1447;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1451()
    {
      const int source = 1451;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1453()
    {
      const int source = 1453;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1459()
    {
      const int source = 1459;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1471()
    {
      const int source = 1471;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1481()
    {
      const int source = 1481;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1483()
    {
      const int source = 1483;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1487()
    {
      const int source = 1487;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1489()
    {
      const int source = 1489;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1493()
    {
      const int source = 1493;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1499()
    {
      const int source = 1499;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1511()
    {
      const int source = 1511;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1523()
    {
      const int source = 1523;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1531()
    {
      const int source = 1531;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1543()
    {
      const int source = 1543;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1549()
    {
      const int source = 1549;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1553()
    {
      const int source = 1553;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1559()
    {
      const int source = 1559;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1567()
    {
      const int source = 1567;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1571()
    {
      const int source = 1571;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1579()
    {
      const int source = 1579;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1583()
    {
      const int source = 1583;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1597()
    {
      const int source = 1597;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1601()
    {
      const int source = 1601;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1607()
    {
      const int source = 1607;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1609()
    {
      const int source = 1609;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1613()
    {
      const int source = 1613;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1619()
    {
      const int source = 1619;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1621()
    {
      const int source = 1621;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1627()
    {
      const int source = 1627;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1637()
    {
      const int source = 1637;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1657()
    {
      const int source = 1657;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1663()
    {
      const int source = 1663;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1667()
    {
      const int source = 1667;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1669()
    {
      const int source = 1669;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1693()
    {
      const int source = 1693;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1697()
    {
      const int source = 1697;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1699()
    {
      const int source = 1699;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1709()
    {
      const int source = 1709;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1721()
    {
      const int source = 1721;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1723()
    {
      const int source = 1723;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1733()
    {
      const int source = 1733;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1741()
    {
      const int source = 1741;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1747()
    {
      const int source = 1747;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1753()
    {
      const int source = 1753;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1759()
    {
      const int source = 1759;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1777()
    {
      const int source = 1777;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1783()
    {
      const int source = 1783;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1787()
    {
      const int source = 1787;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1789()
    {
      const int source = 1789;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1801()
    {
      const int source = 1801;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1811()
    {
      const int source = 1811;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1823()
    {
      const int source = 1823;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1831()
    {
      const int source = 1831;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1847()
    {
      const int source = 1847;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1861()
    {
      const int source = 1861;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1867()
    {
      const int source = 1867;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1871()
    {
      const int source = 1871;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1873()
    {
      const int source = 1873;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1877()
    {
      const int source = 1877;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1879()
    {
      const int source = 1879;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1889()
    {
      const int source = 1889;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1901()
    {
      const int source = 1901;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1907()
    {
      const int source = 1907;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1913()
    {
      const int source = 1913;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1931()
    {
      const int source = 1931;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1933()
    {
      const int source = 1933;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1949()
    {
      const int source = 1949;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1951()
    {
      const int source = 1951;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1973()
    {
      const int source = 1973;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1979()
    {
      const int source = 1979;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1987()
    {
      const int source = 1987;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1993()
    {
      const int source = 1993;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1997()
    {
      const int source = 1997;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1999()
    {
      const int source = 1999;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2003()
    {
      const int source = 2003;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2011()
    {
      const int source = 2011;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2017()
    {
      const int source = 2017;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2027()
    {
      const int source = 2027;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2029()
    {
      const int source = 2029;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2039()
    {
      const int source = 2039;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2053()
    {
      const int source = 2053;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2063()
    {
      const int source = 2063;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2069()
    {
      const int source = 2069;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2081()
    {
      const int source = 2081;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2083()
    {
      const int source = 2083;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2087()
    {
      const int source = 2087;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2089()
    {
      const int source = 2089;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2099()
    {
      const int source = 2099;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2111()
    {
      const int source = 2111;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2113()
    {
      const int source = 2113;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2129()
    {
      const int source = 2129;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2131()
    {
      const int source = 2131;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2137()
    {
      const int source = 2137;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2141()
    {
      const int source = 2141;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2143()
    {
      const int source = 2143;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2153()
    {
      const int source = 2153;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2161()
    {
      const int source = 2161;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2179()
    {
      const int source = 2179;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2203()
    {
      const int source = 2203;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2207()
    {
      const int source = 2207;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2213()
    {
      const int source = 2213;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2221()
    {
      const int source = 2221;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2237()
    {
      const int source = 2237;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2239()
    {
      const int source = 2239;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2243()
    {
      const int source = 2243;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2251()
    {
      const int source = 2251;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2267()
    {
      const int source = 2267;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2269()
    {
      const int source = 2269;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2273()
    {
      const int source = 2273;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2281()
    {
      const int source = 2281;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2287()
    {
      const int source = 2287;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2293()
    {
      const int source = 2293;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2297()
    {
      const int source = 2297;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2309()
    {
      const int source = 2309;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2311()
    {
      const int source = 2311;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2333()
    {
      const int source = 2333;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2339()
    {
      const int source = 2339;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2341()
    {
      const int source = 2341;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2347()
    {
      const int source = 2347;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2351()
    {
      const int source = 2351;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [Owner("Fred")]
    [Description("Testing if 2357 is prime")]
    [Priority(1)]
    [TestCategory("Prime test")]
    public void TestMethod_IsPrime_2357()
    {
      const int source = 2357;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
      StringAssert.Contains(source.ToString(), source.ToString());
      StringAssert.StartsWith(source.ToString(), source.ToString());
    }

    [TestMethod]
    [TestCategory("Regex test")]
    public void TestMethod_Regex_only_numbers()
    {
      const int source = 2357;
      Regex onlyNumbersRegex = new Regex(@"^[0-9]+$");
      StringAssert.Matches(source.ToString(), onlyNumbersRegex);
    }

    [TestMethod]
    [TestCategory("Regex test")]
    public void TestMethod_Regex_only_letters_and_space()
    {
      string source = "Once upon a time";
      Regex onlyLettersRegex = new Regex(@"^[a-zA-Z ]+$");
      StringAssert.Matches(source, onlyLettersRegex);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    public void TestMethod_IsPrime_2371()
    {
      const int source = 2371;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    public void TestMethod_IsPrime_2377()
    {
      const int source = 2377;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    public void TestMethod_IsPrime_2381()
    {
      const int source = 2381;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    [Timeout(3000)]
    public void TestMethod_IsPrime_2383()
    {
      const int source = 2383;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    //[DataTestMethod]
    //[DataRow(-1)]
    //[DataRow(0)]
    //[DataRow(1)]
    [TestMethod]
    public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
    {
      //bool result = FunctionsMath.IsPrime(value);
      //Assert.IsFalse(result, $"{value} should not be prime");
      Assert.IsFalse(false);
    }

    [TestMethod]
    [Timeout(3500)]
    [Ignore]
    public void TestMethod_SimulateTimeOut()
    {
      Thread.Sleep(4000);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    [WorkItem(1)]
    public void TestMethod_IsPrime_2389()
    {
      const int source = 2389;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    public void TestMethod_IsPrime_2393()
    {
      const int source = 2393;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    public void TestMethod_IsPrime_2399()
    {
      const int source = 2399;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    public void TestMethod_IsPrime_2411()
    {
      const int source = 2411;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    public void TestMethod_IsPrime_2417()
    {
      const int source = 2417;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    public void TestMethod_IsPrime_2423()
    {
      const int source = 2423;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    public void TestMethod_IsPrime_2437()
    {
      const int source = 2437;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    public void TestMethod_IsPrime_2441()
    {
      const int source = 2441;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    public void TestMethod_IsPrime_2447()
    {
      const int source = 2447;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    public void TestMethod_IsPrime_2459()
    {
      const int source = 2459;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    public void TestMethod_IsPrime_2467()
    {
      const int source = 2467;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    public void TestMethod_IsPrime_2473()
    {
      const int source = 2473;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    public void TestMethod_IsPrime_2477()
    {
      const int source = 2477;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    public void TestMethod_IsPrime_2503()
    {
      const int source = 2503;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    public void TestMethod_IsPrime_2521()
    {
      const int source = 2521;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    public void TestMethod_IsPrime_2531()
    {
      const int source = 2531;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    public void TestMethod_IsPrime_2539()
    {
      const int source = 2539;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    public void TestMethod_IsPrime_2543()
    {
      const int source = 2543;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [TestCategory("Prime test")]
    public void TestMethod_IsPrime_2549()
    {
      const int source = 2549;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    /*  Add unit test
     *  
      TOUS LES NOMBRES PREMIERS DE 2001 À 3000
     2 549 2 551 2 557 2 579 2 591 2 593 2 609 2 617 2 621 2 633 2 647 2 657 2 659 2 663 2 671 2 677 2 683 2 687 2 689 2 693 2 699 2 707 2 711 2 713 2 719 2 729 2 731 2 741 2 749 2 753 2 767 2 777 2 789 2 791 2 797 2 801 2 803 2 819 2 833 2 837 2 843 2 851 2 857 2 861 2 879 2 887 2 897 2 903 2 909 2 917 2 927 2 939 2 953 2 957 2 963 2 969 2 971 2 999

TOUS LES NOMBRES PREMIERS DE 3001 À 4000
3 001 3 011 3 019 3 023 3 037 3 041 3 049 3 061 3 067 3 079 3 083 3 089 3 109 3 119 3 121 3 137 3 163 3 167 3 169 3 181 3 187 3 191 3 203 3 209 3 217 3 221 3 229 3 251 3 253 3 257 3 259 3 271 3 299 3 301 3 307 3 313 3 319 3 323 3 329 3 331 3 343 3 347 3 359 3 361 3 371 3 373 3 389 3 391 3 407 3 413 3 433 3 449 3 457 3 461 3 463 3 467 3 469 3 491 3 499 3 511 3 517 3 527 3 529 3 533 3 539 3 541 3 547 3 557 3 559 3 571 3 581 3 583 3 593 3 607 3 613 3 617 3 623 3 631 3 637 3 643 3 659 3 671 3 673 3 677 3 691 3 697 3 701 3 709 3 719 3 727 3 733 3 739 3 761 3 767 3 769 3 779 3 793 3 797 3 803 3 821 3 823 3 833 3 847 3 851 3 853 3 863 3 877 3 881 3 889 3 907 3 911 3 917 3 919 3 923 3 929 3 931 3 943 3 947 3 967 3 989

TOUS LES NOMBRES PREMIERS DE 4001 À 5000
4 001 4 003 4 007 4 013 4 019 4 021 4 027 4 049 4 051 4 057 4 073 4 079 4 091 4 093 4 099 4 111 4 127 4 129 4 133 4 139 4 153 4 157 4 159 4 177 4 201 4 211 4 217 4 219 4 229 4 231 4 241 4 243 4 253 4 259 4 261 4 271 4 273 4 283 4 289 4 297 4 327 4 337 4 339 4 349 4 357 4 363 4 373 4 391 4 397 4 409 4 421 4 423 4 441 4 447 4 451 4 457 4 463 4 481 4 483 4 493 4 507 4 513 4 517 4 519 4 523 4 547 4 549 4 561 4 567 4 583 4 591 4 597 4 603 4 621 4 637 4 639 4 643 4 649 4 651 4 657 4 663 4 673 4 679 4 691 4 703 4 721 4 723 4 729 4 733 4 751 4 759 4 783 4 787 4 789 4 793 4 799 4 801 4 813 4 817 4 831 4 861 4 871 4 877 4 889 4 903 4 909 4 919 4 931 4 933 4 937 4 943 4 951 4 957 4 967 4 969 4 973 4 987 4 993 4 999

TOUS LES NOMBRES PREMIERS DE 5001 À 6000
5 003 5 009 5 011 5 021 5 023 5 039 5 051 5 059 5 077 5 081 5 087 5 099 5 101 5 107 5 113 5 119 5 147 5 153 5 167 5 171 5 179 5 189 5 197 5 209 5 227 5 231 5 233 5 237 5 261 5 273 5 279 5 281 5 297 5 303 5 309 5 323 5 333 5 347 5 351 5 381 5 387 5 393 5 399 5 407 5 413 5 417 5 419 5 431 5 437 5 441 5 443 5 449 5 471 5 477 5 479 5 483 5 501 5 503 5 507 5 519 5 521 5 527 5 531 5 557 5 563 5 569 5 573 5 581 5 591 5 623 5 639 5 641 5 647 5 651 5 653 5 657 5 659 5 669 5 683 5 689 5 693 5 701 5 711 5 717 5 737 5 741 5 743 5 749 5 779 5 783 5 791 5 801 5 807 5 813 5 821 5 827 5 839 5 843 5 849 5 851 5 857 5 861 5 867 5 869 5 879 5 881 5 897 5 903 5 923 5 927 5 939 5 953 5 981 5 987

TOUS LES NOMBRES PREMIERS DE 6001 À 7000
6 007 6 011 6 029 6 037 6 043 6 047 6 053 6 067 6 073 6 079 6 089 6 091 6 101 6 113 6 121 6 131 6 133 6 143 6 151 6 163 6 173 6 197 6 199 6 203 6 211 6 217 6 221 6 229 6 247 6 257 6 263 6 269 6 271 6 277 6 287 6 299 6 301 6 311 6 317 6 323 6 329 6 337 6 343 6 353 6 359 6 361 6 367 6 373 6 379 6 389 6 397 6 421 6 427 6 449 6 451 6 469 6 473 6 481 6 491 6 521 6 529 6 547 6 551 6 553 6 563 6 569 6 571 6 577 6 581 6 599 6 607 6 619 6 637 6 653 6 659 6 661 6 673 6 679 6 689 6 691 6 701 6 703 6 709 6 719 6 733 6 737 6 761 6 763 6 779 6 781 6 791 6 793 6 803 6 823 6 827 6 829 6 833 6 841 6 857 6 863 6 869 6 871 6 883 6 899 6 907 6 911 6 917 6 947 6 949 6 959 6 961 6 967 6 971 6 977 6 983 6 991 6 997

TOUS LES NOMBRES PREMIERS DE 7001 À 8000
7 001 7 013 7 019 7 027 7 039 7 043 7 057 7 069 7 079 7 103 7 109 7 121 7 127 7 129 7 151 7 159 7 177 7 187 7 193 7 207 7 211 7 213 7 219 7 229 7 237 7 243 7 247 7 253 7 283 7 297 7 307 7 309 7 321 7 331 7 333 7 349 7 351 7 369 7 393 7 411 7 417 7 433 7 451 7 457 7 459 7 477 7 481 7 487 7 489 7 499 7 507 7 517 7 523 7 529 7 537 7 541 7 547 7 549 7 559 7 561 7 573 7 577 7 583 7 589 7 591 7 603 7 607 7 621 7 639 7 643 7 649 7 669 7 673 7 681 7 687 7 691 7 699 7 703 7 717 7 723 7 727 7 741 7 753 7 757 7 759 7 789 7 793 7 817 7 823 7 829 7 841 7 853 7 867 7 873 7 877 7 879 7 883 7 901 7 907 7 919 7 927 7 933 7 937 7 949 7 951 7 963 7 993

TOUS LES NOMBRES PREMIERS DE 8001 À 9000
8 009 8 011 8 017 8 039 8 053 8 059 8 069 8 081 8 087 8 089 8 093 8 101 8 111 8 117 8 123 8 147 8 161 8 167 8 171 8 179 8 191 8 209 8 219 8 221 8 231 8 233 8 237 8 243 8 263 8 269 8 273 8 287 8 291 8 293 8 297 8 311 8 317 8 329 8 353 8 363 8 369 8 377 8 387 8 389 8 419 8 423 8 429 8 431 8 443 8 447 8 461 8 467 8 501 8 513 8 521 8 527 8 537 8 539 8 543 8 563 8 573 8 581 8 597 8 599 8 609 8 623 8 627 8 629 8 641 8 647 8 663 8 669 8 677 8 681 8 689 8 693 8 699 8 707 8 713 8 719 8 731 8 737 8 741 8 747 8 753 8 761 8 779 8 783 8 803 8 807 8 819 8 821 8 831 8 837 8 839 8 849 8 861 8 863 8 867 8 887 8 893 8 923 8 929 8 933 8 941 8 951 8 963 8 969 8 971 8 999

TOUS LES NOMBRES PREMIERS DE 9001 À 10000
9 001 9 007 9 011 9 013 9 029 9 041 9 043 9 049 9 059 9 067 9 091 9 103 9 109 9 127 9 133 9 137 9 151 9 157 9 161 9 173 9 181 9 187 9 199 9 203 9 209 9 221 9 227 9 239 9 241 9 257 9 277 9 281 9 283 9 293 9 311 9 319 9 323 9 337 9 341 9 343 9 349 9 371 9 377 9 391 9 397 9 403 9 413 9 419 9 421 9 431 9 433 9 437 9 439 9 461 9 463 9 467 9 473 9 479 9 491 9 497 9 511 9 521 9 533 9 539 9 547 9 551 9 587 9 601 9 613 9 619 9 623 9 629 9 631 9 643 9 649 9 661 9 677 9 679 9 689 9 697 9 719 9 721 9 733 9 739 9 743 9 749 9 767 9 769 9 781 9 787 9 791 9 803 9 811 9 817 9 829 9 833 9 839 9 851 9 857 9 859 9 871 9 883 9 887 9 901 9 907 9 923 9 929 9 931 9 941 9 949 9 967 9 973

TOUS LES NOMBRES PREMIERS DE 10001 À 20000
10 007 10 009 10 037 10 039 10 061 10 067 10 069 10 079 10 091 10 093 10 099 10 103 10 111 10 133 10 139 10 141 10 151 10 159 10 163 10 169 10 177 10 181 10 193 10 211 10 223 10 243 10 247 10 253 10 259 10 267 10 271 10 273 10 289 10 301 10 303 10 313 10 321 10 331 10 333 10 337 10 343 10 357 10 369 10 391 10 399 10 427 10 429 10 433 10 453 10 457 10 459 10 463 10 477 10 487 10 499 10 501 10 513 10 529 10 531 10 559 10 567 10 589 10 597 10 601 10 607 10 613 10 627 10 631 10 639 10 651 10 657 10 663 10 667 10 687 10 691 10 709 10 711 10 723 10 729 10 733 10 739 10 753 10 771 10 781 10 789 10 799 10 831 10 837 10 847 10 853 10 859 10 861 10 867 10 883 10 889 10 891 10 903 10 909 10 937 10 939 10 949 10 957 10 973 10 979 10 987 10 993 11 003 11 027 11 047 11 057 11 059 11 069 11 071 11 083 11 087 11 093 11 113 11 117 11 119 11 131 11 149 11 159 11 161 11 171 11 173 11 177 11 197 11 213 11 239 11 243 11 251 11 257 11 261 11 273 11 279 11 287 11 299 11 311 11 317 11 321 11 329 11 351 11 353 11 369 11 383 11 393 11 399 11 411 11 423 11 437 11 443 11 447 11 467 11 471 11 483 11 489 11 491 11 497 11 503 11 519 11 527 11 549 11 551 11 579 11 587 11 593 11 597 11 617 11 621 11 633 11 657 11 677 11 681 11 689 11 699 11 701 11 717 11 719 11 731 11 743 11 777 11 779 11 783 11 789 11 801 11 807 11 813 11 821 11 827 11 831 11 833 11 839 11 863 11 867 11 887 11 897 11 903 11 909 11 923 11 927 11 933 11 939 11 941 11 953 11 959 11 969 11 971 11 981 11 987 12 007 12 011 12 037 12 041 12 043 12 049 12 071 12 073 12 097 12 101 12 107 12 109 12 113 12 119 12 143 12 149 12 157 12 161 12 163 12 197 12 203 12 211 12 227 12 239 12 241 12 251 12 253 12 263 12 269 12 277 12 281 12 289 12 301 12 323 12 329 12 343 12 347 12 373 12 377 12 379 12 391 12 401 12 409 12 413 12 421 12 433 12 437 12 451 12 457 12 473 12 479 12 487 12 491 12 497 12 503 12 511 12 517 12 527 12 539 12 541 12 547 12 553 12 569 12 577 12 583 12 589 12 601 12 611 12 613 12 619 12 637 12 641 12 647 12 653 12 659 12 671 12 689 12 697 12 703 12 713 12 721 12 739 12 743 12 757 12 763 12 781 12 791 12 799 12 809 12 821 12 823 12 829 12 841 12 853 12 889 12 893 12 899 12 907 12 911 12 917 12 919 12 923 12 941 12 953 12 959 12 967 12 973 12 979 12 983 13 001 13 003 13 007 13 009 13 033 13 037 13 043 13 049 13 063 13 093 13 099 13 103 13 109 13 121 13 127 13 147 13 151 13 159 13 163 13 171 13 177 13 183 13 187 13 217 13 219 13 229 13 241 13 249 13 259 13 267 13 291 13 297 13 309 13 313 13 327 13 331 13 337 13 339 13 367 13 381 13 397 13 399 13 411 13 417 13 421 13 441 13 451 13 457 13 463 13 469 13 477 13 487 13 499 13 513 13 523 13 537 13 553 13 567 13 577 13 591 13 597 13 613 13 619 13 627 13 633 13 649 13 669 13 679 13 681 13 687 13 691 13 693 13 697 13 709 13 711 13 721 13 723 13 729 13 751 13 757 13 759 13 763 13 781 13 789 13 799 13 807 13 829 13 831 13 841 13 859 13 873 13 877 13 879 13 883 13 901 13 903 13 907 13 913 13 921 13 931 13 933 13 963 13 967 13 997 13 999 14 009 14 011 14 029 14 033 14 051 14 057 14 071 14 081 14 083 14 087 14 107 14 143 14 149 14 153 14 159 14 173 14 177 14 197 14 207 14 221 14 243 14 249 14 251 14 281 14 293 14 303 14 321 14 323 14 327 14 341 14 347 14 369 14 387 14 389 14 401 14 407 14 411 14 419 14 423 14 431 14 437 14 447 14 449 14 461 14 479 14 489 14 503 14 519 14 533 14 537 14 543 14 549 14 551 14 557 14 561 14 563 14 591 14 593 14 621 14 627 14 629 14 633 14 639 14 653 14 657 14 669 14 683 14 699 14 713 14 717 14 723 14 731 14 737 14 741 14 747 14 753 14 759 14 767 14 771 14 779 14 783 14 797 14 813 14 821 14 827 14 831 14 843 14 851 14 867 14 869 14 879 14 887 14 891 14 897 14 923 14 929 14 939 14 947 14 951 14 957 14 969 14 983 15 013 15 017 15 031 15 053 15 061 15 073 15 077 15 083 15 091 15 101 15 107 15 121 15 131 15 137 15 139 15 149 15 161 15 173 15 187 15 193 15 199 15 217 15 227 15 233 15 241 15 259 15 263 15 269 15 271 15 277 15 287 15 289 15 299 15 307 15 313 15 319 15 329 15 331 15 349 15 359 15 361 15 373 15 377 15 383 15 391 15 401 15 413 15 427 15 439 15 443 15 451 15 461 15 467 15 473 15 493 15 497 15 511 15 527 15 541 15 551 15 559 15 569 15 581 15 583 15 601 15 607 15 619 15 629 15 641 15 643 15 647 15 649 15 661 15 667 15 671 15 679 15 683 15 727 15 731 15 733 15 737 15 739 15 749 15 761 15 767 15 773 15 787 15 791 15 797 15 803 15 809 15 817 15 823 15 859 15 877 15 881 15 887 15 889 15 901 15 907 15 913 15 919 15 923 15 937 15 959 15 971 15 973 15 991 16 001 16 007 16 033 16 057 16 061 16 063 16 067 16 069 16 073 16 087 16 091 16 097 16 103 16 111 16 127 16 139 16 141 16 183 16 187 16 189 16 193 16 217 16 223 16 229 16 231 16 249 16 253 16 267 16 273 16 301 16 319 16 333 16 339 16 349 16 361 16 363 16 369 16 381 16 411 16 417 16 421 16 427 16 433 16 447 16 451 16 453 16 477 16 481 16 487 16 493 16 519 16 529 16 547 16 553 16 561 16 567 16 573 16 603 16 607 16 619 16 631 16 633 16 649 16 651 16 657 16 661 16 673 16 691 16 693 16 699 16 703 16 729 16 741 16 747 16 759 16 763 16 787 16 811 16 823 16 829 16 831 16 843 16 871 16 879 16 883 16 889 16 901 16 903 16 921 16 927 16 931 16 937 16 943 16 963 16 979 16 981 16 987 16 993 17 011 17 021 17 027 17 029 17 033 17 041 17 047 17 053 17 077 17 093 17 099 17 107 17 117 17 123 17 137 17 159 17 167 17 183 17 189 17 191 17 203 17 207 17 209 17 231 17 239 17 257 17 291 17 293 17 299 17 317 17 321 17 327 17 333 17 341 17 351 17 359 17 377 17 383 17 387 17 389 17 393 17 401 17 417 17 419 17 431 17 443 17 449 17 467 17 471 17 477 17 483 17 489 17 491 17 497 17 509 17 519 17 539 17 551 17 569 17 573 17 579 17 581 17 597 17 599 17 609 17 623 17 627 17 657 17 659 17 669 17 681 17 683 17 707 17 713 17 729 17 737 17 747 17 749 17 761 17 783 17 789 17 791 17 807 17 827 17 837 17 839 17 851 17 863 17 881 17 891 17 903 17 909 17 911 17 921 17 923 17 929 17 939 17 957 17 959 17 971 17 977 17 981 17 987 17 989 18 013 18 041 18 043 18 047 18 049 18 059 18 061 18 077 18 089 18 097 18 119 18 121 18 127 18 131 18 133 18 143 18 149 18 169 18 181 18 191 18 199 18 211 18 217 18 223 18 229 18 233 18 251 18 253 18 257 18 269 18 287 18 289 18 301 18 307 18 311 18 313 18 329 18 341 18 353 18 367 18 371 18 379 18 397 18 401 18 413 18 427 18 433 18 439 18 443 18 451 18 457 18 461 18 481 18 493 18 503 18 517 18 521 18 523 18 539 18 541 18 553 18 583 18 587 18 593 18 617 18 637 18 661 18 671 18 679 18 691 18 701 18 713 18 719 18 731 18 743 18 749 18 757 18 773 18 787 18 793 18 797 18 803 18 839 18 859 18 869 18 899 18 911 18 913 18 917 18 919 18 947 18 959 18 973 18 979 19 001 19 009 19 013 19 031 19 037 19 051 19 069 19 073 19 079 19 081 19 087 19 121 19 139 19 141 19 157 19 163 19 181 19 183 19 207 19 211 19 213 19 219 19 231 19 237 19 249 19 259 19 267 19 273 19 289 19 301 19 309 19 319 19 333 19 373 19 379 19 381 19 387 19 391 19 403 19 417 19 421 19 423 19 427 19 429 19 433 19 441 19 447 19 457 19 463 19 469 19 471 19 477 19 483 19 489 19 501 19 507 19 531 19 541 19 543 19 553 19 559 19 571 19 577 19 583 19 597 19 603 19 609 19 661 19 681 19 687 19 697 19 699 19 709 19 717 19 727 19 739 19 751 19 753 19 759 19 763 19 777 19 793 19 801 19 813 19 819 19 841 19 843 19 853 19 861 19 867 19 889 19 891 19 913 19 919 19 927 19 937 19 949 19 961 19 963 19 973 19 979 19 991 19 993 19 997

TOUS LES NOMBRES PREMIERS DE 20001 À 30000
20 011 20 021 20 023 20 029 20 047 20 051 20 063 20 071 20 089 20 101 20 107 20 113 20 117 20 123 20 129 20 143 20 147 20 149 20 161 20 173 20 177 20 183 20 201 20 219 20 231 20 233 20 249 20 261 20 269 20 287 20 297 20 323 20 327 20 333 20 341 20 347 20 353 20 357 20 359 20 369 20 389 20 393 20 399 20 407 20 411 20 431 20 441 20 443 20 477 20 479 20 483 20 507 20 509 20 521 20 533 20 543 20 549 20 551 20 563 20 593 20 599 20 611 20 627 20 639 20 641 20 663 20 681 20 693 20 707 20 717 20 719 20 731 20 743 20 747 20 749 20 753 20 759 20 771 20 773 20 789 20 807 20 809 20 849 20 857 20 873 20 879 20 887 20 897 20 899 20 903 20 921 20 929 20 939 20 947 20 959 20 963 20 981 20 983 21 001 21 011 21 013 21 017 21 019 21 023 21 031 21 059 21 061 21 067 21 089 21 101 21 107 21 121 21 139 21 143 21 149 21 157 21 163 21 169 21 179 21 187 21 191 21 193 21 211 21 221 21 227 21 247 21 269 21 277 21 283 21 313 21 317 21 319 21 323 21 341 21 347 21 377 21 379 21 383 21 391 21 397 21 401 21 407 21 419 21 433 21 467 21 481 21 487 21 491 21 493 21 499 21 503 21 517 21 521 21 523 21 529 21 557 21 559 21 563 21 569 21 577 21 587 21 589 21 599 21 601 21 611 21 613 21 617 21 647 21 649 21 661 21 673 21 683 21 701 21 713 21 727 21 737 21 739 21 751 21 757 21 767 21 773 21 787 21 799 21 803 21 817 21 821 21 839 21 841 21 851 21 859 21 863 21 871 21 881 21 893 21 911 21 929 21 937 21 943 21 961 21 977 21 991 21 997 22 003 22 013 22 027 22 031 22 037 22 039 22 051 22 063 22 067 22 073 22 079 22 091 22 093 22 109 22 111 22 123 22 129 22 133 22 147 22 153 22 157 22 159 22 171 22 189 22 193 22 229 22 247 22 259 22 271 22 273 22 277 22 279 22 283 22 291 22 303 22 307 22 343 22 349 22 367 22 369 22 381 22 391 22 397 22 409 22 433 22 441 22 447 22 453 22 469 22 481 22 483 22 501 22 511 22 531 22 541 22 543 22 549 22 567 22 571 22 573 22 613 22 619 22 621 22 637 22 639 22 643 22 651 22 669 22 679 22 691 22 697 22 699 22 709 22 717 22 721 22 727 22 739 22 741 22 751 22 769 22 777 22 783 22 787 22 807 22 811 22 817 22 853 22 859 22 861 22 871 22 877 22 901 22 907 22 921 22 937 22 943 22 961 22 963 22 973 22 993 23 003 23 011 23 017 23 021 23 027 23 029 23 039 23 041 23 053 23 057 23 059 23 063 23 071 23 081 23 087 23 099 23 117 23 131 23 143 23 159 23 167 23 173 23 189 23 197 23 201 23 203 23 209 23 227 23 251 23 269 23 279 23 291 23 293 23 297 23 311 23 321 23 327 23 333 23 339 23 357 23 369 23 371 23 399 23 417 23 431 23 447 23 459 23 473 23 497 23 509 23 531 23 537 23 539 23 549 23 557 23 561 23 563 23 567 23 581 23 593 23 599 23 603 23 609 23 623 23 627 23 629 23 633 23 663 23 669 23 671 23 677 23 687 23 689 23 719 23 741 23 743 23 747 23 753 23 761 23 767 23 773 23 789 23 801 23 813 23 819 23 827 23 831 23 833 23 857 23 869 23 873 23 879 23 887 23 893 23 899 23 909 23 911 23 917 23 929 23 957 23 971 23 977 23 981 23 993 24 001 24 007 24 019 24 023 24 029 24 043 24 049 24 061 24 071 24 077 24 083 24 091 24 097 24 103 24 107 24 109 24 113 24 121 24 133 24 137 24 151 24 169 24 179 24 181 24 197 24 203 24 223 24 229 24 239 24 247 24 251 24 281 24 317 24 329 24 337 24 359 24 371 24 373 24 379 24 391 24 407 24 413 24 419 24 421 24 439 24 443 24 469 24 473 24 481 24 499 24 509 24 517 24 527 24 533 24 547 24 551 24 571 24 593 24 611 24 623 24 631 24 659 24 671 24 677 24 683 24 691 24 697 24 709 24 733 24 749 24 763 24 767 24 781 24 793 24 799 24 809 24 821 24 841 24 847 24 851 24 859 24 877 24 889 24 907 24 917 24 919 24 923 24 943 24 953 24 967 24 971 24 977 24 979 24 989 25 013 25 031 25 033 25 037 25 057 25 073 25 087 25 097 25 111 25 117 25 121 25 127 25 147 25 153 25 163 25 169 25 171 25 183 25 189 25 219 25 229 25 237 25 243 25 247 25 253 25 261 25 301 25 303 25 307 25 309 25 321 25 339 25 343 25 349 25 357 25 367 25 373 25 391 25 409 25 411 25 423 25 439 25 447 25 453 25 457 25 463 25 469 25 471 25 523 25 537 25 541 25 561 25 577 25 579 25 583 25 589 25 601 25 603 25 609 25 621 25 633 25 639 25 643 25 657 25 667 25 673 25 679 25 693 25 703 25 717 25 733 25 741 25 747 25 759 25 763 25 771 25 793 25 799 25 801 25 819 25 841 25 847 25 849 25 867 25 873 25 889 25 903 25 913 25 919 25 931 25 933 25 939 25 943 25 951 25 969 25 981 25 997 25 999 26 003 26 017 26 021 26 029 26 041 26 053 26 083 26 099 26 107 26 111 26 113 26 119 26 141 26 153 26 161 26 171 26 177 26 183 26 189 26 203 26 209 26 227 26 237 26 249 26 251 26 261 26 263 26 267 26 293 26 297 26 309 26 317 26 321 26 339 26 347 26 357 26 371 26 387 26 393 26 399 26 407 26 417 26 423 26 431 26 437 26 449 26 459 26 479 26 489 26 497 26 501 26 513 26 539 26 557 26 561 26 573 26 591 26 597 26 627 26 633 26 641 26 647 26 669 26 681 26 683 26 687 26 693 26 699 26 701 26 711 26 713 26 717 26 723 26 729 26 731 26 737 26 759 26 777 26 783 26 801 26 813 26 821 26 833 26 839 26 849 26 861 26 863 26 879 26 881 26 891 26 893 26 903 26 921 26 927 26 947 26 951 26 953 26 959 26 981 26 987 26 993 27 011 27 017 27 031 27 043 27 059 27 061 27 067 27 073 27 077 27 091 27 103 27 107 27 109 27 127 27 143 27 179 27 191 27 197 27 211 27 239 27 241 27 253 27 259 27 271 27 277 27 281 27 283 27 299 27 329 27 337 27 361 27 367 27 397 27 407 27 409 27 427 27 431 27 437 27 449 27 457 27 479 27 481 27 487 27 509 27 527 27 529 27 539 27 541 27 551 27 581 27 583 27 611 27 617 27 631 27 647 27 653 27 673 27 689 27 691 27 697 27 701 27 733 27 737 27 739 27 743 27 749 27 751 27 763 27 767 27 773 27 779 27 791 27 793 27 799 27 803 27 809 27 817 27 823 27 827 27 847 27 851 27 883 27 893 27 901 27 917 27 919 27 941 27 943 27 947 27 953 27 961 27 967 27 983 27 997 28 001 28 019 28 027 28 031 28 051 28 057 28 069 28 081 28 087 28 097 28 099 28 109 28 111 28 123 28 151 28 163 28 181 28 183 28 201 28 211 28 219 28 229 28 277 28 279 28 283 28 289 28 297 28 307 28 309 28 319 28 349 28 351 28 387 28 393 28 403 28 409 28 411 28 429 28 433 28 439 28 447 28 463 28 477 28 493 28 499 28 513 28 517 28 537 28 541 28 547 28 549 28 559 28 571 28 573 28 579 28 591 28 597 28 603 28 607 28 619 28 621 28 627 28 631 28 643 28 649 28 657 28 661 28 663 28 669 28 687 28 697 28 703 28 711 28 723 28 729 28 751 28 753 28 759 28 771 28 789 28 793 28 807 28 813 28 817 28 837 28 843 28 859 28 867 28 871 28 879 28 901 28 909 28 921 28 927 28 933 28 949 28 961 28 979 29 009 29 017 29 021 29 023 29 027 29 033 29 059 29 063 29 077 29 101 29 123 29 129 29 131 29 137 29 147 29 153 29 167 29 173 29 179 29 191 29 201 29 207 29 209 29 221 29 231 29 243 29 251 29 269 29 287 29 297 29 303 29 311 29 327 29 333 29 339 29 347 29 363 29 383 29 387 29 389 29 399 29 401 29 411 29 423 29 429 29 437 29 443 29 453 29 473 29 483 29 501 29 527 29 531 29 537 29 567 29 569 29 573 29 581 29 587 29 599 29 611 29 629 29 633 29 641 29 663 29 669 29 671 29 683 29 717 29 723 29 741 29 753 29 759 29 761 29 789 29 803 29 819 29 833 29 837 29 851 29 863 29 867 29 873 29 879 29 881 29 917 29 921 29 927 29 947 29 959 29 983 29 989

TOUS LES NOMBRES PREMIERS DE 30001 À 40000
30 011 30 013 30 029 30 047 30 059 30 071 30 089 30 091 30 097 30 103 30 109 30 113 30 119 30 133 30 137 30 139 30 161 30 169 30 181 30 187 30 197 30 203 30 211 30 223 30 241 30 253 30 259 30 269 30 271 30 293 30 307 30 313 30 319 30 323 30 341 30 347 30 367 30 389 30 391 30 403 30 427 30 431 30 449 30 467 30 469 30 491 30 493 30 497 30 509 30 517 30 529 30 539 30 553 30 557 30 559 30 577 30 593 30 631 30 637 30 643 30 649 30 661 30 671 30 677 30 689 30 697 30 703 30 707 30 713 30 727 30 757 30 763 30 773 30 781 30 803 30 809 30 817 30 829 30 839 30 841 30 851 30 853 30 859 30 869 30 871 30 881 30 893 30 911 30 931 30 937 30 941 30 949 30 971 30 977 30 983 31 013 31 019 31 033 31 039 31 051 31 063 31 069 31 079 31 081 31 091 31 121 31 123 31 139 31 147 31 151 31 153 31 159 31 177 31 181 31 183 31 189 31 193 31 219 31 223 31 231 31 237 31 247 31 249 31 253 31 259 31 267 31 271 31 277 31 307 31 319 31 321 31 327 31 333 31 337 31 357 31 379 31 387 31 391 31 393 31 397 31 469 31 477 31 481 31 489 31 511 31 513 31 517 31 531 31 541 31 543 31 547 31 567 31 573 31 583 31 601 31 607 31 627 31 643 31 649 31 657 31 663 31 667 31 687 31 699 31 721 31 723 31 727 31 729 31 741 31 751 31 769 31 771 31 793 31 799 31 817 31 847 31 849 31 859 31 873 31 883 31 891 31 907 31 957 31 963 31 973 31 981 31 991 32 003 32 009 32 027 32 029 32 051 32 057 32 059 32 063 32 069 32 077 32 083 32 089 32 099 32 117 32 119 32 141 32 143 32 159 32 173 32 183 32 189 32 191 32 203 32 213 32 233 32 237 32 251 32 257 32 261 32 297 32 299 32 303 32 309 32 321 32 323 32 327 32 341 32 353 32 359 32 363 32 369 32 371 32 377 32 381 32 401 32 411 32 413 32 423 32 429 32 441 32 443 32 467 32 479 32 491 32 497 32 503 32 507 32 531 32 533 32 537 32 561 32 563 32 569 32 573 32 579 32 587 32 603 32 609 32 611 32 621 32 633 32 647 32 653 32 687 32 693 32 707 32 713 32 717 32 719 32 749 32 771 32 779 32 783 32 789 32 797 32 801 32 803 32 831 32 833 32 839 32 843 32 869 32 887 32 909 32 911 32 917 32 933 32 939 32 941 32 957 32 969 32 971 32 983 32 987 32 993 32 999 33 013 33 023 33 029 33 037 33 049 33 053 33 071 33 073 33 083 33 091 33 107 33 113 33 119 33 149 33 151 33 161 33 179 33 181 33 191 33 199 33 203 33 211 33 223 33 247 33 287 33 289 33 301 33 311 33 317 33 329 33 331 33 343 33 347 33 349 33 353 33 359 33 377 33 391 33 403 33 409 33 413 33 427 33 457 33 461 33 469 33 479 33 487 33 493 33 503 33 521 33 529 33 533 33 547 33 563 33 569 33 577 33 581 33 587 33 589 33 599 33 601 33 613 33 617 33 619 33 623 33 629 33 637 33 641 33 647 33 679 33 703 33 713 33 721 33 739 33 749 33 751 33 757 33 767 33 769 33 773 33 791 33 797 33 809 33 811 33 827 33 829 33 851 33 857 33 863 33 871 33 889 33 893 33 911 33 923 33 931 33 937 33 941 33 961 33 967 33 997 34 019 34 031 34 033 34 039 34 057 34 061 34 123 34 127 34 129 34 141 34 147 34 157 34 159 34 171 34 183 34 211 34 213 34 217 34 231 34 253 34 259 34 261 34 267 34 273 34 283 34 297 34 301 34 303 34 313 34 319 34 327 34 337 34 351 34 361 34 367 34 369 34 381 34 403 34 421 34 429 34 439 34 457 34 469 34 471 34 483 34 487 34 499 34 501 34 511 34 513 34 519 34 537 34 543 34 549 34 583 34 589 34 591 34 603 34 607 34 613 34 631 34 649 34 651 34 667 34 673 34 679 34 687 34 693 34 703 34 721 34 729 34 739 34 747 34 757 34 759 34 763 34 781 34 807 34 819 34 841 34 843 34 847 34 849 34 871 34 877 34 883 34 897 34 913 34 919 34 939 34 949 34 961 34 963 34 981 35 023 35 027 35 051 35 053 35 059 35 069 35 081 35 083 35 089 35 099 35 107 35 111 35 117 35 129 35 141 35 149 35 153 35 159 35 171 35 201 35 221 35 227 35 251 35 257 35 267 35 279 35 281 35 291 35 311 35 317 35 323 35 327 35 339 35 353 35 363 35 381 35 393 35 401 35 407 35 419 35 423 35 437 35 447 35 449 35 461 35 491 35 507 35 509 35 521 35 527 35 531 35 533 35 537 35 543 35 569 35 573 35 591 35 593 35 597 35 603 35 617 35 671 35 677 35 729 35 731 35 747 35 753 35 759 35 771 35 797 35 801 35 803 35 809 35 831 35 837 35 839 35 851 35 863 35 869 35 879 35 897 35 899 35 911 35 923 35 933 35 951 35 963 35 969 35 977 35 983 35 993 35 999 36 007 36 011 36 013 36 017 36 037 36 061 36 067 36 073 36 083 36 097 36 107 36 109 36 131 36 137 36 151 36 161 36 187 36 191 36 209 36 217 36 229 36 241 36 251 36 263 36 269 36 277 36 293 36 299 36 307 36 313 36 319 36 341 36 343 36 353 36 373 36 383 36 389 36 433 36 451 36 457 36 467 36 469 36 473 36 479 36 493 36 497 36 523 36 527 36 529 36 541 36 551 36 559 36 563 36 571 36 583 36 587 36 599 36 607 36 629 36 637 36 643 36 653 36 671 36 677 36 683 36 691 36 697 36 709 36 713 36 721 36 739 36 749 36 761 36 767 36 779 36 781 36 787 36 791 36 793 36 809 36 821 36 833 36 847 36 857 36 871 36 877 36 887 36 899 36 901 36 913 36 919 36 923 36 929 36 931 36 943 36 947 36 973 36 979 36 997 37 003 37 013 37 019 37 021 37 039 37 049 37 057 37 061 37 087 37 097 37 117 37 123 37 139 37 159 37 171 37 181 37 189 37 199 37 201 37 217 37 223 37 243 37 253 37 273 37 277 37 307 37 309 37 313 37 321 37 337 37 339 37 357 37 361 37 363 37 369 37 379 37 397 37 409 37 423 37 441 37 447 37 463 37 483 37 489 37 493 37 501 37 507 37 511 37 517 37 529 37 537 37 547 37 549 37 561 37 567 37 571 37 573 37 579 37 589 37 591 37 607 37 619 37 633 37 643 37 649 37 657 37 663 37 691 37 693 37 699 37 717 37 747 37 781 37 783 37 799 37 811 37 813 37 831 37 847 37 853 37 861 37 871 37 879 37 889 37 897 37 907 37 951 37 957 37 963 37 967 37 987 37 991 37 993 37 997 38 011 38 039 38 047 38 053 38 069 38 083 38 113 38 119 38 149 38 153 38 167 38 177 38 183 38 189 38 197 38 201 38 219 38 231 38 237 38 239 38 261 38 273 38 281 38 287 38 299 38 303 38 317 38 321 38 327 38 329 38 333 38 351 38 371 38 377 38 393 38 431 38 447 38 449 38 453 38 459 38 461 38 501 38 543 38 557 38 561 38 567 38 569 38 593 38 603 38 609 38 611 38 629 38 639 38 651 38 653 38 669 38 671 38 677 38 693 38 699 38 707 38 711 38 713 38 723 38 729 38 737 38 747 38 749 38 767 38 783 38 791 38 803 38 821 38 833 38 839 38 851 38 861 38 867 38 873 38 891 38 903 38 917 38 921 38 923 38 933 38 953 38 959 38 971 38 977 38 993 39 019 39 023 39 041 39 043 39 047 39 079 39 089 39 097 39 103 39 107 39 113 39 119 39 133 39 139 39 157 39 161 39 163 39 181 39 191 39 199 39 209 39 217 39 227 39 229 39 233 39 239 39 241 39 251 39 293 39 301 39 313 39 317 39 323 39 341 39 343 39 359 39 367 39 371 39 373 39 383 39 397 39 409 39 419 39 439 39 443 39 451 39 461 39 499 39 503 39 509 39 511 39 521 39 541 39 551 39 563 39 569 39 581 39 607 39 619 39 623 39 631 39 659 39 667 39 671 39 679 39 703 39 709 39 719 39 727 39 733 39 749 39 761 39 769 39 779 39 791 39 799 39 821 39 827 39 829 39 839 39 841 39 847 39 857 39 863 39 869 39 877 39 883 39 887 39 901 39 929 39 937 39 953 39 971 39 979 39 983 39 989

TOUS LES NOMBRES PREMIERS DE 40001 À 50000
40 009 40 013 40 031 40 037 40 039 40 063 40 087 40 093 40 099 40 111 40 123 40 127 40 129 40 151 40 153 40 163 40 169 40 177 40 189 40 193 40 213 40 231 40 237 40 241 40 253 40 277 40 283 40 289 40 343 40 351 40 357 40 361 40 387 40 423 40 427 40 429 40 433 40 459 40 471 40 483 40 487 40 493 40 499 40 507 40 519 40 529 40 531 40 543 40 559 40 577 40 583 40 591 40 597 40 609 40 627 40 637 40 639 40 693 40 697 40 699 40 709 40 739 40 751 40 759 40 763 40 771 40 787 40 801 40 813 40 819 40 823 40 829 40 841 40 847 40 849 40 853 40 867 40 879 40 883 40 897 40 903 40 927 40 933 40 939 40 949 40 961 40 973 40 993 41 011 41 017 41 023 41 039 41 047 41 051 41 057 41 077 41 081 41 113 41 117 41 131 41 141 41 143 41 149 41 161 41 177 41 179 41 183 41 189 41 201 41 203 41 213 41 221 41 227 41 231 41 233 41 243 41 257 41 263 41 269 41 281 41 299 41 333 41 341 41 351 41 357 41 381 41 387 41 389 41 399 41 411 41 413 41 443 41 453 41 467 41 479 41 491 41 507 41 513 41 519 41 521 41 539 41 543 41 549 41 579 41 593 41 597 41 603 41 609 41 611 41 617 41 621 41 627 41 641 41 647 41 651 41 659 41 669 41 681 41 687 41 719 41 729 41 737 41 759 41 761 41 771 41 777 41 801 41 809 41 813 41 843 41 849 41 851 41 863 41 879 41 887 41 893 41 897 41 903 41 911 41 927 41 941 41 947 41 953 41 957 41 959 41 969 41 981 41 983 41 999 42 013 42 017 42 019 42 023 42 043 42 061 42 071 42 073 42 083 42 089 42 101 42 131 42 139 42 157 42 169 42 179 42 181 42 187 42 193 42 197 42 209 42 221 42 223 42 227 42 239 42 257 42 281 42 283 42 293 42 299 42 307 42 323 42 331 42 337 42 349 42 359 42 373 42 379 42 391 42 397 42 403 42 407 42 409 42 433 42 437 42 443 42 451 42 457 42 461 42 463 42 467 42 473 42 487 42 491 42 499 42 509 42 533 42 557 42 569 42 571 42 577 42 589 42 611 42 641 42 643 42 649 42 667 42 677 42 683 42 689 42 697 42 701 42 703 42 709 42 719 42 727 42 737 42 743 42 751 42 767 42 773 42 787 42 793 42 797 42 821 42 829 42 839 42 841 42 853 42 859 42 863 42 899 42 901 42 923 42 929 42 937 42 943 42 953 42 961 42 967 42 979 42 989 43 003 43 013 43 019 43 037 43 049 43 051 43 063 43 067 43 093 43 103 43 117 43 133 43 151 43 159 43 177 43 189 43 201 43 207 43 223 43 237 43 261 43 271 43 283 43 291 43 313 43 319 43 321 43 331 43 391 43 397 43 399 43 403 43 411 43 427 43 441 43 451 43 457 43 481 43 487 43 499 43 517 43 541 43 543 43 573 43 577 43 579 43 591 43 597 43 607 43 609 43 613 43 627 43 633 43 649 43 651 43 661 43 669 43 691 43 711 43 717 43 721 43 753 43 759 43 777 43 781 43 783 43 787 43 789 43 793 43 801 43 853 43 867 43 889 43 891 43 913 43 933 43 943 43 951 43 961 43 963 43 969 43 973 43 987 43 991 43 997 44 017 44 021 44 027 44 029 44 041 44 053 44 059 44 071 44 087 44 089 44 101 44 111 44 119 44 123 44 129 44 131 44 159 44 171 44 179 44 189 44 201 44 203 44 207 44 221 44 249 44 257 44 263 44 267 44 269 44 273 44 279 44 281 44 293 44 351 44 357 44 371 44 381 44 383 44 389 44 417 44 449 44 453 44 483 44 491 44 497 44 501 44 507 44 519 44 531 44 533 44 537 44 543 44 549 44 563 44 579 44 587 44 617 44 621 44 623 44 633 44 641 44 647 44 651 44 657 44 683 44 687 44 699 44 701 44 711 44 729 44 741 44 753 44 771 44 773 44 777 44 789 44 797 44 809 44 819 44 839 44 843 44 851 44 867 44 879 44 887 44 893 44 909 44 917 44 927 44 939 44 953 44 959 44 963 44 971 44 983 44 987 45 007 45 013 45 053 45 061 45 077 45 083 45 119 45 121 45 127 45 131 45 137 45 139 45 161 45 179 45 181 45 191 45 197 45 233 45 247 45 259 45 263 45 281 45 289 45 293 45 307 45 317 45 319 45 329 45 337 45 341 45 343 45 361 45 377 45 389 45 403 45 413 45 427 45 433 45 439 45 481 45 491 45 497 45 503 45 523 45 533 45 541 45 553 45 557 45 569 45 587 45 589 45 599 45 613 45 631 45 641 45 659 45 667 45 673 45 677 45 691 45 697 45 707 45 737 45 751 45 757 45 763 45 767 45 779 45 817 45 821 45 823 45 827 45 833 45 841 45 853 45 863 45 869 45 887 45 893 45 943 45 949 45 953 45 959 45 971 45 979 45 989 46 021 46 027 46 049 46 051 46 061 46 073 46 091 46 093 46 099 46 103 46 133 46 141 46 147 46 153 46 171 46 181 46 183 46 187 46 199 46 219 46 229 46 237 46 261 46 271 46 273 46 279 46 301 46 307 46 309 46 327 46 337 46 349 46 351 46 381 46 399 46 411 46 439 46 441 46 447 46 451 46 457 46 471 46 477 46 489 46 499 46 507 46 511 46 523 46 549 46 559 46 567 46 573 46 589 46 591 46 601 46 619 46 633 46 639 46 643 46 649 46 663 46 679 46 681 46 687 46 691 46 703 46 723 46 727 46 747 46 751 46 757 46 769 46 771 46 807 46 811 46 817 46 819 46 829 46 831 46 853 46 861 46 867 46 877 46 889 46 901 46 919 46 933 46 957 46 993 46 997 47 017 47 041 47 051 47 057 47 059 47 087 47 093 47 111 47 119 47 123 47 129 47 137 47 143 47 147 47 149 47 161 47 189 47 207 47 221 47 237 47 251 47 269 47 279 47 287 47 293 47 297 47 303 47 309 47 317 47 339 47 351 47 353 47 363 47 381 47 387 47 389 47 407 47 417 47 419 47 431 47 441 47 459 47 491 47 497 47 501 47 507 47 513 47 521 47 527 47 533 47 543 47 563 47 569 47 581 47 591 47 599 47 609 47 623 47 629 47 639 47 653 47 657 47 659 47 681 47 699 47 701 47 711 47 713 47 717 47 737 47 741 47 743 47 777 47 779 47 791 47 797 47 807 47 809 47 819 47 837 47 843 47 857 47 869 47 881 47 903 47 911 47 917 47 933 47 939 47 947 47 951 47 963 47 969 47 977 47 981 48 017 48 023 48 029 48 049 48 073 48 079 48 091 48 109 48 119 48 121 48 131 48 157 48 163 48 179 48 187 48 193 48 197 48 221 48 239 48 247 48 259 48 271 48 281 48 299 48 311 48 313 48 337 48 341 48 353 48 371 48 383 48 397 48 407 48 409 48 413 48 437 48 449 48 463 48 473 48 479 48 481 48 487 48 491 48 497 48 523 48 527 48 533 48 539 48 541 48 563 48 571 48 589 48 593 48 611 48 619 48 623 48 647 48 649 48 661 48 673 48 677 48 679 48 731 48 733 48 751 48 757 48 761 48 767 48 779 48 781 48 787 48 799 48 809 48 817 48 821 48 823 48 847 48 857 48 859 48 869 48 871 48 883 48 889 48 907 48 947 48 953 48 973 48 989 48 991 49 003 49 009 49 019 49 031 49 033 49 037 49 043 49 057 49 069 49 081 49 103 49 109 49 117 49 121 49 123 49 139 49 157 49 169 49 171 49 177 49 193 49 199 49 201 49 207 49 211 49 223 49 253 49 261 49 277 49 279 49 297 49 307 49 331 49 333 49 339 49 363 49 367 49 369 49 391 49 393 49 409 49 411 49 417 49 429 49 433 49 451 49 459 49 463 49 477 49 481 49 499 49 523 49 529 49 531 49 537 49 547 49 549 49 559 49 597 49 603 49 613 49 627 49 633 49 639 49 663 49 667 49 669 49 681 49 697 49 711 49 727 49 739 49 741 49 747 49 757 49 783 49 787 49 789 49 801 49 807 49 811 49 823 49 831 49 843 49 853 49 871 49 877 49 891 49 919 49 921 49 927 49 937 49 939 49 943 49 957 49 991 49 993 49 999 

     * */

    [TestMethod]
    public void TestMethod_IsPrime_Int_MaxValue()
    {
      const int source = 2147483647;
      const bool expected = true;
      bool result = FunctionsMath.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    #endregion
    #region GetListOfPrime
    [TestMethod]
    public void TestMethod_GetListOfPrime_4_numbers()
    {
      const int source1 = 2;
      const int source2 = 10;
      var expected = new List<int> { 2, 3, 5, 7 };
      List<int> result = FunctionsMath.GetListOfPrime(source1, source2 - source1);
      AssertListsAreSimilar(result, expected);
      //CollectionAssert.AreNotEqual(result, expected);
      result.Sort();
      CollectionAssert.AreEqual(result, expected);
      CollectionAssert.AreEquivalent(result, expected);
      CollectionAssert.AllItemsAreNotNull(result);
      CollectionAssert.AllItemsAreUnique(result);
      CollectionAssert.AreEquivalent(result, expected);
      CollectionAssert.AllItemsAreInstancesOfType(result, typeof(int));
    }

    [TestMethod]
    public void TestMethod_GetListOfPrime_none()
    {
      const int source1 = 32;
      const int source2 = 5;
      var expected = new List<int>();
      List<int> result = FunctionsMath.GetListOfPrime(source1, source2);
      AssertListsAreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetListOfPrime_until_100()
    {
      const int source1 = 2;
      const int source2 = 100;
      var expected = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
      List<int> result = FunctionsMath.GetListOfPrime(source1, source2 - source1);
      AssertListsAreSimilar(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetListOfPrime_until_127()
    {
      const int source1 = 2;
      const int source2 = 127;
      var expected = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127 };
      List<int> result = FunctionsMath.GetListOfPrime(source1, source2);
      AssertListsAreSimilar(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetListOfPrime_until_7919()
    {
      const int source1 = 2;
      const int source2 = 7919;
      var expected = new List<int>
      {
        2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97,
        101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193,
        197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307,
        311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421,
        431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547,
        557, 563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659,
        661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797,
        809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, 929,
        937, 941, 947, 953, 967, 971, 977, 983, 991, 997, 1009, 1013, 1019, 1021, 1031, 1033, 1039,
        1049, 1051, 1061, 1063, 1069, 1087, 1091, 1093, 1097, 1103, 1109, 1117, 1123, 1129, 1151,
        1153, 1163, 1171, 1181, 1187, 1193, 1201, 1213, 1217, 1223, 1229, 1231, 1237, 1249, 1259,
        1277, 1279, 1283, 1289, 1291, 1297, 1301, 1303, 1307, 1319, 1321, 1327, 1361, 1367, 1373,
        1381, 1399, 1409, 1423, 1427, 1429, 1433, 1439, 1447, 1451, 1453, 1459, 1471, 1481, 1483,
        1487, 1489, 1493, 1499, 1511, 1523, 1531, 1543, 1549, 1553, 1559, 1567, 1571, 1579, 1583,
        1597, 1601, 1607, 1609, 1613, 1619, 1621, 1627, 1637, 1657, 1663, 1667, 1669, 1693, 1697,
        1699, 1709, 1721, 1723, 1733, 1741, 1747, 1753, 1759, 1777, 1783, 1787, 1789, 1801, 1811,
        1823, 1831, 1847, 1861, 1867, 1871, 1873, 1877, 1879, 1889, 1901, 1907, 1913, 1931, 1933,
        1949, 1951, 1973, 1979, 1987, 1993, 1997, 1999, 2003, 2011, 2017, 2027, 2029, 2039, 2053,
        2063, 2069, 2081, 2083, 2087, 2089, 2099, 2111, 2113, 2129, 2131, 2137, 2141, 2143, 2153,
        2161, 2179, 2203, 2207, 2213, 2221, 2237, 2239, 2243, 2251, 2267, 2269, 2273, 2281, 2287,
        2293, 2297, 2309, 2311, 2333, 2339, 2341, 2347, 2351, 2357, 2371, 2377, 2381, 2383, 2389,
        2393, 2399, 2411, 2417, 2423, 2437, 2441, 2447, 2459, 2467, 2473, 2477, 2503, 2521, 2531,
        2539, 2543, 2549, 2551, 2557, 2579, 2591, 2593, 2609, 2617, 2621, 2633, 2647, 2657, 2659,
        2663, 2671, 2677, 2683, 2687, 2689, 2693, 2699, 2707, 2711, 2713, 2719, 2729, 2731, 2741,
        2749, 2753, 2767, 2777, 2789, 2791, 2797, 2801, 2803, 2819, 2833, 2837, 2843, 2851, 2857,
        2861, 2879, 2887, 2897, 2903, 2909, 2917, 2927, 2939, 2953, 2957, 2963, 2969, 2971, 2999,
        3001, 3011, 3019, 3023, 3037, 3041, 3049, 3061, 3067, 3079, 3083, 3089, 3109, 3119, 3121,
        3137, 3163, 3167, 3169, 3181, 3187, 3191, 3203, 3209, 3217, 3221, 3229, 3251, 3253, 3257,
        3259, 3271, 3299, 3301, 3307, 3313, 3319, 3323, 3329, 3331, 3343, 3347, 3359, 3361, 3371,
        3373, 3389, 3391, 3407, 3413, 3433, 3449, 3457, 3461, 3463, 3467, 3469, 3491, 3499, 3511,
        3517, 3527, 3529, 3533, 3539, 3541, 3547, 3557, 3559, 3571, 3581, 3583, 3593, 3607, 3613,
        3617, 3623, 3631, 3637, 3643, 3659, 3671, 3673, 3677, 3691, 3697, 3701, 3709, 3719, 3727,
        3733, 3739, 3761, 3767, 3769, 3779, 3793, 3797, 3803, 3821, 3823, 3833, 3847, 3851, 3853,
        3863, 3877, 3881, 3889, 3907, 3911, 3917, 3919, 3923, 3929, 3931, 3943, 3947, 3967, 3989,
        4001, 4003, 4007, 4013, 4019, 4021, 4027, 4049, 4051, 4057, 4073, 4079, 4091, 4093, 4099,
        4111, 4127, 4129, 4133, 4139, 4153, 4157, 4159, 4177, 4201, 4211, 4217, 4219, 4229, 4231,
        4241, 4243, 4253, 4259, 4261, 4271, 4273, 4283, 4289, 4297, 4327, 4337, 4339, 4349, 4357,
        4363, 4373, 4391, 4397, 4409, 4421, 4423, 4441, 4447, 4451, 4457, 4463, 4481, 4483, 4493,
        4507, 4513, 4517, 4519, 4523, 4547, 4549, 4561, 4567, 4583, 4591, 4597, 4603, 4621, 4637,
        4639, 4643, 4649, 4651, 4657, 4663, 4673, 4679, 4691, 4703, 4721, 4723, 4729, 4733, 4751,
        4759, 4783, 4787, 4789, 4793, 4799, 4801, 4813, 4817, 4831, 4861, 4871, 4877, 4889, 4903,
        4909, 4919, 4931, 4933, 4937, 4943, 4951, 4957, 4967, 4969, 4973, 4987, 4993, 4999, 5003,
        5009, 5011, 5021, 5023, 5039, 5051, 5059, 5077, 5081, 5087, 5099, 5101, 5107, 5113, 5119,
        5147, 5153, 5167, 5171, 5179, 5189, 5197, 5209, 5227, 5231, 5233, 5237, 5261, 5273, 5279,
        5281, 5297, 5303, 5309, 5323, 5333, 5347, 5351, 5381, 5387, 5393, 5399, 5407, 5413, 5417,
        5419, 5431, 5437, 5441, 5443, 5449, 5471, 5477, 5479, 5483, 5501, 5503, 5507, 5519, 5521,
        5527, 5531, 5557, 5563, 5569, 5573, 5581, 5591, 5623, 5639, 5641, 5647, 5651, 5653, 5657,
        5659, 5669, 5683, 5689, 5693, 5701, 5711, 5717, 5737, 5741, 5743, 5749, 5779, 5783, 5791,
        5801, 5807, 5813, 5821, 5827, 5839, 5843, 5849, 5851, 5857, 5861, 5867, 5869, 5879, 5881,
        5897, 5903, 5923, 5927, 5939, 5953, 5981, 5987, 6007, 6011, 6029, 6037, 6043, 6047, 6053,
        6067, 6073, 6079, 6089, 6091, 6101, 6113, 6121, 6131, 6133, 6143, 6151, 6163, 6173, 6197,
        6199, 6203, 6211, 6217, 6221, 6229, 6247, 6257, 6263, 6269, 6271, 6277, 6287, 6299, 6301,
        6311, 6317, 6323, 6329, 6337, 6343, 6353, 6359, 6361, 6367, 6373, 6379, 6389, 6397, 6421,
        6427, 6449, 6451, 6469, 6473, 6481, 6491, 6521, 6529, 6547, 6551, 6553, 6563, 6569, 6571,
        6577, 6581, 6599, 6607, 6619, 6637, 6653, 6659, 6661, 6673, 6679, 6689, 6691, 6701, 6703,
        6709, 6719, 6733, 6737, 6761, 6763, 6779, 6781, 6791, 6793, 6803, 6823, 6827, 6829, 6833,
        6841, 6857, 6863, 6869, 6871, 6883, 6899, 6907, 6911, 6917, 6947, 6949, 6959, 6961, 6967,
        6971, 6977, 6983, 6991, 6997, 7001, 7013, 7019, 7027, 7039, 7043, 7057, 7069, 7079, 7103,
        7109, 7121, 7127, 7129, 7151, 7159, 7177, 7187, 7193, 7207, 7211, 7213, 7219, 7229, 7237,
        7243, 7247, 7253, 7283, 7297, 7307, 7309, 7321, 7331, 7333, 7349, 7351, 7369, 7393, 7411,
        7417, 7433, 7451, 7457, 7459, 7477, 7481, 7487, 7489, 7499, 7507, 7517, 7523, 7529, 7537,
        7541, 7547, 7549, 7559, 7561, 7573, 7577, 7583, 7589, 7591, 7603, 7607, 7621, 7639, 7643,
        7649, 7669, 7673, 7681, 7687, 7691, 7699, 7703, 7717, 7723, 7727, 7741, 7753, 7757, 7759,
        7789, 7793, 7817, 7823, 7829, 7841, 7853, 7867, 7873, 7877, 7879, 7883, 7901, 7907, 7919
      };

      List<int> result = FunctionsMath.GetListOfPrime(source1, source2);
      AssertListsAreSimilar(result, expected);
    }

    private static void AssertListsAreEqual(IReadOnlyList<int> result, IReadOnlyList<int> expected)
    {
      Assert.AreEqual(result.Count, expected.Count);
      for (int i = 0; i < result.Count; i++)
      {
        Assert.AreEqual(result[i], expected[i]);
      }
    }

    private static void AssertListsAreSimilar(IReadOnlyCollection<int> result, ICollection<int> expected)
    {
      // similar because of a Parallel loop
      Assert.AreEqual(result.Count, expected.Count);
      foreach (int item in result)
      {
        Assert.IsTrue(expected.Contains(item));
      }
    }

    #endregion
    #region PrimeByFormula
    [TestMethod]
    public void TestMethod_PrimeByFormula_0()
    {
      const ushort source = 0;
      const int expected = 41;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_1()
    {
      const ushort source = 1;
      const int expected = 41;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_2()
    {
      const ushort source = 2;
      const int expected = 43;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_3()
    {
      const ushort source = 3;
      const int expected = 47;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_4()
    {
      const ushort source = 4;
      const int expected = 53;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_5()
    {
      const ushort source = 5;
      const int expected = 61;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_6()
    {
      const ushort source = 6;
      const int expected = 71;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_7()
    {
      const ushort source = 7;
      const int expected = 83;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_8()
    {
      const ushort source = 8;
      const int expected = 97;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_9()
    {
      const ushort source = 9;
      const int expected = 113;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_10()
    {
      const ushort source = 10;
      const int expected = 131;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_11()
    {
      const ushort source = 11;
      const int expected = 151;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_12()
    {
      const ushort source = 12;
      const int expected = 173;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_13()
    {
      const ushort source = 13;
      const int expected = 197;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_14()
    {
      const ushort source = 14;
      const int expected = 223;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_15()
    {
      const ushort source = 15;
      const int expected = 251;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_16()
    {
      const ushort source = 16;
      const int expected = 281;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_17()
    {
      const ushort source = 17;
      const int expected = 313;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_18()
    {
      const ushort source = 18;
      const int expected = 347;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_19()
    {
      const ushort source = 19;
      const int expected = 383;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_20()
    {
      const ushort source = 20;
      const int expected = 421;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_21()
    {
      const ushort source = 21;
      const int expected = 461;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_22()
    {
      const ushort source = 22;
      const int expected = 503;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_23()
    {
      const ushort source = 23;
      const int expected = 547;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_24()
    {
      const ushort source = 24;
      const int expected = 593;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_25()
    {
      const ushort source = 25;
      const int expected = 641;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_26()
    {
      const ushort source = 26;
      const int expected = 691;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_27()
    {
      const ushort source = 27;
      const int expected = 743;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_28()
    {
      const ushort source = 28;
      const int expected = 797;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_29()
    {
      const ushort source = 29;
      const int expected = 853;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_30()
    {
      const ushort source = 30;
      const int expected = 911;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_31()
    {
      const ushort source = 31;
      const int expected = 971;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_32()
    {
      const ushort source = 32;
      const int expected = 1033;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_33()
    {
      const ushort source = 33;
      const int expected = 1097;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_34()
    {
      const ushort source = 34;
      const int expected = 1163;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_35()
    {
      const ushort source = 35;
      const int expected = 1231;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_36()
    {
      const ushort source = 36;
      const int expected = 1301;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_37()
    {
      const ushort source = 37;
      const int expected = 1373;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_38()
    {
      const ushort source = 38;
      const int expected = 1447;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_39()
    {
      const ushort source = 39;
      const int expected = 1523;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_PrimeByFormula_value_40()
    {
      const ushort source = 40;
      const int expected = 1601;
      int result = FunctionsMath.PrimeByFormula(source);
      Assert.AreEqual(result, expected);
    }

    #endregion PrimeByFormula
    #endregion Math Methods

    #region Unit Test Helper methods
    public static void AssertAreEqualList(List<int> result, List<int> expected)
    {
      Assert.AreEqual(result.Count, expected.Count);
      for (int i = 0; i < expected.Count; i++)
      {
        Assert.AreEqual(result[i], expected[i]);
      }
    }
    #endregion Unit Test Helper methods

  }
}
