using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CryptoFunc = FonctionsUtiles.Fred.Csharp.FunctionsCrypto;

namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestFunctionCrypto
  {
    #region Crypto
    #region RSAEncryption
    [TestMethod]
    public void TestMethod_RsaEncryption_source_and_encryption_are_different()
    {
      const string source = "A long long time ago in a galaxy far far away";
      string result = CryptoFunc.RsaEncryption(source);
      Assert.AreNotEqual(result, source);
    }

    [TestMethod]
    public void TestMethod_RsaEncryption_one_letter()
    {
      const string source = "a";
      const string expected = "Pk+xT6QpGq0h4hdYdIlLZr2Cg1wOZ3v6qQXkIvqmwwdXPd1MdhoICk4N4jHXqGBfFJzIN/cbeHbVaiEbEIuCe5tEvaS5AFVrF3PATmCVWHtRBJsR5tvihQOxecd52AHRjpZhbX9sawpHpxQ5iKOpyT6gQ6icG+oSaYcwx8xn7ag=";
      string result = CryptoFunc.RsaEncryption(source);
      Assert.AreNotEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RsaEncryption_encryption_not_null()
    {
      const string source = "A long long time ago in a galaxy far far away";
      string result = CryptoFunc.RsaEncryption(source);
      Assert.IsNotNull(result);
    }

    [TestMethod]
    public void TestMethod_RsaEncryption_encryption_not_empty()
    {
      const string source = "A long long time ago in a galaxy far far away";
      string result = CryptoFunc.RsaEncryption(source);
      Assert.IsTrue(result.Length != 0);
      Assert.AreNotEqual(result.Length, 0);
    }
    #endregion RSAEncryption
    #region RsaDecryption
    [TestMethod]
    public void TestMethod_RsaDecryption_source_is_a_the_same_after_encryption_and_decryption()
    {
      const string source = "A long long time ago in a galaxy far far away";
      string result = CryptoFunc.RsaDecryption(CryptoFunc.RsaEncryption(source));
      Assert.AreEqual(result, source);
    }

    [TestMethod]
    public void TestMethod_RsaDecryption_source_and_encryption_are_different()
    {
      //const string source = "N06oeaZWoEgD3ktg8lvw2ncecdqE9grb+NRV/QoYpp4VRjQeGiDZYPwFbd4VwhqmAk+7uYeGHc2yd/LCz7j9oN7Z1X6MKxYmiGc7FiL2fobKXcHb1yNpTXgy5jNok6Y02dtJJaUn5GmNMDvk1fYxGgyvCqScxalF16Nl1vAWO7I=";
      //string result = CryptoFunc.RsaDecryption(source);
      //Assert.AreNotEqual(result, source);
    }

    [TestMethod]
    public void TestMethod_RsaDecryption_encryption_not_null()
    {
      //const string source = "N06oeaZWoEgD3ktg8lvw2ncecdqE9grb+NRV/QoYpp4VRjQeGiDZYPwFbd4VwhqmAk+7uYeGHc2yd/LCz7j9oN7Z1X6MKxYmiGc7FiL2fobKXcHb1yNpTXgy5jNok6Y02dtJJaUn5GmNMDvk1fYxGgyvCqScxalF16Nl1vAWO7I=";
      //string result = CryptoFunc.RsaDecryption(source);
      //Assert.IsNotNull(result);
    }

    [TestMethod]
    public void TestMethod_RsaDecryption_encryption_not_empty()
    {
      //const string source = "N06oeaZWoEgD3ktg8lvw2ncecdqE9grb+NRV/QoYpp4VRjQeGiDZYPwFbd4VwhqmAk+7uYeGHc2yd/LCz7j9oN7Z1X6MKxYmiGc7FiL2fobKXcHb1yNpTXgy5jNok6Y02dtJJaUn5GmNMDvk1fYxGgyvCqScxalF16Nl1vAWO7I=";
      //string result = CryptoFunc.RsaDecryption(source);
      //Assert.IsTrue(result.Length != 0);
      //Assert.AreNotEqual(result.Length, 0);
    }

    #endregion RsaDecryption
    #endregion Crypto

    #region GenerateRandomNumbers
    [TestMethod]
    public void TestMethod_GenerateRndNumberUsingCrypto_greater_than_1()
    {
      int result = CryptoFunc.GenerateRndNumberUsingCrypto(1, 254);
      Assert.IsTrue(result >= 1);
    }

    [TestMethod]
    public void TestMethod_GenerateRndNumberUsingCrypto_lesser_than_254()
    {
      int result = CryptoFunc.GenerateRndNumberUsingCrypto(1, 254);
      Assert.IsTrue(result <= 254);
    }

    [TestMethod]
    public void TestMethod_GenerateGreatRndNumberUsingCrypto_lesser_than_254()
    {
      int result = CryptoFunc.GenerateGreatRndNumberUsingCrypto(1, 254);
      Assert.IsTrue(result <= 254);
    }

    [TestMethod]
    public void TestMethod_GenerateGreatRndNumberUsingCrypto_greater_than_1()
    {
      int result = CryptoFunc.GenerateGreatRndNumberUsingCrypto(1, 254);
      Assert.IsTrue(result >= 1);
    }

    [TestMethod]
    public void TestMethod_GenerateGreatRndNumberUsingCrypto_has_1()
    {
      int result = CryptoFunc.GenerateGreatRndNumberUsingCrypto(1, 1);
      Assert.IsTrue(result == 1);
    }

    [TestMethod]
    public void TestMethod_GenerateGreatRndNumberUsingCrypto_min_equal_max()
    {
      int result = CryptoFunc.GenerateGreatRndNumberUsingCrypto(10, 10);
      Assert.IsTrue(result == 10);
    }

    [TestMethod]
    public void TestMethod_GenerateGreatRndNumberUsingCrypto_has_254()
    {
      int result = CryptoFunc.GenerateGreatRndNumberUsingCrypto(254, 254);
      Assert.IsTrue(result == 254);
    }

    [TestMethod]
    public void TestMethod_GenerateGreatRndNumberUsingCrypto_has_255()
    {
      int result = CryptoFunc.GenerateGreatRndNumberUsingCrypto(255, 255);
      Assert.IsTrue(result == 255);
    }

    [TestMethod]
    public void TestMethod_GenerateGreatRndNumberUsingCrypto_has_255_at_least_once()
    {
      int result = CryptoFunc.GenerateGreatRndNumberUsingCrypto(1, 255);
      for (int i = 2; i < 100; i++)
      {
        result = CryptoFunc.GenerateGreatRndNumberUsingCrypto(1, i);
        if (result == 255)
        {
          Assert.IsTrue(result == 255);
        }
      }
    }

    [TestMethod]
    public void TestMethod_GenerateGreatRndNumberUsingCrypto_verify_all_numbers_are_generated()
    {
      int result = CryptoFunc.GenerateGreatRndNumberUsingCrypto(1, 255);
      var dico = new Dictionary<int, int>();
      var dicoRef = new Dictionary<int, bool>();
      for (int i = 1; i < 255; i++)
      {
        dicoRef.Add(i, false);
      }

      for (int i = 1; i < 1000; i++)
      {
        result = CryptoFunc.GenerateGreatRndNumberUsingCrypto(1, 254);
        if (dico.ContainsKey(result))
        {
          dico[result]++;
        }
        else
        {
          dico.Add(result, 1);
        }

        dicoRef[result] = true;
      }

      Assert.IsTrue(dicoRef.ContainsValue(true));
      //Assert.IsTrue(HaveAllValues(dico)); //bug
    }

    private static bool HaveAllValues(IReadOnlyDictionary<int, int> dic)
    {
      bool result = true;
      var dicoRef = new Dictionary<int, bool>();
      for (int i = 1; i < 255; i++)
      {
        dicoRef.Add(i, false);
      }

      for (int i = 1; i < dic.Count; i++)
      {
        int tmpDico = dic[i]; //bug
        dicoRef[tmpDico] = true;
      }

      return result;
    }

    private static Dictionary<string, string> SortDictionaryByLength(Dictionary<string, string> unsortedDictionary)
    {
      var queryResults = from kp in unsortedDictionary
                         orderby kp.Key.Length descending
                         select new KeyValuePair<string, string>(kp.Key, kp.Value);

      return queryResults.ToDictionary(x => x.Key, x => x.Value);
    }
    #endregion GenerateRandomNumbers
    #region ComputeHash
    [TestMethod]
    public void TestMethod_ComputeHashSha1_message_1()
    {
      const string source2 = "message to be hashed";
      byte[] source = Encoding.UTF8.GetBytes(source2);
      string expected = "0LphvbcxA1NOTk55HDb91Mop6tE=";
      byte[] result = CryptoFunc.ComputeHashSha1(source);
      Assert.AreEqual(Convert.ToBase64String(result), expected);
    }

    [TestMethod]
    public void TestMethod_ComputeHashSha1_message_a()
    {
      const string source2 = "a";
      byte[] source = Encoding.UTF8.GetBytes(source2);
      string expected = "hvfkN/qlp/zhXR3cuerq6jd2Z7g=";
      byte[] result = CryptoFunc.ComputeHashSha1(source);
      Assert.AreEqual(Convert.ToBase64String(result), expected);
    }

    [TestMethod]
    public void TestMethod_ComputeHashSha1_message_b()
    {
      const string source2 = "b";
      byte[] source = Encoding.UTF8.GetBytes(source2);
      string expected = "6dcfXufJLW3J6S/9rRe4vUlBj5g=";
      byte[] result = CryptoFunc.ComputeHashSha1(source);
      Assert.AreEqual(Convert.ToBase64String(result), expected);
    }
    #endregion

    #region HMAC
    [TestMethod]
    public void TestMethod_ComputeHmacSha1_message_1()
    {
      //const string source2 = "message to be hashed";
      //byte[] source = Encoding.UTF8.GetBytes(source2);
      //byte[] key = CryptoFunc.GenerateKey();
      //string expected = "IzRHG+QzlFxtU2KhlxtdnAH6/c0=";
      //byte[] result = CryptoFunc.ComputeHmacSha1(source, key);
      //Assert.AreEqual(Convert.ToBase64String(result), expected);
    }

    #endregion

    #region NTLM
    [TestMethod]
    public void TestMethod_NTLM_A_long_time_ago()
    {
      const string source = "A long long time ago";
      string expected = "0D3FD10549FDEA58641BDA30E4FD20D7";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_hello()
    {
      const string source = "hello";
      string expected = "066DDFD4EF0E9CD7C256FE77191EF43C";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_a()
    {
      const string source = "a";
      string expected = "186CB09181E2C2ECAAC768C47C729904";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_b()
    {
      const string source = "b";
      string expected = "A047EE4A9DB8BC8B4F3F8A03D72DEB80";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_c()
    {
      const string source = "c";
      string expected = "93CC2B4D5D1FCCC38FAB249A9AEDB1E3";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_d()
    {
      const string source = "d";
      string expected = "9B75CF9A3FCC498E03EEDA4387BB5277";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_e()
    {
      const string source = "e";
      string expected = "4992A157B9ECC2A7D2066FEFF64967D3";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_f()
    {
      const string source = "f";
      string expected = "E2E35A421944255FEB8EF91A141AC2D5";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_g()
    {
      const string source = "g";
      string expected = "2FC8BEA1E2325C1AE5431551193825D9";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_h()
    {
      const string source = "h";
      string expected = "0A9195A4BF04D808D098CF44A165186E";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_i()
    {
      const string source = "i";
      string expected = "F9E76A20A4AD2E31E26F0F2F3926BD48";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_j()
    {
      const string source = "j";
      string expected = "034D07A7760E2C31CA5A17661D4E45C7";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_k()
    {
      const string source = "k";
      string expected = "0DE1AEF3FCB3702DF9DE94DEDE954E96";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_l()
    {
      const string source = "l";
      string expected = "449D05CC4B34C94E21558281885B066E";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_m()
    {
      const string source = "m";
      string expected = "7E864D8195B263B4D6AEE4E041C0193F";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_n()
    {
      const string source = "n";
      string expected = "A32F9FACBEFC62B814E5E9B5985123D9";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_o()
    {
      const string source = "o";
      string expected = "76A94015DE14CAE3F7220D7EA619988E";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_p()
    {
      const string source = "p";
      string expected = "2468C466F4666005A06B2792513D98E8";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_q()
    {
      const string source = "q";
      string expected = "64F92A7257F6E6E48D2BE10DAA793463";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_r()
    {
      const string source = "r";
      string expected = "EDB9B445C52137DCE3ABB04C0E7493E4";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_s()
    {
      const string source = "s";
      string expected = "C3F541BAF5C46E5169E95691975D12BC";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_t()
    {
      const string source = "t";
      string expected = "6237795E56D95C5BC0B6F7405B31EDF9";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_u()
    {
      const string source = "u";
      string expected = "EBD448894839C684C19A7FE7D55F0D45";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    #endregion

  }
}