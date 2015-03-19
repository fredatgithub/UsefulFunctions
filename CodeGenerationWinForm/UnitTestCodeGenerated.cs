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

    private string carriageReturn = Environment.NewLine;

    public UnitTestCodeGenerated( 
      string codeSignatureMiddle = "no_title", 
      string codeExpected = @"const string expected = "";",
      string codeResult = @"string result = "";",
      string codeAssert = "Assert.AreEqual(string.Empty, string.Empty);",
      string codeAttribute = "[TestMethod]")
    {
      CodeAttribute = codeAttribute;
      CodeSignatureMiddle = codeSignatureMiddle;
      CodeExpected = codeExpected;
      CodeResult = codeResult;
      CodeAssert = codeAssert;
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