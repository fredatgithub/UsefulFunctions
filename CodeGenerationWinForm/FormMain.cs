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

namespace CodeGenerationWinForm
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
    {
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
    }

    private void FillComboBoxLanguage(ComboBox cb)
    {
      cb.Items.Clear();
      cb.Items.Add("French");
      cb.Items.Add("English");
      cb.Items.Add("Both French and English");
      cb.SelectedIndex = 2;
    }

    private void GetWindowValue()
    {
      Width = Settings.Default.WindowWidth;
      Height = Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
    }

    private void SaveWindowValue()
    {
      Settings.Default.WindowHeight = Height;
      Settings.Default.WindowWidth = Width;
      Settings.Default.WindowLeft = Left;
      Settings.Default.WindowTop = Top;
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

    private static bool IsTextBoxEmpty(Control tb)
    {
      return tb.Text == string.Empty;
    }

    private void DisplayEmptyTextMessage()
    {
      DisplayMessageOk("There is no text to copy", "No text", MessageBoxButtons.OK);
    }

    private void DisplayNoTextSelectedMessage()
    {
      DisplayMessageOk("There is no text selected", "No text selected", MessageBoxButtons.OK);
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (textBoxOneMethodNumber == ActiveControl)
      {
        if (textBoxOneMethodNumber.SelectedText != string.Empty)
        {
          Clipboard.SetText(textBoxOneMethodNumber.SelectedText);
        }
      }

      if (textBoxCodeGeneratedResult == ActiveControl)
      {
        string selectedTab = tabControlMain.SelectedTab.ToString();
        switch (selectedTab)
        {
          case "TabPage: {One Method}":
            if (IsTextBoxEmpty(textBoxCodeGeneratedResult))
            {
              DisplayEmptyTextMessage();
            }
            else
            {
              // test if there is any text selected
              if (textBoxCodeGeneratedResult.SelectedText != string.Empty)
              {
                Clipboard.SetText(textBoxCodeGeneratedResult.SelectedText);
              }
              else
              {
                DisplayNoTextSelectedMessage();
              }
            }

            break;

          case "TabPage: {Several Methods by range}":
            if (textBoxRangeMethods.Text == string.Empty)
            {
              DisplayEmptyTextMessage();
            }
            else
            {
              Clipboard.SetText(textBoxRangeMethods.SelectedText);
            }

            break;

          case "TabPage: {Random Methods}":
            if (textBoxRandomMethodResult.Text == string.Empty)
            {
              DisplayEmptyTextMessage();
            }
            else
            {
              Clipboard.SetText(textBoxRandomMethodResult.SelectedText);
            }

            break;
        }
      }
    }

    private void cutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (textBoxCodeGeneratedResult == ActiveControl)
      {
        if (textBoxCodeGeneratedResult.Text == string.Empty)
        {
          DisplayMessageOk("There is no text to copy", "No text", MessageBoxButtons.OK);
          return;
        }

        Clipboard.SetText(textBoxCodeGeneratedResult.SelectedText);
        textBoxCodeGeneratedResult.SelectedText = string.Empty;
      }

      if (textBoxOneMethodNumber == ActiveControl)
      {
        if (textBoxOneMethodNumber.Text == string.Empty)
        {
          DisplayMessageOk("There is no number to copy", "No number", MessageBoxButtons.OK);
          return;
        }

        Clipboard.SetText(textBoxOneMethodNumber.SelectedText);
        textBoxOneMethodNumber.SelectedText = string.Empty;
      }
    }

    private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (textBoxOneMethodNumber == ActiveControl)
      {
        textBoxOneMethodNumber.Text += Clipboard.GetText();
      }

      if (textBoxCodeGeneratedResult == ActiveControl)
      {
        textBoxCodeGeneratedResult.Text += Clipboard.GetText();
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
          break;
        default:
          method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToEnglishWords(numberToBeGenerated), ' ', '_');
          method1.CodeExpected = "const string expected = \"" + StringFunc.NumberToEnglishWords(numberToBeGenerated) + "\";";
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
          "const string expected = \"\";",
          "string result = StringFunc.NumberToEnglishWords(" + i + ");",
          "Assert.AreEqual(expected, result);");
        switch (languageToTranslate)
        {
          case "English":
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToEnglishWords(i), ' ', '_');
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(method1.CodeSignatureMethodName, '-', '_');
            method1.CodeExpected = "const string expected = \"" + StringFunc.NumberToEnglishWords(i) + "\";";
            break;
          case "French":
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToFrenchWords(i), ' ', '_');
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(method1.CodeSignatureMethodName, '-', '_');
            method1.CodeExpected = "const string expected = \"" + StringFunc.NumberToFrenchWords(i) + "\";";
            method1.CodeResult = "string result = StringFunc.NumberToFrenchWords(" + i + ");";
            break;
          case "Both French and English":
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToEnglishWords(i), ' ', '_');
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(method1.CodeSignatureMethodName, '-', '_');
            method1.CodeExpected = "const string expected = \"" + StringFunc.NumberToEnglishWords(i) + "\";";
            break;
          default:
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToEnglishWords(i), ' ', '_');
            method1.CodeExpected = "const string expected = \"" + StringFunc.NumberToEnglishWords(i) + "\";";
            break;
        }

        if (languageToTranslate == "Both French and English")
        {
          textBoxRangeMethods.Text += method1.ToString();
          var method2 = new UnitTestCodeGenerated(
          StringFunc.NumberToFrenchWords(i),
          "const string expected = \"" + StringFunc.NumberToFrenchWords(i) + "\";",
          "string result = StringFunc.NumberToEnglishWords(" + i + ");",
          "Assert.AreEqual(expected, result);")
          {
            CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToFrenchWords(i), ' ', '_')
          };

          method2.CodeSignatureMethodName = StringFunc.ReplaceCharacters(method2.CodeSignatureMethodName, '-', '_');
          method2.CodeExpected = "const string expected = \"" + StringFunc.NumberToFrenchWords(i) + "\";";
          method2.CodeResult = "string result = StringFunc.NumberToFrenchWords(" + i + ");";
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
          "const string expected = \"\";",
          "string result = StringFunc.NumberToEnglishWords(" + rndNumber + ");",
          "Assert.AreEqual(expected, result);");
        switch (languageToTranslate)
        {
          case "English":
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToEnglishWords(rndNumber), ' ', '_');
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(method1.CodeSignatureMethodName, '-', '_');
            method1.CodeExpected = "  const string expected = \"" + StringFunc.NumberToEnglishWords(rndNumber) + "\";";
            break;
          case "French":
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToFrenchWords(rndNumber), ' ', '_');
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(method1.CodeSignatureMethodName, '-', '_');
            method1.CodeExpected = "const string expected = \"" + StringFunc.NumberToFrenchWords(rndNumber) + "\";";
            method1.CodeResult = "string result = StringFunc.NumberToFrenchWords(" + rndNumber + ");";
            break;
          case "Both French and English":
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToEnglishWords(rndNumber), ' ', '_');
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(method1.CodeSignatureMethodName, '-', '_');
            method1.CodeExpected = "const string expected = \"" + StringFunc.NumberToEnglishWords(rndNumber) + "\";";
            break;
          default:
            method1.CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToEnglishWords(rndNumber), ' ', '_');
            method1.CodeExpected = "const string expected = \"" + StringFunc.NumberToEnglishWords(rndNumber) + "\";";
            break;
        }

        if (languageToTranslate == "Both French and English")
        {
          textBoxRandomMethodResult.Text += method1.ToString();
          var method2 = new UnitTestCodeGenerated(
          StringFunc.NumberToFrenchWords(rndNumber),
          "const string expected = \"" + StringFunc.NumberToFrenchWords(rndNumber) + "\";",
          "string result = StringFunc.NumberToEnglishWords(" + rndNumber + ");",
          "Assert.AreEqual(expected, result);")
          {
            CodeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToFrenchWords(rndNumber), ' ', '_')
          };

          method2.CodeSignatureMethodName = StringFunc.ReplaceCharacters(method2.CodeSignatureMethodName, '-', '_');
          method2.CodeExpected = "const string expected = \"" + StringFunc.NumberToFrenchWords(rndNumber) + "\";";
          method2.CodeResult = "string result = StringFunc.NumberToFrenchWords(" + rndNumber + ");";
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
      }
    }

    private void buttonClearOneMethodTextBox_Click(object sender, EventArgs e)
    {
      textBoxCodeGeneratedResult.Text = string.Empty;
    }
  }
}