namespace MethodSpeedBenchmarks
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.personalizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.labelBenchChooseMethod = new System.Windows.Forms.Label();
      this.comboBoxBenchChooseMethod = new System.Windows.Forms.ComboBox();
      this.buttonBenchStart = new System.Windows.Forms.Button();
      this.progressBarBenchmark = new System.Windows.Forms.ProgressBar();
      this.listViewBenchmark = new System.Windows.Forms.ListView();
      this.columnHeaderMethod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeaderIteration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeaderIterationInWords = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeadertimeLapse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.labelBenchIteration = new System.Windows.Forms.Label();
      this.textBoxBenchIteration = new System.Windows.Forms.TextBox();
      this.tableLayoutPanelBenchmark = new System.Windows.Forms.TableLayoutPanel();
      this.buttonBenchStartAllmethods = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      this.tableLayoutPanelBenchmark.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
      this.menuStrip1.Size = new System.Drawing.Size(921, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveasToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
      this.fileToolStripMenuItem.Text = "&Fichier";
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.newToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.newToolStripMenuItem.Text = "&Nouveau";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.openToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.openToolStripMenuItem.Text = "&Ouvrir";
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(202, 6);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.saveToolStripMenuItem.Text = "&Enregistrer";
      // 
      // saveasToolStripMenuItem
      // 
      this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
      this.saveasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.saveasToolStripMenuItem.Text = "Enregistrer &sous";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
      // 
      // printToolStripMenuItem
      // 
      this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.printToolStripMenuItem.Name = "printToolStripMenuItem";
      this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
      this.printToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.printToolStripMenuItem.Text = "&Imprimer";
      // 
      // printPreviewToolStripMenuItem
      // 
      this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
      this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.printPreviewToolStripMenuItem.Text = "Aperçu a&vant impression";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
      // 
      // quitToolStripMenuItem
      // 
      this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
      this.quitToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.quitToolStripMenuItem.Text = "&Quitter";
      this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
      this.editToolStripMenuItem.Text = "&Edition";
      // 
      // cancelToolStripMenuItem
      // 
      this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
      this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.cancelToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.cancelToolStripMenuItem.Text = "&Annuler";
      // 
      // redoToolStripMenuItem
      // 
      this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
      this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.redoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.redoToolStripMenuItem.Text = "&Rétablir";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
      // 
      // cutToolStripMenuItem
      // 
      this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
      this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.cutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.cutToolStripMenuItem.Text = "&Couper";
      // 
      // copyToolStripMenuItem
      // 
      this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.copyToolStripMenuItem.Text = "Co&pier";
      // 
      // pasteToolStripMenuItem
      // 
      this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
      this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.pasteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.pasteToolStripMenuItem.Text = "Co&ller";
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
      // 
      // selectAllToolStripMenuItem
      // 
      this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
      this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.selectAllToolStripMenuItem.Text = "Sélectio&nner tout";
      // 
      // toolsToolStripMenuItem
      // 
      this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
      this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
      this.toolsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
      this.toolsToolStripMenuItem.Text = "&Outils";
      // 
      // personalizeToolStripMenuItem
      // 
      this.personalizeToolStripMenuItem.Name = "personalizeToolStripMenuItem";
      this.personalizeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.personalizeToolStripMenuItem.Text = "&Personnaliser";
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.optionsToolStripMenuItem.Text = "&Options";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frenchToolStripMenuItem,
            this.englishToolStripMenuItem});
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
      this.toolStripMenuItem1.Text = "Language";
      // 
      // frenchToolStripMenuItem
      // 
      this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
      this.frenchToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
      this.frenchToolStripMenuItem.Text = "Français";
      // 
      // englishToolStripMenuItem
      // 
      this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
      this.englishToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
      this.englishToolStripMenuItem.Text = "Anglais";
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.helpToolStripMenuItem.Text = "&Aide";
      // 
      // summaryToolStripMenuItem
      // 
      this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
      this.summaryToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.summaryToolStripMenuItem.Text = "&Sommaire";
      // 
      // indexToolStripMenuItem
      // 
      this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
      this.indexToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.indexToolStripMenuItem.Text = "&Index";
      // 
      // searchToolStripMenuItem
      // 
      this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
      this.searchToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.searchToolStripMenuItem.Text = "&Rechercher";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(144, 6);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.aboutToolStripMenuItem.Text = "À &propos de...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
      // 
      // labelBenchChooseMethod
      // 
      this.labelBenchChooseMethod.AutoSize = true;
      this.labelBenchChooseMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelBenchChooseMethod.Location = new System.Drawing.Point(2, 0);
      this.labelBenchChooseMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelBenchChooseMethod.Name = "labelBenchChooseMethod";
      this.labelBenchChooseMethod.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
      this.labelBenchChooseMethod.Size = new System.Drawing.Size(60, 32);
      this.labelBenchChooseMethod.TabIndex = 2;
      this.labelBenchChooseMethod.Text = "Choose Method:";
      // 
      // comboBoxBenchChooseMethod
      // 
      this.comboBoxBenchChooseMethod.Dock = System.Windows.Forms.DockStyle.Fill;
      this.comboBoxBenchChooseMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.comboBoxBenchChooseMethod.FormattingEnabled = true;
      this.comboBoxBenchChooseMethod.Location = new System.Drawing.Point(105, 2);
      this.comboBoxBenchChooseMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.comboBoxBenchChooseMethod.Name = "comboBoxBenchChooseMethod";
      this.comboBoxBenchChooseMethod.Size = new System.Drawing.Size(124, 25);
      this.comboBoxBenchChooseMethod.TabIndex = 3;
      // 
      // buttonBenchStart
      // 
      this.buttonBenchStart.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonBenchStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonBenchStart.Location = new System.Drawing.Point(431, 2);
      this.buttonBenchStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonBenchStart.Name = "buttonBenchStart";
      this.buttonBenchStart.Size = new System.Drawing.Size(79, 28);
      this.buttonBenchStart.TabIndex = 4;
      this.buttonBenchStart.Text = "Start";
      this.buttonBenchStart.UseVisualStyleBackColor = true;
      this.buttonBenchStart.Click += new System.EventHandler(this.ButtonBenchStart_Click);
      // 
      // progressBarBenchmark
      // 
      this.tableLayoutPanelBenchmark.SetColumnSpan(this.progressBarBenchmark, 6);
      this.progressBarBenchmark.Dock = System.Windows.Forms.DockStyle.Fill;
      this.progressBarBenchmark.Location = new System.Drawing.Point(2, 388);
      this.progressBarBenchmark.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.progressBarBenchmark.Name = "progressBarBenchmark";
      this.progressBarBenchmark.Size = new System.Drawing.Size(918, 20);
      this.progressBarBenchmark.TabIndex = 6;
      this.progressBarBenchmark.Visible = false;
      // 
      // listViewBenchmark
      // 
      this.listViewBenchmark.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMethod,
            this.columnHeaderIteration,
            this.columnHeaderIterationInWords,
            this.columnHeadertimeLapse});
      this.tableLayoutPanelBenchmark.SetColumnSpan(this.listViewBenchmark, 6);
      this.listViewBenchmark.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listViewBenchmark.LabelEdit = true;
      this.listViewBenchmark.Location = new System.Drawing.Point(2, 34);
      this.listViewBenchmark.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.listViewBenchmark.MultiSelect = false;
      this.listViewBenchmark.Name = "listViewBenchmark";
      this.listViewBenchmark.Size = new System.Drawing.Size(918, 350);
      this.listViewBenchmark.TabIndex = 7;
      this.listViewBenchmark.UseCompatibleStateImageBehavior = false;
      this.listViewBenchmark.View = System.Windows.Forms.View.List;
      // 
      // columnHeaderMethod
      // 
      this.columnHeaderMethod.Text = "Method Name";
      this.columnHeaderMethod.Width = 150;
      // 
      // columnHeaderIteration
      // 
      this.columnHeaderIteration.Text = "Iteration";
      this.columnHeaderIteration.Width = 100;
      // 
      // columnHeaderIterationInWords
      // 
      this.columnHeaderIterationInWords.Text = "Iteration in words";
      this.columnHeaderIterationInWords.Width = 200;
      // 
      // columnHeadertimeLapse
      // 
      this.columnHeadertimeLapse.Text = "Time lapse";
      this.columnHeadertimeLapse.Width = 500;
      // 
      // labelBenchIteration
      // 
      this.labelBenchIteration.AutoSize = true;
      this.labelBenchIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelBenchIteration.Location = new System.Drawing.Point(233, 0);
      this.labelBenchIteration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelBenchIteration.Name = "labelBenchIteration";
      this.labelBenchIteration.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
      this.labelBenchIteration.Size = new System.Drawing.Size(63, 32);
      this.labelBenchIteration.TabIndex = 8;
      this.labelBenchIteration.Text = "Choose iteration:";
      // 
      // textBoxBenchIteration
      // 
      this.textBoxBenchIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxBenchIteration.Location = new System.Drawing.Point(345, 2);
      this.textBoxBenchIteration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.textBoxBenchIteration.Name = "textBoxBenchIteration";
      this.textBoxBenchIteration.Size = new System.Drawing.Size(82, 23);
      this.textBoxBenchIteration.TabIndex = 9;
      this.textBoxBenchIteration.Text = "100";
      // 
      // tableLayoutPanelBenchmark
      // 
      this.tableLayoutPanelBenchmark.ColumnCount = 6;
      this.tableLayoutPanelBenchmark.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
      this.tableLayoutPanelBenchmark.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
      this.tableLayoutPanelBenchmark.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
      this.tableLayoutPanelBenchmark.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
      this.tableLayoutPanelBenchmark.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
      this.tableLayoutPanelBenchmark.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 410F));
      this.tableLayoutPanelBenchmark.Controls.Add(this.buttonBenchStartAllmethods, 5, 0);
      this.tableLayoutPanelBenchmark.Controls.Add(this.labelBenchChooseMethod, 0, 0);
      this.tableLayoutPanelBenchmark.Controls.Add(this.progressBarBenchmark, 0, 2);
      this.tableLayoutPanelBenchmark.Controls.Add(this.textBoxBenchIteration, 3, 0);
      this.tableLayoutPanelBenchmark.Controls.Add(this.listViewBenchmark, 0, 1);
      this.tableLayoutPanelBenchmark.Controls.Add(this.buttonBenchStart, 4, 0);
      this.tableLayoutPanelBenchmark.Controls.Add(this.labelBenchIteration, 2, 0);
      this.tableLayoutPanelBenchmark.Controls.Add(this.comboBoxBenchChooseMethod, 1, 0);
      this.tableLayoutPanelBenchmark.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanelBenchmark.Location = new System.Drawing.Point(0, 24);
      this.tableLayoutPanelBenchmark.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.tableLayoutPanelBenchmark.Name = "tableLayoutPanelBenchmark";
      this.tableLayoutPanelBenchmark.RowCount = 3;
      this.tableLayoutPanelBenchmark.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanelBenchmark.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanelBenchmark.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
      this.tableLayoutPanelBenchmark.Size = new System.Drawing.Size(921, 410);
      this.tableLayoutPanelBenchmark.TabIndex = 10;
      // 
      // buttonBenchStartAllmethods
      // 
      this.buttonBenchStartAllmethods.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonBenchStartAllmethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonBenchStartAllmethods.Location = new System.Drawing.Point(514, 2);
      this.buttonBenchStartAllmethods.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonBenchStartAllmethods.Name = "buttonBenchStartAllmethods";
      this.buttonBenchStartAllmethods.Size = new System.Drawing.Size(406, 28);
      this.buttonBenchStartAllmethods.TabIndex = 10;
      this.buttonBenchStartAllmethods.Text = "Start all methods, all iterations";
      this.buttonBenchStartAllmethods.UseVisualStyleBackColor = true;
      this.buttonBenchStartAllmethods.Click += new System.EventHandler(this.ButtonBenchStartAllmethods_Click);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(921, 434);
      this.Controls.Add(this.tableLayoutPanelBenchmark);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "FormMain";
      this.ShowIcon = false;
      this.Text = "Method speed benchmarks";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainFormClosing);
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.tableLayoutPanelBenchmark.ResumeLayout(false);
      this.tableLayoutPanelBenchmark.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveasToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem personalizeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
    private System.Windows.Forms.Label labelBenchChooseMethod;
    private System.Windows.Forms.ComboBox comboBoxBenchChooseMethod;
    private System.Windows.Forms.Button buttonBenchStart;
    private System.Windows.Forms.ProgressBar progressBarBenchmark;
    private System.Windows.Forms.ListView listViewBenchmark;
    private System.Windows.Forms.ColumnHeader columnHeaderMethod;
    private System.Windows.Forms.ColumnHeader columnHeaderIteration;
    private System.Windows.Forms.ColumnHeader columnHeadertimeLapse;
    private System.Windows.Forms.Label labelBenchIteration;
    private System.Windows.Forms.TextBox textBoxBenchIteration;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBenchmark;
    private System.Windows.Forms.Button buttonBenchStartAllmethods;
    private System.Windows.Forms.ColumnHeader columnHeaderIterationInWords;
  }
}