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

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DateFunc = FonctionsUtiles.Fred.Csharp.FunctionsDateTime;
using dllFuncs = FonctionsUtiles.Fred.Csharp;

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

    [TestMethod]
    public void TestMethod_BuildUpTime_true_zero_one_hour()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 0 * second + 0 * millisecond;
      const string expected = "1 hour 0 minute 0 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 0 * second + 1 * millisecond;
      const string expected = "1 hour 0 minute 0 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_one_hundred_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 0 * second + 100 * millisecond;
      const string expected = "1 hour 0 minute 0 second 100 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_one_second()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 1 * second + 0 * millisecond;
      const string expected = "1 hour 0 minute 1 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 1 * second + 1 * millisecond;
      const string expected = "1 hour 0 minute 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 1 * second + 2 * millisecond;
      const string expected = "1 hour 0 minute 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_seconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 2 * second + 0 * millisecond;
      const string expected = "1 hour 0 minute 2 seconds 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 2 * second + 1 * millisecond;
      const string expected = "1 hour 0 minute 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 2 * second + 2 * millisecond;
      const string expected = "1 hour 0 minute 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_one_minute()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 0 * second + 0 * millisecond;
      const string expected = "1 hour 1 minute 0 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_one_minute_zero_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 0 * second + 1 * millisecond;
      const string expected = "1 hour 1 minute 0 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_one_minute_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 1 * second + 1 * millisecond;
      const string expected = "1 hour 1 minute 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_one_minute_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 1 * second + 2 * millisecond;
      const string expected = "1 hour 1 minute 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_one_minute_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 2 * second + 1 * millisecond;
      const string expected = "1 hour 1 minute 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_one_minute_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 2 * second + 2 * millisecond;
      const string expected = "1 hour 1 minute 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_minutes_zero_second_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 0 * second + 0 * millisecond;
      const string expected = "1 hour 2 minutes 0 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_minutes_zero_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 0 * second + 1 * millisecond;
      const string expected = "1 hour 2 minutes 0 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_minutes_zero_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 0 * second + 2 * millisecond;
      const string expected = "1 hour 2 minutes 0 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_minutes_one_second_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 1 * second + 0 * millisecond;
      const string expected = "1 hour 2 minutes 1 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_minutes_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 1 * second + 1 * millisecond;
      const string expected = "1 hour 2 minutes 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_minutes_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 1 * second + 2 * millisecond;
      const string expected = "1 hour 2 minutes 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_minutes_two_seconds_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 2 * second + 0 * millisecond;
      const string expected = "1 hour 2 minutes 2 seconds 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_minutes_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 2 * second + 1 * millisecond;
      const string expected = "1 hour 2 minutes 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_one_hour_two_minutes_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 2 * second + 2 * millisecond;
      const string expected = "1 hour 2 minutes 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_BuildUpTime_true_zero_two_hours()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 0 * second + 0 * millisecond;
      const string expected = "2 hours 0 minute 0 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 0 * second + 1 * millisecond;
      const string expected = "2 hours 0 minute 0 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_one_hundred_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 0 * second + 100 * millisecond;
      const string expected = "2 hours 0 minute 0 second 100 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_one_second()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 1 * second + 0 * millisecond;
      const string expected = "2 hours 0 minute 1 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 1 * second + 1 * millisecond;
      const string expected = "2 hours 0 minute 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 1 * second + 2 * millisecond;
      const string expected = "2 hours 0 minute 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_seconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 2 * second + 0 * millisecond;
      const string expected = "2 hours 0 minute 2 seconds 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 2 * second + 1 * millisecond;
      const string expected = "2 hours 0 minute 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 2 * second + 2 * millisecond;
      const string expected = "2 hours 0 minute 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_one_minute()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 0 * second + 0 * millisecond;
      const string expected = "2 hours 1 minute 0 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_one_minute_zero_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 0 * second + 1 * millisecond;
      const string expected = "2 hours 1 minute 0 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_one_minute_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 1 * second + 1 * millisecond;
      const string expected = "2 hours 1 minute 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_one_minute_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 1 * second + 2 * millisecond;
      const string expected = "2 hours 1 minute 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_one_minute_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 2 * second + 1 * millisecond;
      const string expected = "2 hours 1 minute 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_one_minute_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 2 * second + 2 * millisecond;
      const string expected = "2 hours 1 minute 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_minutes_zero_second_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 0 * second + 0 * millisecond;
      const string expected = "2 hours 2 minutes 0 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_minutes_zero_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 0 * second + 1 * millisecond;
      const string expected = "2 hours 2 minutes 0 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_minutes_zero_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 0 * second + 2 * millisecond;
      const string expected = "2 hours 2 minutes 0 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_minutes_one_second_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 1 * second + 0 * millisecond;
      const string expected = "2 hours 2 minutes 1 second 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_minutes_one_second_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 1 * second + 1 * millisecond;
      const string expected = "2 hours 2 minutes 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_minutes_one_second_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 1 * second + 2 * millisecond;
      const string expected = "2 hours 2 minutes 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_minutes_two_seconds_zero_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 2 * second + 0 * millisecond;
      const string expected = "2 hours 2 minutes 2 seconds 0 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_minutes_two_seconds_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 2 * second + 1 * millisecond;
      const string expected = "2 hours 2 minutes 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_two_hours_two_minutes_two_seconds_two_milliseconds()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 2 * second + 2 * millisecond;
      const string expected = "2 hours 2 minutes 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source);
      Assert.AreEqual(result, expected);
    }

    //*********************BuildUpTime with removal of zeros****************************
    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_zero()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 0 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_millisecond()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 0 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hundred_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 0 * second + 100 * millisecond;
      const bool source2 = true;
      const string expected = "100 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_second()
    {
      const int millisecond = 1;
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 1 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "1 second";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_second_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 1 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_second_two_milliseconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 1 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_seconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 2 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "2 seconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_seconds_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 2 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_seconds_two_milliseconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 0 * minute + 2 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_minute()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 0 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "1 minute";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_minute_zero_second_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 0 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 minute 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_minute_one_second_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 1 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 minute 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_minute_one_second_two_milliseconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 1 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "1 minute 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_minute_two_seconds_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 2 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 minute 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_minute_two_seconds_two_milliseconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 1 * minute + 2 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "1 minute 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_minutes_zero_second_zero_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 0 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "2 minutes";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_minutes_zero_second_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 0 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 minutes 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_minutes_zero_second_two_milliseconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 0 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "2 minutes 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_minutes_one_second_zero_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 1 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "2 minutes 1 second";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_minutes_one_second_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 1 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 minutes 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_minutes_one_second_two_milliseconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 1 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "2 minutes 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_minutes_two_seconds_zero_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 2 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "2 minutes 2 seconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_minutes_two_seconds_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 2 * second + 1 * millisecond;
      const bool source2 = true; 
      const string expected = "2 minutes 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_minutes_two_seconds_two_milliseconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 0 * hour + 2 * minute + 2 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "2 minutes 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_zero_one_hour()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 0 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 0 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_one_hundred_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 0 * second + 100 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 100 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_one_second()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 1 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 1 second";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_one_second_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 1 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_one_second_two_milliseconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 1 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_seconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 2 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 seconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_seconds_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 2 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_seconds_two_milliseconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 0 * minute + 2 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_one_minute()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 0 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 1 minute";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_one_minute_zero_second_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 0 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 1 minute 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_one_minute_one_second_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 1 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 1 minute 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_one_minute_one_second_two_milliseconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 1 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 1 minute 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_one_minute_two_seconds_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 2 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 1 minute 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_one_minute_two_seconds_two_milliseconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 1 * minute + 2 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 1 minute 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_minutes_zero_second_zero_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 0 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 minutes";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_minutes_zero_second_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 0 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 minutes 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_minutes_zero_second_two_milliseconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 0 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 minutes 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_minutes_one_second_zero_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 1 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 minutes 1 second";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_minutes_one_second_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 1 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 minutes 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_minutes_one_second_two_milliseconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 1 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 minutes 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_minutes_two_seconds_zero_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 2 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 minutes 2 seconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_minutes_two_seconds_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 2 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 minutes 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_one_hour_two_minutes_two_seconds_two_milliseconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 1 * hour + 2 * minute + 2 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "1 hour 2 minutes 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_zero_two_hours()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 0 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 0 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_one_hundred_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 0 * second + 100 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 100 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_one_second()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 1 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 1 second";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_one_second_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 1 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_one_second_two_milliseconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 1 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_seconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 2 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 seconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_seconds_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 2 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_seconds_two_milliseconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 0 * minute + 2 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_one_minute()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 0 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 1 minute";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_one_minute_zero_second_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 0 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 1 minute 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_one_minute_one_second_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 1 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 1 minute 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_one_minute_one_second_two_milliseconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 1 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 1 minute 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_one_minute_two_seconds_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 2 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 1 minute 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_one_minute_two_seconds_two_milliseconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 1 * minute + 2 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 1 minute 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_minutes_zero_second_zero_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 0 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 minutes";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_minutes_zero_second_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 0 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 minutes 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_minutes_zero_second_two_milliseconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 0 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 minutes 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_minutes_one_second_zero_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 1 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 minutes 1 second";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_minutes_one_second_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 1 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 minutes 1 second 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_minutes_one_second_two_milliseconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 1 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 minutes 1 second 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_minutes_two_seconds_zero_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 2 * second + 0 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 minutes 2 seconds";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_minutes_two_seconds_one_millisecond()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 2 * second + 1 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 minutes 2 seconds 1 millisecond";
      string result = DateFunc.BuildUpTime(source, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_BuildUpTime_true_without_zeros_two_hours_two_minutes_two_seconds_two_milliseconds()
    {
      const int millisecond = 1; 
      const int second = 1000 * millisecond;
      const int minute = 60 * second;
      const int hour = 60 * minute;
      const int source = 2 * hour + 2 * minute + 2 * second + 2 * millisecond;
      const bool source2 = true;
      const string expected = "2 hours 2 minutes 2 seconds 2 milliseconds";
      string result = DateFunc.BuildUpTime(source, source2);
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
   #region TimeSpanElement
    // **********************TimeSpanElement**************
    [TestMethod]
    public void TestMethod_TimeSpanElement_true_all_enum_exists_no_deleted_item()
    {
      Assert.AreEqual(dllFuncs.TimeSpanElement.Millisecond, dllFuncs.TimeSpanElement.Millisecond);
      Assert.AreEqual(dllFuncs.TimeSpanElement.Second, dllFuncs.TimeSpanElement.Second);
      Assert.AreEqual(dllFuncs.TimeSpanElement.Minute, dllFuncs.TimeSpanElement.Minute);
      Assert.AreEqual(dllFuncs.TimeSpanElement.Hour, dllFuncs.TimeSpanElement.Hour);
      Assert.AreEqual(dllFuncs.TimeSpanElement.Day, dllFuncs.TimeSpanElement.Day);
    }

    [TestMethod]
    public void TestMethod_TimeSpanElement_false_no_equality()
    {
      Assert.AreNotEqual(dllFuncs.TimeSpanElement.Millisecond, dllFuncs.TimeSpanElement.Day);
      Assert.AreNotEqual(dllFuncs.TimeSpanElement.Second, dllFuncs.TimeSpanElement.Minute);
      Assert.AreNotEqual(dllFuncs.TimeSpanElement.Minute, dllFuncs.TimeSpanElement.Second);
      Assert.AreNotEqual(dllFuncs.TimeSpanElement.Hour, dllFuncs.TimeSpanElement.Millisecond);
      Assert.AreNotEqual(dllFuncs.TimeSpanElement.Day, dllFuncs.TimeSpanElement.Hour);
    }

    [TestMethod]
    public void TestMethod_TimeSpanElement_true_all_enum_exist_by_their_value_number()
    {
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.TimeSpanElement), 0));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.TimeSpanElement), 1));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.TimeSpanElement), 2));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.TimeSpanElement), 3));
      Assert.IsTrue(Enum.IsDefined(typeof(dllFuncs.TimeSpanElement), 4));
    }

    [TestMethod]
    public void TestMethod_TimeSpanElement_true_all_enum_exists_with_no_change_in_their_value()
    {
      Assert.AreEqual((int)dllFuncs.TimeSpanElement.Millisecond, 0);
      Assert.AreEqual((int)dllFuncs.TimeSpanElement.Second, 1);
      Assert.AreEqual((int)dllFuncs.TimeSpanElement.Minute, 2);
      Assert.AreEqual((int)dllFuncs.TimeSpanElement.Hour, 3);
      Assert.AreEqual((int)dllFuncs.TimeSpanElement.Day, 4);
    }
    #endregion TimeSpanElement
  }
}