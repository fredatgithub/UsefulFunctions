using System;
using System.Linq;
using System.Text;

namespace FonctionsUtiles.Fred.Csharp
{
  using StringFunc = FunctionsString;

  public class FunctionsDateTime
  {
    public static bool IsOutsideWeekEnd()
    {
      return DateTime.Now.DayOfWeek != DayOfWeek.Sunday && DateTime.Now.DayOfWeek != DayOfWeek.Saturday;
    }

    public static bool IsOutsideWeekEnd(DateTime dt)
    {
      return dt.DayOfWeek != DayOfWeek.Sunday && dt.DayOfWeek != DayOfWeek.Saturday;
    }

    public static bool IsWeekEnd()
    {
      return !IsOutsideWeekEnd();
    }

    public static bool IsWeekEnd(DateTime dt)
    {
      return !IsOutsideWeekEnd(dt);
    }

    public static bool IsMorning(DateTime time)
    {
      return time.Hour < 12;
    }

    public static string ConvertTimeSpanToStringWithoutNames(TimeSpan ts)
    {
      return $"{ts.Days}:{ts.Hours}:{ts.Minutes}:{ts.Seconds}:{ts.Milliseconds}";
    }

    public static string ConvertTimeSpanToString(TimeSpan ts)
    {
      var jours = $"{ts.Days} jour{Plural(ts.Days)}";
      var heures = $"{ts.Hours} heure{Plural(ts.Hours)}";
      var minutes = $"{ts.Minutes} minute{Plural(ts.Minutes)}";
      var secondes = $"{ts.Seconds} seconde{Plural(ts.Seconds)}";
      var milliSecondes = $"{ts.Milliseconds} milli-seconde{Plural(ts.Milliseconds)}";

      return $"{jours} {heures}:{minutes}:{secondes}";
    }

    public static string Plural(int number)
    {
      return number > 1 ? "s" : string.Empty;
    }

    public static string ConvertTimeSpanToStringUS(TimeSpan ts)
    {
      var days = $"{ts.Days} day{Plural(ts.Days)}";
      var hours = $"{ts.Hours} hour{Plural(ts.Hours)}";
      var minutes = $"{ts.Minutes} minute{Plural(ts.Minutes)}";
      var seconds = $"{ts.Seconds} second{Plural(ts.Seconds)}";
      var milliSeconds = $"{ts.Milliseconds} milliseconde{Plural(ts.Milliseconds)}";

      return $"{days} {hours}:{minutes}:{seconds}";
    }


    public static string DisplayElapseTime(TimeSpan ts)
    {
      return $"{ts.Days:000}:{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}";
    }

    public static string TimeSpanToLongTimeNotNull(TimeSpan timeSpan)
    {
      return TimeSpanToFriendlyDisplay(timeSpan) == string.Empty ? "1 millisecond" :
        TimeSpanToFriendlyDisplay(timeSpan);
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

      return string.Join(
        ", ",
        parts.Select(p => $"{p.Item2} {p.Item1}{(p.Item2 > 1 ? "s" : string.Empty)}"));
    }

    /// <summary>
    /// The date to byte array.
    /// </summary>
    /// Convert a DateTime to the equivalent long (Win32 FileTime) byte array
    /// <param name="date">
    /// DateTime to convert
    /// </param>
    /// <returns>
    /// "long" byte array representing the DateTime
    /// </returns>
    public static byte[] DateToByteArray(DateTime date)
    {
      long longDate = date.ToFileTime();
      return BitConverter.GetBytes(longDate);
    }

    /// <summary>
    /// The byte array to date.
    /// </summary>
    /// Coverts a long (aka Win32 FileTime) byte array to a DateTime
    /// <param name="bytes">
    /// Bytes to convert
    /// </param>
    /// <returns>
    /// DateTime representation of the "long" bytes
    /// </returns>
    public static DateTime ByteArrayToDate(byte[] bytes)
    {
      if (bytes.Length != 8)
      {
        return new DateTime();
      }

      long longDate = BitConverter.ToInt64(bytes, 0);
      return DateTime.FromFileTime(longDate);
    }

    public static double GetHoursMinutes(string hours, string minutes)
    {
      double minutesB60 = double.Parse(minutes);
      double minutesB10 = minutesB60 / 60;
      var result = double.Parse(hours) + minutesB10;
      return result;
    }

    public static double GetHoursMinutes(int hours, int minutes)
    {
      return hours + ((double)minutes / 60);
    }

