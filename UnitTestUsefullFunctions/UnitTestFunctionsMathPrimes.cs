﻿using System.Collections.Generic;
using FonctionsUtiles.Fred.Csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

    /*  Add unit test
    De 601 à 700:
    601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691
    De 701 à 800:
    701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797
    De 801 à 900:
    809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887
    De 901 à 1000:
    907, 911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997
    */

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