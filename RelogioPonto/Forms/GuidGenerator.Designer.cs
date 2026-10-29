using System.ComponentModel;

namespace RelogioPonto
{
    partial class GuidGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.btnGerar = new System.Windows.Forms.Button();
            this.lstGuids = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkUpperCase = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(320, 355);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(89, 29);
            this.btnGerar.TabIndex = 3;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lstGuids
            // 
            this.lstGuids.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGuids.FormattingEnabled = true;
            this.lstGuids.ItemHeight = 18;
            this.lstGuids.Location = new System.Drawing.Point(12, 55);
            this.lstGuids.Name = "lstGuids";
            this.lstGuids.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstGuids.Size = new System.Drawing.Size(397, 292);
            this.lstGuids.TabIndex = 4;
            this.lstGuids.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstGuids_KeyDown);
            this.lstGuids.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstGuids_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantidade";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(105, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 24);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "1";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // chkUpperCase
            // 
            this.chkUpperCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpperCase.Location = new System.Drawing.Point(265, 14);
            this.chkUpperCase.Name = "chkUpperCase";
            this.chkUpperCase.Size = new System.Drawing.Size(104, 24);
            this.chkUpperCase.TabIndex = 2;
            this.chkUpperCase.Text = "Maiúsculos";
            this.chkUpperCase.UseVisualStyleBackColor = true;
            // 
            // GuidGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 396);
            this.Controls.Add(this.chkUpperCase);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstGuids);
            this.Controls.Add(this.btnGerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuidGenerator";
            this.Text = "Gerar Guid";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckBox chkUpperCase;

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.ListBox lstGuids;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}