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
  using System.Linq;

  public class FunctionsDateTime
  {
    public static bool OutsideWeekEnd()
    {
      return (DateTime.Now.DayOfWeek != DayOfWeek.Sunday) && (DateTime.Now.DayOfWeek != DayOfWeek.Saturday);
    }

    public static bool OutsideWeekEnd(DateTime dt)
    {
      return (dt.DayOfWeek != DayOfWeek.Sunday) && (dt.DayOfWeek != DayOfWeek.Saturday);
    }

    public static bool IsWeekEnd()
    {
      return !OutsideWeekEnd();
    }

    public static bool IsWeekEnd(DateTime dt)
    {
      return !OutsideWeekEnd(dt);
    }

    public static bool IsMorning(DateTime time)
    {
      return time.Hour < 12;
    }

    public static string ConvertTimeSpanToString(TimeSpan ts)
    {
      return string.Format("{0}:{1}:{2}:{3}:{4}", ts.Days, ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
    }

    public enum TimeSpanElement
    {
      Millisecond,
      Second,
      Minute,
      Hour,
      Day
    }

    public static string TimeSpanToFriendlyDisplay(TimeSpan timeSpan, int maxNrOfElements = 5)
    {
      maxNrOfElements = Math.Max(Math.Min(maxNrOfElements, 5), 1);
      var parts = new[]
        {
          Tuple.Create(TimeSpanElement.Day, timeSpan.Days),
          Tuple.Create(TimeSpanElement.Hour, timeSpan.Hours),
          Tuple.Create(TimeSpanElement.Minute, timeSpan.Minutes),
          Tuple.Create(TimeSpanElement.Second, timeSpan.Seconds),
          Tuple.Create(TimeSpanElement.Millisecond, timeSpan.Milliseconds)
        }
      .SkipWhile(i => i.Item2 <= 0).Take(maxNrOfElements);

      return string.Join(", ", parts.Select(p => string.Format(
        "{0} {1}{2}", p.Item2, p.Item1, p.Item2 > 1 ? "s" : string.Empty)));
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
        return new DateTime();
      }

      long longDate = BitConverter.ToInt64(bytes, 0);
      return DateTime.FromFileTime(longDate);
    }
  }
}