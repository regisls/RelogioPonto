using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;
using Microsoft.Win32;

namespace RelogioPonto
{
    public partial class Form1 : Form
    {
        private string BaseDir { get; set; }
        private string AppDir { get; set; }
        private string NomeArquivo { get; set; }
        private string UltimoEvento { get; set; }

        private const string SAIDA = "SAIDA";
        private const string ENTRADA = "ENTRADA";
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            Hide();

            this.BaseDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            this.AppDir = Path.Combine(BaseDir, "Folha Ponto");

            if (!Directory.Exists(AppDir))
                Directory.CreateDirectory(AppDir);

            SystemEvents.SessionSwitch += new SessionSwitchEventHandler(SystemEvents_SessionSwitch);
            SystemEvents.SessionEnding += new SessionEndingEventHandler(SystemEvents_SessionEnding);

            string observacao = "Relógio Ponto iniciado";
            string evento = ENTRADA;

            GravarLog(evento, observacao);
        }

        private void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            string observacao = string.Empty;
            string evento = "";

            if (e.Reason == SessionSwitchReason.SessionLock)
            {
                //I left my desk
                observacao = "Bloqueio do computador";
                evento = SAIDA;
            }
            else if (e.Reason == SessionSwitchReason.SessionUnlock)
            {
                //I returned to my desk
                observacao = "Desbloqueio do computador";
                evento = ENTRADA;
            }

            GravarLog(evento, observacao);
        }

        private void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
        {
            string observacao = string.Empty;
            string evento = SAIDA;

            switch(e.Reason)
            {
                case SessionEndReasons.Logoff:
                    observacao = "Logoff do usuário";
                    break;
                case SessionEndReasons.SystemShutdown:
                    observacao = "Máquina desligada";
                    break;
            }

            GravarLog(evento, observacao);
        }

        private void GravarLog(string Evento, string observacao = "")
        {
            this.NomeArquivo = Path.Combine(AppDir, $"Ponto-{DateTime.Now:yyyy-MM-dd}.txt");
            this.UltimoEvento = $"{Evento,-7} | {DateTime.Now:HH:mm} | {observacao}";

            File.AppendAllText(NomeArquivo, $"{UltimoEvento}\r\n");
            
            AppIcone.Text = $"Relógio ponto - {UltimoEvento}";
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppIcone.Visible = false;
            AppIcone.Dispose();
            Application.Exit();
        }

        private void mnuVerRegistros_Click(object sender, EventArgs e)
        {
            Process.Start(AppDir);
        }

        private void compactarRegistrosDoMesAnteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompressFiles();
        }

        // compress all files from last month in the AppDir path
        private void CompressFiles()
        {
            int mesAnterior = DateTime.Now.Month - 1;

            var files = Directory.EnumerateFiles(AppDir, $"Ponto-{DateTime.Now:yyyy}-{mesAnterior:00}-*.txt").ToList();

            if (files.Count == 0)
            {
                MessageBox.Show("Não há arquivos para compactar");
                return;
            }

            string zipFile = Path.Combine(AppDir, $"Ponto-{DateTime.Now:yyyy}-{mesAnterior:00}.zip");

            using (var zip = new ZipFile())
            {
                zip.AddFiles(files, false, "");
                zip.Save(zipFile);
            }

            foreach (var file in files)
                File.Delete(file);

            MessageBox.Show("Compactação realizada com sucesso");
        }
    }
}
