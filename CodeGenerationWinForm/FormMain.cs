using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using CodeGenerationWinForm.Properties;
using System.Security.Cryptography;

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

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (textBoxCodeGeneratedResult.Text == string.Empty)
      {
        DialogResult result = DisplayMessage("There is no text to copy", "No text", MessageBoxButtons.OK);
        return;
      }

      Clipboard.SetText(textBoxCodeGeneratedResult.Text);
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

    private static int GenerateRandomNumberUsingCrypto(int min, int max)
    {
      if (max >= 255)
      {
        return 0;
      }
      int result;
      RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
      byte[] randomNumber = new byte[1];
      do
      {
        crypto.GetBytes(randomNumber);
        result = randomNumber[0];
      } while (result <= min || result >= max);

      return result;
    }
  }
}