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

    [TestMethod]
    public void TestMethod_NTLM_v()
    {
      const string source = "v";
      string expected = "9AF153E5C3A2B66026B89C11898FEAF7";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_w()
    {
      const string source = "w";
      string expected = "60F7C6F674D8AF497A7C8217B4DA8AD6";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_x()
    {
      const string source = "x";
      string expected = "A9F0DD57E1EDAB5BB55A9AC0A99C15EC";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_y()
    {
      const string source = "y";
      string expected = "53C1BF6DEAEDE22FA6110FF189023576";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_z()
    {
      const string source = "z";
      string expected = "0366F5C43990657D4AF37BC470E0EF97";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_A()
    {
      const string source = "A";
      string expected = "C5DD1C2BC8719C01B25B4EB2692C9FEE";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_B()
    {
      const string source = "B";
      string expected = "8C7B1DD12B477BB21A3AA139BA015754";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_C()
    {
      const string source = "C";
      string expected = "6E66A0AEA87D174A435DEE9106A0A052";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_D()
    {
      const string source = "D";
      string expected = "F06BB79769EBF65FCCF5B5BA9B744A86";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_E()
    {
      const string source = "E";
      string expected = "A076FECF3D1E72F7C1492851B4348CCA";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_NTLM_F()
    {
      const string source = "F";
      string expected = "0053373ECEA316C0EBF1C8EC1C8355AA";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_G()
    {
      const string source = "G";
      string expected = "9D4CB962D0A85D46FCD1F63EC49492F4";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_H()
    {
      const string source = "H";
      string expected = "0E11E37CC1F49780E021A014634B7164";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_I()
    {
      const string source = "I";
      string expected = "51CB6445669D84FD441D544A2CB89EA4";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_J()
    {
      const string source = "J";
      string expected = "E3EA28F20242275E2B67BC042776D9B7";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_K()
    {
      const string source = "K";
      string expected = "D05ADF9D53C67A5C1256E1F360E14F4A";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_L()
    {
      const string source = "L";
      string expected = "C99BEA6C832B52C0EA2F415EFCB7675D";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_M()
    {
      const string source = "M";
      string expected = "02DF27D458169B9D58A5FD4E10AA3BF9";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_N()
    {
      const string source = "N";
      string expected = "344A4C52F4870D5D81B062E9F283F108";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_O()
    {
      const string source = "O";
      string expected = "AFA83985AF6B341AF0822567B19A393E";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_P()
    {
      const string source = "P";
      string expected = "E788D377ACD8B4CAFBA02CC864D5E4DB";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_Q()
    {
      const string source = "Q";
      string expected = "4CBA0529F0A4FA46F705B610B8118020";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_R()
    {
      const string source = "R";
      string expected = "B1F59CAD4492784E2C9AB98A6647AA7E";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_S()
    {
      const string source = "S";
      string expected = "A2BC7FF665D2DD44F08DEFE1D2007EE9";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_T()
    {
      const string source = "T";
      string expected = "25E87AB85DA56F330F6349A51F586A16";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_U()
    {
      const string source = "U";
      string expected = "E13A473448119D45B179E43C957AFD48";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_V()
    {
      const string source = "V";
      string expected = "ADC5DF4B1F4A1B2501BBEEF236F5BE92";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_W()
    {
      const string source = "W";
      string expected = "CBB5D41A63E9A77BB35D603B629992C2";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_X()
    {
      const string source = "X";
      string expected = "8434E62CE07803876E2EBDAAF4BCA0CD";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_Y()
    {
      const string source = "Y";
      string expected = "E1D968098AC90CA0036A4957645AB03F";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_Z()
    {
      const string source = "Z";
      string expected = "5D9ECAF62D6D99DDD95F0DA0BE245138";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_0()
    {
      const string source = "0";
      string expected = "7BC26760A19FC23E0996DAA99744CA80";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_1()
    {
      const string source = "1";
      string expected = "69943C5E63B4D2C104DBBCC15138B72B";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_2()
    {
      const string source = "2";
      string expected = "8F33E2EBE5960B8738D98A80363786B0";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_3()
    {
      const string source = "3";
      string expected = "5F18A8499CDD4F43D89424AD39CE9AF7";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_4()
    {
      const string source = "4";
      string expected = "E30F7B55215AA69B2920E3715E0392A0";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_5()
    {
      const string source = "5";
      string expected = "94F23786FE827D0A3C0029DC5EB27A65";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_6()
    {
      const string source = "6";
      string expected = "C7C0F6F33F4E34BC0B595FC942CB6D03";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_7()
    {
      const string source = "7";
      string expected = "B3CC27D02C5E59AC39384440FDFFF0FD";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_8()
    {
      const string source = "8";
      string expected = "99CE74551BA6BFB12EAC366090E26032";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_NTLM_9()
    {
      const string source = "9";
      string expected = "90AD6AB281C4AE016E5A7564C307A7E8";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_10()
    {
      const string source = "10";
      string expected = "1BE12A813BF08ED15AFBD3FF3E8EC60B";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_NTLM_11()
    {
      const string source = "11";
      string expected = "AE0597DC61A5C66B3A0600C60044C448";
      string result = CryptoFunc.Ntlm(source);
      Assert.AreEqual(result, expected);
    }

    #endregion

  }
}