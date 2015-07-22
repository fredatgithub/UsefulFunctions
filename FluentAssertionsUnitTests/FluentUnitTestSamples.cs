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
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
namespace FluentAssertionsUnitTests
{
  [TestFixture]
  public class FluentUnitTestSamples
  {
    [Test]
    public void Should_Start_With_Example()
    {
      const string actual = "ABCDEFGHI";
      actual.Should().StartWith("AB").And.EndWith("HI").And.Contain("EF").And.HaveLength(9);
    }

    [Test]
    public void Array_Should_Contain_Item_Example()
    {
      new[] { 1, 2, 3 }.Should().Contain(item => item > 1, "at least {0} item should be larger than 3", 1);
    }

    [Test]
    public void Collection_Should_Have_Count_Example()
    {
      IEnumerable<int> collection = new[] { 1, 2, 3 };
      collection.Should().HaveCount(3, "because we thought we put three items in the collection");
    }

    [Test]
    public void Some_Object_Should_Be_Of_TypeExample()
    {
      var someObject = new object();
      someObject.Should().BeOfType<object>();
    }

    [Test]
    public void xDocument_should_have_element_childExample()
    {
      //xDocument.Should().HaveElement("child").Which.Should().BeOfType<XElement>().And.HaveAttribute("attr", "1");
    }

    [Test]
    public void String_should_be_Example()
    {
      "1234567890".Should().Be("1234567890");
    }

    [Test]
    public void Object_should_be_Null_Example()
    {
      object theObject = null;
      // ReSharper disable once ExpressionIsAlwaysNull
      theObject.Should().BeNull("because the value is null");
    }

    [Test]
    public void Object_should_not_be_Null_Example()
    {
      object theObject = "sample";
      theObject.Should().NotBeNull("because the value is null");
    }

    [Test]
    public void Object_should_be_of_type_string_Example()
    {
      object theObject = "whatever";
      theObject.Should().BeOfType<string>("because a {0} is set", typeof(string));
    }

    [Test]
    public void Object_should_be_of_type_type_of_string_Example()
    {
      object theObject = "whatever";
      theObject.Should().BeOfType(typeof(string), "because a {0} is set", typeof(string));
    }

    [Test]
    public void Object_should_be_same_as_Example()
    {
      object theObject = "whatever";
      object otherObject = theObject;
      theObject.Should().BeSameAs(otherObject);
    }

    [Test]
    public void Object_should_not_be_same_as_Example()
    {
      object theObject = "whatever";
      object otherObject = "something else";
      theObject.Should().NotBeSameAs(otherObject);
    }

    [Test]
    public void Object_should_be_assignable_to_Example()
    {
      var ex = new ArgumentException();
      ex.Should().BeAssignableTo<Exception>("because it is an exception");
    }

    [Test]
    public void Object_should_match_Example()
    {
      //var dummy = new object();
      //dummy.Should().Match(anItem => (anItem.ToString() == "System.object"));
      //dummy.Should().Match<string>(anItem => (anItem == "System.object"));
      //dummy.Should().Match((string anItem) => (anItem == "System.object"));
    }

    [Test]
    public void Class_instance_should_be_of_value_Example()
    {
      // customer.Animals.First().As<Human>().Height.Should().Be(178);
    }

    [Test]
    public void Object_should_be_serializable_Example()
    {
      object theObject = "an XML file content";
      theObject.Should().BeXmlSerializable();
      theObject.Should().BeBinarySerializable();
    }

    [Test]
    public void Object_should_not_have_value_Example()
    {
      short? theShort = null;
      // ReSharper disable once ExpressionIsAlwaysNull
      theShort.Should().NotHaveValue();
    }

    [Test]
    public void Object_should_have_value_Example()
    {
      int? theInt = 3;
      theInt.Should().HaveValue();
    }

    [Test]
    public void Date_should_not_have_value_Example()
    {
      DateTime? theDate = null;
      // ReSharper disable once ExpressionIsAlwaysNull
      theDate.Should().NotHaveValue();
    }

    [Test]
    public void Object_should_be_false_Example()
    {
      const bool theBoolean = false;
      theBoolean.Should().BeFalse("it's set to false");
    }

    [Test]
    public void Object_should_be_true_Example()
    {
      const bool theBoolean = true;
      theBoolean.Should().BeTrue();
    }

    [Test]
    public void Object_should_be_other_boolean_Example()
    {
      const bool theBoolean = true;
      const bool otherBoolean = true;
      theBoolean.Should().Be(otherBoolean);
    }

