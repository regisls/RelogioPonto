using System.ComponentModel;

namespace RelogioPonto
{
    partial class PassGenerator
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
            this.lblTamanho = new System.Windows.Forms.Label();
            this.txtLenght = new System.Windows.Forms.TextBox();
            this.chkMaiusculas = new System.Windows.Forms.CheckBox();
            this.chkMinusculas = new System.Windows.Forms.CheckBox();
            this.chkNumeros = new System.Windows.Forms.CheckBox();
            this.chkCaracteres = new System.Windows.Forms.CheckBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTamanho
            // 
            this.lblTamanho.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanho.Location = new System.Drawing.Point(12, 15);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(100, 23);
            this.lblTamanho.TabIndex = 0;
            this.lblTamanho.Text = "Tamanho";
            // 
            // txtLenght
            // 
            this.txtLenght.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLenght.Location = new System.Drawing.Point(80, 12);
            this.txtLenght.Name = "txtLenght";
            this.txtLenght.Size = new System.Drawing.Size(100, 25);
            this.txtLenght.TabIndex = 1;
            this.txtLenght.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLenght_KeyDown);
            // 
            // chkMaiusculas
            // 
            this.chkMaiusculas.AutoSize = true;
            this.chkMaiusculas.Checked = true;
            this.chkMaiusculas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMaiusculas.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMaiusculas.Location = new System.Drawing.Point(80, 65);
            this.chkMaiusculas.Name = "chkMaiusculas";
            this.chkMaiusculas.Size = new System.Drawing.Size(129, 24);
            this.chkMaiusculas.TabIndex = 2;
            this.chkMaiusculas.Text = "Letras maiúsculas";
            this.chkMaiusculas.UseVisualStyleBackColor = true;
            // 
            // chkMinusculas
            // 
            this.chkMinusculas.AutoSize = true;
            this.chkMinusculas.Checked = true;
            this.chkMinusculas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMinusculas.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMinusculas.Location = new System.Drawing.Point(215, 65);
            this.chkMinusculas.Name = "chkMinusculas";
            this.chkMinusculas.Size = new System.Drawing.Size(129, 24);
            this.chkMinusculas.TabIndex = 3;
            this.chkMinusculas.Text = "Letras minúsculas";
            this.chkMinusculas.UseVisualStyleBackColor = true;
            // 
            // chkNumeros
            // 
            this.chkNumeros.AutoSize = true;
            this.chkNumeros.Checked = true;
            this.chkNumeros.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumeros.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNumeros.Location = new System.Drawing.Point(80, 95);
            this.chkNumeros.Name = "chkNumeros";
            this.chkNumeros.Size = new System.Drawing.Size(79, 24);
            this.chkNumeros.TabIndex = 4;
            this.chkNumeros.Text = "Números";
            this.chkNumeros.UseVisualStyleBackColor = true;
            // 
            // chkCaracteres
            // 
            this.chkCaracteres.AutoSize = true;
            this.chkCaracteres.Checked = true;
            this.chkCaracteres.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCaracteres.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCaracteres.Location = new System.Drawing.Point(165, 95);
            this.chkCaracteres.Name = "chkCaracteres";
            this.chkCaracteres.Size = new System.Drawing.Size(145, 24);
            this.chkCaracteres.TabIndex = 5;
            this.chkCaracteres.Text = "Caracteres especiais";
            this.chkCaracteres.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(12, 138);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(385, 25);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(186, 12);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 7;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click_1);
            // 
            // PassGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 184);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.chkCaracteres);
            this.Controls.Add(this.chkNumeros);
            this.Controls.Add(this.chkMinusculas);
            this.Controls.Add(this.chkMaiusculas);
            this.Controls.Add(this.txtLenght);
            this.Controls.Add(this.lblTamanho);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PassGenerator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de senhas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnGerar;

        private System.Windows.Forms.TextBox txtSenha;

        private System.Windows.Forms.CheckBox chkCaracteres;

        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.TextBox txtLenght;
        private System.Windows.Forms.CheckBox chkMaiusculas;
        private System.Windows.Forms.CheckBox chkMinusculas;
        private System.Windows.Forms.CheckBox chkNumeros;

        #endregion
    }
}