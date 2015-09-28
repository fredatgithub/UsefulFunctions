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
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using CodeGenerationWinForm.Properties;
using MathFunc = FonctionsUtiles.Fred.Csharp.FunctionsMath;
using StringFunc = FonctionsUtiles.Fred.Csharp.FunctionsString;
using FonctionsUtiles.Fred.Csharp;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Linq;

namespace CodeGenerationWinForm
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    readonly Dictionary<string, string> _languageDicoEn = new Dictionary<string, string>();
    readonly Dictionary<string, string> _languageDicoFr = new Dictionary<string, string>();
    private string _currentLanguage = "english";

    private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveWindowValue();
      Application.Exit();
    }

    private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutBoxApplication aboutBoxApplication = new AboutBoxApplication();
      aboutBoxApplication.ShowDialog();
    }

    private void DisplayTitle()
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      // Text += $" V{fvi.FileMajorPart}.{fvi.FileMinorPart}.{fvi.FileBuildPart}.{fvi.FilePrivatePart}"; // doesn't build in appveyor
      Text += string.Format(" V{0}.{1}.{2}.{3}", fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart, fvi.FilePrivatePart);
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      LoadSettingsAtStartup();
    }

    private void LoadSettingsAtStartup()
    {
      DisplayTitle();
      LoadLanguages();
      SetLanguage(Settings.Default.LastLanguageUsed);
      FillComboBoxLanguage(comboBoxLanguage);
      FillComboBoxLanguage(comboBoxRndMethodLanguage);
      FillComboBoxLanguage(comboBoxOneMethodLanguage);
      FillComboBoxOtherMethods(comboBoxOthersMethodName);
      FillComboBoxWithTypes(comboBoxCustoExpectedType);
      FillComboBoxWithTypes(comboBoxCustoSourceType);
      FillComboBoxWithTypes(comboBoxCustoResultReturnedType);
      FillComboBoxWithAssertMethods(comboBoxCustoAssertMethod);
      tabControlMain.SelectedIndex = Settings.Default.MostRecentTabUsed;
      checkBoxCustomRange.Checked = Settings.Default.checkBoxCustomRange;
      GetWindowValue();
    }

    private static void FillComboBoxLanguage(ComboBox cb)
    {
      cb.Items.Clear();
      cb.Items.Add("French");
      cb.Items.Add("English");
      cb.Items.Add("Both French and English");
      cb.SelectedIndex = 0;
    }

    private static void FillComboBoxWithDllMethods(ComboBox cb)
    {
      cb.Items.Clear();
      cb.Items.Add("FunctionsFiles");
      cb.Items.Add("FunctionsMath");
      cb.Items.Add("FunctionsString");
      cb.Items.Add("FunctionsUseful");
      cb.SelectedIndex = 0;
    }

    private static void FillComboBoxWithAssertMethods(ComboBox cb)
    {
      cb.Items.Clear();
      cb.Items.Add("AreEqual");
      cb.Items.Add("AreNotEqual");
      cb.Items.Add("IsTrue");
      cb.Items.Add("IsFalse");
      cb.Items.Add("AreNotSame");
      cb.Items.Add("AreSame");
      cb.Items.Add("Equals");
      cb.Items.Add("Fail");
      cb.Items.Add("Inconclusive");
      cb.Items.Add("IsInstanceOfType");
      cb.Items.Add("IsNotInstanceOfType");
      cb.Items.Add("IsNotNull");
      cb.Items.Add("IsNull");
      cb.Items.Add("ReferenceEquals");
      cb.Items.Add("ReplaceNullChars");
      cb.SelectedIndex = 0;
    }

    private static void FillComboBoxOtherMethods(ComboBox cb)
    {
      cb.Items.Clear();
      cb.Items.Add("BigInt");
      cb.SelectedIndex = 0;
    }

    private static void FillComboBoxWithTypes(ComboBox cb)
    {
      cb.Items.Clear();
      cb.Items.Add("char");
      cb.Items.Add("char[]");
      cb.Items.Add("short");
      cb.Items.Add("short[]");
      cb.Items.Add("ushort");
      cb.Items.Add("ushort[]");
      cb.Items.Add("int");
      cb.Items.Add("int[]");
      cb.Items.Add("uint");
      cb.Items.Add("uint[]");
      cb.Items.Add("byte");
      cb.Items.Add("byte[]");
      cb.Items.Add("sbyte");
      cb.Items.Add("sbyte[]");
      cb.Items.Add("bool");
      cb.Items.Add("bool[]");
      cb.Items.Add("long");
      cb.Items.Add("long[]");
      cb.Items.Add("ulong");
      cb.Items.Add("ulong[]");
      cb.Items.Add("decimal");
      cb.Items.Add("decimal[]");
      cb.Items.Add("float");
      cb.Items.Add("float[]");
      cb.Items.Add("string");
      cb.Items.Add("string[]");
      cb.Items.Add("object");
      cb.Items.Add("object[]");
      cb.SelectedIndex = 0;
    }

    private static int MatchingComboBox(string typeString)
    {
      if (typeString == "true") // bool
      {
        return 6;
      }

      if (typeString == "false") // bool
      {
        return 6;
      }

      int tmp = 0;
      if (int.TryParse(typeString, out tmp)) // int
      {
        return 0;
      }

      if (typeString.StartsWith("\"")) // string
      {
        return 2;
      }

      byte tmp2 = 0;
      if (byte.TryParse(typeString, out tmp2)) // byte
      {
        return 4;
      }

      return 0;
    }

    private void GetWindowValue()
    {
      Width = Settings.Default.WindowWidth;
      Height = Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
      checkBoxAutoCheckTypes.Checked = Settings.Default.checkBoxAutoCheckTypes;
      // Customized method tab
      textBoxCustPublic.Text = Settings.Default.textBoxCustPublic;
      textBoxCustoVoid.Text = Settings.Default.textBoxCustoVoid;
      textBoxCustoTestMethod.Text = Settings.Default.textBoxCustoTestMethod;
      textBoxCustoMethodName.Text = Settings.Default.textBoxCustoMethodName;
      textBoxCustoExpectedCosntant.Text = Settings.Default.textBoxCustoExpectedCosntant;
      comboBoxCustoExpectedType.SelectedIndex = Settings.Default.comboBoxCustoExpectedType;
      textBoxCustoExpectedWord.Text = Settings.Default.textBoxCustoExpectedWord;
      textBoxCustoExpectedEqualSign.Text = Settings.Default.textBoxCustoExpectedEqualSign;
      textBoxCustoExpectedValue.Text = Settings.Default.textBoxCustoExpectedValue;
      textBoxCustoConstantSource.Text = Settings.Default.textBoxCustoConstantSource;
      comboBoxCustoSourceType.SelectedIndex = Settings.Default.comboBoxCustoSourceType;
      textBoxCustoSourceWord.Text = Settings.Default.textBoxCustoSourceWord;
      textBoxCustoSourceEqualSign.Text = Settings.Default.textBoxCustoSourceEqualSign;
      textBoxCustoSourceValue.Text = Settings.Default.textBoxCustoSourceValue;
      comboBoxCustoResultReturnedType.SelectedIndex = Settings.Default.comboBoxCustoResultReturnedType;
      textBoxCustoResultWord.Text = Settings.Default.textBoxCustoResultWord;
      textBoxCustoResultEqualSign.Text = Settings.Default.textBoxCustoResultEqualSign;
      textBoxCustoResultFunctionClass.Text = Settings.Default.textBoxCustoResultFunctionClass;
      textBoxcustoResultFunctionName.Text = Settings.Default.textBoxcustoResultFunctionName;
      textBoxCustoResultSourceWord.Text = Settings.Default.textBoxCustoResultSourceWord;
      textBoxCustoAssertWord.Text = Settings.Default.textBoxCustoAssertWord;
      comboBoxCustoAssertMethod.SelectedIndex = Settings.Default.comboBoxCustoAssertMethod;
      textBoxCustoAssertOpenParenthesis.Text = Settings.Default.textBoxCustoAssertOpenParenthesis;
      textBoxCustoAssertResultWord.Text = Settings.Default.textBoxCustoAssertResultWord;
      textBoxCustoAssertComma.Text = Settings.Default.textBoxCustoAssertComma;
      textBoxCustoAssertExpectedWord.Text = Settings.Default.textBoxCustoAssertExpectedWord;
      textBoxCustoAssertClosingParenthesis.Text = Settings.Default.textBoxCustoAssertClosingParenthesis;
      textBoxCustomFrom.Text = Settings.Default.textBoxCustomFrom;
      textBoxCustomTo.Text = Settings.Default.textBoxCustomTo;
      textBoxCodeLineRangeFrom.Text = Settings.Default.textBoxCodeLineRangeFrom;
      textBoxCodeLineRangeTo.Text = Settings.Default.textBoxCodeLineRangeTo;
      textBoxCodeLineSentence1.Text = Settings.Default.textBoxCodeLineSentence1;
      textBoxCodeLineSentence2.Text = Settings.Default.textBoxCodeLineSentence2;
      textBoxCodeLineSentence3.Text = Settings.Default.textBoxCodeLineSentence3;
      textBoxCodeLineSentence4.Text = Settings.Default.textBoxCodeLineSentence4;
      textBoxCodeLineSentence5.Text = Settings.Default.textBoxCodeLineSentence5;
      radioButtonCodeLineOneLine.Checked = Settings.Default.radioButtonCodeLineOneLine;
      radioButtonCodeLineSeveralLines.Checked = !Settings.Default.radioButtonCodeLineOneLine;
      radioButtonCodeLineIncrementNumber.Checked = Settings.Default.radioButtonCodeLineIncrementNumber;
      radioButtonCodeLineIncrementLetter.Checked = !Settings.Default.radioButtonCodeLineIncrementNumber;
      textBoxCodeLineIteratorChar.Text = Settings.Default.textBoxCodeLineIteratorChar;
      checkBoxCodeLineResultAssembled.Checked = Settings.Default.checkBoxCodeLineResultAssembled;
    }

    private void SaveWindowValue()
    {
      Settings.Default.WindowHeight = Height;
      Settings.Default.WindowWidth = Width;
      Settings.Default.WindowLeft = Left;
      Settings.Default.WindowTop = Top;
      Settings.Default.MostRecentTabUsed = tabControlMain.SelectedIndex;
      // Customized method tab
      Settings.Default.checkBoxAutoCheckTypes = checkBoxAutoCheckTypes.Checked;
      Settings.Default.checkBoxCustomRange = checkBoxCustomRange.Checked;
      Settings.Default.textBoxCustoAttribute = textBoxCustoAttribute.Text;
      Settings.Default.textBoxCustomFrom = textBoxCustomFrom.Text;
      Settings.Default.textBoxCustomTo = textBoxCustomTo.Text;
      Settings.Default.textBoxCustPublic = textBoxCustPublic.Text;
      Settings.Default.textBoxCustoVoid = textBoxCustoVoid.Text;
      Settings.Default.textBoxCustPublic = textBoxCustPublic.Text;
      Settings.Default.textBoxCustoVoid = textBoxCustoVoid.Text;
      Settings.Default.textBoxCustoTestMethod = textBoxCustoTestMethod.Text;
      Settings.Default.textBoxCustoMethodName = textBoxCustoMethodName.Text;
      Settings.Default.textBoxCustoExpectedCosntant = textBoxCustoExpectedCosntant.Text;
      Settings.Default.comboBoxCustoExpectedType = comboBoxCustoExpectedType.SelectedIndex;
      Settings.Default.textBoxCustoExpectedWord = textBoxCustoExpectedWord.Text;
      Settings.Default.textBoxCustoExpectedEqualSign = textBoxCustoExpectedEqualSign.Text;
      Settings.Default.textBoxCustoExpectedValue = textBoxCustoExpectedValue.Text;
      Settings.Default.textBoxCustoConstantSource = textBoxCustoConstantSource.Text;
      Settings.Default.comboBoxCustoSourceType = comboBoxCustoSourceType.SelectedIndex;
      Settings.Default.textBoxCustoSourceWord = textBoxCustoSourceWord.Text;
      Settings.Default.textBoxCustoSourceEqualSign = textBoxCustoSourceEqualSign.Text;
      Settings.Default.textBoxCustoSourceValue = textBoxCustoSourceValue.Text;
      Settings.Default.comboBoxCustoResultReturnedType = comboBoxCustoResultReturnedType.SelectedIndex;
      Settings.Default.textBoxCustoResultWord = textBoxCustoResultWord.Text;
      Settings.Default.textBoxCustoResultEqualSign = textBoxCustoResultEqualSign.Text;
      Settings.Default.textBoxCustoResultFunctionClass = textBoxCustoResultFunctionClass.Text;
      Settings.Default.textBoxcustoResultFunctionName = textBoxcustoResultFunctionName.Text;
      Settings.Default.textBoxCustoResultSourceWord = textBoxCustoResultSourceWord.Text;
      Settings.Default.textBoxCustoAssertWord = textBoxCustoAssertWord.Text;
      Settings.Default.comboBoxCustoAssertMethod = comboBoxCustoAssertMethod.SelectedIndex;
      Settings.Default.textBoxCustoAssertOpenParenthesis = textBoxCustoAssertOpenParenthesis.Text;
      Settings.Default.textBoxCustoAssertResultWord = textBoxCustoAssertResultWord.Text;
      Settings.Default.textBoxCustoAssertComma = textBoxCustoAssertComma.Text;
      Settings.Default.textBoxCustoAssertExpectedWord = textBoxCustoAssertExpectedWord.Text;
      Settings.Default.textBoxCustoAssertClosingParenthesis = textBoxCustoAssertClosingParenthesis.Text;
      Settings.Default.LastLanguageUsed = frenchToolStripMenuItem.Checked ? "French" : "English";
      Settings.Default.textBoxCustomFrom = textBoxCustomFrom.Text;
      Settings.Default.textBoxCustomTo = textBoxCustomTo.Text;
      Settings.Default.textBoxCodeLineRangeFrom = textBoxCodeLineRangeFrom.Text;
      Settings.Default.textBoxCodeLineRangeTo = textBoxCodeLineRangeTo.Text;
      Settings.Default.textBoxCodeLineSentence1 = textBoxCodeLineSentence1.Text;
      Settings.Default.textBoxCodeLineSentence2 = textBoxCodeLineSentence2.Text;
      Settings.Default.textBoxCodeLineSentence3 = textBoxCodeLineSentence3.Text;
      Settings.Default.textBoxCodeLineSentence4 = textBoxCodeLineSentence4.Text;
      Settings.Default.textBoxCodeLineSentence5 = textBoxCodeLineSentence5.Text;
      Settings.Default.radioButtonCodeLineOneLine = radioButtonCodeLineOneLine.Checked;
      Settings.Default.radioButtonCodeLineIncrementNumber = radioButtonCodeLineIncrementNumber.Checked;
      Settings.Default.textBoxCodeLineIteratorChar = textBoxCodeLineIteratorChar.Text;
      Settings.Default.checkBoxCodeLineResultAssembled = checkBoxCodeLineResultAssembled.Checked;
      Settings.Default.Save();
    }

    private void FormMainFormClosing(object sender, FormClosingEventArgs e)
    {
      SaveWindowValue();
    }

    public enum Language
    {
      French,
      English
    }

    private void LoadLanguages()
    {
      if (!File.Exists(Settings.Default.LanguageFileName))
      {
        CreateLanguageFile();
      }

      // read the translation file and feed the language
      XDocument xDoc = XDocument.Load(Settings.Default.LanguageFileName);
      var result = from node in xDoc.Descendants("term")
                   where node.HasElements
                   let xElemenName = node.Element("name")
                   where xElemenName != null
                   let xElementEnglish = node.Element("englishValue")
                   where xElementEnglish != null
                   let xElementFrench = node.Element("frenchValue")
                   where xElementFrench != null
                   select new
                   {
                     name = xElemenName.Value,
                     englishValue = xElementEnglish.Value,
                     frenchValue = xElementFrench.Value
                   };
      foreach (var i in result)
      {
        _languageDicoEn.Add(i.name, i.englishValue);
        _languageDicoFr.Add(i.name, i.frenchValue);
      }
    }

    private static void CreateLanguageFile()
    {
      var minimumVersion = new List<string>
      {
        "<?xml version=\"1.0\" encoding=\"utf - 8\" ?>",
        "<Document>",
        "<DocumentVersion>",
        "<version> 1.0 </version>",
        "</DocumentVersion>",
        "<terms>",
         "<term>",
        "<name>MenuFile</name>",
        "<englishValue>File</englishValue>",
        "<frenchValue>Fichier</frenchValue>",
        "</term>",
        "  </terms>",
        "</Document>"
      };
      StreamWriter sw = new StreamWriter(Settings.Default.LanguageFileName);
      foreach (string item in minimumVersion)
      {
        sw.WriteLine(item);
      }

      sw.Close();
    }

    private DialogResult DisplayMessage(string message, string title, MessageBoxButtons buttons)
    {
      DialogResult result = MessageBox.Show(this, message, title, buttons);
      return result;
    }

    private void DisplayMessageOk(string message, string title, MessageBoxButtons buttons)
    {
      MessageBox.Show(this, message, title, buttons);
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control>
      {
        textBoxCodeGeneratedResult,
        textBoxOneMethodNumber,
        textBoxRangeMethods,
        textBoxFromNumber,
        textBoxToNumber,
        textBoxRandomMethodResult,
        textBoxNumberOfRndMethod,
        textBoxOthersResult,
        textBoxOthersFrom,
        textBoxOthersTo,
        textBoxCustoResult,
        // fifth tab customized method
        textBoxCustPublic,
        textBoxCustoTestMethod,
        textBoxCustoMethodName,
        textBoxCustoExpectedCosntant,
        textBoxCustoExpectedWord,
        textBoxCustoExpectedEqualSign,
        textBoxCustoExpectedValue,
        textBoxCustoExpectedSemiColon,
        textBoxCustoConstantSource,
        textBoxCustoSourceWord,
        textBoxCustoSourceValue,
        textBoxCustoSourceSemiColon,
        textBoxCustoResultWord,
        textBoxCustoResultEqualSign,
        textBoxCustoResultFunctionClass,
        textBoxcustoResultFunctionName,
        textBoxCustoResultSourceWord,
        textBoxCustoAssertWord,
        textBoxCustoAssertOpenParenthesis,
        textBoxCustoAssertResultWord,
        textBoxCustoAssertComma,
        textBoxCustoAssertExpectedWord,
        textBoxCustoAssertClosingParenthesis,
        textBoxCustomFrom,
        textBoxCustomTo,
        textBoxCustoResult
      });
      var tb = focusedControl as TextBox;
      if (tb != null)
      {
        CopytToClipboard(tb);
      }
    }

    private void CopytToClipboard(TextBoxBase tb, string message = "nothing")
    {
      if (tb != ActiveControl) return;
      if (tb.Text == string.Empty)
      {
        DisplayMessageOk("There is nothing to copy ", message, MessageBoxButtons.OK);
        return;
      }


      if (tb.SelectedText == string.Empty)
      {
        DisplayMessageOk("No text has been selected", message, MessageBoxButtons.OK);
        return;
      }

      Clipboard.SetText(tb.SelectedText);
    }

    private void CutToClipboard(TextBoxBase tb, string errorMessage = "nothing")
    {
      if (tb != ActiveControl) return;
      if (tb.Text == string.Empty)
      {
        DisplayMessageOk("There is " + errorMessage + " to cut ", errorMessage, MessageBoxButtons.OK);
        return;
      }


      if (tb.SelectedText == string.Empty)
      {
        DisplayMessageOk("No text has been selected", errorMessage, MessageBoxButtons.OK);
        return;
      }

      Clipboard.SetText(tb.SelectedText);
      tb.SelectedText = string.Empty;
    }

    private void PasteFromClipboard(TextBoxBase tb)
    {
      if (tb != ActiveControl) return;
      var selectionIndex = tb.SelectionStart;
      tb.Text = tb.Text.Insert(selectionIndex, Clipboard.GetText());
      tb.SelectionStart = selectionIndex + Clipboard.GetText().Length;
    }

    private void cutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control>
      {
        textBoxCodeGeneratedResult,
        textBoxOneMethodNumber,
        textBoxRangeMethods,
        textBoxFromNumber,
        textBoxToNumber,
        textBoxRandomMethodResult,
        textBoxNumberOfRndMethod,
        textBoxOthersResult,
        textBoxOthersFrom,
        textBoxOthersTo,
        textBoxCustoResult,
        // fifth tab customized method
        textBoxCustPublic,
        textBoxCustoTestMethod,
        textBoxCustoMethodName,
        textBoxCustoExpectedCosntant,
        textBoxCustoExpectedWord,
        textBoxCustoExpectedEqualSign,
        textBoxCustoExpectedValue,
        textBoxCustoExpectedSemiColon,
        textBoxCustoConstantSource,
        textBoxCustoSourceWord,
        textBoxCustoSourceValue,
        textBoxCustoSourceSemiColon,
        textBoxCustoResultWord,
        textBoxCustoResultEqualSign,
        textBoxCustoResultFunctionClass,
        textBoxcustoResultFunctionName,
        textBoxCustoResultSourceWord,
        textBoxCustoAssertWord,
        textBoxCustoAssertOpenParenthesis,
        textBoxCustoAssertResultWord,
        textBoxCustoAssertComma,
        textBoxCustoAssertExpectedWord,
        textBoxCustoAssertClosingParenthesis,
        textBoxCustomFrom,
        textBoxCustomTo,
        textBoxCustoResult
        });

      var tb = focusedControl as TextBox;
      if (tb != null)
      {
        CutToClipboard(tb);
      }
    }

    private static Control FindFocusedControl(List<Control> container)
    {
      return container.FirstOrDefault(control => control.Focused);
    }

    private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control>
      {
        textBoxCodeGeneratedResult,
        textBoxOneMethodNumber,
        textBoxRangeMethods,
        textBoxFromNumber,
        textBoxToNumber,
        textBoxRandomMethodResult,
        textBoxNumberOfRndMethod,
        textBoxOthersResult,
        textBoxOthersFrom,
        textBoxOthersTo,
        textBoxCustoResult,
        // fifth tab customized method
        textBoxCustPublic,
        textBoxCustoTestMethod,
        textBoxCustoMethodName,
        textBoxCustoExpectedCosntant,
        textBoxCustoExpectedWord,
        textBoxCustoExpectedEqualSign,
        textBoxCustoExpectedValue,
        textBoxCustoExpectedSemiColon,
        textBoxCustoConstantSource,
        textBoxCustoSourceWord,
        textBoxCustoSourceValue,
        textBoxCustoSourceSemiColon,
        textBoxCustoResultWord,
        textBoxCustoResultEqualSign,
        textBoxCustoResultFunctionClass,
        textBoxcustoResultFunctionName,
        textBoxCustoResultSourceWord,
        textBoxCustoAssertWord,
        textBoxCustoAssertOpenParenthesis,
        textBoxCustoAssertResultWord,
        textBoxCustoAssertComma,
        textBoxCustoAssertExpectedWord,
        textBoxCustoAssertClosingParenthesis,
        textBoxCustomFrom,
        textBoxCustomTo,
        textBoxCustoResult
      });
      var tb = focusedControl as TextBox;
      if (tb != null)
      {
        PasteFromClipboard(tb);
      }
    }

    private void buttonGenerateCode_Click(object sender, EventArgs e)
    {
      if (textBoxOneMethodNumber.Text == string.Empty)
      {
        DisplayMessageOk("The number cannot be empty", "Empty field", MessageBoxButtons.OK);
        return;
      }

      int numberToBeGenerated = 0;
      if (!int.TryParse(textBoxOneMethodNumber.Text, out numberToBeGenerated))
      {
        DisplayMessageOk("The characters are not a number or\nthe number is too big (above 2,147,483,647)", "Not a number", MessageBoxButtons.OK);
        textBoxOneMethodNumber.Text = string.Empty;
        return;
      }

      string languageToTranslate = comboBoxOneMethodLanguage.SelectedItem.ToString();
      var method1 = new UnitTestCodeGenerated(
        numberToBeGenerated.ToString(),
        "const string expected = \"" + numberToBeGenerated + "\";",
        "string result = StringFunc.NumberToEnglishWords(" + numberToBeGenerated + ");",
        "Assert.AreEqual(expected, result);");
      switch (languageToTranslate)
      {
        case "English":
          method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToEnglishWords(numberToBeGenerated), ' ', '_');
          method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(method1.CodeSignatureMethodName, '-', '_');
          method1.CodeExpected = "const string expected = \"" + StringFunc.NumberToEnglishWords(numberToBeGenerated) + "\";";
          method1.CodeResult = "string result = StringFunc.NumberToFrenchWords(" + numberToBeGenerated + ");";
          break;
        case "French":
          method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToFrenchWords(numberToBeGenerated), ' ', '_');
          method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(method1.CodeSignatureMethodName, '-', '_');
          method1.CodeExpected = "const string expected = \"" + StringFunc.NumberToFrenchWords(numberToBeGenerated) + "\";";
          method1.CodeResult = "string result = StringFunc.NumberToFrenchWords(" + numberToBeGenerated + ");";
          break;
        case "Both French and English":
          method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToEnglishWords(numberToBeGenerated), ' ', '_');
          method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(method1.CodeSignatureMethodName, '-', '_');
          method1.CodeExpected = "const string expected = \"" + StringFunc.NumberToEnglishWords(numberToBeGenerated) + "\";";
          method1.CodeResult = "string result = StringFunc.NumberToEnglishWords(" + numberToBeGenerated + ");";
          break;
      }

      if (languageToTranslate == "Both French and English")
      {
        textBoxCodeGeneratedResult.Text += method1.ToString();
        var method2 = new UnitTestCodeGenerated(
        StringFunc.NumberToFrenchWords(numberToBeGenerated),
        "const string expected = \"" + StringFunc.NumberToFrenchWords(numberToBeGenerated) + "\";",
        "string result = StringFunc.NumberToEnglishWords(" + numberToBeGenerated + ");",
        "Assert.AreEqual(expected, result);")
        {
          CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToFrenchWords(numberToBeGenerated), ' ', '_')
        };

        method2.CodeSignatureMethodName = StringFunc.ReplaceCharacters(method2.CodeSignatureMethodName, '-', '_');
        method2.CodeExpected = "const string expected = \"" + StringFunc.NumberToFrenchWords(numberToBeGenerated) + "\";";
        method2.CodeResult = "string result = StringFunc.NumberToFrenchWords(" + numberToBeGenerated + ");";
        textBoxCodeGeneratedResult.Text += method2.ToString();
      }
      else
      {
        textBoxCodeGeneratedResult.Text += method1.ToString();
      }
    }

    private void buttonGenerateSeveralMethods_Click(object sender, EventArgs e)
    {
      if (textBoxFromNumber.Text == string.Empty)
      {
        DisplayMessageOk("The number of method requested cannot be empty", "Empty field", MessageBoxButtons.OK);
        return;
      }

      int fromNumberOfMethodToBeGenerated = 0;
      if (!int.TryParse(textBoxFromNumber.Text, out fromNumberOfMethodToBeGenerated))
      {
        DisplayMessageOk("The lower bound is not a number or\nthe number is too big (above 2,147,483,647)", "Not a number", MessageBoxButtons.OK);
        textBoxFromNumber.Text = string.Empty;
        return;
      }

      int toNumberOfMethodToBeGenerated = 0;
      if (!int.TryParse(textBoxToNumber.Text, out toNumberOfMethodToBeGenerated))
      {
        DisplayMessageOk("The upper bound is not a number or\nthe number is too big (above 2,147,483,647)", "Not a number", MessageBoxButtons.OK);
        textBoxToNumber.Text = string.Empty;
        return;
      }

      if (toNumberOfMethodToBeGenerated < fromNumberOfMethodToBeGenerated)
      {
        DisplayMessageOk("The upper bound is smaller than the lower bound", "Negative range", MessageBoxButtons.OK);
        textBoxToNumber.Text = string.Empty;
        return;
      }

      textBoxRangeMethods.Text = string.Empty;

      string languageToTranslate = comboBoxLanguage.SelectedItem.ToString();
      progressBarSeveralMethods.Visible = true;
      progressBarSeveralMethods.Minimum = fromNumberOfMethodToBeGenerated;
      progressBarSeveralMethods.Maximum = toNumberOfMethodToBeGenerated;
      progressBarSeveralMethods.Value = progressBarSeveralMethods.Minimum;
      Application.DoEvents();
      for (int i = fromNumberOfMethodToBeGenerated; i <= toNumberOfMethodToBeGenerated; i++)
      {
        progressBarSeveralMethods.Value = i;
        Application.DoEvents();

        var method1 = new UnitTestCodeGenerated(
          i.ToString(),
          " const string expected = \"\";",
          " string result = StringFunc.NumberToEnglishWords(" + i + ");",
          " Assert.AreEqual(expected, result);");
        switch (languageToTranslate)
        {
          case "English":
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToEnglishWords(i), ' ', '_');
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(method1.CodeSignatureMethodName, '-', '_');
            method1.CodeExpected = " const string expected = \"" + StringFunc.NumberToEnglishWords(i) + "\";";
            break;
          case "French":
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToFrenchWords(i), ' ', '_');
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(method1.CodeSignatureMethodName, '-', '_');
            method1.CodeExpected = " const string expected = \"" + StringFunc.NumberToFrenchWords(i) + "\";";
            method1.CodeResult = " string result = StringFunc.NumberToFrenchWords(" + i + ");";
            break;
          case "Both French and English":
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToEnglishWords(i), ' ', '_');
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(method1.CodeSignatureMethodName, '-', '_');
            method1.CodeExpected = " const string expected = \"" + StringFunc.NumberToEnglishWords(i) + "\";";
            break;
          default:
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToEnglishWords(i), ' ', '_');
            method1.CodeExpected = " const string expected = \"" + StringFunc.NumberToEnglishWords(i) + "\";";
            break;
        }

        if (languageToTranslate == "Both French and English")
        {
          textBoxRangeMethods.Text += method1.ToString();
          var method2 = new UnitTestCodeGenerated(
          StringFunc.NumberToFrenchWords(i),
          " const string expected = \"" + StringFunc.NumberToFrenchWords(i) + "\";",
          " string result = StringFunc.NumberToEnglishWords(" + i + ");",
          " Assert.AreEqual(expected, result);")
          {
            CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToFrenchWords(i), ' ', '_')
          };

          method2.CodeSignatureMethodName = StringFunc.ReplaceCharacters(method2.CodeSignatureMethodName, '-', '_');
          method2.CodeExpected = " const string expected = \"" + StringFunc.NumberToFrenchWords(i) + "\";";
          method2.CodeResult = " string result = StringFunc.NumberToFrenchWords(" + i + ");";
          textBoxRangeMethods.Text += method2.ToString();
        }
        else
        {
          textBoxRangeMethods.Text += method1.ToString();
        }
      }

      progressBarSeveralMethods.Value = progressBarSeveralMethods.Minimum;
      progressBarSeveralMethods.Visible = false;
    }

    private void buttonGenerateRdnMethod_Click(object sender, EventArgs e)
    {
      if (textBoxNumberOfRndMethod.Text == string.Empty)
      {
        DisplayMessageOk("The number of method requested cannot be empty", "Empty field", MessageBoxButtons.OK);
        return;
      }

      int numberOfMethodToBeGenerated = 0;
      if (!int.TryParse(textBoxNumberOfRndMethod.Text, out numberOfMethodToBeGenerated))
      {
        DisplayMessageOk("This is not a number or\nthe number is too big (above 2,147,483,647)", "Not a number", MessageBoxButtons.OK);
        textBoxNumberOfRndMethod.Text = string.Empty;
        return;
      }

      textBoxRandomMethodResult.Text = string.Empty;
      string languageToTranslate = comboBoxRndMethodLanguage.SelectedItem.ToString();
      progressBarRandomMethods.Visible = true;
      progressBarRandomMethods.Minimum = 0;
      progressBarRandomMethods.Maximum = numberOfMethodToBeGenerated;
      progressBarRandomMethods.Value = progressBarRandomMethods.Minimum;
      Application.DoEvents();
      for (int i = 0; i < numberOfMethodToBeGenerated; i++)
      {
        progressBarRandomMethods.Value = i;
        Application.DoEvents();
        ulong rndNumber = MathFunc.GenerateRandomBigNumbers(1, 1000000);

        var method1 = new UnitTestCodeGenerated(
          rndNumber.ToString(),
          " const string source = \"\";",
          " string result = StringFunc.NumberToEnglishWords(" + rndNumber + ");",
          " Assert.AreEqual(expected, result);");
        switch (languageToTranslate)
        {
          case "English":
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToEnglishWords(rndNumber), ' ', '_');
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(method1.CodeSignatureMethodName, '-', '_');
            method1.CodeExpected = " const string expected = \"" + StringFunc.NumberToEnglishWords(rndNumber) + "\";";
            method1.CodeResult = " string result = StringFunc.NumberToEnglishWords(" + rndNumber + ");";
            method1.CodeSource = " const ulong source = " + rndNumber + ";";
            break;
          case "French":
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToFrenchWords(rndNumber), ' ', '_');
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(method1.CodeSignatureMethodName, '-', '_');
            method1.CodeExpected = " const string expected = \"" + StringFunc.NumberToFrenchWords(rndNumber) + "\";";
            method1.CodeResult = " string result = StringFunc.NumberToFrenchWords(" + rndNumber + ");";
            method1.CodeSource = " const ulong source = " + rndNumber + ";";
            break;
          case "Both French and English":
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToEnglishWords(rndNumber), ' ', '_');
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(method1.CodeSignatureMethodName, '-', '_');
            method1.CodeExpected = " const string expected = \"" + StringFunc.NumberToEnglishWords(rndNumber) + "\";";
            method1.CodeResult = " string result = StringFunc.NumberToEnglishWords(" + rndNumber + ");";
            method1.CodeSource = " const ulong source = " + rndNumber + ";";
            break;
        }

        if (languageToTranslate == "Both French and English")
        {
          textBoxRandomMethodResult.Text += method1.ToString();
          var method2 = new UnitTestCodeGenerated(
          StringFunc.NumberToFrenchWords(rndNumber),
          " const string expected = \"" + StringFunc.NumberToFrenchWords(rndNumber) + "\";",
          " string result = StringFunc.NumberToFrenchWords(" + rndNumber + ");",
          " Assert.AreEqual(expected, result);")
          {
            CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToFrenchWords(rndNumber), ' ', '_')
          };

          method2.CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToFrenchWords(rndNumber), ' ', '_');
          method2.CodeSignatureMethodName = StringFunc.ReplaceCharacters(method2.CodeSignatureMethodName, '-', '_');
          method2.CodeExpected = " const string expected = \"" + StringFunc.NumberToFrenchWords(rndNumber) + "\";";
          method2.CodeResult = " string result = StringFunc.NumberToFrenchWords(" + rndNumber + ");";
          method2.CodeSource = " const ulong source = " + rndNumber + ";";

          textBoxRandomMethodResult.Text += method2.ToString();
        }
        else
        {
          textBoxRandomMethodResult.Text += method1.ToString();
        }
      }

      progressBarRandomMethods.Value = progressBarRandomMethods.Minimum;
      progressBarRandomMethods.Visible = false;
    }

    private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control>
      {
        textBoxCodeGeneratedResult,
        textBoxOneMethodNumber,
        textBoxRangeMethods,
        textBoxFromNumber,
        textBoxToNumber,
        textBoxRandomMethodResult,
        textBoxNumberOfRndMethod,
        textBoxOthersResult,
        textBoxOthersFrom,
        textBoxOthersTo,
        textBoxCustoResult,
        // fifth tab customized method
        textBoxCustPublic,
        textBoxCustoTestMethod,
        textBoxCustoMethodName,
        textBoxCustoExpectedCosntant,
        textBoxCustoExpectedWord,
        textBoxCustoExpectedEqualSign,
        textBoxCustoExpectedValue,
        textBoxCustoExpectedSemiColon,
        textBoxCustoConstantSource,
        textBoxCustoSourceWord,
        textBoxCustoSourceValue,
        textBoxCustoSourceSemiColon,
        textBoxCustoResultWord,
        textBoxCustoResultEqualSign,
        textBoxCustoResultFunctionClass,
        textBoxcustoResultFunctionName,
        textBoxCustoResultSourceWord,
        textBoxCustoAssertWord,
        textBoxCustoAssertOpenParenthesis,
        textBoxCustoAssertResultWord,
        textBoxCustoAssertComma,
        textBoxCustoAssertExpectedWord,
        textBoxCustoAssertClosingParenthesis,
        textBoxCustomFrom,
        textBoxCustomTo,
        textBoxCustoResult
      });
      if (focusedControl is TextBox)
      {
        ((TextBox)focusedControl).SelectAll();
      }
      //string selectedTab = tabControlMain.SelectedTab.ToString();
      //switch (selectedTab)
      //{
      //  case "TabPage: {One Method}":
      //    //detect which TextBox has the focus
      //    if (textBoxCodeGeneratedResult == ActiveControl)
      //    {
      //      textBoxCodeGeneratedResult.SelectAll();
      //    }

      //    if (textBoxOneMethodNumber == ActiveControl)
      //    {
      //      textBoxOneMethodNumber.SelectAll();
      //    }

      //    break;
      //  case "TabPage: {Several Methods by range}":
      //    if (textBoxRangeMethods == ActiveControl)
      //    {
      //      textBoxRangeMethods.SelectAll();
      //    }

      //    if (textBoxFromNumber == ActiveControl)
      //    {
      //      textBoxFromNumber.SelectAll();
      //    }

      //    if (textBoxToNumber == ActiveControl)
      //    {
      //      textBoxToNumber.SelectAll();
      //    }
      //    break;
      //  case "TabPage: {Random Methods}":
      //    if (textBoxRandomMethodResult == ActiveControl)
      //    {
      //      textBoxRandomMethodResult.SelectAll();
      //    }

      //    if (textBoxNumberOfRndMethod == ActiveControl)
      //    {
      //      textBoxNumberOfRndMethod.SelectAll();
      //    }

      //    break;
      //  case "TabPage: {Others}":
      //    if (textBoxOthersResult == ActiveControl)
      //    {
      //      textBoxOthersResult.SelectAll();
      //    }

      //    if (textBoxOthersFrom == ActiveControl)
      //    {
      //      textBoxOthersFrom.SelectAll();
      //    }

      //    if (textBoxOthersTo == ActiveControl)
      //    {
      //      textBoxOthersTo.SelectAll();
      //    }
      //    break;
      //  case "TabPage: {Customized Method}":
      //    if (textBoxCustoResult == ActiveControl)
      //    {
      //      textBoxCustoResult.SelectAll();
      //    }

      //    break;
      //}
    }

    private void buttonClearOneMethodTextBox_Click(object sender, EventArgs e)
    {
      textBoxCodeGeneratedResult.Text = string.Empty;
    }

    private void buttonOthersGenerate_Click(object sender, EventArgs e)
    {
      if (textBoxOthersFrom.Text == string.Empty)
      {
        DisplayMessageOk("The number of method requested cannot be empty", "Empty field", MessageBoxButtons.OK);
        return;
      }

      int fromNumberOfMethodToBeGenerated = 0;
      if (!int.TryParse(textBoxOthersFrom.Text, out fromNumberOfMethodToBeGenerated))
      {
        DisplayMessageOk("The lower bound is not a number or\nthe number is too big (above 2,147,483,647)", "Not a number", MessageBoxButtons.OK);
        textBoxOthersFrom.Text = string.Empty;
        return;
      }

      int toNumberOfMethodToBeGenerated = 0;
      if (!int.TryParse(textBoxOthersTo.Text, out toNumberOfMethodToBeGenerated))
      {
        DisplayMessageOk("The upper bound is not a number or\nthe number is too big (above 2,147,483,647)", "Not a number", MessageBoxButtons.OK);
        textBoxOthersTo.Text = string.Empty;
        return;
      }

      if (toNumberOfMethodToBeGenerated < fromNumberOfMethodToBeGenerated)
      {
        DisplayMessageOk("The upper bound is smaller than the lower bound", "Negative range", MessageBoxButtons.OK);
        textBoxOthersTo.Text = string.Empty;
        return;
      }

      textBoxOthersResult.Text = string.Empty;

      string chosenMethod = comboBoxOthersMethodName.SelectedItem.ToString();
      progressBarOtherMethods.Visible = true;
      progressBarOtherMethods.Minimum = fromNumberOfMethodToBeGenerated;
      progressBarOtherMethods.Maximum = toNumberOfMethodToBeGenerated;
      progressBarOtherMethods.Value = progressBarOtherMethods.Minimum;
      Application.DoEvents();
      for (int i = fromNumberOfMethodToBeGenerated; i <= toNumberOfMethodToBeGenerated; i++)
      {
        progressBarOtherMethods.Value = i;
        Application.DoEvents();

        var method1 = new UnitTestCodeGenerated(
          i.ToString(),
          "const string expected = \"\";",
          "string result = StringFunc." + chosenMethod + "(" + i + ");",
          "Assert.AreEqual(expected, result);");
        switch (chosenMethod)
        {
          case "BigInt":
            BigInt j = i;
            method1.CodeSource = chosenMethod + " source = " + i + ";";
            method1.CodeSignatureMethodName = "Factorial_" + chosenMethod + "_" + StringFunc.ReplaceCharacters(StringFunc.NumberToEnglishWords(i), '-', '_');
            method1.CodeExpected = chosenMethod + " expected = " + MathFunc.Factorial(j) + ";";
            method1.CodeResult = chosenMethod + " result = FunctionsMath.Factorial(source);";
            break;
        }

        textBoxOthersResult.Text += method1.ToString();
      }

      progressBarOtherMethods.Value = progressBarOtherMethods.Minimum;
      progressBarOtherMethods.Visible = false;
    }

    private static bool TypesAreMatching(TextBoxBase tb, ComboBox cb)
    {
      bool result = false;
      switch (cb.SelectedItem.ToString())
      {
        case "bool":
          if (tb.Text.ToLower() == "true")
          {
            tb.Text = "true"; // remove uppercase
          }

          if (tb.Text.ToLower() == "false")
          {
            tb.Text = "false"; // remove uppercase
          }

          if (tb.Text == "true" || tb.Text == "false")
          {
            result = true;
          }
          else
          {
            result = false;
          }

          break;
        case "string":
          result = tb.Text.StartsWith("\"");
          break;
        case "int":
          int tmp = 0;
          result = int.TryParse(tb.Text, out tmp);
          break;
        case "byte":
          byte tmp2 = 1;
          result = byte.TryParse(tb.Text, out tmp2);
          break;
      }

      return result;
    }

    private void CheckMatchingType(TextBoxBase tb, ComboBox cb, string keyword, bool askUser = true)
    {
      if (TypesAreMatching(tb, cb))
      {
        return;
      }

      if (askUser)
      {
        DialogResult wrongType = DisplayMessage(
        "The type for the " + keyword.ToUpper() + " value doesn't match " +
        cb.SelectedItem
        + "\nWould you like to fix this?",
        "Type mismatched", MessageBoxButtons.YesNo);
        if (wrongType == DialogResult.Yes)
        {
          cb.SelectedIndex = MatchingComboBox(tb.Text);
        }
      }
      else
      {
        cb.SelectedIndex = MatchingComboBox(tb.Text);
      }
    }

    private void buttonCustomizedMethodGenerate_Click(object sender, EventArgs e)
    {
      // Verification of every types used with values
      CheckMatchingType(textBoxCustoExpectedValue, comboBoxCustoExpectedType, "EXPECTED", !checkBoxAutoCheckTypes.Checked);

      // Generation of the result
      textBoxCustoResult.Text = string.Empty;
      if (!checkBoxCustomRange.Checked)
      {
        StringBuilder result = new StringBuilder();
        // next line ATTRIBUTE
        result.Append(textBoxCustoAttribute.Text);
        result.Append(Punctuation.CrLf);

        // next line METHOD SIGNATURE
        result.Append(textBoxCustPublic.Text);
        result.Append(Punctuation.OneSpace);
        result.Append(textBoxCustoVoid.Text);
        result.Append(Punctuation.OneSpace);
        result.Append(textBoxCustoTestMethod.Text);
        result.Append(Punctuation.OneSpace);
        result.Append(textBoxCustoMethodName.Text);
        result.Append(Punctuation.CrLf);

        result.Append(textBoxcustoOpenCurlyBrace.Text);
        result.Append(Punctuation.CrLf);

        // next line SOURCE
        result.Append(Punctuation.Tabulate(2));
        result.Append(textBoxCustoConstantSource.Text);
        result.Append(Punctuation.OneSpace);
        result.Append(comboBoxCustoSourceType.SelectedItem);
        result.Append(Punctuation.OneSpace);
        result.Append(textBoxCustoSourceWord.Text);
        result.Append(Punctuation.OneSpace);
        result.Append(textBoxCustoSourceEqualSign.Text);
        result.Append(Punctuation.OneSpace);
        result.Append(textBoxCustoSourceValue.Text);
        result.Append(Punctuation.OneSpace);
        result.Append(textBoxCustoSourceSemiColon.Text);
        result.Append(Punctuation.CrLf);

        // next line EXPECTED
        result.Append(Punctuation.Tabulate(2));
        result.Append(textBoxCustoExpectedCosntant.Text);
        result.Append(Punctuation.OneSpace);
        result.Append(comboBoxCustoExpectedType.SelectedItem);
        result.Append(Punctuation.OneSpace);
        result.Append(textBoxCustoExpectedWord.Text);
        result.Append(Punctuation.OneSpace);
        result.Append(textBoxCustoExpectedEqualSign.Text);
        result.Append(Punctuation.OneSpace);
        result.Append(textBoxCustoExpectedValue.Text);
        result.Append(Punctuation.OneSpace);
        result.Append(textBoxCustoExpectedSemiColon.Text);
        result.Append(Punctuation.CrLf);

        // next line RESULT
        result.Append(Punctuation.Tabulate(2));
        result.Append(comboBoxCustoResultReturnedType.SelectedItem);
        result.Append(Punctuation.OneSpace);
        result.Append(textBoxCustoResultWord.Text);
        result.Append(Punctuation.OneSpace);
        result.Append(textBoxCustoResultEqualSign.Text);
        result.Append(Punctuation.OneSpace);
        result.Append(textBoxCustoResultFunctionClass.Text);
        result.Append(textBoxcustoResultFunctionName.Text);
        result.Append(Punctuation.OneSpace);
        result.Append(textBoxCustoResultSourceWord.Text);
        result.Append(Punctuation.CrLf);

        // next line ASSERT
        result.Append(Punctuation.Tabulate(2));
        result.Append(textBoxCustoAssertWord.Text);
        result.Append(Punctuation.OneSpace);
        result.Append(comboBoxCustoAssertMethod.SelectedItem);
        result.Append(Punctuation.OneSpace);
        result.Append(textBoxCustoAssertOpenParenthesis.Text);
        result.Append(Punctuation.OneSpace);
        result.Append(textBoxCustoAssertResultWord.Text);
        result.Append(Punctuation.OneSpace);
        result.Append(textBoxCustoAssertComma.Text);
        if (!textBoxCustoAssertComma.Text.EndsWith(" "))
        {
          result.Append(Punctuation.OneSpace);
        }

        result.Append(textBoxCustoAssertExpectedWord.Text);
        result.Append(Punctuation.OneSpace);
        result.Append(textBoxCustoAssertClosingParenthesis.Text);
        result.Append(Punctuation.CrLf);

        // next line closing parenthesis
        result.Append(textBoxCustoCloseCurlyBrace.Text);
        result.Append(Punctuation.CrLf);

        textBoxCustoResult.Text = result.ToString();
      }
      else
      {
        // range of multi instances iterator = %
        int start;
        if (!int.TryParse(textBoxCustomFrom.Text, out start))
        {
          DisplayMessageOk(Translate("This is not a number"), Translate("Not a number"), MessageBoxButtons.OK);
          return;
        }

        int end;
        if (!int.TryParse(textBoxCustomTo.Text, out end))
        {
          DisplayMessageOk(Translate("This is not a number"), Translate("Not a number"), MessageBoxButtons.OK);
          return;
        }

        if (end < start)
        {
          DisplayMessageOk(Translate("The end number must be greater than the start number"),
            Translate("End smaller start"), MessageBoxButtons.OK);
          return;
        }

        for (int i = start; i <= end; i++)
        {
          StringBuilder result = new StringBuilder();
          // next line ATTRIBUTE
          result.Append(textBoxCustoAttribute.Text);
          result.Append(Punctuation.CrLf);

          // next line METHOD SIGNATURE
          result.Append(textBoxCustPublic.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.OneSpace);
          result.Append(textBoxCustoVoid.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.OneSpace);
          result.Append(textBoxCustoTestMethod.Text.Replace("%", i.ToString()));
          result.Append(textBoxCustoMethodName.Text.Replace("%", i.ToString()).EndsWith("()") ?
            textBoxCustoMethodName.Text.Replace("%", i.ToString()) : textBoxCustoMethodName.Text.Replace("%", i.ToString()) + "()");
          result.Append(Punctuation.CrLf);

          result.Append(textBoxcustoOpenCurlyBrace.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.CrLf);

          // next line SOURCE
          result.Append(Punctuation.Tabulate(2));
          result.Append(textBoxCustoConstantSource.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.OneSpace);
          result.Append(comboBoxCustoSourceType.SelectedItem);
          result.Append(Punctuation.OneSpace);
          result.Append(textBoxCustoSourceWord.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.OneSpace);
          result.Append(textBoxCustoSourceEqualSign.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.OneSpace);
          result.Append(textBoxCustoSourceValue.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.OneSpace);
          result.Append(textBoxCustoSourceSemiColon.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.CrLf);

          // next line EXPECTED
          result.Append(Punctuation.Tabulate(2));
          result.Append(textBoxCustoExpectedCosntant.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.OneSpace);
          result.Append(comboBoxCustoExpectedType.SelectedItem);
          result.Append(Punctuation.OneSpace);
          result.Append(textBoxCustoExpectedWord.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.OneSpace);
          result.Append(textBoxCustoExpectedEqualSign.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.OneSpace);
          result.Append(textBoxCustoExpectedValue.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.OneSpace);
          result.Append(textBoxCustoExpectedSemiColon.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.CrLf);

          // next line RESULT
          result.Append(Punctuation.Tabulate(2));
          result.Append(comboBoxCustoResultReturnedType.SelectedItem);
          result.Append(Punctuation.OneSpace);
          result.Append(textBoxCustoResultWord.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.OneSpace);
          result.Append(textBoxCustoResultEqualSign.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.OneSpace);
          result.Append(textBoxCustoResultFunctionClass.Text);
          result.Append(textBoxcustoResultFunctionName.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.OneSpace);
          result.Append(textBoxCustoResultSourceWord.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.CrLf);

          // next line ASSERT
          result.Append(Punctuation.Tabulate(2));
          result.Append(textBoxCustoAssertWord.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.OneSpace);
          result.Append(comboBoxCustoAssertMethod.SelectedItem);
          result.Append(Punctuation.OneSpace);
          result.Append(textBoxCustoAssertOpenParenthesis.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.OneSpace);
          result.Append(textBoxCustoAssertResultWord.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.OneSpace);
          result.Append(textBoxCustoAssertComma.Text.Replace("%", i.ToString()));
          if (!textBoxCustoAssertComma.Text.EndsWith(" "))
          {
            result.Append(Punctuation.OneSpace);
          }

          result.Append(textBoxCustoAssertExpectedWord.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.OneSpace);
          result.Append(textBoxCustoAssertClosingParenthesis.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.CrLf);

          // next line closing parenthesis
          result.Append(textBoxCustoCloseCurlyBrace.Text.Replace("%", i.ToString()));
          result.Append(Punctuation.CrLf);
          result.Append(Punctuation.CrLf);
          textBoxCustoResult.Text += result.ToString();
        }
      }
    }

    private string Translate(string stringToBeTranslated)
    {
      string result = string.Empty;
      switch (_currentLanguage.ToLower())
      {
        case "english":
          result = _languageDicoEn.ContainsKey(stringToBeTranslated) ? _languageDicoEn[stringToBeTranslated] :
           "the term: \"" + stringToBeTranslated +
           "\" has not been translated yet.\nPlease tell the developer to translate this term";
          break;
        case "french":
          result = _languageDicoFr.ContainsKey(stringToBeTranslated) ? _languageDicoFr[stringToBeTranslated] :
            "the term: \"" + stringToBeTranslated +
            "\" has not been translated yet.\nPlease tell the developer to translate this term";
          break;
      }

      return result;
    }

    //private string GetTranslatedString(string index, string language)
    //{
    //  string result = string.Empty;
    //  switch (language.ToLower())
    //  {
    //    case "english":
    //      result = _languageDicoEn.ContainsKey(index) ? _languageDicoEn[index] :
    //       "the term: \"" + index + "\" has not been translated yet.\nPlease tell the developer to translate this term";
    //      break;
    //    case "french":
    //      result = _languageDicoFr.ContainsKey(index) ? _languageDicoFr[index] :
    //        "the term: \"" + index + "\" has not been translated yet.\nPlease tell the developer to translate this term";
    //      break;
    //  }

    //  return result;
    //}

    private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
    {
      _currentLanguage = Language.French.ToString();
      SetLanguage(Language.French.ToString());
    }

    private void englishToolStripMenuItem_Click(object sender, EventArgs e)
    {
      _currentLanguage = Language.English.ToString();
      SetLanguage(Language.English.ToString());
    }

    private void SetLanguage(string myLanguage)
    {
      switch (myLanguage)
      {
        case "English":
          frenchToolStripMenuItem.Checked = false;
          englishToolStripMenuItem.Checked = true;
          fileToolStripMenuItem.Text = _languageDicoEn["MenuFile"];
          newToolStripMenuItem.Text = _languageDicoEn["MenuFileNew"];
          openToolStripMenuItem.Text = _languageDicoEn["MenuFileOpen"];
          saveToolStripMenuItem.Text = _languageDicoEn["MenuFileSave"];
          saveasToolStripMenuItem.Text = _languageDicoEn["MenuFileSaveAs"];
          printPreviewToolStripMenuItem.Text = _languageDicoEn["MenuFilePrint"];
          printPreviewToolStripMenuItem.Text = _languageDicoEn["MenufilePageSetup"];
          quitToolStripMenuItem.Text = _languageDicoEn["MenufileQuit"];
          editToolStripMenuItem.Text = _languageDicoEn["MenuEdit"];
          cancelToolStripMenuItem.Text = _languageDicoEn["MenuEditCancel"];
          redoToolStripMenuItem.Text = _languageDicoEn["MenuEditRedo"];
          cutToolStripMenuItem.Text = _languageDicoEn["MenuEditCut"];
          copyToolStripMenuItem.Text = _languageDicoEn["MenuEditCopy"];
          pasteToolStripMenuItem.Text = _languageDicoEn["MenuEditPaste"];
          selectAllToolStripMenuItem.Text = _languageDicoEn["MenuEditSelectAll"];
          toolsToolStripMenuItem.Text = _languageDicoEn["MenuTools"];
          personalizeToolStripMenuItem.Text = _languageDicoEn["MenuToolsCustomize"];
          optionsToolStripMenuItem.Text = _languageDicoEn["MenuToolsOptions"];
          languagetoolStripMenuItem.Text = _languageDicoEn["MenuLanguage"];
          englishToolStripMenuItem.Text = _languageDicoEn["MenuLanguageEnglish"];
          frenchToolStripMenuItem.Text = _languageDicoEn["MenuLanguageFrench"];
          helpToolStripMenuItem.Text = _languageDicoEn["MenuHelp"];
          summaryToolStripMenuItem.Text = _languageDicoEn["MenuHelpSummary"];
          indexToolStripMenuItem.Text = _languageDicoEn["MenuHelpIndex"];
          searchToolStripMenuItem.Text = _languageDicoEn["MenuHelpSearch"];
          aboutToolStripMenuItem.Text = _languageDicoEn["MenuHelpAbout"];

          groupBoxCodeLineNumberOfLines.Text = _languageDicoEn["Number of lines"];
          groupBoxCodeLineIncrement.Text = _languageDicoEn["Iterator Type"];
          groupBoxCodeLineCharacter.Text = _languageDicoEn["Iterator Character"];
          groupBoxCodeLineRange.Text = _languageDicoEn["Range (From - To)"];
          radioButtonCodeLineOneLine.Text = _languageDicoEn["One Line"];
          radioButtonCodeLineSeveralLines.Text = _languageDicoEn["Several Lines"];
          radioButtonCodeLineIncrementNumber.Text = _languageDicoEn["Number"];
          radioButtonCodeLineIncrementLetter.Text = _languageDicoEn["Letter"];
          buttonCodeLineGenerate.Text = _languageDicoEn["Generate"];
          checkBoxCodeLineResultAssembled.Text = _languageDicoEn["Code Line assembled 123 123 or not assembled 111 222 333"];

          break;
        case "French":
          frenchToolStripMenuItem.Checked = true;
          englishToolStripMenuItem.Checked = false;
          fileToolStripMenuItem.Text = _languageDicoFr["MenuFile"];
          newToolStripMenuItem.Text = _languageDicoFr["MenuFileNew"];
          openToolStripMenuItem.Text = _languageDicoFr["MenuFileOpen"];
          saveToolStripMenuItem.Text = _languageDicoFr["MenuFileSave"];
          saveasToolStripMenuItem.Text = _languageDicoFr["MenuFileSaveAs"];
          printPreviewToolStripMenuItem.Text = _languageDicoFr["MenuFilePrint"];
          printPreviewToolStripMenuItem.Text = _languageDicoFr["MenufilePageSetup"];
          quitToolStripMenuItem.Text = _languageDicoFr["MenufileQuit"];
          editToolStripMenuItem.Text = _languageDicoFr["MenuEdit"];
          cancelToolStripMenuItem.Text = _languageDicoFr["MenuEditCancel"];
          redoToolStripMenuItem.Text = _languageDicoFr["MenuEditRedo"];
          cutToolStripMenuItem.Text = _languageDicoFr["MenuEditCut"];
          copyToolStripMenuItem.Text = _languageDicoFr["MenuEditCopy"];
          pasteToolStripMenuItem.Text = _languageDicoFr["MenuEditPaste"];
          selectAllToolStripMenuItem.Text = _languageDicoFr["MenuEditSelectAll"];
          toolsToolStripMenuItem.Text = _languageDicoFr["MenuTools"];
          personalizeToolStripMenuItem.Text = _languageDicoFr["MenuToolsCustomize"];
          optionsToolStripMenuItem.Text = _languageDicoFr["MenuToolsOptions"];
          languagetoolStripMenuItem.Text = _languageDicoFr["MenuLanguage"];
          englishToolStripMenuItem.Text = _languageDicoFr["MenuLanguageEnglish"];
          frenchToolStripMenuItem.Text = _languageDicoFr["MenuLanguageFrench"];
          helpToolStripMenuItem.Text = _languageDicoFr["MenuHelp"];
          summaryToolStripMenuItem.Text = _languageDicoFr["MenuHelpSummary"];
          indexToolStripMenuItem.Text = _languageDicoFr["MenuHelpIndex"];
          searchToolStripMenuItem.Text = _languageDicoFr["MenuHelpSearch"];
          aboutToolStripMenuItem.Text = _languageDicoFr["MenuHelpAbout"];
          groupBoxCodeLineNumberOfLines.Text = _languageDicoFr["Number of lines"];
          groupBoxCodeLineIncrement.Text = _languageDicoFr["Iterator Type"];
          groupBoxCodeLineCharacter.Text = _languageDicoFr["Iterator Character"];
          groupBoxCodeLineRange.Text = _languageDicoFr["Range (From - To)"];
          radioButtonCodeLineOneLine.Text = _languageDicoFr["One Line"];
          radioButtonCodeLineSeveralLines.Text = _languageDicoFr["Several Lines"];
          radioButtonCodeLineIncrementNumber.Text = _languageDicoFr["Number"];
          radioButtonCodeLineIncrementLetter.Text = _languageDicoFr["Letter"];
          buttonCodeLineGenerate.Text = _languageDicoFr["Generate"];
          checkBoxCodeLineResultAssembled.Text = _languageDicoFr["Code Line assembled 123 123 or not assembled 111 222 333"];

          break;

      }
    }

    private void textBoxFromNumber_TextChanged(object sender, EventArgs e)
    {
      AcceptOnlyNumbers(textBoxFromNumber);
    }

    private void textBoxToNumber_TextChanged(object sender, EventArgs e)
    {
      AcceptOnlyNumbers(textBoxToNumber);
    }

    private static void AcceptOnlyNumbers(TextBox textBox)
    {
      if (textBox == null) return;
      int value;
      if (!int.TryParse(textBox.Text, out value))
      {
        textBox.Text = string.Empty;
      }
    }

    private void textBoxNumberOfRndMethod_TextChanged(object sender, EventArgs e)
    {
      AcceptOnlyNumbers(textBoxNumberOfRndMethod);
    }

    private void textBoxOthersFrom_TextChanged(object sender, EventArgs e)
    {
      AcceptOnlyNumbers(textBoxOthersFrom);
    }

    private void textBoxOthersTo_TextChanged(object sender, EventArgs e)
    {
      AcceptOnlyNumbers(textBoxOthersTo);
    }

    private void textBoxCustomFrom_TextChanged(object sender, EventArgs e)
    {
      AcceptOnlyNumbers(textBoxCustomFrom);
    }

    private void textBoxCustomTo_TextChanged(object sender, EventArgs e)
    {
      AcceptOnlyNumbers(textBoxCustomTo);
    }

    private void comboBoxCustoExpectedType_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (comboBoxCustoResultReturnedType.Items.Count != 0 && comboBoxCustoExpectedType.Items.Count != 0)
      {
        comboBoxCustoResultReturnedType.SelectedIndex = comboBoxCustoExpectedType.SelectedIndex;
      }
    }

    private void comboBoxCustoResultReturnedType_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (comboBoxCustoResultReturnedType.Items.Count != 0 && comboBoxCustoExpectedType.Items.Count != 0)
      {
        comboBoxCustoExpectedType.SelectedIndex = comboBoxCustoResultReturnedType.SelectedIndex;
      }
    }

    private void radioButtonCodeLineOneLine_CheckedChanged(object sender, EventArgs e)
    {
      textBoxCodeLineSentence2.Visible = false;
      textBoxCodeLineSentence3.Visible = false;
      textBoxCodeLineSentence4.Visible = false;
      textBoxCodeLineSentence5.Visible = false;
    }

    private void radioButtonCodeLineSeveralLines_CheckedChanged(object sender, EventArgs e)
    {
      textBoxCodeLineSentence2.Visible = true;
      textBoxCodeLineSentence3.Visible = true;
      textBoxCodeLineSentence4.Visible = true;
      textBoxCodeLineSentence5.Visible = true;
    }

    private void buttonCodeLineGenerate_Click(object sender, EventArgs e)
    {
      textBoxCodeLineResult.Text = string.Empty;
      bool oneLine = radioButtonCodeLineOneLine.Checked;
      bool incrementalCharacterNumber = radioButtonCodeLineIncrementNumber.Checked;
      string rangeFrom = textBoxCodeLineRangeFrom.Text;
      string rangeTo = textBoxCodeLineRangeTo.Text;
      int start;
      if ((!int.TryParse(textBoxCodeLineRangeFrom.Text, out start)) && incrementalCharacterNumber)
      {
        DisplayMessageOk(Translate("This is not a number"), Translate("Not a number"), MessageBoxButtons.OK);
        return;
      }

      int end;
      if ((!int.TryParse(textBoxCodeLineRangeTo.Text, out end)) && incrementalCharacterNumber)
      {
        DisplayMessageOk(Translate("This is not a number"), Translate("Not a number"), MessageBoxButtons.OK);
        return;
      }

      if (end < start)
      {
        DisplayMessageOk(Translate("The end number must be greater than the start number"),
          Translate("End smaller start"), MessageBoxButtons.OK);
        return;
      }

      if (textBoxCodeLineSentence1.Text == string.Empty)
      {
        DisplayMessageOk(Translate("The first line cannot be empty"), Translate("First Line Empty"), MessageBoxButtons.OK);
        return;
      }

      var result = new StringBuilder();
      textBoxCodeLineResult.Text = string.Empty;
      var iterationNumbers = new List<int>();
      var iterationLetters = new List<char>();
      var iterationList = new List<string>();
      if (radioButtonCodeLineIncrementNumber.Checked)
      {
        for (int i = int.Parse(textBoxCodeLineRangeFrom.Text); i <= int.Parse(textBoxCodeLineRangeTo.Text); i++)
        {
          iterationNumbers.Add(i);
          iterationList.Add(i.ToString());
        }
      }
      else
      {
        for (char i = char.Parse(textBoxCodeLineRangeFrom.Text); i <= char.Parse(textBoxCodeLineRangeTo.Text); i++)
        {
          iterationLetters.Add(i);
          iterationList.Add(i.ToString());
        }
      }

      foreach (string item in iterationList)
      {
        result.Append(textBoxCodeLineSentence1.Text.Replace(textBoxCodeLineIteratorChar.Text[0].ToString(), item));
      }

      if (radioButtonCodeLineSeveralLines.Checked)
      {
        if (checkBoxCodeLineResultAssembled.Checked)
        {
          foreach (string item in iterationList)
          {
            result.Append(CreateSentence(5, AssemblyOrder.Assembled, item, textBoxCodeLineSentence2.Text,
              textBoxCodeLineSentence3.Text, textBoxCodeLineSentence4.Text,
              textBoxCodeLineSentence5.Text));
          }
        }
        else
        {


        }
      }

      textBoxCodeLineResult.Text = result.ToString();
    }

    public enum AssemblyOrder
    {
      Assembled,
      NotAssembled
    }

    private static string CreateSentence(int howMany, AssemblyOrder order, string stringAdded, params string[] textList)
    {
      // order = "assembled" or "NotAssembled"
      string result = string.Empty;
      if (howMany == 1)
      {
        return textList[0] + stringAdded;
      }

      // assembled = 123 123 123 123
      // NotAssembled = 111 222 333
      // return textList.Aggregate(result, (current, line) => current + (line + stringAdded + Punctuation.CrLf));
      foreach (string line in textList)
      {
        if (line != string.Empty)
        {
          result += line + stringAdded + Punctuation.CrLf;
        }
      }

      return result;
    }

    private void textBoxCodeLineSentence1_TextChanged(object sender, EventArgs e)
    {
      buttonCodeLineGenerate.Enabled = textBoxCodeLineSentence1.Text.Length != 0;
    }

    private void textBoxCodeLineRangeFrom_TextChanged(object sender, EventArgs e)
    {
      if (radioButtonCodeLineIncrementNumber.Checked)
      {
        AcceptOnlyNumbers(textBoxCodeLineRangeFrom);
      }
      else
      {
        AcceptOnlyLetters(textBoxCodeLineRangeFrom);
      }
    }

    private void textBoxCodeLineRangeTo_TextChanged(object sender, EventArgs e)
    {
      if (radioButtonCodeLineIncrementNumber.Checked)
      {
        AcceptOnlyNumbers(textBoxCodeLineRangeTo);
      }
      else
      {
        AcceptOnlyLetters(textBoxCodeLineRangeTo);
      }
    }

    private static void AcceptOnlyLetters(TextBox textBox)
    {
      if (textBox == null) return;
      foreach (char c in textBox.Text.Where(c => !char.IsLetter(c)))
      {
        textBox.Text = string.Empty;
        break;
      }
    }
  }
}