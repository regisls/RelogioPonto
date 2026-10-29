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

        private string _ultimoTipoEvento = null;
        private DateTime _ultimoTempoEvento = DateTime.MinValue;
        private static readonly TimeSpan _limiarDeduplicacao = TimeSpan.FromSeconds(5);

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
            SystemEvents.PowerModeChanged += new PowerModeChangedEventHandler(SystemEvents_PowerModeChanged);

            GravarLog(ENTRADA, "Relógio Ponto iniciado");
        }

        private void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            if (e.Reason == SessionSwitchReason.SessionLock)
                GravarLog(SAIDA, "Bloqueio do computador");
            else if (e.Reason == SessionSwitchReason.SessionUnlock)
                GravarLog(ENTRADA, "Desbloqueio do computador");
        }

        private void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
        {
            string observacao = e.Reason == SessionEndReasons.Logoff
                ? "Logoff do usuário"
                : "Máquina desligada";

            GravarLog(SAIDA, observacao);
        }

        private void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            if (e.Mode == PowerModes.Suspend)
                GravarLog(SAIDA, "Computador em suspensão");
            else if (e.Mode == PowerModes.Resume)
                GravarLog(ENTRADA, "Computador retomado da suspensão");
        }

        private void GravarLog(string Evento, string observacao = "")
        {
            if (string.IsNullOrEmpty(Evento))
                return;

            var agora = DateTime.Now;
            if (Evento == _ultimoTipoEvento && agora - _ultimoTempoEvento < _limiarDeduplicacao)
                return;

            _ultimoTipoEvento = Evento;
            _ultimoTempoEvento = agora;

            this.NomeArquivo = Path.Combine(AppDir, $"Ponto-{agora:yyyy-MM-dd}.txt");
            this.UltimoEvento = $"{Evento,-7} | {agora:HH:mm:ss} | {observacao}";

            try
            {
                File.AppendAllText(NomeArquivo, $"{UltimoEvento}\r\n");
                AppIcone.Text = $"Relógio ponto - {UltimoEvento}";
            }
            catch (Exception ex)
            {
                AppIcone.ShowBalloonTip(5000, "Erro ao gravar registro", ex.Message, ToolTipIcon.Error);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppIcone.Visible = false;
            AppIcone.Dispose();
            Application.Exit();
        }

        // compress all files from last month in the AppDir path
        private void CompressFiles()
        {
            int mesAnterior = DateTime.Now.Month - 1;
            int ano = DateTime.Now.Year;

            if (mesAnterior == 0)
            {
                mesAnterior = 12;
                ano--;
            }

            var files = Directory.EnumerateFiles(AppDir, $"Ponto-{ano}-{mesAnterior:00}-*.txt").ToList();

            if (files.Count == 0)
            {
                MessageBox.Show("Não há arquivos para compactar", "Relógio Ponto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string zipFile = Path.Combine(AppDir, $"Ponto-{ano}-{mesAnterior:00}.zip");

            using (var zip = new ZipFile())
            {
                zip.AddFiles(files, false, "");
                zip.Save(zipFile);
            }

            foreach (var file in files)
                File.Delete(file);

            MessageBox.Show("Compactação realizada com sucesso", "Relógio Ponto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void geradorDeSenhasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassGenerator passGenerator = new PassGenerator();
            passGenerator.Show();
        }

        private void gerarGUIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuidGenerator guidGenerator = new GuidGenerator();
            guidGenerator.Show();
        }

        private void visualisarTodosOsRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(AppDir);
        }

        private void abrirReistrosDeHojeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string arquivoHoje = Path.Combine(AppDir, $"Ponto-{DateTime.Now:yyyy-MM-dd}.txt");

            if (!File.Exists(arquivoHoje))
            {
                MessageBox.Show("Nenhum registro encontrado para hoje.", "Registros de hoje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Process.Start(arquivoHoje);
        }

        private void arquivarMesAnteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompressFiles();
        }

        private void analisarRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeAdvisor timeAdvisor = new TimeAdvisor();
            timeAdvisor.Show();
        }
    }
}
