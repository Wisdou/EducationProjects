using System.Collections.Generic;
using System.Windows.Forms;

namespace MetrologyApp
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFileWork = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSaver = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAnalys = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAnalysCombinatoricalCriteria = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAnalysAbbeCriteria = new System.Windows.Forms.ToolStripMenuItem();
            this.ListData = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TXTFileOpener = new System.Windows.Forms.OpenFileDialog();
            this.saveData = new System.Windows.Forms.SaveFileDialog();
            this.labelMean = new System.Windows.Forms.Label();
            this.statParameters = new System.Windows.Forms.RichTextBox();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileWork,
            this.MenuAnalys,
            this.MenuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFileWork
            // 
            this.MenuFileWork.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileOpen,
            this.MenuFileSaver});
            this.MenuFileWork.Name = "MenuFileWork";
            this.MenuFileWork.Size = new System.Drawing.Size(59, 26);
            this.MenuFileWork.Text = "Файл";
            // 
            // MenuFileOpen
            // 
            this.MenuFileOpen.Name = "MenuFileOpen";
            this.MenuFileOpen.Size = new System.Drawing.Size(166, 26);
            this.MenuFileOpen.Text = "Открыть";
            this.MenuFileOpen.Click += new System.EventHandler(this.MenuFileOpen_Click);
            // 
            // MenuFileSaver
            // 
            this.MenuFileSaver.Name = "MenuFileSaver";
            this.MenuFileSaver.Size = new System.Drawing.Size(166, 26);
            this.MenuFileSaver.Text = "Сохранить";
            this.MenuFileSaver.Click += new System.EventHandler(this.MenuFileSaver_Click);
            // 
            // MenuAnalys
            // 
            this.MenuAnalys.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAnalysCombinatoricalCriteria,
            this.MenuAnalysAbbeCriteria});
            this.MenuAnalys.Name = "MenuAnalys";
            this.MenuAnalys.Size = new System.Drawing.Size(130, 26);
            this.MenuAnalys.Text = "Анализ данных";
            // 
            // MenuAnalysCombinatoricalCriteria
            // 
            this.MenuAnalysCombinatoricalCriteria.Name = "MenuAnalysCombinatoricalCriteria";
            this.MenuAnalysCombinatoricalCriteria.Size = new System.Drawing.Size(291, 26);
            this.MenuAnalysCombinatoricalCriteria.Text = "Комбинационный критерий";
            this.MenuAnalysCombinatoricalCriteria.Click += new System.EventHandler(this.MenuAnalysCombinatoricalCriteria_Click);
            // 
            // MenuAnalysAbbeCriteria
            // 
            this.MenuAnalysAbbeCriteria.Name = "MenuAnalysAbbeCriteria";
            this.MenuAnalysAbbeCriteria.Size = new System.Drawing.Size(291, 26);
            this.MenuAnalysAbbeCriteria.Text = "Критерий Аббе";
            this.MenuAnalysAbbeCriteria.Click += new System.EventHandler(this.MenuAnalysAbbeCriteria_Click);
            // 
            // ListData
            // 
            this.ListData.FormattingEnabled = true;
            this.ListData.ItemHeight = 16;
            this.ListData.Location = new System.Drawing.Point(12, 31);
            this.ListData.Name = "ListData";
            this.ListData.Size = new System.Drawing.Size(289, 324);
            this.ListData.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(13, 366);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(288, 33);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить элемент";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(13, 405);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(288, 33);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить выбранный элемент";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // TXTFileOpener
            // 
            this.TXTFileOpener.FileName = "TXTFileOpener";
            // 
            // labelMean
            // 
            this.labelMean.AutoSize = true;
            this.labelMean.Location = new System.Drawing.Point(325, 31);
            this.labelMean.Name = "labelMean";
            this.labelMean.Size = new System.Drawing.Size(0, 17);
            this.labelMean.TabIndex = 4;
            this.labelMean.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statParameters
            // 
            this.statParameters.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statParameters.Location = new System.Drawing.Point(316, 31);
            this.statParameters.Name = "statParameters";
            this.statParameters.ReadOnly = true;
            this.statParameters.Size = new System.Drawing.Size(467, 407);
            this.statParameters.TabIndex = 6;
            this.statParameters.Text = "";
            // 
            // MenuHelp
            // 
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(83, 26);
            this.MenuHelp.Text = "Помощь";
            this.MenuHelp.Click += new System.EventHandler(this.MenuHelp_Click);
            // 
            // MainWindow
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 453);
            this.Controls.Add(this.statParameters);
            this.Controls.Add(this.labelMean);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.ListData);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFileWork;
        private System.Windows.Forms.ToolStripMenuItem MenuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuFileSaver;
        private System.Windows.Forms.ToolStripMenuItem MenuAnalys;
        private System.Windows.Forms.ToolStripMenuItem MenuAnalysCombinatoricalCriteria;
        private System.Windows.Forms.ToolStripMenuItem MenuAnalysAbbeCriteria;
        public System.Windows.Forms.ListBox ListData;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog TXTFileOpener;
        private Label labelMean;
        private RichTextBox statParameters;
        private SaveFileDialog saveData;
        private ToolStripMenuItem MenuHelp;
    }
}

