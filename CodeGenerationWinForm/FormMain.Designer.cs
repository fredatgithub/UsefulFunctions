﻿namespace CodeGenerationWinForm
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
      this.textBoxCodeGeneratedResult = new System.Windows.Forms.TextBox();
      this.buttonGenerateCode = new System.Windows.Forms.Button();
      this.tabControlMain = new System.Windows.Forms.TabControl();
      this.tabPageOneMethod = new System.Windows.Forms.TabPage();
      this.tabPageSeveralMethods = new System.Windows.Forms.TabPage();
      this.buttonGenerateSeveralMethods = new System.Windows.Forms.Button();
      this.textBoxToNumber = new System.Windows.Forms.TextBox();
      this.textBoxFromNumber = new System.Windows.Forms.TextBox();
      this.labelTo = new System.Windows.Forms.Label();
      this.labelFrom = new System.Windows.Forms.Label();
      this.textBoxRangeMethods = new System.Windows.Forms.TextBox();
      this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
      this.tabPageRandomMethods = new System.Windows.Forms.TabPage();
      this.buttonGenerateRdnMethod = new System.Windows.Forms.Button();
      this.textBoxNumberOfRndMethod = new System.Windows.Forms.TextBox();
      this.labelNumberOfRndMethod = new System.Windows.Forms.Label();
      this.comboBoxRndMethodLanguage = new System.Windows.Forms.ComboBox();
      this.textBoxRandomMethodResult = new System.Windows.Forms.TextBox();
      this.menuStrip1.SuspendLayout();
      this.tabControlMain.SuspendLayout();
      this.tabPageOneMethod.SuspendLayout();
      this.tabPageSeveralMethods.SuspendLayout();
      this.tabPageRandomMethods.SuspendLayout();
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
      this.menuStrip1.Size = new System.Drawing.Size(811, 28);
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
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
      this.fileToolStripMenuItem.Text = "&Fichier";
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.newToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
      this.newToolStripMenuItem.Text = "&Nouveau";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.openToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
      this.openToolStripMenuItem.Text = "&Ouvrir";
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(244, 6);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
      this.saveToolStripMenuItem.Text = "&Enregistrer";
      // 
      // saveasToolStripMenuItem
      // 
      this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
      this.saveasToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
      this.saveasToolStripMenuItem.Text = "Enregistrer &sous";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(244, 6);
      // 
      // printToolStripMenuItem
      // 
      this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.printToolStripMenuItem.Name = "printToolStripMenuItem";
      this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
      this.printToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
      this.printToolStripMenuItem.Text = "&Imprimer";
      // 
      // printPreviewToolStripMenuItem
      // 
      this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
      this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
      this.printPreviewToolStripMenuItem.Text = "Aperçu a&vant impression";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(244, 6);
      // 
      // quitToolStripMenuItem
      // 
      this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
      this.quitToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
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
      this.editToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
      this.editToolStripMenuItem.Text = "&Edition";
      // 
      // cancelToolStripMenuItem
      // 
      this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
      this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.cancelToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
      this.cancelToolStripMenuItem.Text = "&Annuler";
      // 
      // redoToolStripMenuItem
      // 
      this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
      this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.redoToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
      this.redoToolStripMenuItem.Text = "&Rétablir";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(194, 6);
      // 
      // cutToolStripMenuItem
      // 
      this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
      this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.cutToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
      this.cutToolStripMenuItem.Text = "&Couper";
      this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
      // 
      // copyToolStripMenuItem
      // 
      this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copyToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
      this.copyToolStripMenuItem.Text = "Co&pier";
      this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
      // 
      // pasteToolStripMenuItem
      // 
      this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
      this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.pasteToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
      this.pasteToolStripMenuItem.Text = "Co&ller";
      this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(194, 6);
      // 
      // selectAllToolStripMenuItem
      // 
      this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
      this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
      this.selectAllToolStripMenuItem.Text = "Sélectio&nner tout";
      // 
      // toolsToolStripMenuItem
      // 
      this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
      this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
      this.toolsToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
      this.toolsToolStripMenuItem.Text = "&Outils";
      // 
      // personalizeToolStripMenuItem
      // 
      this.personalizeToolStripMenuItem.Name = "personalizeToolStripMenuItem";
      this.personalizeToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
      this.personalizeToolStripMenuItem.Text = "&Personnaliser";
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
      this.optionsToolStripMenuItem.Text = "&Options";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frenchToolStripMenuItem,
            this.englishToolStripMenuItem});
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(86, 24);
      this.toolStripMenuItem1.Text = "Language";
      // 
      // frenchToolStripMenuItem
      // 
      this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
      this.frenchToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
      this.frenchToolStripMenuItem.Text = "Français";
      // 
      // englishToolStripMenuItem
      // 
      this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
      this.englishToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
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
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
      this.helpToolStripMenuItem.Text = "&Aide";
      // 
      // summaryToolStripMenuItem
      // 
      this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
      this.summaryToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
      this.summaryToolStripMenuItem.Text = "&Sommaire";
      // 
      // indexToolStripMenuItem
      // 
      this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
      this.indexToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
      this.indexToolStripMenuItem.Text = "&Index";
      // 
      // searchToolStripMenuItem
      // 
      this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
      this.searchToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
      this.searchToolStripMenuItem.Text = "&Rechercher";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(172, 6);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
      this.aboutToolStripMenuItem.Text = "À &propos de...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
      // 
      // textBoxCodeGeneratedResult
      // 
      this.textBoxCodeGeneratedResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxCodeGeneratedResult.Location = new System.Drawing.Point(27, 86);
      this.textBoxCodeGeneratedResult.Multiline = true;
      this.textBoxCodeGeneratedResult.Name = "textBoxCodeGeneratedResult";
      this.textBoxCodeGeneratedResult.Size = new System.Drawing.Size(770, 383);
      this.textBoxCodeGeneratedResult.TabIndex = 2;
      // 
      // buttonGenerateCode
      // 
      this.buttonGenerateCode.Location = new System.Drawing.Point(27, 29);
      this.buttonGenerateCode.Name = "buttonGenerateCode";
      this.buttonGenerateCode.Size = new System.Drawing.Size(227, 30);
      this.buttonGenerateCode.TabIndex = 3;
      this.buttonGenerateCode.Text = "Generate code for one method";
      this.buttonGenerateCode.UseVisualStyleBackColor = true;
      this.buttonGenerateCode.Click += new System.EventHandler(this.buttonGenerateCode_Click);
      // 
      // tabControlMain
      // 
      this.tabControlMain.Controls.Add(this.tabPageOneMethod);
      this.tabControlMain.Controls.Add(this.tabPageSeveralMethods);
      this.tabControlMain.Controls.Add(this.tabPageRandomMethods);
      this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControlMain.Location = new System.Drawing.Point(0, 28);
      this.tabControlMain.Name = "tabControlMain";
      this.tabControlMain.SelectedIndex = 0;
      this.tabControlMain.Size = new System.Drawing.Size(811, 506);
      this.tabControlMain.TabIndex = 4;
      // 
      // tabPageOneMethod
      // 
      this.tabPageOneMethod.Controls.Add(this.textBoxCodeGeneratedResult);
      this.tabPageOneMethod.Controls.Add(this.buttonGenerateCode);
      this.tabPageOneMethod.Location = new System.Drawing.Point(4, 25);
      this.tabPageOneMethod.Name = "tabPageOneMethod";
      this.tabPageOneMethod.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageOneMethod.Size = new System.Drawing.Size(803, 477);
      this.tabPageOneMethod.TabIndex = 0;
      this.tabPageOneMethod.Text = "One Method";
      this.tabPageOneMethod.UseVisualStyleBackColor = true;
      // 
      // tabPageSeveralMethods
      // 
      this.tabPageSeveralMethods.Controls.Add(this.buttonGenerateSeveralMethods);
      this.tabPageSeveralMethods.Controls.Add(this.textBoxToNumber);
      this.tabPageSeveralMethods.Controls.Add(this.textBoxFromNumber);
      this.tabPageSeveralMethods.Controls.Add(this.labelTo);
      this.tabPageSeveralMethods.Controls.Add(this.labelFrom);
      this.tabPageSeveralMethods.Controls.Add(this.textBoxRangeMethods);
      this.tabPageSeveralMethods.Controls.Add(this.comboBoxLanguage);
      this.tabPageSeveralMethods.Location = new System.Drawing.Point(4, 25);
      this.tabPageSeveralMethods.Name = "tabPageSeveralMethods";
      this.tabPageSeveralMethods.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageSeveralMethods.Size = new System.Drawing.Size(803, 477);
      this.tabPageSeveralMethods.TabIndex = 1;
      this.tabPageSeveralMethods.Text = "Several Methods by range";
      this.tabPageSeveralMethods.UseVisualStyleBackColor = true;
      // 
      // buttonGenerateSeveralMethods
      // 
      this.buttonGenerateSeveralMethods.Location = new System.Drawing.Point(672, 49);
      this.buttonGenerateSeveralMethods.Name = "buttonGenerateSeveralMethods";
      this.buttonGenerateSeveralMethods.Size = new System.Drawing.Size(88, 24);
      this.buttonGenerateSeveralMethods.TabIndex = 6;
      this.buttonGenerateSeveralMethods.Text = "Generate";
      this.buttonGenerateSeveralMethods.UseVisualStyleBackColor = true;
      this.buttonGenerateSeveralMethods.Click += new System.EventHandler(this.buttonGenerateSeveralMethods_Click);
      // 
      // textBoxToNumber
      // 
      this.textBoxToNumber.Location = new System.Drawing.Point(495, 50);
      this.textBoxToNumber.Name = "textBoxToNumber";
      this.textBoxToNumber.Size = new System.Drawing.Size(169, 22);
      this.textBoxToNumber.TabIndex = 5;
      this.textBoxToNumber.Text = "25";
      // 
      // textBoxFromNumber
      // 
      this.textBoxFromNumber.Location = new System.Drawing.Point(285, 50);
      this.textBoxFromNumber.Name = "textBoxFromNumber";
      this.textBoxFromNumber.Size = new System.Drawing.Size(169, 22);
      this.textBoxFromNumber.TabIndex = 4;
      this.textBoxFromNumber.Text = "21";
      // 
      // labelTo
      // 
      this.labelTo.AutoSize = true;
      this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTo.Location = new System.Drawing.Point(459, 53);
      this.labelTo.Name = "labelTo";
      this.labelTo.Size = new System.Drawing.Size(37, 17);
      this.labelTo.TabIndex = 3;
      this.labelTo.Text = "To: ";
      // 
      // labelFrom
      // 
      this.labelFrom.AutoSize = true;
      this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelFrom.Location = new System.Drawing.Point(233, 53);
      this.labelFrom.Name = "labelFrom";
      this.labelFrom.Size = new System.Drawing.Size(54, 17);
      this.labelFrom.TabIndex = 2;
      this.labelFrom.Text = "From: ";
      // 
      // textBoxRangeMethods
      // 
      this.textBoxRangeMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxRangeMethods.Location = new System.Drawing.Point(30, 99);
      this.textBoxRangeMethods.Multiline = true;
      this.textBoxRangeMethods.Name = "textBoxRangeMethods";
      this.textBoxRangeMethods.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxRangeMethods.Size = new System.Drawing.Size(730, 345);
      this.textBoxRangeMethods.TabIndex = 1;
      // 
      // comboBoxLanguage
      // 
      this.comboBoxLanguage.FormattingEnabled = true;
      this.comboBoxLanguage.Location = new System.Drawing.Point(30, 49);
      this.comboBoxLanguage.Name = "comboBoxLanguage";
      this.comboBoxLanguage.Size = new System.Drawing.Size(198, 24);
      this.comboBoxLanguage.TabIndex = 0;
      // 
      // tabPageRandomMethods
      // 
      this.tabPageRandomMethods.Controls.Add(this.buttonGenerateRdnMethod);
      this.tabPageRandomMethods.Controls.Add(this.textBoxNumberOfRndMethod);
      this.tabPageRandomMethods.Controls.Add(this.labelNumberOfRndMethod);
      this.tabPageRandomMethods.Controls.Add(this.comboBoxRndMethodLanguage);
      this.tabPageRandomMethods.Controls.Add(this.textBoxRandomMethodResult);
      this.tabPageRandomMethods.Location = new System.Drawing.Point(4, 25);
      this.tabPageRandomMethods.Name = "tabPageRandomMethods";
      this.tabPageRandomMethods.Size = new System.Drawing.Size(803, 477);
      this.tabPageRandomMethods.TabIndex = 2;
      this.tabPageRandomMethods.Text = "Random Methods";
      this.tabPageRandomMethods.UseVisualStyleBackColor = true;
      // 
      // buttonGenerateRdnMethod
      // 
      this.buttonGenerateRdnMethod.Location = new System.Drawing.Point(660, 38);
      this.buttonGenerateRdnMethod.Name = "buttonGenerateRdnMethod";
      this.buttonGenerateRdnMethod.Size = new System.Drawing.Size(88, 24);
      this.buttonGenerateRdnMethod.TabIndex = 7;
      this.buttonGenerateRdnMethod.Text = "Generate";
      this.buttonGenerateRdnMethod.UseVisualStyleBackColor = true;
      this.buttonGenerateRdnMethod.Click += new System.EventHandler(this.buttonGenerateRdnMethod_Click);
      // 
      // textBoxNumberOfRndMethod
      // 
      this.textBoxNumberOfRndMethod.Location = new System.Drawing.Point(516, 39);
      this.textBoxNumberOfRndMethod.Name = "textBoxNumberOfRndMethod";
      this.textBoxNumberOfRndMethod.Size = new System.Drawing.Size(138, 22);
      this.textBoxNumberOfRndMethod.TabIndex = 5;
      this.textBoxNumberOfRndMethod.Text = "2";
      // 
      // labelNumberOfRndMethod
      // 
      this.labelNumberOfRndMethod.AutoSize = true;
      this.labelNumberOfRndMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelNumberOfRndMethod.Location = new System.Drawing.Point(233, 42);
      this.labelNumberOfRndMethod.Name = "labelNumberOfRndMethod";
      this.labelNumberOfRndMethod.Size = new System.Drawing.Size(289, 17);
      this.labelNumberOfRndMethod.TabIndex = 4;
      this.labelNumberOfRndMethod.Text = "Number of generated random method: ";
      // 
      // comboBoxRndMethodLanguage
      // 
      this.comboBoxRndMethodLanguage.FormattingEnabled = true;
      this.comboBoxRndMethodLanguage.Location = new System.Drawing.Point(18, 38);
      this.comboBoxRndMethodLanguage.Name = "comboBoxRndMethodLanguage";
      this.comboBoxRndMethodLanguage.Size = new System.Drawing.Size(198, 24);
      this.comboBoxRndMethodLanguage.TabIndex = 3;
      // 
      // textBoxRandomMethodResult
      // 
      this.textBoxRandomMethodResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxRandomMethodResult.Location = new System.Drawing.Point(18, 68);
      this.textBoxRandomMethodResult.Multiline = true;
      this.textBoxRandomMethodResult.Name = "textBoxRandomMethodResult";
      this.textBoxRandomMethodResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxRandomMethodResult.Size = new System.Drawing.Size(730, 392);
      this.textBoxRandomMethodResult.TabIndex = 2;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(811, 534);
      this.Controls.Add(this.tabControlMain);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FormMain";
      this.ShowIcon = false;
      this.Text = "CodeGeneration for Unit tests";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainFormClosing);
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.tabControlMain.ResumeLayout(false);
      this.tabPageOneMethod.ResumeLayout(false);
      this.tabPageOneMethod.PerformLayout();
      this.tabPageSeveralMethods.ResumeLayout(false);
      this.tabPageSeveralMethods.PerformLayout();
      this.tabPageRandomMethods.ResumeLayout(false);
      this.tabPageRandomMethods.PerformLayout();
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
    private System.Windows.Forms.TextBox textBoxCodeGeneratedResult;
    private System.Windows.Forms.Button buttonGenerateCode;
    private System.Windows.Forms.TabControl tabControlMain;
    private System.Windows.Forms.TabPage tabPageOneMethod;
    private System.Windows.Forms.TabPage tabPageSeveralMethods;
    private System.Windows.Forms.TextBox textBoxRangeMethods;
    private System.Windows.Forms.ComboBox comboBoxLanguage;
    private System.Windows.Forms.TabPage tabPageRandomMethods;
    private System.Windows.Forms.ComboBox comboBoxRndMethodLanguage;
    private System.Windows.Forms.TextBox textBoxRandomMethodResult;
    private System.Windows.Forms.Button buttonGenerateSeveralMethods;
    private System.Windows.Forms.TextBox textBoxToNumber;
    private System.Windows.Forms.TextBox textBoxFromNumber;
    private System.Windows.Forms.Label labelTo;
    private System.Windows.Forms.Label labelFrom;
    private System.Windows.Forms.Button buttonGenerateRdnMethod;
    private System.Windows.Forms.TextBox textBoxNumberOfRndMethod;
    private System.Windows.Forms.Label labelNumberOfRndMethod;
  }
}