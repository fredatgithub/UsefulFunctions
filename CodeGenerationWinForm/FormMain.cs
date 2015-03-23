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
      // Set this if you want a minimum width
      //Width = Settings.Default.WindowWidth < 395 ? 395 : Settings.Default.WindowWidth;
      Width = Settings.Default.WindowWidth;
      // Set this if you want a minimum Height
      // Height = Settings.Default.WindowHeight < 180 ? 180 : Settings.Default.WindowHeight;
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

    private void DisplayMessageOK(string message, string title, MessageBoxButtons buttons)
    {
      MessageBox.Show(this, message, title, buttons);
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string selectedTab = tabControlMain.SelectedTab.ToString();
      switch (selectedTab)
      {
        case "TabPage: {One Method}":
          if (textBoxCodeGeneratedResult.Text == string.Empty)
          {
            DialogResult result = DisplayMessage("There is no text to copy", "No text", MessageBoxButtons.OK);
            return;
          }
          else
          {
            textBoxCodeGeneratedResult.SelectAll();
          }
          
          break;
        case "TabPage: {Several Methods by range}":
          if (textBoxRangeMethods.Text == string.Empty)
          {
            DialogResult result = DisplayMessage("There is no text to copy", "No text", MessageBoxButtons.OK);
            return;
          }
          else
          {
            textBoxRangeMethods.SelectAll();
          }

          break;
        case "TabPage: {Random Methods}":
          if (textBoxRandomMethodResult.Text == string.Empty)
          {
            DialogResult result = DisplayMessage("There is no text to copy", "No text", MessageBoxButtons.OK);
            return;
          }
          else
          {
            textBoxRandomMethodResult.SelectAll();
          }
          break;
      }

      switch (selectedTab)
      {
        case "TabPage: {One Method}":
          Clipboard.SetText(textBoxCodeGeneratedResult.Text);
          break;
        case "TabPage: {Several Methods by range}":
          Clipboard.SetText(textBoxRangeMethods.Text);
          break;
        case "TabPage: {Random Methods}":
          Clipboard.SetText(textBoxRandomMethodResult.Text);
          break;
      }
    }

    private void cutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (textBoxCodeGeneratedResult.Text == string.Empty)
      {
        DialogResult result = DisplayMessage("There is no text to copy", "No text", MessageBoxButtons.OK);
        return;
      }

      Clipboard.SetText(textBoxCodeGeneratedResult.SelectedText);
      textBoxCodeGeneratedResult.SelectedText = string.Empty;
    }

    private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      textBoxCodeGeneratedResult.Text += Clipboard.GetText();
    }

    private void buttonGenerateCode_Click(object sender, EventArgs e)
    {
      var method1 = new UnitTestCodeGenerated(
        "two_million",
        "const string expected = \"two million\";",
        "string result = StringFunc.NumberToEnglishWords(2000000);",
        "Assert.AreEqual(expected, result);");
      textBoxCodeGeneratedResult.Text += method1.ToString();
    }

    private void buttonGenerateSeveralMethods_Click(object sender, EventArgs e)
    {
      // sample generated method
      /*
      [TestMethod]
    public void TestMethod_NumberToEnglishWords_two_million()
    {
      const string expected = "two million";
      string result = StringFunc.NumberToEnglishWords(2000000);
      Assert.AreEqual(expected, result);
    }
    */
      /*
      var method1 = new UnitTestCodeGenerated(
          "two_million",
          "  const string expected = \"two million\";",
          "  string result = StringFunc.NumberToEnglishWords(2000000);",
          "  Assert.AreEqual(expected, result);");
        textBoxCodeGeneratedResult.Text += method1.ToString();
        */
      if (textBoxFromNumber.Text == string.Empty)
      {
        DialogResult dr = DisplayMessage("The number of method requested cannot be empty", "Empty field", MessageBoxButtons.OK);
        return;
      }

      int fromNumberOfMethodToBeGenerated = 0;
      if (!int.TryParse(textBoxFromNumber.Text, out fromNumberOfMethodToBeGenerated))
      {
        DialogResult dr = DisplayMessage("The lower bound is not a number", "Not a number", MessageBoxButtons.OK);
        textBoxFromNumber.Text = string.Empty;
        return;
      }

      int toNumberOfMethodToBeGenerated = 0;
      if (!int.TryParse(textBoxToNumber.Text, out toNumberOfMethodToBeGenerated))
      {
        DialogResult dr = DisplayMessage("The upper bound is not a number", "Not a number", MessageBoxButtons.OK);
        textBoxToNumber.Text = string.Empty;
        return;
      }

      if (toNumberOfMethodToBeGenerated < fromNumberOfMethodToBeGenerated)
      {
        DialogResult dr = DisplayMessage("The upper bound is smaller than the lower bound", "Negative range", MessageBoxButtons.OK);
        textBoxToNumber.Text = string.Empty;
        return;
      }

      textBoxRangeMethods.Text = string.Empty;

    }

    private void buttonGenerateRdnMethod_Click(object sender, EventArgs e)
    {
      if (textBoxNumberOfRndMethod.Text == string.Empty)
      {
        DisplayMessageOK("The number of method requested cannot be empty", "Empty field", MessageBoxButtons.OK);
        return;
      }

      int numberOfMethodToBeGenerated = 0;
      if (!int.TryParse(textBoxNumberOfRndMethod.Text, out numberOfMethodToBeGenerated))
      {
        DisplayMessageOK("This is not a number", "Not a number", MessageBoxButtons.OK);
        textBoxNumberOfRndMethod.Text = string.Empty;
        return;
      }

      textBoxRandomMethodResult.Text = string.Empty;
      string LanguageToTranslate = comboBoxRndMethodLanguage.SelectedItem.ToString();
      for (int i = 0; i < numberOfMethodToBeGenerated; i++)
      {
        ulong rndNumber = MathFunc.GenerateRandomBigNumbers(1, 1000000);

        var method1 = new UnitTestCodeGenerated(
          rndNumber.ToString(),
          "  const string expected = \"two million\";",
          "  string result = StringFunc.NumberToEnglishWords(" + rndNumber.ToString() + ");",
          "  Assert.AreEqual(expected, result);");
        switch (LanguageToTranslate)
        {
          case "English":
            method1.codeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToEnglishWords(rndNumber), ' ', '_');
            method1.codeSignatureMethodName = StringFunc.ReplaceCharacters(method1.codeSignatureMethodName, '-', '_');
            method1.CodeExpected = "  const string expected = \"" + StringFunc.NumberToEnglishWords(rndNumber) + "\";";
            break;
          case "French":
            method1.codeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToFrenchWords(rndNumber), ' ', '_');
            method1.codeSignatureMethodName = StringFunc.ReplaceCharacters(method1.codeSignatureMethodName, '-', '_');
            method1.CodeExpected = "  const string expected = \"" + StringFunc.NumberToFrenchWords(rndNumber) + "\";";
            method1.CodeResult = "  string result = StringFunc.NumberToFrenchWords(" + rndNumber.ToString() + ");";
            break;
          case "Both French and English":
            method1.codeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToEnglishWords(rndNumber), ' ', '_');
            method1.codeSignatureMethodName = StringFunc.ReplaceCharacters(method1.codeSignatureMethodName, '-', '_');
            method1.CodeExpected = "  const string expected = \"" + StringFunc.NumberToEnglishWords(rndNumber) + "\";";
            break;
          default:
            method1.codeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToEnglishWords(rndNumber), ' ', '_');
            method1.CodeExpected = "  const string expected = \"" + StringFunc.NumberToEnglishWords(rndNumber) + "\";";
            break;
        }

        if (LanguageToTranslate == "Both French and English")
        {
          textBoxRandomMethodResult.Text += method1.ToString();
          var method2 = new UnitTestCodeGenerated(
          StringFunc.NumberToFrenchWords(rndNumber),
          "  const string expected = \"" + StringFunc.NumberToFrenchWords(rndNumber) + "\";",
          "  string result = StringFunc.NumberToEnglishWords(" + rndNumber.ToString() + ");",
          "  Assert.AreEqual(expected, result);");
          method2.codeSignatureMethodName = StringFunc.ReplaceCharacters(StringFunc.NumberToFrenchWords(rndNumber), ' ', '_');
          method2.codeSignatureMethodName = StringFunc.ReplaceCharacters(method2.codeSignatureMethodName, '-', '_');
          method2.CodeExpected = "  const string expected = \"" + StringFunc.NumberToFrenchWords(rndNumber) + "\";";
          method2.CodeResult = "  string result = StringFunc.NumberToFrenchWords(" + rndNumber.ToString() + ");";
          textBoxRandomMethodResult.Text += method2.ToString();
        }
        else
        {
          textBoxRandomMethodResult.Text += method1.ToString();
        }

      }
    }

    private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string selectedTab = tabControlMain.SelectedTab.ToString();
      switch (selectedTab)
      {
        case "TabPage: {One Method}":
          textBoxCodeGeneratedResult.SelectAll();
          break;
        case "TabPage: {Several Methods by range}":
          textBoxRangeMethods.SelectAll();
          break;
        case "TabPage: {Random Methods}":
          textBoxRandomMethodResult.SelectAll();
          break;
        default:
          break;
      }
    }
  }
}