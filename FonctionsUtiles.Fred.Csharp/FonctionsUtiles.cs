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
namespace FonctionsUtiles.Fred.Csharp
{
  using System;
  using System.Text;

  public class FonctionsDateTime
  {
    public static bool HorsWeekEnd()
    {
      if ((DateTime.Now.DayOfWeek != DayOfWeek.Sunday) && (DateTime.Now.DayOfWeek != DayOfWeek.Saturday))
      {
        return true;
      }
      return false;
    }

    public static bool IsMorning(DateTime time)
    {
      return time.Hour < 12;
    }

    /// Convert a DateTime to the equivalent long (Win32 FileTime) byte array
    /// <param name="date">DateTime to convert</param>
    /// <returns>"long" byte array representing the DateTime</returns>
    public static byte[] DateToByteArray(DateTime date)
    {
      long longDate = date.ToFileTime();
      return BitConverter.GetBytes(longDate);
    }

    /// Coverts a long (aka Win32 FileTime) byte array to a DateTime
    /// <param name="bytes">Bytes to convert</param>
    /// <returns>DateTime representation of the "long" bytes</returns>
    public static DateTime ByteArrayToDate(byte[] bytes)
    {
      if (bytes.Length != 8)
      {
        throw new ArgumentException("bytes");
      }

      long longDate = BitConverter.ToInt64(bytes, 0);
      return DateTime.FromFileTime(longDate);
    }

    public static string ByteArrayToHexString(byte[] bytes)
    {
      StringBuilder sb = new StringBuilder();
      for (int i = 0; i < bytes.Length; i++)
      {
        sb.Append(bytes[i].ToString("X2"));
      }
      return sb.ToString();
    }

    /// Converts a hex string to a byte array
    /// <param name="hexString">The hex string to convert</param>
    /// <returns>A byte array representing the hex string</returns>
    public static byte[] HexStringToByteArray(string hexString)
    {
      byte[] returnBytes = new byte[hexString.Length / 2];
      for (int i = 0; i < returnBytes.Length; i++)
      {
        returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
      }

      return returnBytes;
    }
  }
}