using System;
using System.Text;

namespace CodeGenerationWinForm
{
  internal class UnitTestCodeGenerated
  {
    public string CodeAttribute { get; set; }
    private const string CodeSignatureStart = "public void TestMethod_";
    public string CodeSignatureMethodName { get; set; }
    private const string CodeSignatureEnd = "()";
    private const string OpenCurlyBrace = "{";
    public string CodeSource { get; set; }
    public string CodeExpected { get; set; }
    public string CodeResult { get; set; }
    public string CodeAssert { get; set; }
    private const string CloseCurlyBrace = "}";
    public string Tabulation {get; private set; } 

    private readonly string carriageReturn = Environment.NewLine;

    public UnitTestCodeGenerated( 
      string codeSignatureMiddle = "no_title", 
      string codeSource = "const string source = ",
      string codeExpected = @"const string expected = "";",
      string codeResult = @"string result = "";",
      string codeAssert = " Assert.AreEqual(result, expected);",
      string tabulation = "  ",
      string codeAttribute = "[TestMethod]")
    {
      CodeAttribute = codeAttribute;
      CodeSignatureMethodName = codeSignatureMiddle;
      CodeSource = codeSource;
      CodeExpected = codeExpected;
      CodeResult =  codeResult;
      CodeAssert =  codeAssert;
    }

    public override string ToString()
    {
      StringBuilder result = new StringBuilder();
      result.Append(CodeAttribute);
      result.Append(carriageReturn);
      result.Append(CodeSignatureStart);
      result.Append(CodeSignatureMethodName);
      result.Append(CodeSignatureEnd);
      result.Append(carriageReturn);
      result.Append(OpenCurlyBrace);
      result.Append(carriageReturn);
      result.Append(Tabulation);
      result.Append(CodeSource);
      result.Append(carriageReturn);
      result.Append(Tabulation);
      result.Append(CodeExpected);
      result.Append(carriageReturn);
      result.Append(Tabulation);
      result.Append(CodeResult);
      result.Append(carriageReturn);
      result.Append(Tabulation);
      result.Append(CodeAssert);
      result.Append(carriageReturn);
      result.Append(CloseCurlyBrace);
      result.Append(carriageReturn);
      result.Append(carriageReturn);
      return result.ToString();
    }
  }
}