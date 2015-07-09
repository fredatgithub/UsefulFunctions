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

namespace CodeGenerationWinForm
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private readonly string carriageReturn = Environment.NewLine;
    private const string Space = " ";
    private const string Tabulation = "  "; // used StringFunc.Tabulation method instead TODO
    private int MostRecentTabUsed = 2;

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
      Text += string.Format(" V{0}.{1}.{2}.{3}", fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart, fvi.FilePrivatePart);
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      DisplayTitle();
      GetWindowValue();
      FillComboBoxLanguage(comboBoxLanguage);
      FillComboBoxLanguage(comboBoxRndMethodLanguage);
      FillComboBoxLanguage(comboBoxOneMethodLanguage);
      FillComboBoxOtherMethods(comboBoxOthersMethodName);
      FillComboBoxWithTypes(comboBoxCustoExpectedType);
      FillComboBoxWithTypes(comboBoxCustoSourceType);
      FillComboBoxWithTypes(comboBoxCustoResultReturnedType);
      FillComboBoxWithDllMethods(comboBoxCustoResultFunctionClass);
      FillComboBoxWithAssertMethods(comboBoxCustoAssertMethod);
      LoadSettingsAtStartup();
    }

    private void LoadSettingsAtStartup()
    {
      tabControlMain.SelectedIndex = 2;
      tabControlMain.SelectedIndex = Settings.Default.MostRecentTabUsed;
      checkBoxCustomRange.Checked = Settings.Default.checkBoxCustomRange;
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
      cb.Items.Add("int");
      cb.Items.Add("int[]");
      cb.Items.Add("string");
      cb.Items.Add("string[]");
      cb.Items.Add("byte");
      cb.Items.Add("byte[]");
      cb.Items.Add("bool");
      cb.Items.Add("bool[]");
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

      Settings.Default.Save();
    }

    private void FormMainFormClosing(object sender, FormClosingEventArgs e)
    {
      SaveWindowValue();
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
      // first tab: One Method Number
      CopytToClipboard(textBoxCodeGeneratedResult, "no text");
      CopytToClipboard(textBoxOneMethodNumber, "no number");

      // second tab: Several Range Methods 
      CopytToClipboard(textBoxRangeMethods, "no text");
      CopytToClipboard(textBoxFromNumber, "no number");
      CopytToClipboard(textBoxToNumber, "no number");

      // third tab: Random Method
      CopytToClipboard(textBoxRandomMethodResult, "no text");
      CopytToClipboard(textBoxNumberOfRndMethod, "no number");

      // fourth tab: Other Result
      CopytToClipboard(textBoxOthersResult, "no text");
      CopytToClipboard(textBoxOthersFrom, "no number");
      CopytToClipboard(textBoxOthersTo, "no number");

      // fifth tab: Customized Method
      CopytToClipboard(textBoxCustoResult, "no text");
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
      // first tab: One Method Number
      CutToClipboard(textBoxCodeGeneratedResult, "no text");
      CutToClipboard(textBoxOneMethodNumber, "no number");

      // second tab: Range Methods 
      CutToClipboard(textBoxRangeMethods, "no text");
      CutToClipboard(textBoxFromNumber, "no number");
      CutToClipboard(textBoxToNumber, "no number");

      // third tab: Random Method
      CutToClipboard(textBoxRandomMethodResult, "no text");
      CutToClipboard(textBoxNumberOfRndMethod, "no number");

      // fourth tab: Other Results 
      CutToClipboard(textBoxOthersResult, "no text");
      CutToClipboard(textBoxOthersFrom, "no number");
      CutToClipboard(textBoxOthersTo, "no number");

      // fifth tab: Customized Method
      CutToClipboard(textBoxCustoResult, "no text");
    }

    private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // first tab: Code Generated
      PasteFromClipboard(textBoxCodeGeneratedResult);
      PasteFromClipboard(textBoxOneMethodNumber);

      // second tab: Range Methods 
      PasteFromClipboard(textBoxRangeMethods);
      PasteFromClipboard(textBoxFromNumber);
      PasteFromClipboard(textBoxToNumber);

      // third tab: Random Method
      PasteFromClipboard(textBoxRandomMethodResult);
      PasteFromClipboard(textBoxNumberOfRndMethod);

      // fourth tab: Other Result
      PasteFromClipboard(textBoxOthersResult);
      PasteFromClipboard(textBoxOthersFrom);
      PasteFromClipboard(textBoxOthersTo);

      // fifth tab: Customized Method
      PasteFromClipboard(textBoxCustoResult);
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
      string selectedTab = tabControlMain.SelectedTab.ToString();
      switch (selectedTab)
      {
        case "TabPage: {One Method}":
          //detect which TextBox has the focus
          if (textBoxCodeGeneratedResult == ActiveControl)
          {
            textBoxCodeGeneratedResult.SelectAll();
          }

          if (textBoxOneMethodNumber == ActiveControl)
          {
            textBoxOneMethodNumber.SelectAll();
          }

          break;
        case "TabPage: {Several Methods by range}":
          if (textBoxRangeMethods == ActiveControl)
          {
            textBoxRangeMethods.SelectAll();
          }

          if (textBoxFromNumber == ActiveControl)
          {
            textBoxFromNumber.SelectAll();
          }

          if (textBoxToNumber == ActiveControl)
          {
            textBoxToNumber.SelectAll();
          }
          break;
        case "TabPage: {Random Methods}":
          if (textBoxRandomMethodResult == ActiveControl)
          {
            textBoxRandomMethodResult.SelectAll();
          }

          if (textBoxNumberOfRndMethod == ActiveControl)
          {
            textBoxNumberOfRndMethod.SelectAll();
          }

          break;
        case "TabPage: {Others}":
          if (textBoxOthersResult == ActiveControl)
          {
            textBoxOthersResult.SelectAll();
          }

          if (textBoxOthersFrom == ActiveControl)
          {
            textBoxOthersFrom.SelectAll();
          }

          if (textBoxOthersTo == ActiveControl)
          {
            textBoxOthersTo.SelectAll();
          }
          break;
        case "TabPage: {Customized Method}":
          if (textBoxCustoResult == ActiveControl)
          {
            textBoxCustoResult.SelectAll();
          }

          break;
      }
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
      // Verification of all types used with values
      CheckMatchingType(textBoxCustoExpectedValue, comboBoxCustoExpectedType, "EXPECTED", !checkBoxAutoCheckTypes.Checked);
      CheckMatchingType(textBoxCustoSourceValue, comboBoxCustoSourceType, "SOURCE", !checkBoxAutoCheckTypes.Checked);

      // Generation of the result
      textBoxCustoResult.Text = string.Empty;
      if (checkBoxCustomRange.Checked)
      {
        StringBuilder result = new StringBuilder();
        // next line ATTRIBUTE
        result.Append(textBoxCustoAttribute.Text);
        result.Append(carriageReturn);

        // next line METHOD SIGNATURE
        result.Append(textBoxCustPublic.Text);
        result.Append(Space);
        result.Append(textBoxCustoVoid.Text);
        result.Append(Space);
        result.Append(textBoxCustoTestMethod.Text);
        result.Append(Space);
        result.Append(textBoxCustoMethodName.Text);
        result.Append(carriageReturn);

        result.Append(textBoxcustoOpenCurlyBrace.Text);
        result.Append(carriageReturn);

        // next line SOURCE
        result.Append(Tabulation);
        result.Append(textBoxCustoConstantSource.Text);
        result.Append(Space);
        result.Append(comboBoxCustoSourceType.SelectedItem);
        result.Append(Space);
        result.Append(textBoxCustoSourceWord.Text);
        result.Append(Space);
        result.Append(textBoxCustoSourceEqualSign.Text);
        result.Append(Space);
        result.Append(textBoxCustoSourceValue.Text);
        result.Append(Space);
        result.Append(textBoxCustoSourceSemiColon.Text);
        result.Append(carriageReturn);

        // next line EXPECTED
        result.Append(Tabulation);
        result.Append(textBoxCustoExpectedCosntant.Text);
        result.Append(Space);
        result.Append(comboBoxCustoExpectedType.SelectedItem);
        result.Append(Space);
        result.Append(textBoxCustoExpectedWord.Text);
        result.Append(Space);
        result.Append(textBoxCustoExpectedEqualSign.Text);
        result.Append(Space);
        result.Append(textBoxCustoExpectedValue.Text);
        result.Append(Space);
        result.Append(textBoxCustoExpectedSemiColon.Text);
        result.Append(carriageReturn);

        // next line RESULT
        result.Append(Tabulation);
        result.Append(comboBoxCustoResultReturnedType.SelectedItem);
        result.Append(Space);
        result.Append(textBoxCustoResultWord.Text);
        result.Append(Space);
        result.Append(textBoxCustoResultEqualSign.Text);
        result.Append(Space);
        result.Append(comboBoxCustoResultFunctionClass.SelectedItem);
        result.Append(Space);
        result.Append(textBoxcustoResultFunctionName.Text);
        result.Append(Space);
        result.Append(textBoxCustoResultSourceWord.Text);
        result.Append(carriageReturn);

        // next line ASSERT
        result.Append(Tabulation);
        result.Append(textBoxCustoAssertWord.Text);
        result.Append(Space);
        result.Append(comboBoxCustoAssertMethod.SelectedItem);
        result.Append(Space);
        result.Append(textBoxCustoAssertOpenParenthesis.Text);
        result.Append(Space);
        result.Append(textBoxCustoAssertResultWord.Text);
        result.Append(Space);
        result.Append(textBoxCustoAssertComma.Text);
        if (!textBoxCustoAssertComma.Text.EndsWith(" "))
        {
          result.Append(Space);
        }

        result.Append(textBoxCustoAssertExpectedWord.Text);
        result.Append(Space);
        result.Append(textBoxCustoAssertClosingParenthesis.Text);
        result.Append(carriageReturn);

        // next line closing parenthesis
        result.Append(textBoxCustoCloseCurlyBrace.Text);
        result.Append(carriageReturn);

        textBoxCustoResult.Text = result.ToString();
      }
      else
      {
        // range of multi instances iterator = %

      }
      
    }
  }
}