
using MetrologyHometask;
using System;

namespace MetrologyApp
{
    partial class CriteriaForm
    {
        ICriteria criteria;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public CriteriaForm(ICriteria criteria)
        {
            InitializeComponent();
            this.criteria = criteria;
            try
            {
                criteriaInfo.Text = $"{Analyser.GetReport(Program.data)}\n\n{criteria.CheckCriteria(Program.data)}";
            }
            catch (Exception)
            {
                criteriaInfo.Text = "Не достаточно измерений для применения критерия или невозможно применить критерий для данной выборки.";
            }
        }
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
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSaver = new System.Windows.Forms.ToolStripMenuItem();
            this.criteriaInfo = new System.Windows.Forms.RichTextBox();
            this.saveCriteria = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(461, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSaver});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(59, 24);
            this.MenuFile.Text = "Файл";
            // 
            // MenuSaver
            // 
            this.MenuSaver.Name = "MenuSaver";
            this.MenuSaver.Size = new System.Drawing.Size(166, 26);
            this.MenuSaver.Text = "Сохранить";
            this.MenuSaver.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // criteriaInfo
            // 
            this.criteriaInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.criteriaInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.criteriaInfo.Location = new System.Drawing.Point(0, 28);
            this.criteriaInfo.Name = "criteriaInfo";
            this.criteriaInfo.ReadOnly = true;
            this.criteriaInfo.Size = new System.Drawing.Size(461, 313);
            this.criteriaInfo.TabIndex = 1;
            this.criteriaInfo.Text = "";
            // 
            // CriteriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 341);
            this.Controls.Add(this.criteriaInfo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CriteriaForm";
            this.Text = "CriteriaForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuSaver;
        private System.Windows.Forms.RichTextBox criteriaInfo;
        private System.Windows.Forms.SaveFileDialog saveCriteria;
    }
}