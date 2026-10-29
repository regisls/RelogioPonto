using System.ComponentModel;

namespace RelogioPonto
{
    partial class TimeAdvisor
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPeriodo = new System.Windows.Forms.DateTimePicker();
            this.lblResultados = new System.Windows.Forms.Label();
            this.rtbResultados = new System.Windows.Forms.RichTextBox();
            this.lblAlertas = new System.Windows.Forms.Label();
            this.rtbAlertas = new System.Windows.Forms.RichTextBox();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Período";
            //
            // dtpPeriodo
            //
            this.dtpPeriodo.CustomFormat = "MM/yyyy";
            this.dtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPeriodo.Location = new System.Drawing.Point(12, 25);
            this.dtpPeriodo.Name = "dtpPeriodo";
            this.dtpPeriodo.Size = new System.Drawing.Size(100, 20);
            this.dtpPeriodo.TabIndex = 3;
            //
            // lblResultados
            //
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(12, 50);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.TabIndex = 6;
            this.lblResultados.Text = "Resultados";
            //
            // rtbResultados
            //
            this.rtbResultados.Font = new System.Drawing.Font("Courier New", 9F);
            this.rtbResultados.Location = new System.Drawing.Point(12, 66);
            this.rtbResultados.Name = "rtbResultados";
            this.rtbResultados.ReadOnly = true;
            this.rtbResultados.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.rtbResultados.Size = new System.Drawing.Size(776, 212);
            this.rtbResultados.TabIndex = 4;
            this.rtbResultados.WordWrap = false;
            this.rtbResultados.BackColor = System.Drawing.SystemColors.Window;
            //
            // lblAlertas
            //
            this.lblAlertas.AutoSize = true;
            this.lblAlertas.Location = new System.Drawing.Point(12, 285);
            this.lblAlertas.Name = "lblAlertas";
            this.lblAlertas.TabIndex = 7;
            this.lblAlertas.Text = "Alertas";
            //
            // rtbAlertas
            //
            this.rtbAlertas.Font = new System.Drawing.Font("Courier New", 9F);
            this.rtbAlertas.Location = new System.Drawing.Point(12, 301);
            this.rtbAlertas.Name = "rtbAlertas";
            this.rtbAlertas.ReadOnly = true;
            this.rtbAlertas.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbAlertas.Size = new System.Drawing.Size(776, 137);
            this.rtbAlertas.TabIndex = 8;
            this.rtbAlertas.WordWrap = false;
            this.rtbAlertas.BackColor = System.Drawing.SystemColors.Window;
            //
            // btnAnalisar
            //
            this.btnAnalisar.Location = new System.Drawing.Point(118, 22);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(90, 23);
            this.btnAnalisar.TabIndex = 5;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            //
            // TimeAdvisor
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnalisar);
            this.Controls.Add(this.rtbAlertas);
            this.Controls.Add(this.lblAlertas);
            this.Controls.Add(this.rtbResultados);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.dtpPeriodo);
            this.Controls.Add(this.label1);
            this.Name = "TimeAdvisor";
            this.Text = "TimeAdvisor";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnAnalisar;
        private System.Windows.Forms.RichTextBox rtbResultados;
        private System.Windows.Forms.RichTextBox rtbAlertas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Label lblAlertas;
        private System.Windows.Forms.DateTimePicker dtpPeriodo;

        #endregion
    }
}