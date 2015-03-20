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
using System.Text;

namespace CodeGenerationWinForm
{
  class UnitTestCodeGenerated
  {
    public string CodeAttribute { get; set; }
    private const string CodeSignatureStart = "public void TestMethod_";
    public string CodeSignatureMiddle { get; set; }
    private const string CodeSignatureEnd = "()";
    private const string openCurlyBrace = "{";
    public string CodeExpected { get; set; }
    public string CodeResult { get; set; }
    public string CodeAssert { get; set; }
    private const string closeCurlyBrace = "}";
    private const string tabulation = "  ";

    private string carriageReturn = Environment.NewLine;

    public UnitTestCodeGenerated( 
      string codeSignatureMiddle = "no_title", 
      string codeExpected = @"const string expected = "";",
      string codeResult = @"string result = "";",
      string codeAssert = "Assert.AreEqual(string.Empty, string.Empty);",
      string tabulation = "  ",
      string codeAttribute = "[TestMethod]")
    {
      CodeAttribute = codeAttribute;
      CodeSignatureMiddle = codeSignatureMiddle;
      CodeExpected = tabulation + codeExpected;
      CodeResult = tabulation + codeResult;
      CodeAssert = tabulation + codeAssert;
    }

    public override string ToString()
    {
      StringBuilder result = new StringBuilder();
      result.Append(CodeAttribute);
      result.Append(carriageReturn);
      result.Append(CodeSignatureStart);
      result.Append(CodeSignatureMiddle);
      result.Append(CodeSignatureEnd);
      result.Append(carriageReturn);
      result.Append(openCurlyBrace);
      result.Append(carriageReturn);
      result.Append(CodeExpected);
      result.Append(carriageReturn);
      result.Append(CodeResult);
      result.Append(carriageReturn);
      result.Append(CodeAssert);
      result.Append(carriageReturn);
      result.Append(closeCurlyBrace);
      result.Append(carriageReturn);
      return result.ToString();
    }
  }
}