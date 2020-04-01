using System;
using System.Security.Cryptography;
using System.Text;

namespace FonctionsUtiles.Fred.Csharp
{
  public static class FunctionsCrypto
  {
    public static string RsaEncryption(string clearData)
    {
      var param = new CspParameters { KeyContainerName = "MyKeyContainer" };
      using (var rsa = new RSACryptoServiceProvider(param))
      {
        string plainText = clearData;
        byte[] plainData = Encoding.Default.GetBytes(plainText);
        byte[] encryptedData = rsa.Encrypt(plainData, false);
        string encryptedString = Convert.ToBase64String(encryptedData);
        return encryptedString;
      }
    }

    public static string RsaDecryption(string encryptedData)
    {
      var param = new CspParameters { KeyContainerName = "MyKeyContainer" };
      using (var rsa = new RSACryptoServiceProvider(param))
      {
        byte[] encryptedBytes = Convert.FromBase64String(encryptedData);
        byte[] decryptedData = rsa.Decrypt(encryptedBytes, false);
        string plainData = Encoding.Default.GetString(decryptedData);
        return plainData;
      }
    }

    public static int GenerateRndNumberUsingCrypto(int min, int max)
    {
      if (max > 255 || min < 0)
      {
        return 0;
      }

      if (max == min)
      {
        return min;
      }

      int result;
      var crypto = new RNGCryptoServiceProvider();
      byte[] randomNumber = new byte[1];
      do
      {
        crypto.GetBytes(randomNumber);
        result = randomNumber[0];
      } while (result < min || result > max);

      return result;
    }

    public static int GenerateGreatRndNumberUsingCrypto(int min, int max)
    {
      if (max > 255 || min < 0)
      {
        return 0;
      }

      if (max == min)
      {
        return min;
      }

      int result;
      var crypto = new RNGCryptoServiceProvider();
      byte[] randomNumber = new byte[1];
      do
      {
        crypto.GetBytes(randomNumber);
        result = randomNumber[0];
      } while (result < min || result > max);

      return result;
    }

    public static byte[] GenerateRandomNumbers(int length)
    {
      using (var randomNumberGenerator = new RNGCryptoServiceProvider())
      {
        var randomNumber = new byte[length];
        randomNumberGenerator.GetBytes(randomNumber);
        return randomNumber;
      }
    }

    public static byte[] ComputeHashSha1(byte[] toBeHashed)
    {
      using (var sha1 = SHA1.Create())
      {
        return sha1.ComputeHash(toBeHashed);
      }
    }

    public static byte[] ComputeHashSha256(byte[] toBeHashed)
    {
      using (var sha256 = SHA256.Create())
      {
        return sha256.ComputeHash(toBeHashed);
      }
    }

    public static byte[] ComputeHashSha512(byte[] toBeHashed)
    {
      using (var sha512 = SHA512.Create())
      {
        return sha512.ComputeHash(toBeHashed);
      }
    }

    public static byte[] ComputeHashMd5(byte[] toBeHashed)
    {
      using (var md5 = MD5.Create())
      {
        return md5.ComputeHash(toBeHashed);
      }
    }

    public static byte[] ComputeHmacSha256(byte[] toBeHashed, byte[] key)
    {
      using (var hmac = new HMACSHA256(key))
      {
        return hmac.ComputeHash(toBeHashed);
      }
    }

    public static byte[] ComputeHmacSha1(byte[] toBeHashed, byte[] key)
    {
      using (var hmac = new HMACSHA1(key))
      {
        return hmac.ComputeHash(toBeHashed);
      }
    }

    public static byte[] ComputeHmacSha512(byte[] toBeHashed, byte[] key)
    {
      using (var hmac = new HMACSHA512(key))
      {
        return hmac.ComputeHash(toBeHashed);
      }
    }

    public static byte[] ComputeHmacMd5(byte[] toBeHashed, byte[] key)
    {
      using (var hmac = new HMACMD5(key))
      {
        return hmac.ComputeHash(toBeHashed);
      }
    }

    public static byte[] GenerateKey(int keySize = 32)
    {
      using (var randomNumberGenerator = new RNGCryptoServiceProvider())
      {
        byte[] randomNumber = new byte[keySize];
        randomNumberGenerator.GetBytes(randomNumber);
        return randomNumber;
      }
    }

    public static string EncryptCaesar(string message)
    {
      string result = string.Empty;
      for (int i = 0; i < message.Length; i++)
      {
        result += (char)((int)(message[i]) + 1);
      }

      return result;
    }

    public static string DecryptCaesar(string message)
    {
      string result = string.Empty;
      for (int i = 0; i < message.Length; i++)
      {
        result += (char)((int)(message[i]) - 1);
      }

      return result;
    }

    public static string EncryptDecryptUsingXor(string plainText, int encryptionKey)
    {
      StringBuilder inputStringBuild = new StringBuilder(plainText);
      StringBuilder outStringBuild = new StringBuilder(plainText.Length);
      char character;
      for (int i = 0; i < plainText.Length; i++)
      {
        character = inputStringBuild[i];
        character = (char)(character ^ encryptionKey);
        outStringBuild.Append(character);
      }

      return outStringBuild.ToString();
    }
  }
}