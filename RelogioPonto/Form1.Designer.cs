
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
            this.açõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geradorDeSenhasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarGUIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualisarTodosOsRegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirReistrosDeHojeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analisarRegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.arquivarMesAnteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.sairToolStripMenuItem, this.toolStripMenuItem1, this.açõesToolStripMenuItem, this.pontoToolStripMenuItem });
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(119, 76);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 6);
            // 
            // açõesToolStripMenuItem
            // 
            this.açõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.geradorDeSenhasToolStripMenuItem, this.gerarGUIDToolStripMenuItem });
            this.açõesToolStripMenuItem.Name = "açõesToolStripMenuItem";
            this.açõesToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.açõesToolStripMenuItem.Text = "Ações";
            // 
            // geradorDeSenhasToolStripMenuItem
            // 
            this.geradorDeSenhasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("geradorDeSenhasToolStripMenuItem.Image")));
            this.geradorDeSenhasToolStripMenuItem.Name = "geradorDeSenhasToolStripMenuItem";
            this.geradorDeSenhasToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.geradorDeSenhasToolStripMenuItem.Text = "Gerar senha";
            this.geradorDeSenhasToolStripMenuItem.Click += new System.EventHandler(this.geradorDeSenhasToolStripMenuItem_Click);
            // 
            // gerarGUIDToolStripMenuItem
            // 
            this.gerarGUIDToolStripMenuItem.Name = "gerarGUIDToolStripMenuItem";
            this.gerarGUIDToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gerarGUIDToolStripMenuItem.Text = "Gerar GUID\'s";
            this.gerarGUIDToolStripMenuItem.Click += new System.EventHandler(this.gerarGUIDToolStripMenuItem_Click);
            // 
            // pontoToolStripMenuItem
            // 
            this.pontoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.visualisarTodosOsRegistrosToolStripMenuItem, this.abrirReistrosDeHojeToolStripMenuItem, this.analisarRegistrosToolStripMenuItem, this.toolStripMenuItem2, this.arquivarMesAnteriorToolStripMenuItem });
            this.pontoToolStripMenuItem.Name = "pontoToolStripMenuItem";
            this.pontoToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.pontoToolStripMenuItem.Text = "Ponto";
            // 
            // visualisarTodosOsRegistrosToolStripMenuItem
            // 
            this.visualisarTodosOsRegistrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visualisarTodosOsRegistrosToolStripMenuItem.Image")));
            this.visualisarTodosOsRegistrosToolStripMenuItem.Name = "visualisarTodosOsRegistrosToolStripMenuItem";
            this.visualisarTodosOsRegistrosToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.visualisarTodosOsRegistrosToolStripMenuItem.Text = "Visualisar todos os registros";
            this.visualisarTodosOsRegistrosToolStripMenuItem.Click += new System.EventHandler(this.visualisarTodosOsRegistrosToolStripMenuItem_Click);
            // 
            // abrirReistrosDeHojeToolStripMenuItem
            // 
            this.abrirReistrosDeHojeToolStripMenuItem.Name = "abrirReistrosDeHojeToolStripMenuItem";
            this.abrirReistrosDeHojeToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.abrirReistrosDeHojeToolStripMenuItem.Text = "Abrir registros de hoje";
            this.abrirReistrosDeHojeToolStripMenuItem.Click += new System.EventHandler(this.abrirReistrosDeHojeToolStripMenuItem_Click);
            // 
            // analisarRegistrosToolStripMenuItem
            // 
            this.analisarRegistrosToolStripMenuItem.Name = "analisarRegistrosToolStripMenuItem";
            this.analisarRegistrosToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.analisarRegistrosToolStripMenuItem.Text = "Analisar registros";
            this.analisarRegistrosToolStripMenuItem.Click += new System.EventHandler(this.analisarRegistrosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(296, 6);
            // 
            // arquivarMesAnteriorToolStripMenuItem
            // 
            this.arquivarMesAnteriorToolStripMenuItem.Name = "arquivarMesAnteriorToolStripMenuItem";
            this.arquivarMesAnteriorToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.arquivarMesAnteriorToolStripMenuItem.Text = "Arquivar registros do mes anterior";
            this.arquivarMesAnteriorToolStripMenuItem.Click += new System.EventHandler(this.arquivarMesAnteriorToolStripMenuItem_Click);
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

        private System.Windows.Forms.ToolStripMenuItem analisarRegistrosToolStripMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pontoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualisarTodosOsRegistrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirReistrosDeHojeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivarMesAnteriorToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem gerarGUIDToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem geradorDeSenhasToolStripMenuItem;

        #endregion

        private System.Windows.Forms.NotifyIcon AppIcone;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem açõesToolStripMenuItem;
    }
}

