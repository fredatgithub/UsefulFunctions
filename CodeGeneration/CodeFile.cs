using System;
using System.Collections.Generic;
using System.IO;

namespace CodeGeneration
{
  internal class CodeFile
  {
    private List<string> ListOfUsing;
    private Dictionary<string, string> usingRequired;
    private string carriageReturn = Environment.NewLine;
    private const string usingToken = "using";
    private const string space = " ";
    private const string semiColon = ";";
    private const string systemtoken = "System";
    private const string openCurlyBrace = "{";
    private const string closeCurlyBrace = "}";
    private byte tabulation = 2;
    private const string openSquareBracket = "[";
    private const string closeSquareBracket = "]";
    private const string openParenthesis = "(";
    private const string closeParenthesis = ")";
    private const string openCloseParenthesis = "()";
    private const string testClass = "[TestClass]";
    private const string testMethod = "[TestMethod]";
    private const string testMethodOnly = "TestMethod";
    private const string underScore = "_";
    private const string period = ".";
    private const string trueToken = "true";
    private const string falseToken = "false";
    private const string publictoken = "public";
    private const string voidToken = "void";
    private const string assertToken = "Assert";
    private const string areEqualToken = "AreEqual";
    private const string areNotEqualToken = "AreNotEqual";
    private const string isTrueToken = "IsTrue";
    private const string isFalseToken = "IsFalse";
    private const string areNotSameToken = "AreNotSame";
    private const string areSameToken = "AreSame";
    private const string equalsToken = "Equals";
    private const string failToken = "Fail";
    private const string inconclusiveToken = "Inconclusive";
    private const string isInstanceOfTypeToken = "IsInstanceOfType";
    private const string isNotInstnaceOfTypeToken = "IsNotInstanceOfType";
    private const string isNotNulToken = "IsNotNull";
    private const string isNullToken = "IsNull";
    private const string ReferenceEqualsToken = "ReferenceEquals";
    private const string replaceNullCharsToken = "ReplaceNullChars";
    private const string publicClass = "public class UnitTestMethodsString";
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
      Code += semiColon;
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
      Code += period;
    }

    public void AddIsTrue()
    {
      Code += isTrueToken;
    }

    public void AddTrue()
    {
      Code += trueToken;
    }

    public void VerifyUsingDependance()
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
        VerifyUsingDependance();
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