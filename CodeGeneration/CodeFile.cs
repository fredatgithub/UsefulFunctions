using System;
using System.Collections.Generic;
using System.IO;

namespace CodeGeneration
{
  internal class CodeFile
  {
    private List<string> ListOfUsing;
    private readonly string carriageReturn = Environment.NewLine;
    private const string UsingToken = "using";
    private const string Space = " ";
    private const string SemiColon = ";";
    private const string Systemtoken = "System";
    private const string OpenCurlyBrace = "{";
    private const string CloseCurlyBrace = "}";
    private const string OpenSquareBracket = "[";
    private const string CloseSquareBracket = "]";
    private const string OpenParenthesis = "(";
    private const string CloseParenthesis = ")";
    private const string OpenCloseParenthesis = "()";
    private const string TestClass = "[TestClass]";
    private const string TestMethod = "[TestMethod]";
    private const string TestMethodOnly = "TestMethod";
    private const string UnderScore = "_";
    private const string Period = ".";
    private const string TrueToken = "true";
    private const string FalseToken = "false";
    private const string Publictoken = "public";
    private const string VoidToken = "void";
    private const string AssertToken = "Assert";
    private const string AreEqualToken = "AreEqual";
    private const string AreNotEqualToken = "AreNotEqual";
    private const string IsTrueToken = "IsTrue";
    private const string IsFalseToken = "IsFalse";
    private const string AreNotSameToken = "AreNotSame";
    private const string AreSameToken = "AreSame";
    private const string EqualsToken = "Equals";
    private const string FailToken = "Fail";
    private const string InconclusiveToken = "Inconclusive";
    private const string IsInstanceOfTypeToken = "IsInstanceOfType";
    private const string IsNotInstnaceOfTypeToken = "IsNotInstanceOfType";
    private const string IsNotNulToken = "IsNotNull";
    private const string IsNullToken = "IsNull";
    private const string ReferenceEqualsToken = "ReferenceEquals";
    private const string ReplaceNullCharsToken = "ReplaceNullChars";
    private const string PublicClass = "public class UnitTestMethodsString";
    private bool usingHaveBeenVerified = false;
    public string Name { get; set; }
    public string FileName { get; set; }
    public string Code { get; set; }

    public CodeFile(string name = "untitled name", string fileName = "untitledCode.cs")
    {
      Name = name;
      FileName = fileName;
      ListOfUsing = new List<string>();
      Code = string.Empty;
      usingHaveBeenVerified = false;
    }

    public void AddCode(string code)
    {
      Code += code;
    }

    public void AddSemiColon()
    {
      Code += SemiColon;
    }

    public void AddCarriageReturn()
    {
      Code += "\n";
    }

    public void AddOpenCurlyBrace()
    {
      Code += "{" + carriageReturn;
    }
    
    public void AddCloseCurlyBrace()
    {
      Code += "}" + carriageReturn;
    }

    public void AddOpenParenthesis()
    {
      Code += "(";
    }

    public void AddCloseParenthesis()
    {
      Code += ")";
    }

    public void AddTabulation(byte tabulationNumber)
    {
      Code += CreateTabulation(tabulationNumber);
    }

    private string CreateTabulation(byte tabulationNumber)
    {
      string result = string.Empty;
      for (byte i = 1; i <= tabulationNumber; i++)
      {
        result += " ";
      }

      return result;
    }

    public void AddUsing(string usingToken2)
    {
      if (!ListOfUsing.Contains(usingToken2))
      {
        ListOfUsing.Add(usingToken2);
      }
    }

    public void AddTestClassAttribute()
    {
      Code += "[TestClass]" + carriageReturn;
    }

    public void AddTestMethodAttribute()
    {
      Code += "[TestMethod]" + carriageReturn;
    }

    public void AddAssert()
    {
      Code += "Assert";
    }

    public void AddPeriod()
    {
      Code += Period;
    }

    public void AddIsTrue()
    {
      Code += IsTrueToken;
    }

    public void AddTrue()
    {
      Code += TrueToken;
    }

    public void VerifyUsingDependence()
    {
      // TODO
      usingHaveBeenVerified = true;
    }

    public override string ToString()
    {
      string result = string.Empty;
      // add all the using
      if (ListOfUsing.Count != 0)
      {
        foreach (string item in ListOfUsing)
        {
          result += item + carriageReturn;
        }
      }

      return result + Code;
    }

    public void Save(string savePath = ".\\")
    {
      if (!usingHaveBeenVerified)
      {
        VerifyUsingDependence();
      }

      if (!Directory.Exists(savePath))
      {
        savePath = string.Empty;
      }

      savePath += FileName;
      var sw = new StreamWriter(savePath);
      sw.Write(ToString());
      sw.Close();
    }
  }
}