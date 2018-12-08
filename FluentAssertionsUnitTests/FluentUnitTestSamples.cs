
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Xml;
using System.Xml.Linq;
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
    public void Array_Should_Contain_Item_Example2()
    {
      new[] { 1, 2, 3 }.Should().Contain(item => item > 2, "at least {0} item should be larger than 3", 1);
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
      theByte.Should().BeOneOf(3, 6, 1, 2, 4, 5, 7, 8, 9);
    }

    [Test]
    public void date_should_be_of_several_Examples()
    {
      var theDatetime = 1.March(2010).At(22, 15);

      theDatetime.Should().BeAfter(1.February(2010));
      theDatetime.Should().BeBefore(2.March(2010));
      theDatetime.Should().BeOnOrAfter(1.March(2010));

      theDatetime.Should().Be(1.March(2010).At(22, 15));
      theDatetime.Should().NotBe(1.March(2010).At(22, 16));

      theDatetime.Should().HaveDay(1);
      theDatetime.Should().HaveMonth(3);
      theDatetime.Should().HaveYear(2010);
      theDatetime.Should().HaveHour(22);
      theDatetime.Should().HaveMinute(15);
      theDatetime.Should().HaveSecond(0);
    }

    [Test]
    public void date_should_be_less_of_several_Examples()
    {
      var theDatetime = 31.December(1999).At(23, 58);
      var y2K = 1.January(2000).At(0, 02);
      var otherDatetime = 1.January(2000).At(1, 15);
      var anotherDatetime = 1.January(2001).At(1, 15);
      var appointement = 1.January(2000).At(23, 58);
      var anotherAppointement = 5.January(2000).At(23, 58);

      theDatetime.Should().BeLessThan(10.Minutes()).Before(y2K);           // Equivalent to <
      theDatetime.Should().BeWithin(2.Hours()).After(otherDatetime);       // Equivalent to <=
      theDatetime.Should().BeMoreThan(1.Days()).Before(anotherDatetime);   // Equivalent to >
      theDatetime.Should().BeAtLeast(2.Days()).Before(anotherAppointement);// Equivalent to >=
      theDatetime.Should().BeExactly(24.Hours()).Before(appointement);     // Equivalent to ==
    }

    [Test]
    public void TimeSpans_should_be_less_of_several_Examples()
    {
      var timeSpan = new TimeSpan(12, 59, 59);
      var timeSpan2 = new TimeSpan(-1, 59, 59);
      var timeSpan3 = new TimeSpan(12, 0, 0);
      TimeSpan someOtherTimeSpan = new TimeSpan(13, 0, 0);
      TimeSpan anotherTimeSpan = new TimeSpan(11, 0, 0);

      timeSpan.Should().BePositive();
      timeSpan2.Should().BeNegative();
      timeSpan3.Should().Be(12.Hours());
      timeSpan.Should().NotBe(1.Days());

      timeSpan.Should().BeLessThan(someOtherTimeSpan);
      timeSpan.Should().BeLessOrEqualTo(someOtherTimeSpan);
      timeSpan.Should().BeGreaterThan(anotherTimeSpan);
      timeSpan.Should().BeGreaterOrEqualTo(anotherTimeSpan);
    }

    [Test]
    public void TimeSpan_should_be_close_to_Example()
    {
      var timeSpan = new TimeSpan(1, 10, 0);
      var expectedSpan = new TimeSpan(1, 10, 0);
      timeSpan.Should().BeCloseTo(expectedSpan, (int)10.Ticks().TotalSeconds, "not within time slot");
    }

    [Test]
    public void Collections_should_be_of_several_Examples()
    {
      IEnumerable collection = new[] { 1, 2, 5, 8 };

      collection.Should().NotBeEmpty()
           .And.HaveCount(4)
           .And.ContainInOrder(new[] { 2, 5 })
           .And.ContainItemsAssignableTo<int>();

      collection.Should().Equal(new List<int> { 1, 2, 5, 8 });
      collection.Should().Equal(1, 2, 5, 8);
      collection.Should().BeEquivalentTo(8, 2, 1, 5);
      collection.Should().NotBeEquivalentTo(new[] { 8, 2, 3, 5 });

      collection.Should().HaveCount(c => c > 3).And.OnlyHaveUniqueItems();
      collection.Should().HaveSameCount(new[] { 6, 2, 0, 5 });
      int element = 1;
      const int element2 = 8;
      collection.Should().StartWith(element);
      collection.Should().EndWith(element2);

      collection.Should().BeSubsetOf(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, });

      collection.Should().Contain(1); //ContainSingle();
      collection.Should().OnlyHaveUniqueItems();//ContainSingle(x => x > 3);
      collection.Should().Contain(8).And.HaveElementAt(2, 5).And.NotBeSubsetOf(new[] { 11, 56 });
      collection.Should().Contain(new[] { 1, 2, 3, 8 }.Where(x => x > 3));
      collection.Should().Contain(collection, " ", 5, 6); // It should contain the original items, plus 5 and 6.

      collection.Should().OnlyHaveUniqueItems(); //OnlyContain(x => x < 10);
      collection.Should().ContainItemsAssignableTo<int>(); //OnlyContainItemsOfType<int>();

      collection.Should().ContainInOrder(new[] { 1, 5, 8 });

      collection.Should().NotContain(82);
      collection.Should().NotContainNulls();
      collection.Should().NotContain(new[] { 100, 200, 300 }); // NotContain(x => x > 10);

      const int successor = 5;
      const int predecessor = 5;
      element = 2;
      collection.Should().HaveElementPreceding(successor, element);
      element = 8;
      collection.Should().HaveElementSucceeding(predecessor, element);

      IEnumerable collection2 = new int[] { };
      collection2.Should().BeEmpty();
      collection2.Should().BeNullOrEmpty();
      collection.Should().NotBeNullOrEmpty();

      IEnumerable otherCollection = new[] { 1, 2, 5, 8, 1 };
      IEnumerable anotherCollection = new[] { 10, 20, 50, 80, 10 };
      collection.Should().IntersectWith(otherCollection);
      collection.Should().NotIntersectWith(anotherCollection);

      collection.Should().BeInAscendingOrder();
      anotherCollection.Should().NotBeAscendingInOrder();
    }

    [Test]
    public void Collection_should_be_in_ascending_order_with_property_Example()
    {
      //IEnumerable collection = new[] { 1, 2, 5, 8 };
      //collection.Should().BeInAscendingOrder(x => x.SomeProperty);
      //collection.Should().NotBeInAscendingOrder(x => x.SomeProperty);
    }

    [Test]
    public void PersistedCustomers_Should_Equal_c1_Name_equals_c2_Name_Example()
    {
      //persistedCustomers.Should().Equal(customers, (c1, c2) => c1.Name == c2.Name);
    }

    [Test]
    public void Dictionary_Should_be_empty_Not_null_Example()
    {
      Dictionary<int, string> dictionary;
      //dictionary.Should().BeNull();
      dictionary = new Dictionary<int, string>();
      dictionary.Should().NotBeNull();
      dictionary.Should().BeEmpty();
      dictionary.Add(1, "first element");
      dictionary.Should().NotBeEmpty();
    }

    [Test]
    public void Dictionary_Should_equal_or_not_equal_Example()
    {
      var dictionary1 = new Dictionary<int, string>
{
    { 1, "One" },
    { 2, "Two" }
};

      var dictionary2 = new Dictionary<int, string>
{
    { 1, "One" },
    { 2, "Two" }
};

      var dictionary3 = new Dictionary<int, string>
{
    { 3, "Three" },
};

      dictionary1.Should().Equal(dictionary2);
      dictionary1.Should().NotEqual(dictionary3);

      dictionary1.Should().ContainKey(1);
      dictionary1.Should().NotContainKey(9);
      dictionary1.Should().ContainValue("One");
      dictionary1.Should().NotContainValue("Nine");

      dictionary1.Should().HaveCount(2);

      KeyValuePair<int, string> item = new KeyValuePair<int, string>(1, "One");

      dictionary1.Should().Contain(item);
      dictionary1.Should().Contain(2, "Two");
      dictionary1.Should().NotContain(9, "Nine");

      //dictionary.Should().ContainValue(myClass).Which.SomeProperty.Should().BeGreaterThan(0);
    }

    [Test]
    public void Guid_should_be_empty_not_empty_example()
    {
      Guid theGuid = Guid.NewGuid();
      Guid sameGuid = theGuid;
      Guid otherGuid = Guid.NewGuid();

      theGuid.Should().Be(sameGuid);
      theGuid.Should().NotBe(otherGuid);
      theGuid.Should().NotBeEmpty();

      Guid.Empty.Should().BeEmpty();
    }

    public enum WorkingDays
    {
      Monday,
      Tuesday,
      Wednesday,
      Thursday,
      Friday
    }

    public enum MyWorkingDays
    {
      Monday,
      Tuesday,
      Wednesday,
      Thursday,
      Friday
    }

    [Test]
    public void Enum_should_be_empty_not_empty_example()
    {
      // TODO to be debugged
      //WorkingDays.Equals(MyWorkingDays);
      //MyWorkingDays.Should().Be().NotEmpty();
    }

    public void Foo(string text)
    {
      throw new InvalidOperationException();
    }

    [Test]
    public void Exceptions_should_throw_example()
    {
      // subject.Invoking(y => y.Foo("Hello"))
      //.ShouldThrow<InvalidOperationException>()
      //.WithMessage("Hello is not allowed at this moment");
    }

    [Test]
    public void Exceptions2_should_throw_example()
    {
      //Action act = () => subject.Foo2("Hello");

      //act.ShouldThrow<InvalidOperationException>()
      //     .WithInnerException<ArgumentException>()
      //     .WithInnerMessage("whatever");
    }

    [Test]
    public void Exceptions3_should_throw_example()
    {
      //Action act = () => subject.Foo(null));

      //act.ShouldThrow<ArgumentNullException>()
      // .And.ParamName.Should().Equal("message");
    }

    [Test]
    public void XML_should_have_example()
    {
      XmlDocument doc = new XmlDocument();
      XmlElement root = doc.CreateElement("configuration");
      root.SetAttribute("name", "value");
      XmlElement child = doc.CreateElement("child");
      child.InnerText = "text node";
      root.AppendChild(child);
      doc.AppendChild(root);

      XDocument xDocument = new XDocument(
    new XElement("configuration",
                 new XAttribute("age", "36"),
                 new XElement("settings", "36")));

      XmlDocument xDocument2 = new XmlDocument();
      //xDocument2.Should().HaveRoot("configuration");
      //xDocument2.Should().HaveElement("settings");

      //xElement.Should().HaveValue("36");
      //xElement.Should().HaveAttribute("age", "36");
      //xElement.Should().HaveElement("address");
    }

    [Test]
    public void XML2_should_have_attribute_example()
    {
      //XmlElement xElement;
      //xElement.Should().HaveAttribute(XName.Get("age", "http://www.example.com/2012/test"), "36");
      //xElement.Should().HaveElement(XName.Get("address", "http://www.example.com/2012/test"));

      //xAttribute.Should().HaveValue("Amsterdam");

      //xDocument.Should().BeEquivalentTo(XDocument.Parse("<configuration><item>value</item></configuration>"));
      //xElement.Should().BeEquivalentTo(XElement.Parse("<item>value</item>"));

      //xDocument.Should().HaveElement("child").Which.Should().BeOfType<XElement>().And.HaveAttribute("attr", "1");
    }

    public class SomePotentiallyVerySlowClass
    {
      public void ExpensiveMethod()
      {
        for (short i = 0; i < short.MaxValue; i++)
        {
          string tmp = " ";
          if (!string.IsNullOrEmpty(tmp))
          {
            tmp += " ";
          }
        }
      }
    }

    [Test]
    public void Execution_time_should_not_exceed_example()
    {
      var subject = new SomePotentiallyVerySlowClass();
      subject.ExecutionTimeOf(s => s.ExpensiveMethod()).ShouldNotExceed(1000.Milliseconds());

      Action someAction = () => Thread.Sleep(510);
      someAction.ExecutionTime().ShouldNotExceed(1000.Milliseconds());
    }
  }
}
