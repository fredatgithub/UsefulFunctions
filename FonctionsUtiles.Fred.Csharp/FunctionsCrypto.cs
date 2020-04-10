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
        result += (char)(message[i] + 1);
      }

      return result;
    }

    public static string DecryptCaesar(string message)
    {
      string result = string.Empty;
      for (int i = 0; i < message.Length; i++)
      {
        result += (char)(message[i] - 1);
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

    public static string Ntlm(string key)
    {
      const uint INIT_A = 0x67452301;
      const uint INIT_B = 0xefcdab89;
      const uint INIT_C = 0x98badcfe;
      const uint INIT_D = 0x10325476;

      const uint SQRT_2 = 0x5a827999;
      const uint SQRT_3 = 0x6ed9eba1;

      char[] itoa16 = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

      uint[] nt_buffer = new uint[16];
      uint[] output = new uint[4];
      char[] hex_format = new char[32];

      //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
      // Prepare the string for hash calculation
      //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
      int i = 0;
      int length = key.Length;
      //The length of key need to be <= 27
      for (; i < length / 2; i++)
      {
        nt_buffer[i] = (key[2 * i] | ((uint)key[2 * i + 1] << 16));
      }

      //padding
      if (length % 2 == 1)
      {
        nt_buffer[i] = (uint)key[length - 1] | 0x800000;
      }
      else
      {
        nt_buffer[i] = 0x80;
      }

      //put the length
      nt_buffer[14] = (uint)length << 4;

      //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
      // NTLM hash calculation
      //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
      uint a = INIT_A;
      uint b = INIT_B;
      uint c = INIT_C;
      uint d = INIT_D;

      /* Round 1 */
      a += (d ^ (b & (c ^ d))) + nt_buffer[0]; a = (a << 3) | (a >> 29);
      d += (c ^ (a & (b ^ c))) + nt_buffer[1]; d = (d << 7) | (d >> 25);
      c += (b ^ (d & (a ^ b))) + nt_buffer[2]; c = (c << 11) | (c >> 21);
      b += (a ^ (c & (d ^ a))) + nt_buffer[3]; b = (b << 19) | (b >> 13);

      a += (d ^ (b & (c ^ d))) + nt_buffer[4]; a = (a << 3) | (a >> 29);
      d += (c ^ (a & (b ^ c))) + nt_buffer[5]; d = (d << 7) | (d >> 25);
      c += (b ^ (d & (a ^ b))) + nt_buffer[6]; c = (c << 11) | (c >> 21);
      b += (a ^ (c & (d ^ a))) + nt_buffer[7]; b = (b << 19) | (b >> 13);

      a += (d ^ (b & (c ^ d))) + nt_buffer[8]; a = (a << 3) | (a >> 29);
      d += (c ^ (a & (b ^ c))) + nt_buffer[9]; d = (d << 7) | (d >> 25);
      c += (b ^ (d & (a ^ b))) + nt_buffer[10]; c = (c << 11) | (c >> 21);
      b += (a ^ (c & (d ^ a))) + nt_buffer[11]; b = (b << 19) | (b >> 13);

      a += (d ^ (b & (c ^ d))) + nt_buffer[12]; a = (a << 3) | (a >> 29);
      d += (c ^ (a & (b ^ c))) + nt_buffer[13]; d = (d << 7) | (d >> 25);
      c += (b ^ (d & (a ^ b))) + nt_buffer[14]; c = (c << 11) | (c >> 21);
      b += (a ^ (c & (d ^ a))) + nt_buffer[15]; b = (b << 19) | (b >> 13);

      /* Round 2 */
      a += ((b & (c | d)) | (c & d)) + nt_buffer[0] + SQRT_2; a = (a << 3) | (a >> 29);
      d += ((a & (b | c)) | (b & c)) + nt_buffer[4] + SQRT_2; d = (d << 5) | (d >> 27);
      c += ((d & (a | b)) | (a & b)) + nt_buffer[8] + SQRT_2; c = (c << 9) | (c >> 23);
      b += ((c & (d | a)) | (d & a)) + nt_buffer[12] + SQRT_2; b = (b << 13) | (b >> 19);

      a += ((b & (c | d)) | (c & d)) + nt_buffer[1] + SQRT_2; a = (a << 3) | (a >> 29);
      d += ((a & (b | c)) | (b & c)) + nt_buffer[5] + SQRT_2; d = (d << 5) | (d >> 27);
      c += ((d & (a | b)) | (a & b)) + nt_buffer[9] + SQRT_2; c = (c << 9) | (c >> 23);
      b += ((c & (d | a)) | (d & a)) + nt_buffer[13] + SQRT_2; b = (b << 13) | (b >> 19);

      a += ((b & (c | d)) | (c & d)) + nt_buffer[2] + SQRT_2; a = (a << 3) | (a >> 29);
      d += ((a & (b | c)) | (b & c)) + nt_buffer[6] + SQRT_2; d = (d << 5) | (d >> 27);
      c += ((d & (a | b)) | (a & b)) + nt_buffer[10] + SQRT_2; c = (c << 9) | (c >> 23);
      b += ((c & (d | a)) | (d & a)) + nt_buffer[14] + SQRT_2; b = (b << 13) | (b >> 19);

      a += ((b & (c | d)) | (c & d)) + nt_buffer[3] + SQRT_2; a = (a << 3) | (a >> 29);
      d += ((a & (b | c)) | (b & c)) + nt_buffer[7] + SQRT_2; d = (d << 5) | (d >> 27);
      c += ((d & (a | b)) | (a & b)) + nt_buffer[11] + SQRT_2; c = (c << 9) | (c >> 23);
      b += ((c & (d | a)) | (d & a)) + nt_buffer[15] + SQRT_2; b = (b << 13) | (b >> 19);

      /* Round 3 */
      a += (d ^ c ^ b) + nt_buffer[0] + SQRT_3; a = (a << 3) | (a >> 29);
      d += (c ^ b ^ a) + nt_buffer[8] + SQRT_3; d = (d << 9) | (d >> 23);
      c += (b ^ a ^ d) + nt_buffer[4] + SQRT_3; c = (c << 11) | (c >> 21);
      b += (a ^ d ^ c) + nt_buffer[12] + SQRT_3; b = (b << 15) | (b >> 17);

      a += (d ^ c ^ b) + nt_buffer[2] + SQRT_3; a = (a << 3) | (a >> 29);
      d += (c ^ b ^ a) + nt_buffer[10] + SQRT_3; d = (d << 9) | (d >> 23);
      c += (b ^ a ^ d) + nt_buffer[6] + SQRT_3; c = (c << 11) | (c >> 21);
      b += (a ^ d ^ c) + nt_buffer[14] + SQRT_3; b = (b << 15) | (b >> 17);

      a += (d ^ c ^ b) + nt_buffer[1] + SQRT_3; a = (a << 3) | (a >> 29);
      d += (c ^ b ^ a) + nt_buffer[9] + SQRT_3; d = (d << 9) | (d >> 23);
      c += (b ^ a ^ d) + nt_buffer[5] + SQRT_3; c = (c << 11) | (c >> 21);
      b += (a ^ d ^ c) + nt_buffer[13] + SQRT_3; b = (b << 15) | (b >> 17);

      a += (d ^ c ^ b) + nt_buffer[3] + SQRT_3; a = (a << 3) | (a >> 29);
      d += (c ^ b ^ a) + nt_buffer[11] + SQRT_3; d = (d << 9) | (d >> 23);
      c += (b ^ a ^ d) + nt_buffer[7] + SQRT_3; c = (c << 11) | (c >> 21);
      b += (a ^ d ^ c) + nt_buffer[15] + SQRT_3; b = (b << 15) | (b >> 17);

      output[0] = a + INIT_A;
      output[1] = b + INIT_B;
      output[2] = c + INIT_C;
      output[3] = d + INIT_D;

      //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
      // Convert the hash to hex (for being readable)
      //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
      for (i = 0; i < 4; i++)
      {
        int j = 0;
        uint n = output[i];
        //iterate the bytes of the integer
        for (; j < 4; j++)
        {
          uint convert = n % 256;
          hex_format[i * 8 + j * 2 + 1] = itoa16[convert % 16];
          convert = convert / 16;
          hex_format[i * 8 + j * 2 + 0] = itoa16[convert % 16];
          n = n / 256;
        }
      }

      return string.Join(string.Empty, hex_format);
    }
  }
}