    public static string BuildUpTime(int time, bool removeZeros = false)
    {
      StringBuilder result = new StringBuilder();
      if (HasHours(time))
      {
        result.Append(time / 3600000);
        result.Append(" hour");
        result.Append(StringFunc.Plural(time / 3600000));
        time %= 3600000;
      }
      else if (!removeZeros)
      {
        result.Append("0 hour");
      }

      if (HasMinutes(time))
      {
        result.Append(" ");
        result.Append(time / 60000);
        result.Append(" minute");
        result.Append(StringFunc.Plural(time / 60000));
        time %= 60000;
      }
      else if (!removeZeros)
      {
        result.Append(" 0 minute");
      }

      if (HasSeconds(time))
      {
        result.Append(" ");
        result.Append(time / 1000);
        result.Append(" second");
        result.Append(StringFunc.Plural(time / 1000));
        time %= 1000;
      }
      else if (!removeZeros)
      {
        result.Append(" 0 second");
      }

      if (HasMilliSeconds(time))
      {
        result.Append(" ");
        result.Append(time);
        result.Append(" millisecond");
        result.Append(StringFunc.Plural(time));
      }
      else if (!removeZeros)
      {
        result.Append(" 0 millisecond");
      }

      return result.ToString().Trim();
    }

    public static bool HasHours(int time)
    {
      return time / 3600000 > 0;
    }

    public static bool HasMinutes(int time)
    {
      return time / 60000 > 0;
    }

    public static bool HasSeconds(int time)
    {
      return time / 1000 > 0;
    }

    public static bool HasMilliSeconds(int time)
    {
      return time > 0;
    }

    public static bool IsBissextile(DateTime theDate)
    {
      if (theDate.Year % 4 == 0)
      {
        return true;
      }

      // return theDate.Year % 100 != 0 && theDate.Year % 400 == 0;
      if (theDate.Year % 100 != 0 && theDate.Year % 400 == 0)
      {
        return true;
      }

      return false;
    }

    /// <summary>
    /// Renvoi le nombre de jour pour le mois de février en verifiant si on est sur une année bissextile ou pas
    /// </summary>
    /// <param name="annee"></param>
    /// <returns>Un entier donnant le nombre de jour en février pour l'année.</returns>
    public static int GetFebruaryNumberOfDays(int annee)
    {
      if ((annee % 4 == 0 && annee % 100 != 0) || (annee % 400 == 0))
      {
        return 29;
      }
      else
      {
        return 28;
      }
    }

    /// <summary>It gives the number of days for a given month.</summary>
    /// <param name="monthNumber">The Number of the month.</param>
    /// <param name="theYearForFebruary">The year to calculate if it is bissextile for February.</param>
    /// <returns>The number of days for a given month.</returns>
    public static int GetNumberOfDays(int monthNumber, int theYearForFebruary)
    {
      switch (monthNumber)
      {
        case 1:
          return 31;
        case 2:
          return GetFebruaryNumberOfDays(theYearForFebruary);
        case 3:
          return 31;
        case 4:
          return 30;
        case 5:
          return 31;
        case 6:
          return 30;
        case 7:
          return 31;
        case 8:
          return 31;
        case 9:
          return 30;
        case 10:
          return 31;
        case 11:
          return 30;
        case 12:
          return 31;
      }

      return 0;
    }

    /// <summary>
    /// Get a random date.
    /// </summary>
    /// <param name="time1">Start date.</param>
    /// <param name="time2">End date.</param>
    /// <returns>Random date between the two dates.</returns>
    public static DateTime GetRandomDate(DateTime time1, DateTime time2)
    {
      Random random = new Random();
      DateTime minTime = new DateTime();
      DateTime maxTime = new DateTime();

      TimeSpan ts = new TimeSpan(time1.Ticks - time2.Ticks);

      // Get number of seconds between two moments
      double dTotalSecontds = ts.TotalSeconds;
      int iTotalSecontds = 0;

      if (dTotalSecontds > int.MaxValue)
      {
        iTotalSecontds = int.MaxValue;
      }
      else if (dTotalSecontds < int.MinValue)
      {
        iTotalSecontds = int.MinValue;
      }
      else
      {
        iTotalSecontds = (int)dTotalSecontds;
      }


      if (iTotalSecontds > 0)
      {
        minTime = time2;
        maxTime = time1;
      }
      else if (iTotalSecontds < 0)
      {
        minTime = time1;
        maxTime = time2;
      }
      else
      {
        return time1;
      }

      int maxValue = iTotalSecontds;

      if (iTotalSecontds <= int.MinValue)
      {
        maxValue = int.MinValue + 1;
      }

      int i = random.Next(Math.Abs(maxValue));
      return minTime.AddSeconds(i);
    }

    public static DateTime GetRandomTime()
    {
      int hour = FunctionsMath.GenerateRandomNumberUsingCrypto(0, 23);
      int minute = FunctionsMath.GenerateRandomNumberUsingCrypto(0, 59);
      int second = FunctionsMath.GenerateRandomNumberUsingCrypto(0, 59);
      return new DateTime(2022, 1, 1, hour, minute, second);
    }
  }
}