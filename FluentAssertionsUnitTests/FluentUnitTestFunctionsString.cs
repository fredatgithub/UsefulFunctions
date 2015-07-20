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
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
namespace FluentAssertionsUnitTests
{
  [TestFixture]
  public class FluentUnitTestFunctionsString
  {
    [Test]
    public void ShouldStartWithExample()
    {
      const string actual = "ABCDEFGHI";
      actual.Should().StartWith("AB").And.EndWith("HI").And.Contain("EF").And.HaveLength(9);
    }

    [Test]
    public void ArrayShouldContainItemExample()
    {
      new[] { 1, 2, 3 }.Should().Contain(item => item > 1, "at least {0} item should be larger than 3", 1);
    }

    [Test]
    public void CollectionShouldHaveCountExample()
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
  }
}