    [Test]
    public void Boolean_should_not_be_false_nor_true_Example()
    {
      //bool? theBoolean;
      //theBoolean.Should().NotBeFalse();
      //theBoolean.Should().NotBeTrue();
    }

    [Test]
    public void String_should_not_be_null_and_be_empty_Example()
    {
      const string theString = "";
      theString.Should().NotBeNull();
      theString.Should().BeEmpty();
      theString.Should().HaveLength(0);
    }

    [Test]
    public void String_should_not_be_null_nor_white_space_Example()
    {
      const string theString = "hello world";
      theString.Should().NotBeNull();
      theString.Should().NotBeEmpty();
      theString.Should().NotBeNullOrWhiteSpace();
    }

    [Test]
    public void String_should_be_null_Example()
    {
      //string theString;
      //theString.Should().BeNull();
      //theString.Should().BeNullOrWhiteSpace(); // either null, empty or whitespace only
    }

    [Test]
    public void String_should_not_be_null_nor_empty_Example()
    {
      const string theString = "hello world";
      theString.Should().NotBeNull();
      theString.Should().NotBeEmpty("because the string is not empty");
      theString.Should().NotBeNullOrWhiteSpace();
    }

    [Test]
    public void String_should_be_all_methods_Example()
    {
      const string theString = "This is a String";
      theString.Should().Be("This is a String");
      theString.Should().NotBe("This is another String");
      theString.Should().BeEquivalentTo("THIS IS A STRING");

      theString.Should().Contain("is a");
      theString.Should().NotContain("is not a");
      theString.Should().ContainEquivalentOf("THIS IS A STRING");
      theString.Should().NotContainEquivalentOf("WE DONT CARE ABOUT THE CASING");
      theString.Should().NotContainEquivalentOf("HeRe ThE CaSiNg Is IgNoReD As WeLl");

      theString.Should().StartWith("This");
      theString.Should().NotStartWith("These");
      theString.Should().StartWithEquivalent("this");
      theString.Should().NotStartWithEquivalentOf("these");

      theString.Should().EndWith("a String");
      theString.Should().NotEndWith("another String");
      theString.Should().EndWithEquivalent("A STRING");
      theString.Should().NotEndWithEquivalentOf("ANOTHER STRING");
    }

    [Test]
    public void Email_address_should_match_Example()
    {
      const string emailAddress = "my_super_email_address@my_super_isp.com";
      emailAddress.Should().Match("*@*.com");
    }

    [Test]
    public void Email_address_should_match_equivalent_of_Example()
    {
      const string emailAddress = "my_super_email_address@my_super_isp.com";
      emailAddress.Should().MatchEquivalentOf("*@*.COM");
    }

    [Test]
    public void SomeString_should_match_Regex_Example()
    {
      string webSiteAddress = "http://www.world.com";
      webSiteAddress.Should().MatchRegex("^http?://www.world.com$");
      webSiteAddress = "https://www.world.com";
      webSiteAddress.Should().MatchRegex("^http(s)?://www.world.com$");
    }

    [Test]
    public void SomeString_should_not_match_Regex_Example()
    {
      const string webSiteAddress = "http://www.world.com";
      webSiteAddress.Should().NotMatchRegex(".*sex.*");
      webSiteAddress.Should().NotMatchRegex(".*porn.*");
    }

    [Test]
    public void Int_should_be_several_methods_Example()
    {
      const int theInt = 5;
      theInt.Should().BeGreaterOrEqualTo(5);
      theInt.Should().BeGreaterOrEqualTo(3);
      theInt.Should().BeGreaterThan(4);
      theInt.Should().BeLessOrEqualTo(5);
      theInt.Should().BeLessThan(6);
      theInt.Should().BePositive();
      theInt.Should().Be(5);
      theInt.Should().NotBe(10);
      theInt.Should().BeInRange(1, 10);
    }

    [Test]
    public void Int_should_be_negative_Example()
    {
      const int theInt = -8;
      theInt.Should().BeNegative();
      int? nullableInt = 3;
      nullableInt.Should().Be(3);
    }

    [Test]
    public void Double_should_be_greater_than_Example()
    {
      const double theDouble = 5.1;
      theDouble.Should().BeGreaterThan(5);
    }

    [Test]
    public void Byte_should_be_greater_than_Example()
    {
      const byte theByte = 2;
      theByte.Should().Be(2);
    }

    [Test]
    public void Float_should_be_approximately_Example()
    {
      const float value = 3.1415927F;
      value.Should().BeApproximately(3.14F, 0.01F);
    }

    [Test]
    public void Byte_should_be_one_of_the_Example()
    {
      const byte theByte = 3;
      theByte.Should().BeOneOf(3, 6);
    }
  }
}