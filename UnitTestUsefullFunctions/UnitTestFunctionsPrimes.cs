using FonctionsUtiles.Fred.Csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestFunctionsPrimes
  {
    [TestMethod]
    public void TestMethod_BigInteger_substring()
    {
      //number.ToString().Substring(number.ToString().Length - 1, 1) != "7"
      string source = "12345678901234567897";
      string expected = "7";
      string result = source.Substring(source.Length - 1, 1);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_GetPrimesBefore_18()
    {
      const int source = 18;
      List<int> expected = new List<int> { 2, 3, 5, 7, 11, 13, 17 };
      List<int> result = FunctionsPrimes.GetPrimesBefore(source);
      Assert.IsTrue(AssertListAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_NumberOfPrimeUnder_2()
    {
      const int source = 2;
      int expected = 1;
      int result = FunctionsPrimes.NumberOfPrimeUnder(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfPrimeUnder_3()
    {
      const int source = 3;
      int expected = 2;
      int result = FunctionsPrimes.NumberOfPrimeUnder(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfPrimeUnder_5()
    {
      const int source = 5;
      int expected = 3;
      int result = FunctionsPrimes.NumberOfPrimeUnder(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfPrimeUnder_7()
    {
      const int source = 7;
      int expected = 4;
      int result = FunctionsPrimes.NumberOfPrimeUnder(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfPrimeUnder_11()
    {
      const int source = 11;
      int expected = 5;
      int result = FunctionsPrimes.NumberOfPrimeUnder(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NumberOfPrimesByHundred_100()
    {
      const int source = 100;
      Dictionary<int, int> expected = new Dictionary<int, int> { { 100, 25 } };
      Dictionary<int, int> result = FunctionsPrimes.NumberOfPrimesByHundred(source);
      Assert.IsTrue(AssertDictionaryAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_NumberOfPrimesByHundred_200()
    {
      const int source = 200;
      Dictionary<int, int> expected = new Dictionary<int, int> { { 100, 25 }, { 200, 21 } };
      Dictionary<int, int> result = FunctionsPrimes.NumberOfPrimesByHundred(source);
      Assert.IsTrue(AssertDictionaryAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_NumberOfPrimesByHundred_300()
    {
      const int source = 300;
      Dictionary<int, int> expected = new Dictionary<int, int> { { 100, 25 }, { 200, 21 }, { 300, 16 } };
      Dictionary<int, int> result = FunctionsPrimes.NumberOfPrimesByHundred(source);
      Assert.IsTrue(AssertDictionaryAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_NumberOfPrimesByHundred_400()
    {
      const int source = 400;
      Dictionary<int, int> expected = new Dictionary<int, int> { { 100, 25 }, { 200, 21 }, { 300, 16 }, { 400, 16 } };
      Dictionary<int, int> result = FunctionsPrimes.NumberOfPrimesByHundred(source);
      Assert.IsTrue(AssertDictionaryAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_NumberOfPrimesByHundred_500()
    {
      const int source = 500;
      Dictionary<int, int> expected = new Dictionary<int, int> { { 100, 25 }, { 200, 21 }, { 300, 16 }, { 400, 16 }, { 500, 17 } };
      Dictionary<int, int> result = FunctionsPrimes.NumberOfPrimesByHundred(source);
      Assert.IsTrue(AssertDictionaryAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_NumberOfPrimesByHundred_600()
    {
      const int source = 600;
      Dictionary<int, int> expected = new Dictionary<int, int> { { 100, 25 }, { 200, 21 }, { 300, 16 }, { 400, 16 }, { 500, 17 }, { 600, 14 } };
      Dictionary<int, int> result = FunctionsPrimes.NumberOfPrimesByHundred(source);
      Assert.IsTrue(AssertDictionaryAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_NumberOfPrimesByHundred_700()
    {
      const int source = 700;
      Dictionary<int, int> expected = new Dictionary<int, int> { { 100, 25 }, { 200, 21 }, { 300, 16 }, { 400, 16 }, { 500, 17 }, { 600, 14 }, { 700, 16 } };
      Dictionary<int, int> result = FunctionsPrimes.NumberOfPrimesByHundred(source);
      Assert.IsTrue(AssertDictionaryAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_NumberOfPrimesByHundred_800()
    {
      const int source = 800;
      Dictionary<int, int> expected = new Dictionary<int, int> { { 100, 25 }, { 200, 21 }, { 300, 16 }, { 400, 16 }, { 500, 17 }, { 600, 14 }, { 700, 16 }, { 800, 14 } };
      Dictionary<int, int> result = FunctionsPrimes.NumberOfPrimesByHundred(source);
      Assert.IsTrue(AssertDictionaryAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_NumberOfPrimesByHundred_900()
    {
      const int source = 900;
      Dictionary<int, int> expected = new Dictionary<int, int> { { 100, 25 }, { 200, 21 }, { 300, 16 }, { 400, 16 }, { 500, 17 }, { 600, 14 }, { 700, 16 }, { 800, 14 }, { 900, 15 } };
      Dictionary<int, int> result = FunctionsPrimes.NumberOfPrimesByHundred(source);
      Assert.IsTrue(AssertDictionaryAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_TwinPrime()
    {
      const int source = 500;
      List<int> expected = new List<int> { 2,
          11,
          17,
          41,
          71,
          101,
          107,
          197,
          227,
          281,
          311,
          431,
          461 };
      List<int> result = FunctionsPrimes.GetTwinPrimeBefore(source);
      AssertListAreEqualed(result, expected);
    }

    public bool AssertDictionaryAreEqualed(Dictionary<int, int> source, Dictionary<int, int> target)
    {
      bool result = true;
      if (source.Count != target.Count)
      {
        return false;
      }

      foreach (var key in source.Keys)
      {
        if (!source[key].Equals(target[key]))
        {
          result = false;
          break;
        }
      }

      return result;
    }

    [TestMethod]
    public void TestMethod_GetAbsoluteValues()
    {
      Dictionary<int, int> source = FunctionsPrimes.GetAbsoluteValues();
    }

    public static bool AssertListAreEqualed(List<int> source, List<int> target)
    {
      bool result = true;
      if (source.Count != target.Count)
      {
        return false;
      }

      for (int i = 0; i < source.Count; i++)
      {
        if (source[i] != target[i])
        {
          result = false;
          break;
        }
      }

      return result;
    }

    [TestMethod]
    public void TestMethod_Pi_0()
    {
      const int source = 0;
      const int expected = 0;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_1()
    {
      const int source = 1;
      const int expected = 0;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_2()
    {
      const int source = 2;
      const int expected = 1;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_3()
    {
      const int source = 3;
      const int expected = 2;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_4()
    {
      const int source = 4;
      const int expected = 2;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_5()
    {
      const int source = 5;
      const int expected = 3;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_7()
    {
      const int source = 7;
      const int expected = 4;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_11()
    {
      const int source = 11;
      const int expected = 5;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_13()
    {
      const int source = 13;
      const int expected = 6;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_17()
    {
      const int source = 17;
      const int expected = 7;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_19()
    {
      const int source = 19;
      const int expected = 8;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_23()
    {
      const int source = 23;
      const int expected = 9;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_29()
    {
      const int source = 29;
      const int expected = 10;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_31()
    {
      const int source = 31;
      const int expected = 11;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_37()
    {
      const int source = 37;
      const int expected = 12;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_Pi_41()
    {
      const int source = 41;
      const int expected = 13;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_43()
    {
      const int source = 43;
      const int expected = 14;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_47()
    {
      const int source = 47;
      const int expected = 15;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_53()
    {
      const int source = 53;
      const int expected = 16;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_59()
    {
      const int source = 59;
      const int expected = 17;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_61()
    {
      const int source = 61;
      const int expected = 18;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_67()
    {
      const int source = 67;
      const int expected = 19;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_71()
    {
      const int source = 71;
      const int expected = 20;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_73()
    {
      const int source = 73;
      const int expected = 21;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_79()
    {
      const int source = 79;
      const int expected = 22;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_83()
    {
      const int source = 83;
      const int expected = 23;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_89()
    {
      const int source = 89;
      const int expected = 24;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_97()
    {
      const int source = 97;
      const int expected = 25;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_101()
    {
      const int source = 101;
      const int expected = 26;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_103()
    {
      const int source = 103;
      const int expected = 27;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_107()
    {
      const int source = 107;
      const int expected = 28;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_109()
    {
      const int source = 109;
      const int expected = 29;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_113()
    {
      const int source = 113;
      const int expected = 30;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_121()
    {
      const int source = 121; // 121 = 11 X 11
      const int expected = 30;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_127()
    {
      const int source = 127;
      const int expected = 31;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_131()
    {
      const int source = 131;
      const int expected = 32;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_137()
    {
      const int source = 137;
      const int expected = 33;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_139()
    {
      const int source = 139;
      const int expected = 34;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_149()
    {
      const int source = 149;
      const int expected = 35;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_151()
    {
      const int source = 151;
      const int expected = 36;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_157()
    {
      const int source = 157;
      const int expected = 37;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_163()
    {
      const int source = 163;
      const int expected = 38;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_167()
    {
      const int source = 167;
      const int expected = 39;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_173()
    {
      const int source = 173;
      const int expected = 40;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_179()
    {
      const int source = 179;
      const int expected = 41;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_181()
    {
      const int source = 181;
      const int expected = 42;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_191()
    {
      const int source = 191;
      const int expected = 43;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_193()
    {
      const int source = 193;
      const int expected = 44;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_197()
    {
      const int source = 197;
      const int expected = 45;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_199()
    {
      const int source = 199;
      const int expected = 46;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_211()
    {
      const int source = 211;
      const int expected = 47;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrimeTriplet_197()
    {
      const int source = 197;
      const bool expected = false;
      bool result = FunctionsPrimes.IsPrimeTriplet(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_SquareRoot_Of_big_Integer_197()
    {
      const int source = 197;
      BigInteger squareRoot = BigInteger.Pow(source, (int)BigInteger.Log(source));
      const bool expected = true;
      bool result = squareRoot * squareRoot >= source;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_SquareRoot_Of_big_Integer_int_max_value()
    {
      const int source = int.MaxValue;
      BigInteger squareRoot = BigInteger.Pow(source, (int)BigInteger.Log(source));
      const bool expected = true;
      bool result = squareRoot * squareRoot >= source;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_calculation_of_SquareRoot_Of_big_Integer_using_math_exp()
    {
      BigInteger source = int.MaxValue;
      BigInteger squareRoot = (BigInteger)Math.Pow(Math.E, BigInteger.Log(source) / 2);
      const bool expected = true;
      bool result = (squareRoot + 1) * (squareRoot + 1) >= source;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_223()
    {
      const int source = 223;
      const int expected = 48;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_227()
    {
      const int source = 227;
      const int expected = 49;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_229()
    {
      const int source = 229;
      const int expected = 50;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_233()
    {
      const int source = 233;
      const int expected = 51;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_239()
    {
      const int source = 239;
      const int expected = 52;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_241()
    {
      const int source = 241;
      const int expected = 53;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_251()
    {
      const int source = 251;
      const int expected = 54;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_257()
    {
      const int source = 257;
      const int expected = 55;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_263()
    {
      const int source = 263;
      const int expected = 56;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_269()
    {
      const int source = 269;
      const int expected = 57;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_271()
    {
      const int source = 271;
      const int expected = 58;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_277()
    {
      const int source = 277;
      const int expected = 59;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_281()
    {
      const int source = 281;
      const int expected = 60;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_283()
    {
      const int source = 283;
      const int expected = 61;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_293()
    {
      const int source = 293;
      const int expected = 62;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_307()
    {
      const int source = 307;
      const int expected = 63;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_311()
    {
      const int source = 311;
      const int expected = 64;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Pi_313()
    {
      const int source = 313;
      const int expected = 65;
      int result = FunctionsPrimes.Pi(source);
      Assert.AreEqual(result, expected);
    }

    /* Primes between 2 and 4000
      2      3      5      7     11     13     17     19     23     29 
     31     37     41     43     47     53     59     61     67     71 
     73     79     83     89     97    101    103    107    109    113 
    127    131    137    139    149    151    157    163    167    173 
    179    181    191    193    197    199    211    223    227    229 
    233    239    241    251    257    263    269    271    277    281 
    283    293    307    311    313    317    331    337    347    349 
    353    359    367    373    379    383    389    397    401    409 
    419    421    431    433    439    443    449    457    461    463 
    467    479    487    491    499    503    509    521    523    541 
    547    557    563    569    571    577    587    593    599    601 
    607    613    617    619    631    641    643    647    653    659 
    661    673    677    683    691    701    709    719    727    733 
    739    743    751    757    761    769    773    787    797    809 
    811    821    823    827    829    839    853    857    859    863 
    877    881    883    887    907    911    919    929    937    941 
    947    953    967    971    977    983    991    997   1009   1013 
   1019   1021   1031   1033   1039   1049   1051   1061   1063   1069 
   1087   1091   1093   1097   1103   1109   1117   1123   1129   1151 
   1153   1163   1171   1181   1187   1193   1201   1213   1217   1223 
   1229   1231   1237   1249   1259   1277   1279   1283   1289   1291 
   1297   1301   1303   1307   1319   1321   1327   1361   1367   1373 
   1381   1399   1409   1423   1427   1429   1433   1439   1447   1451 
   1453   1459   1471   1481   1483   1487   1489   1493   1499   1511 
   1523   1531   1543   1549   1553   1559   1567   1571   1579   1583 
   1597   1601   1607   1609   1613   1619   1621   1627   1637   1657 
   1663   1667   1669   1693   1697   1699   1709   1721   1723   1733 
   1741   1747   1753   1759   1777   1783   1787   1789   1801   1811 
   1823   1831   1847   1861   1867   1871   1873   1877   1879   1889 
   1901   1907   1913   1931   1933   1949   1951   1973   1979   1987 
   1993   1997   1999   2003   2011   2017   2027   2029   2039   2053 
   2063   2069   2081   2083   2087   2089   2099   2111   2113   2129 
   2131   2137   2141   2143   2153   2161   2179   2203   2207   2213 
   2221   2237   2239   2243   2251   2267   2269   2273   2281   2287 
   2293   2297   2309   2311   2333   2339   2341   2347   2351   2357 
   2371   2377   2381   2383   2389   2393   2399   2411   2417   2423 
   2437   2441   2447   2459   2467   2473   2477   2503   2521   2531 
   2539   2543   2549   2551   2557   2579   2591   2593   2609   2617 
   2621   2633   2647   2657   2659   2663   2671   2677   2683   2687 
   2689   2693   2699   2707   2711   2713   2719   2729   2731   2741 
   2749   2753   2767   2777   2789   2791   2797   2801   2803   2819 
   2833   2837   2843   2851   2857   2861   2879   2887   2897   2903 
   2909   2917   2927   2939   2953   2957   2963   2969   2971   2999 
   3001   3011   3019   3023   3037   3041   3049   3061   3067   3079 
   3083   3089   3109   3119   3121   3137   3163   3167   3169   3181 
   3187   3191   3203   3209   3217   3221   3229   3251   3253   3257 
   3259   3271   3299   3301   3307   3313   3319   3323   3329   3331 
   3343   3347   3359   3361   3371   3373   3389   3391   3407   3413 
   3433   3449   3457   3461   3463   3467   3469   3491   3499   3511 
   3517   3527   3529   3533   3539   3541   3547   3557   3559   3571 
   3581   3583   3593   3607   3613   3617   3623   3631   3637   3643 
   3659   3671   3673   3677   3691   3697   3701   3709   3719   3727 
   3733   3739   3761   3767   3769   3779   3793   3797   3803   3821 
   3823   3833   3847   3851   3853   3863   3877   3881   3889   3907 
   3911   3917   3919   3923   3929   3931   3943   3947   3967   3989
     * */

  }
}
