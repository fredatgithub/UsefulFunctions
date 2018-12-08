namespace XUnitTests
{
  using System;
  using System.Collections.Generic;

  using Xunit;

  public class XUnitTestSamples
  {
    [Fact]
    public void EqualStringIgnoreCase()
    {
      const string expected = "TestString";
      const string actual = "teststring";

      Assert.False(actual == expected);
      Assert.NotEqual(expected, actual);
      Assert.Equal(expected, actual, StringComparer.CurrentCultureIgnoreCase);
    }

    class DateComparer : IEqualityComparer<DateTime>
    {
      public bool Equals(DateTime x, DateTime y)
      {
        return x.Date == y.Date;
      }

      public int GetHashCode(DateTime obj)
      {
        return obj.GetHashCode();
      }
    }

    [Fact]
    public void DateShouldBeEqualEvenThoughTimesAreDifferent()
    {
      DateTime firstTime = DateTime.Now.Date;
      DateTime later = firstTime.AddMinutes(90);

      Assert.NotEqual(firstTime, later);
      Assert.Equal(firstTime, later, new DateComparer());
    }
  }
}