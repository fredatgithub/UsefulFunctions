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
using MethodSpeedBenchmarks.Properties;
using MathFunc = FonctionsUtiles.Fred.Csharp.FunctionsMath;
using StringFunc = FonctionsUtiles.Fred.Csharp.FunctionsString;
using DateFunc = FonctionsUtiles.Fred.Csharp.FunctionsDateTime;
using FonctionsUtiles.Fred.Csharp;


namespace MethodSpeedBenchmarks
{
  public partial class FormMain : Form
  {
    public object comboBoxOthersMethodName { get; private set; }

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
      FillComboBoxBenchmarkMethods(comboBoxBenchChooseMethod);
    }

    private static void FillComboBoxBenchmarkMethods(ComboBox cb)
    {
      cb.Items.Clear();
      cb.Items.Add("ReverseString");
      cb.Items.Add("ReverseString2");
      cb.SelectedIndex = 0;
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

    private void buttonBenchStart_Click(object sender, EventArgs e)
    {
      int iteration = 1;
      if (!int.TryParse(textBoxBenchIteration.Text, out iteration))
      {
        DisplayMessageOk("The number of iteration must be a number", "not a number", MessageBoxButtons.OK);
        textBoxBenchIteration.Text = string.Empty;
        textBoxBenchIteration.Focus();
        return;
      }

      Stopwatch chrono = new Stopwatch();
      chrono.Start();
      progressBarBenchmark.Visible = true;
      progressBarBenchmark.Minimum = 0;
      progressBarBenchmark.Maximum = iteration;
      progressBarBenchmark.Value = progressBarBenchmark.Minimum;
      listViewBenchmark.GridLines = true;
      listViewBenchmark.AllowColumnReorder = true;
      listViewBenchmark.View = View.Details;
      int itemCounter = 0;
      switch (comboBoxBenchChooseMethod.SelectedItem.ToString())
      {
        case "ReverseString":
          string source = "A long long time ago in a galaxy far far away";

          for (int i = 0; i < iteration; i++)
          {
            string tmp = StringFunc.ReverseString(source);
            progressBarBenchmark.Value = i;
          }

          chrono.Stop();
          ListViewItem item = new ListViewItem(comboBoxBenchChooseMethod.SelectedItem.ToString(), itemCounter++);
          item.SubItems.Add(iteration.ToString());
          item.SubItems.Add(StringFunc.NumberToEnglishWords(iteration));
          item.SubItems.Add(DateFunc.TimeSpanToLongTimeNotNull(chrono.Elapsed));
          listViewBenchmark.Items.Add(item);
          break;

        case "ReverseString2":
          string source2 = "A long long time ago in a galaxy far far away";

          for (int i = 0; i < iteration; i++)
          {
            string tmp2 = StringFunc.ReverseString2(source2);
            progressBarBenchmark.Value = i;
          }

          chrono.Stop();
          ListViewItem item2 = new ListViewItem(comboBoxBenchChooseMethod.SelectedItem.ToString(), itemCounter++);
          item2.SubItems.Add(iteration.ToString());
          item2.SubItems.Add(StringFunc.NumberToEnglishWords(iteration));
          item2.SubItems.Add(DateFunc.TimeSpanToLongTimeNotNull(chrono.Elapsed));
          listViewBenchmark.Items.Add(item2);
          break;

      }

      progressBarBenchmark.Value = progressBarBenchmark.Minimum;
      progressBarBenchmark.Visible = false;
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

    private void buttonBenchStartAllmethods_Click(object sender, EventArgs e)
    {
      for (int j = 10; j < int.MaxValue; j = j * 10)
      {
        if (j < 1)
        {
          return;
        }

        textBoxBenchIteration.Text = j.ToString();
        for (int i = 0; i < comboBoxBenchChooseMethod.Items.Count; i++)
        {
          comboBoxBenchChooseMethod.SelectedIndex = i;
          buttonBenchStart_Click(sender, e);
          Application.DoEvents();
        }
      }

      DisplayMessageOk("All the iterations and methods have been run.", "Benchmark is over", MessageBoxButtons.OK);
    }
  }
}