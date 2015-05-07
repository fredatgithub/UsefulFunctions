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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathFunc = FonctionsUtiles.Fred.Csharp.FunctionsMath;
using StringFunc = FonctionsUtiles.Fred.Csharp.FunctionsString;
using DateFunc = FonctionsUtiles.Fred.Csharp.FunctionsDateTime;
using InternetFunc = FonctionsUtiles.Fred.Csharp.FunctionsInternet;
using FonctionsUtiles.Fred.Csharp;

namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestFunctionsDateTime
  {
    #region GetHoursMinutes with strings parameters
    // ******GetHoursMinutes with strings parameters****************
    [TestMethod]
    public void TestMethod_GetHoursMinutes_true_half_an_hour()
    {
      const string source = "0";
      const string source2 = "30";
      const double expected = 0.5d;
      double result = DateFunc.GetHoursMinutes(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetHoursMinutes_true_fifteen_minutes()
    {
      const string source = "0";
      const string source2 = "15";
      const double expected = 0.25d;
      double result = DateFunc.GetHoursMinutes(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetHoursMinutes_true_forty_five_minutes()
    {
      const string source = "0";
      const string source2 = "45";
      const double expected = 0.75d;
      double result = DateFunc.GetHoursMinutes(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetHoursMinutes_true_ten_hours_and_forty_five_minutes()
    {
      const string source = "10";
      const string source2 = "45";
      const double expected = 10.75d;
      double result = DateFunc.GetHoursMinutes(source, source2);
      Assert.AreEqual(result, expected);
    }
    #endregion GetHoursMinutes with strings parameters
    #region GetHoursMinutes with int parameters
    // ******GetHoursMinutes with int parameters****************
    [TestMethod]
    public void TestMethod_GetHoursMinutes_with_int_true_half_an_hour()
    {
      const int source = 0;
      const int source2 = 30;
      const double expected = 0.5d;
      double result = DateFunc.GetHoursMinutes(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetHoursMinutes_int_true_fifteen_minutes()
    {
      const int source = 0;
      const int source2 = 15;
      const double expected = 0.25d;
      double result = DateFunc.GetHoursMinutes(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetHoursMinutes_int_true_forty_five_minutes()
    {
      const int source = 0;
      const int source2 = 45;
      const double expected = 0.75d;
      double result = DateFunc.GetHoursMinutes(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_GetHoursMinutes_int_true_ten_hours_and_forty_five_minutes()
    {
      const int source = 10;
      const int source2 = 45;
      const double expected = 10.75d;
      double result = DateFunc.GetHoursMinutes(source, source2);
      Assert.AreEqual(result, expected);
    }
    #endregion GetHoursMinutes with strings parameters
    #region BuildUpTime
    // ******BuildUpTime****************
    [TestMethod]
    public void TestMethod_BuildUpTime_true_zero()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 0 * second + 0 * millisecond;
      const string expected = "0 hour 0 minute 0 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 0 * second + 1 * millisecond;
      const string expected = "0 hour 0 minute 0 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hundred_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 0 * second + 100 * millisecond;
      const string expected = "0 hour 0 minute 0 second 100 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_second()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 1 * second + 0 * millisecond;
      const string expected = "0 hour 0 minute 1 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 1 * second + 1 * millisecond;
      const string expected = "0 hour 0 minute 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 1 * second + 2 * millisecond;
      const string expected = "0 hour 0 minute 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_seconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 2 * second + 0 * millisecond;
      const string expected = "0 hour 0 minute 2 seconds 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 2 * second + 1 * millisecond;
      const string expected = "0 hour 0 minute 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 2 * second + 2 * millisecond;
      const string expected = "0 hour 0 minute 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_minute()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 0 * second + 0 * millisecond;
      const string expected = "0 hour 1 minute 0 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_minute_zero_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 0 * second + 1 * millisecond;
      const string expected = "0 hour 1 minute 0 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_minute_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 1 * second + 1 * millisecond;
      const string expected = "0 hour 1 minute 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_minute_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 1 * second + 2 * millisecond;
      const string expected = "0 hour 1 minute 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_minute_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 2 * second + 1 * millisecond;
      const string expected = "0 hour 1 minute 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_minute_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 2 * second + 2 * millisecond;
      const string expected = "0 hour 1 minute 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_minutes_zero_second_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 0 * second + 0 * millisecond;
      const string expected = "0 hour 2 minutes 0 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_minutes_zero_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 0 * second + 1 * millisecond;
      const string expected = "0 hour 2 minutes 0 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_minutes_zero_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 0 * second + 2 * millisecond;
      const string expected = "0 hour 2 minutes 0 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_minutes_one_second_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 1 * second + 0 * millisecond;
      const string expected = "0 hour 2 minutes 1 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_minutes_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 1 * second + 1 * millisecond;
      const string expected = "0 hour 2 minutes 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_minutes_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 1 * second + 2 * millisecond;
      const string expected = "0 hour 2 minutes 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_minutes_two_seconds_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 2 * second + 0 * millisecond;
      const string expected = "0 hour 2 minutes 2 seconds 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_minutes_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 2 * second + 1 * millisecond;
      const string expected = "0 hour 2 minutes 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_minutes_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 2 * second + 2 * millisecond;
      const string expected = "0 hour 2 minutes 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }
    #endregion BuildUpTime
    #region HasHours
    // ******HasHours****************
    [TestMethod]
    public void TestMethod_HasHours_false()
    {
      const int source = 0;
      const bool expected = false;
      bool result = DateFunc.HasHours(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasHours_true()
    {
      const int source = 216000000;
      const bool expected = true;
      bool result = DateFunc.HasHours(source);
      Assert.AreEqual(result, expected);
    }
    #endregion HasHours
    #region HasMinutes
    // ******HasMinutes****************
    [TestMethod]
    public void TestMethod_HasMinutes_false()
    {
      const int source = 0;
      const bool expected = false;
      bool result = DateFunc.HasMinutes(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasMinutes_true()
    {
      const int source = 3600000;
      const bool expected = true;
      bool result = DateFunc.HasMinutes(source);
      Assert.AreEqual(result, expected);
    }
    #endregion HasMinutes
    #region HasSeconds
    // ******HasSeconds****************
    [TestMethod]
    public void TestMethod_HasSeconds_false()
    {
      const int source = 0;
      const bool expected = false;
      bool result = DateFunc.HasSeconds(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasSeconds_true()
    {
      const int source = 60000;
      const bool expected = true;
      bool result = DateFunc.HasSeconds(source);
      Assert.AreEqual(result, expected);
    }
    #endregion HasSeconds
    #region HasMilliSeconds
    // ******HasMilliSeconds****************
    [TestMethod]
    public void TestMethod_HasMilliSeconds_false()
    {
      const int source = 0;
      const bool expected = false;
      bool result = DateFunc.HasMilliSeconds(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_HasMilliSeconds_true()
    {
      const int source = 1;
      const bool expected = true;
      bool result = DateFunc.HasMilliSeconds(source);
      Assert.AreEqual(result, expected);
    }
    #endregion HasMilliSeconds
  }
}