﻿
namespace RelogioPonto
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AppIcone = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuVerRegistros = new System.Windows.Forms.ToolStripMenuItem();
            this.açõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compactarRegistrosDoMesAnteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geradorDeSenhasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarGUIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppIcone
            // 
            this.AppIcone.ContextMenuStrip = this.menu;
            this.AppIcone.Icon = ((System.Drawing.Icon)(resources.GetObject("AppIcone.Icon")));
            this.AppIcone.Text = "Relógio ponto";
            this.AppIcone.Visible = true;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.sairToolStripMenuItem, this.toolStripMenuItem1, this.mnuVerRegistros, this.açõesToolStripMenuItem });
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(139, 76);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 6);
            // 
            // mnuVerRegistros
            // 
            this.mnuVerRegistros.Name = "mnuVerRegistros";
            this.mnuVerRegistros.Size = new System.Drawing.Size(138, 22);
            this.mnuVerRegistros.Text = "Ver registros";
            this.mnuVerRegistros.Click += new System.EventHandler(this.mnuVerRegistros_Click);
            // 
            // açõesToolStripMenuItem
            // 
            this.açõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.compactarRegistrosDoMesAnteriorToolStripMenuItem, this.geradorDeSenhasToolStripMenuItem, this.gerarGUIDToolStripMenuItem });
            this.açõesToolStripMenuItem.Name = "açõesToolStripMenuItem";
            this.açõesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.açõesToolStripMenuItem.Text = "Ações";
            // 
            // compactarRegistrosDoMesAnteriorToolStripMenuItem
            // 
            this.compactarRegistrosDoMesAnteriorToolStripMenuItem.Name = "compactarRegistrosDoMesAnteriorToolStripMenuItem";
            this.compactarRegistrosDoMesAnteriorToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.compactarRegistrosDoMesAnteriorToolStripMenuItem.Text = "Compactar registros do mes anterior";
            this.compactarRegistrosDoMesAnteriorToolStripMenuItem.Click += new System.EventHandler(this.compactarRegistrosDoMesAnteriorToolStripMenuItem_Click);
            // 
            // geradorDeSenhasToolStripMenuItem
            // 
            this.geradorDeSenhasToolStripMenuItem.Name = "geradorDeSenhasToolStripMenuItem";
            this.geradorDeSenhasToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.geradorDeSenhasToolStripMenuItem.Text = "Gerar senha";
            this.geradorDeSenhasToolStripMenuItem.Click += new System.EventHandler(this.geradorDeSenhasToolStripMenuItem_Click);
            // 
            // gerarGUIDToolStripMenuItem
            // 
            this.gerarGUIDToolStripMenuItem.Name = "gerarGUIDToolStripMenuItem";
            this.gerarGUIDToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.gerarGUIDToolStripMenuItem.Text = "Gerar GUID\'s";
            this.gerarGUIDToolStripMenuItem.Click += new System.EventHandler(this.gerarGUIDToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ToolStripMenuItem gerarGUIDToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem geradorDeSenhasToolStripMenuItem;

        #endregion

        private System.Windows.Forms.NotifyIcon AppIcone;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuVerRegistros;
        private System.Windows.Forms.ToolStripMenuItem açõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compactarRegistrosDoMesAnteriorToolStripMenuItem;
    }
}

