namespace DirBuster
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ListTarget = new System.Windows.Forms.ListBox();
            this.TargetMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.apriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copiaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rimuoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ripulisciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TargetText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TextDirTarget = new System.Windows.Forms.TextBox();
            this.StartBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResultCheckBox = new System.Windows.Forms.CheckBox();
            this.AdminSetupRadio = new System.Windows.Forms.RadioButton();
            this.CheckPort = new System.Windows.Forms.CheckBox();
            this.AllFileRadio = new System.Windows.Forms.RadioButton();
            this.AllDirectoryRadio = new System.Windows.Forms.RadioButton();
            this.XTreamCodesRadio = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ListResult = new System.Windows.Forms.ListBox();
            this.ResultMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.apriToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.copiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ispezionaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaElencoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ripulisciToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.HTMLEditorText = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SingleProgress = new System.Windows.Forms.ProgressBar();
            this.ImportTarget = new System.Windows.Forms.OpenFileDialog();
            this.TextConsole = new System.Windows.Forms.TextBox();
            this.TotalProgress = new System.Windows.Forms.ProgressBar();
            this.SaveResultDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.TargetMenu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.ResultMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(364, 458);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.ListTarget);
            this.tabPage3.Controls.Add(this.TargetText);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.StartBTN);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(356, 432);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Start";
            // 
            // ListTarget
            // 
            this.ListTarget.ContextMenuStrip = this.TargetMenu;
            this.ListTarget.FormattingEnabled = true;
            this.ListTarget.Location = new System.Drawing.Point(3, 24);
            this.ListTarget.Name = "ListTarget";
            this.ListTarget.Size = new System.Drawing.Size(352, 264);
            this.ListTarget.TabIndex = 6;
            // 
            // TargetMenu
            // 
            this.TargetMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apriToolStripMenuItem1,
            this.copiaToolStripMenuItem1,
            this.rimuoviToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ripulisciToolStripMenuItem});
            this.TargetMenu.Name = "TargetMenu";
            this.TargetMenu.Size = new System.Drawing.Size(119, 98);
            // 
            // apriToolStripMenuItem1
            // 
            this.apriToolStripMenuItem1.Name = "apriToolStripMenuItem1";
            this.apriToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.apriToolStripMenuItem1.Text = "Apri";
            this.apriToolStripMenuItem1.Click += new System.EventHandler(this.apriToolStripMenuItem1_Click);
            // 
            // copiaToolStripMenuItem1
            // 
            this.copiaToolStripMenuItem1.Name = "copiaToolStripMenuItem1";
            this.copiaToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.copiaToolStripMenuItem1.Text = "Copia";
            this.copiaToolStripMenuItem1.Click += new System.EventHandler(this.copiaToolStripMenuItem1_Click);
            // 
            // rimuoviToolStripMenuItem
            // 
            this.rimuoviToolStripMenuItem.Name = "rimuoviToolStripMenuItem";
            this.rimuoviToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.rimuoviToolStripMenuItem.Text = "Rimuovi";
            this.rimuoviToolStripMenuItem.Click += new System.EventHandler(this.rimuoviToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 6);
            // 
            // ripulisciToolStripMenuItem
            // 
            this.ripulisciToolStripMenuItem.Name = "ripulisciToolStripMenuItem";
            this.ripulisciToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.ripulisciToolStripMenuItem.Text = "Ripulisci";
            this.ripulisciToolStripMenuItem.Click += new System.EventHandler(this.ripulisciToolStripMenuItem_Click);
            // 
            // TargetText
            // 
            this.TargetText.Location = new System.Drawing.Point(3, 3);
            this.TargetText.Name = "TargetText";
            this.TargetText.Size = new System.Drawing.Size(353, 20);
            this.TargetText.TabIndex = 5;
            this.TargetText.Text = "Host Target...";
            this.TargetText.Click += new System.EventHandler(this.TargetText_Click_1);
            this.TargetText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TargetText_KeyDown_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.TextDirTarget);
            this.groupBox3.Location = new System.Drawing.Point(3, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 45);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Importa Hosts";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 20);
            this.button2.TabIndex = 1;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TextDirTarget
            // 
            this.TextDirTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextDirTarget.Location = new System.Drawing.Point(5, 16);
            this.TextDirTarget.Name = "TextDirTarget";
            this.TextDirTarget.ReadOnly = true;
            this.TextDirTarget.Size = new System.Drawing.Size(273, 20);
            this.TextDirTarget.TabIndex = 0;
            // 
            // StartBTN
            // 
            this.StartBTN.Location = new System.Drawing.Point(3, 401);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(350, 28);
            this.StartBTN.TabIndex = 3;
            this.StartBTN.Text = "Start";
            this.StartBTN.UseVisualStyleBackColor = true;
            this.StartBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResultCheckBox);
            this.groupBox1.Controls.Add(this.AdminSetupRadio);
            this.groupBox1.Controls.Add(this.CheckPort);
            this.groupBox1.Controls.Add(this.AllFileRadio);
            this.groupBox1.Controls.Add(this.AllDirectoryRadio);
            this.groupBox1.Controls.Add(this.XTreamCodesRadio);
            this.groupBox1.Location = new System.Drawing.Point(3, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CMS";
            // 
            // ResultCheckBox
            // 
            this.ResultCheckBox.AutoSize = true;
            this.ResultCheckBox.Location = new System.Drawing.Point(245, 19);
            this.ResultCheckBox.Name = "ResultCheckBox";
            this.ResultCheckBox.Size = new System.Drawing.Size(106, 17);
            this.ResultCheckBox.TabIndex = 5;
            this.ResultCheckBox.Text = "Escludi File Vuoti";
            this.ResultCheckBox.UseVisualStyleBackColor = true;
            // 
            // AdminSetupRadio
            // 
            this.AdminSetupRadio.AutoSize = true;
            this.AdminSetupRadio.Location = new System.Drawing.Point(6, 42);
            this.AdminSetupRadio.Name = "AdminSetupRadio";
            this.AdminSetupRadio.Size = new System.Drawing.Size(92, 17);
            this.AdminSetupRadio.TabIndex = 4;
            this.AdminSetupRadio.Text = "Admin / Install";
            this.AdminSetupRadio.UseVisualStyleBackColor = true;
            // 
            // CheckPort
            // 
            this.CheckPort.AutoSize = true;
            this.CheckPort.Location = new System.Drawing.Point(245, 46);
            this.CheckPort.Name = "CheckPort";
            this.CheckPort.Size = new System.Drawing.Size(88, 17);
            this.CheckPort.TabIndex = 0;
            this.CheckPort.Text = "Escludi Porta";
            this.CheckPort.UseVisualStyleBackColor = true;
            // 
            // AllFileRadio
            // 
            this.AllFileRadio.AutoSize = true;
            this.AllFileRadio.Location = new System.Drawing.Point(140, 46);
            this.AllFileRadio.Name = "AllFileRadio";
            this.AllFileRadio.Size = new System.Drawing.Size(41, 17);
            this.AllFileRadio.TabIndex = 3;
            this.AllFileRadio.Text = "File";
            this.AllFileRadio.UseVisualStyleBackColor = true;
            // 
            // AllDirectoryRadio
            // 
            this.AllDirectoryRadio.AutoSize = true;
            this.AllDirectoryRadio.Location = new System.Drawing.Point(140, 19);
            this.AllDirectoryRadio.Name = "AllDirectoryRadio";
            this.AllDirectoryRadio.Size = new System.Drawing.Size(67, 17);
            this.AllDirectoryRadio.TabIndex = 1;
            this.AllDirectoryRadio.Text = "Directory";
            this.AllDirectoryRadio.UseVisualStyleBackColor = true;
            // 
            // XTreamCodesRadio
            // 
            this.XTreamCodesRadio.AutoSize = true;
            this.XTreamCodesRadio.Checked = true;
            this.XTreamCodesRadio.Location = new System.Drawing.Point(6, 19);
            this.XTreamCodesRadio.Name = "XTreamCodesRadio";
            this.XTreamCodesRadio.Size = new System.Drawing.Size(92, 17);
            this.XTreamCodesRadio.TabIndex = 0;
            this.XTreamCodesRadio.TabStop = true;
            this.XTreamCodesRadio.Text = "XTreamCodes";
            this.XTreamCodesRadio.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.ListResult);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(356, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Result";
            // 
            // ListResult
            // 
            this.ListResult.ContextMenuStrip = this.ResultMenu;
            this.ListResult.FormattingEnabled = true;
            this.ListResult.Location = new System.Drawing.Point(3, 6);
            this.ListResult.Name = "ListResult";
            this.ListResult.ScrollAlwaysVisible = true;
            this.ListResult.Size = new System.Drawing.Size(350, 420);
            this.ListResult.TabIndex = 0;
            // 
            // ResultMenu
            // 
            this.ResultMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apriToolStripMenuItem2,
            this.copiaToolStripMenuItem,
            this.ispezionaToolStripMenuItem,
            this.salvaElencoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.ripulisciToolStripMenuItem1});
            this.ResultMenu.Name = "ResultMenu";
            this.ResultMenu.Size = new System.Drawing.Size(140, 120);
            // 
            // apriToolStripMenuItem2
            // 
            this.apriToolStripMenuItem2.Name = "apriToolStripMenuItem2";
            this.apriToolStripMenuItem2.Size = new System.Drawing.Size(139, 22);
            this.apriToolStripMenuItem2.Text = "Apri";
            this.apriToolStripMenuItem2.Click += new System.EventHandler(this.apriToolStripMenuItem2_Click);
            // 
            // copiaToolStripMenuItem
            // 
            this.copiaToolStripMenuItem.Name = "copiaToolStripMenuItem";
            this.copiaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.copiaToolStripMenuItem.Text = "Copia";
            this.copiaToolStripMenuItem.Click += new System.EventHandler(this.copiaToolStripMenuItem_Click);
            // 
            // ispezionaToolStripMenuItem
            // 
            this.ispezionaToolStripMenuItem.Name = "ispezionaToolStripMenuItem";
            this.ispezionaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ispezionaToolStripMenuItem.Text = "Ispeziona";
            this.ispezionaToolStripMenuItem.Click += new System.EventHandler(this.ispezionaToolStripMenuItem_Click);
            // 
            // salvaElencoToolStripMenuItem
            // 
            this.salvaElencoToolStripMenuItem.Name = "salvaElencoToolStripMenuItem";
            this.salvaElencoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.salvaElencoToolStripMenuItem.Text = "Salva Elenco";
            this.salvaElencoToolStripMenuItem.Click += new System.EventHandler(this.salvaElencoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(136, 6);
            // 
            // ripulisciToolStripMenuItem1
            // 
            this.ripulisciToolStripMenuItem1.Name = "ripulisciToolStripMenuItem1";
            this.ripulisciToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.ripulisciToolStripMenuItem1.Text = "Ripulisci";
            this.ripulisciToolStripMenuItem1.Click += new System.EventHandler(this.ripulisciToolStripMenuItem1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.HTMLEditorText);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(356, 432);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Ispezione";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // HTMLEditorText
            // 
            this.HTMLEditorText.Location = new System.Drawing.Point(3, 3);
            this.HTMLEditorText.Multiline = true;
            this.HTMLEditorText.Name = "HTMLEditorText";
            this.HTMLEditorText.ReadOnly = true;
            this.HTMLEditorText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HTMLEditorText.Size = new System.Drawing.Size(350, 426);
            this.HTMLEditorText.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(356, 432);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Info";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dev-Slashers";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DirBuster.Properties.Resources._241180672_704377ffc2_o;
            this.pictureBox1.Location = new System.Drawing.Point(-72, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 451);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SingleProgress
            // 
            this.SingleProgress.Location = new System.Drawing.Point(0, 479);
            this.SingleProgress.Name = "SingleProgress";
            this.SingleProgress.Size = new System.Drawing.Size(361, 10);
            this.SingleProgress.TabIndex = 3;
            // 
            // ImportTarget
            // 
            this.ImportTarget.FileName = "openFileDialog1";
            // 
            // TextConsole
            // 
            this.TextConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextConsole.Location = new System.Drawing.Point(0, 457);
            this.TextConsole.Name = "TextConsole";
            this.TextConsole.ReadOnly = true;
            this.TextConsole.Size = new System.Drawing.Size(361, 20);
            this.TextConsole.TabIndex = 4;
            this.TextConsole.Text = "Console";
            this.TextConsole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalProgress
            // 
            this.TotalProgress.Location = new System.Drawing.Point(0, 491);
            this.TotalProgress.Name = "TotalProgress";
            this.TotalProgress.Size = new System.Drawing.Size(361, 10);
            this.TotalProgress.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 503);
            this.Controls.Add(this.TotalProgress);
            this.Controls.Add(this.TextConsole);
            this.Controls.Add(this.SingleProgress);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DirBuster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.TargetMenu.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResultMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ProgressBar SingleProgress;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox ListResult;
        private System.Windows.Forms.ContextMenuStrip TargetMenu;
        private System.Windows.Forms.ToolStripMenuItem apriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rimuoviToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ResultMenu;
        private System.Windows.Forms.ToolStripMenuItem apriToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ripulisciToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ImportTarget;
        private System.Windows.Forms.TextBox TextConsole;
        private System.Windows.Forms.ProgressBar TotalProgress;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox CheckPort;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TextDirTarget;
        private System.Windows.Forms.Button StartBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton AllFileRadio;
        private System.Windows.Forms.RadioButton AllDirectoryRadio;
        private System.Windows.Forms.RadioButton XTreamCodesRadio;
        private System.Windows.Forms.ListBox ListTarget;
        private System.Windows.Forms.TextBox TargetText;
        private System.Windows.Forms.RadioButton AdminSetupRadio;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ripulisciToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salvaElencoToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveResultDialog;
        private System.Windows.Forms.ToolStripMenuItem copiaToolStripMenuItem1;
        private System.Windows.Forms.CheckBox ResultCheckBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox HTMLEditorText;
        private System.Windows.Forms.ToolStripMenuItem ispezionaToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

