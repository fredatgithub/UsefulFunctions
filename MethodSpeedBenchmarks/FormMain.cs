namespace MethodSpeedBenchmarks
{
  using System;
  using System.Diagnostics;
  using System.Reflection;
  using System.Windows.Forms;

  using MethodSpeedBenchmarks.Properties;

  using DateFunc = FonctionsUtiles.Fred.Csharp.FunctionsDateTime;
  using dllFunc = FonctionsUtiles.Fred.Csharp;
  using StringFunc = FonctionsUtiles.Fred.Csharp.FunctionsString;

  public partial class FormMain : Form
  {
    public FormMain()
    {
      this.InitializeComponent();
    }

    private static void FillComboBoxBenchmarkMethods(ComboBox cb)
    {
      cb.Items.Clear();
      cb.Items.Add("ReverseString");
      cb.Items.Add("ReverseString2");
      cb.Items.Add("OppositeCase");
      cb.Items.Add("SwapCases");
      cb.SelectedIndex = 0;
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
      this.Text += $" V{fvi.FileMajorPart}.{fvi.FileMinorPart}.{fvi.FileBuildPart}.{fvi.FilePrivatePart}";
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      this.DisplayTitle();
      this.GetWindowValue();
      FillComboBoxBenchmarkMethods(this.comboBoxBenchChooseMethod);
    }
    
    private void GetWindowValue()
    {
      this.Width = Settings.Default.WindowWidth;
      this.Height = Settings.Default.WindowHeight;
      this.Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      this.Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
    }

    private void SaveWindowValue()
    {
      Settings.Default.WindowHeight = this.Height;
      Settings.Default.WindowWidth = this.Width;
      Settings.Default.WindowLeft = this.Left;
      Settings.Default.WindowTop = this.Top;
      Settings.Default.Save();
    }

    private void FormMainFormClosing(object sender, FormClosingEventArgs e)
    {
      this.SaveWindowValue();
    }

    private void ButtonBenchStart_Click(object sender, EventArgs e)
    {
      int iteration = 1;
      if (!int.TryParse(this.textBoxBenchIteration.Text, out iteration))
      {
        this.DisplayMessageOk("The number of iteration must be a number", "not a number", MessageBoxButtons.OK);
        this.textBoxBenchIteration.Text = string.Empty;
        this.textBoxBenchIteration.Focus();
        return;
      }

      Stopwatch chrono = new Stopwatch();
      chrono.Start();
      this.progressBarBenchmark.Visible = true;
      this.progressBarBenchmark.Minimum = 0;
      this.progressBarBenchmark.Maximum = iteration;
      this.progressBarBenchmark.Value = this.progressBarBenchmark.Minimum;
      this.listViewBenchmark.GridLines = true;
      this.listViewBenchmark.AllowColumnReorder = true;
      this.listViewBenchmark.View = View.Details;
      int itemCounter = 0;
      switch (this.comboBoxBenchChooseMethod.SelectedItem.ToString())
      {
        case "ReverseString":
          string source = "A long long time ago in a galaxy far far away";
          
          for (int i = 0; i < iteration; i++)
          {
            string tmp = StringFunc.ReverseString(source);
            this.progressBarBenchmark.Value = i;
          }

          chrono.Stop();
          ListViewItem item = new ListViewItem(this.comboBoxBenchChooseMethod.SelectedItem.ToString(), itemCounter++);
          item.SubItems.Add(iteration.ToString());
          item.SubItems.Add(StringFunc.NumberToEnglishWords(iteration));
          item.SubItems.Add(DateFunc.TimeSpanToLongTimeNotNull(chrono.Elapsed));
          this.listViewBenchmark.Items.Add(item);
          break;

        case "ReverseString2":
          string source2 = "A long long time ago in a galaxy far far away";

          for (int i = 0; i < iteration; i++)
          {
            string tmp2 = StringFunc.ReverseString(source2);
            this.progressBarBenchmark.Value = i;
          }

          chrono.Stop();
          ListViewItem item2 = new ListViewItem(this.comboBoxBenchChooseMethod.SelectedItem.ToString(), itemCounter++);
          item2.SubItems.Add(iteration.ToString());
          item2.SubItems.Add(StringFunc.NumberToEnglishWords(iteration));
          item2.SubItems.Add(DateFunc.TimeSpanToLongTimeNotNull(chrono.Elapsed));
          this.listViewBenchmark.Items.Add(item2);
          break;

        case "OppositeCase":
          // source = "A long long time ago in a galaxy far far away";
          char[] noForbiddenCharacter = new char[0];
          source = StringFunc.GenerateRandomString(noForbiddenCharacter, false,
            dllFunc.RandomCharacters.UpperLowerDigitSpecial, 255);
          for (int i = 0; i < iteration; i++)
          {
            string tmp = StringFunc.OppositeCase(source);
            this.progressBarBenchmark.Value = i;
          }

          chrono.Stop();
          item = new ListViewItem(this.comboBoxBenchChooseMethod.SelectedItem.ToString(), itemCounter++);
          item.SubItems.Add(iteration.ToString());
          item.SubItems.Add(StringFunc.NumberToEnglishWords(iteration));
          item.SubItems.Add(DateFunc.TimeSpanToLongTimeNotNull(chrono.Elapsed));
          this.listViewBenchmark.Items.Add(item);
          break;

        case "SwapCases":
          // source2 = "A long long time ago in a galaxy far far away";
          noForbiddenCharacter = new char[0];
          source2 = StringFunc.GenerateRandomString(noForbiddenCharacter, false,
            dllFunc.RandomCharacters.UpperLowerDigitSpecial, 255);

          for (int i = 0; i < iteration; i++)
          {
            string tmp2 = StringFunc.SwapCases(source2);
            this.progressBarBenchmark.Value = i;
          }

          chrono.Stop();
          item2 = new ListViewItem(this.comboBoxBenchChooseMethod.SelectedItem.ToString(), itemCounter++);
          item2.SubItems.Add(iteration.ToString());
          item2.SubItems.Add(StringFunc.NumberToEnglishWords(iteration));
          item2.SubItems.Add(DateFunc.TimeSpanToLongTimeNotNull(chrono.Elapsed));
          this.listViewBenchmark.Items.Add(item2);
          break;
      }

      this.progressBarBenchmark.Value = this.progressBarBenchmark.Minimum;
      this.progressBarBenchmark.Visible = false;
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

    private void ButtonBenchStartAllmethods_Click(object sender, EventArgs e)
    {
      for (int j = 10; j < int.MaxValue; j = j * 10)
      {
        this.textBoxBenchIteration.Text = j.ToString();
        for (int i = 0; i < this.comboBoxBenchChooseMethod.Items.Count; i++)
        {
          this.comboBoxBenchChooseMethod.SelectedIndex = i;
          this.ButtonBenchStart_Click(sender, e);
          Application.DoEvents();
        }
      }

      this.DisplayMessageOk("All the iterations and methods have been run.", "Benchmark is over", MessageBoxButtons.OK);
    }
  }
}