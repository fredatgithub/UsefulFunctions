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
using System.IO;
using System.Reflection;
using System.Text;

namespace CodeGeneration
{
  class Program
  {
    static void Main()
    {
      Action<string> display = Console.WriteLine;
      display("Generating code for Unit tests in a file");
      string fileName = "UnitTestFunctionsString2.cs";
      Dictionary<string, string> usingRequired = new Dictionary<string, string>();
      string carriageReturn = Environment.NewLine;
      string usingToken = "using";
      string space = " ";
      string semiColon = ";";
      string systemtoken = "System";
      string openCurlyBrace = "{";
      string closeCurlyBrace = "}";
      string tabulation = "  ";
      string openSquareBracket = "[";
      string closeSquareBracket = "]";
      string openParenthesis = "(";
      string closeParenthesis = ")";
      string openCloseParenthesis = "()";
      string testClass = "[TestClass]";
      string testMethod = "[TestMethod]";
      string testMethodOnly = "TestMethod";
      string underScore = "_";
      string period = ".";
      string trueToken = "true";
      string falseToken = "false";
      string publictoken = "public";
      string voidToken = "void";
      string assertToken = "Assert";
      string areEqualToken = "AreEqual";
      string areNotEqualToken = "AreNotEqual";
      string isTrueToken = "IsTrue";
      string isFalseToken = "IsFalse";
      string areNotSameToken = "AreNotSame";
      string areSameToken = "AreSame";
      string equalsToken = "Equals";
      string failToken = "Fail";
      string inconclusiveToken = "Inconclusive";
      string isInstanceOfTypeToken = "IsInstanceOfType";
      string isNotInstnaceOfTypeToken = "IsNotInstanceOfType";
      string isNotNulToken = "IsNotNull";
      string isNullToken = "IsNull";
      string ReferenceEqualsToken = "ReferenceEquals";
      string replaceNullCharsToken = "ReplaceNullChars";
      string publicClass = "public class UnitTestMethodsString";
      usingRequired.Add(assertToken, "Microsoft.VisualStudio.TestTools.UnitTesting");
      StringBuilder code = new StringBuilder();
      code.Append(usingToken);
      code.Append(space);
      code.Append(systemtoken);
      code.Append(semiColon);
      code.Append(carriageReturn);

      code.Append(usingToken);
      code.Append(space);
      code.Append(usingRequired[assertToken]);
      code.Append(semiColon);
      code.Append(carriageReturn);

      code.Append("namespace UnitTestUsefullFunctions" + carriageReturn);
      code.Append(openCurlyBrace + carriageReturn);
      code.Append(tabulation + testClass + carriageReturn);
      code.Append(tabulation + publicClass + carriageReturn);
      code.Append(tabulation + openCurlyBrace + carriageReturn);
      code.Append(tabulation + tabulation);
      code.Append(testMethod + carriageReturn);
      code.Append(tabulation + tabulation);
      code.Append(publictoken);
      code.Append(space);
      code.Append(voidToken);
      code.Append(space);
      code.Append(testMethodOnly);
      code.Append(underScore);
      code.Append("method1");
      code.Append(underScore);
      code.Append(trueToken);
      code.Append(openCloseParenthesis);
      code.Append(carriageReturn);
      code.Append(tabulation + tabulation);
      code.Append(openCurlyBrace);
      code.Append(carriageReturn);
      code.Append(tabulation + tabulation + tabulation);
      code.Append(assertToken);
      code.Append(period);
      code.Append(isTrueToken);
      code.Append(openParenthesis);
      code.Append(trueToken);
      code.Append(closeParenthesis);
      code.Append(semiColon);
      code.Append(carriageReturn);
      code.Append(tabulation + tabulation);
      code.Append(closeCurlyBrace);
      code.Append(carriageReturn); // close method
      code.Append(tabulation);
      code.Append(closeCurlyBrace); // close class
      code.Append(carriageReturn);
      code.Append(closeCurlyBrace); // close namespace
      code.Append(carriageReturn);
      string codeFinalized = code.ToString();
      // writing the file
      StreamWriter sw = new StreamWriter(fileName);
      sw.Write(codeFinalized);
      sw.Close();
      display("The file has been written in\n" +
        Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\" +
        fileName);

      // with class
      CodeFile codeFile = new CodeFile("UnitTestFunctionsString3", "UnitTestFunctionsString3.cs");
      codeFile.AddUsing("using system;");
      codeFile.AddCarriageReturn();
      codeFile.AddUsing("using Microsoft.VisualStudio.TestTools.UnitTesting;");
      codeFile.AddCode("namespace UnitTestUsefullFunctions");
      codeFile.AddCarriageReturn();
      codeFile.AddOpenCurlyBrace();
      codeFile.AddTabulation(2);
      codeFile.AddTestClassAttribute();
      codeFile.AddTabulation(2);
      codeFile.AddCode("public class UnitTestMethodsString");
      codeFile.AddCarriageReturn();
      codeFile.AddTabulation(2);
      codeFile.AddOpenCurlyBrace();
      codeFile.AddTabulation(4);
      codeFile.AddTestMethodAttribute();
      codeFile.AddTabulation(4);
      codeFile.AddCode("public void TestMethod_method1_true()");
      codeFile.AddCarriageReturn();
      codeFile.AddTabulation(4);
      codeFile.AddOpenCurlyBrace();
      codeFile.AddTabulation(6);
      codeFile.AddAssert();
      codeFile.AddPeriod();
      codeFile.AddIsTrue();
      codeFile.AddOpenParenthesis();
      codeFile.AddTrue();
      codeFile.AddCloseParenthesis();
      codeFile.AddSemiColon();
      codeFile.AddCarriageReturn();
      codeFile.AddTabulation(4);
      codeFile.AddCloseCurlyBrace();
      codeFile.AddTabulation(2);
      codeFile.AddCloseCurlyBrace();
      codeFile.AddCloseCurlyBrace();
      codeFile.Save();
      display("");
      display("The file has been written in\n" +
        Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\" +
        codeFile.FileName);
      display("Press a key to exit:");
      Console.ReadKey();
    }
  }
}