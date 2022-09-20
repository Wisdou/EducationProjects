
namespace MetrologyApp
{
    partial class FormAdder
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
            this.labelAdder = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.doubleInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAdder
            // 
            this.labelAdder.AutoSize = true;
            this.labelAdder.Location = new System.Drawing.Point(14, 16);
            this.labelAdder.Name = "labelAdder";
            this.labelAdder.Size = new System.Drawing.Size(114, 17);
            this.labelAdder.TabIndex = 0;
            this.labelAdder.Text = "Введите число: ";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(16, 56);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(111, 35);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(189, 56);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(111, 35);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // doubleInput
            // 
            this.doubleInput.Location = new System.Drawing.Point(134, 16);
            this.doubleInput.Name = "doubleInput";
            this.doubleInput.Size = new System.Drawing.Size(166, 22);
            this.doubleInput.TabIndex = 4;
            // 
            // FormAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 103);
            this.Controls.Add(this.doubleInput);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelAdder);
            this.Name = "FormAdder";
            this.Text = "FormAdder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdder;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox doubleInput;
    }
}