using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Ionic.Zip;

namespace RelogioPonto
{
    public partial class TimeAdvisor : Form
    {
        private readonly string AppDir;
        private readonly string ScriptPath;

        public TimeAdvisor()
        {
            InitializeComponent();
            string baseDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            AppDir = Path.Combine(baseDir, "Folha Ponto");
            ScriptPath = Path.Combine(AppDir, "scripts", "analisar_ponto.py");
        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            int ano = dtpPeriodo.Value.Year;
            int mes = dtpPeriodo.Value.Month;

            if (!File.Exists(ScriptPath))
            {
                MessageBox.Show($"Script não encontrado:\n{ScriptPath}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string pastaTemp = null;
            string pastaTrabalho;

            try
            {
                bool ehMesAtual = ano == DateTime.Now.Year && mes == DateTime.Now.Month;

                if (ehMesAtual)
                {
                    pastaTrabalho = AppDir;
                }
                else
                {
                    pastaTemp = Path.Combine(Path.GetTempPath(), $"RelogioPonto_{ano}{mes:00}_{Guid.NewGuid():N}");
                    Directory.CreateDirectory(pastaTemp);
                    pastaTrabalho = pastaTemp;

                    if (!ExtrairArquivosMes(ano, mes, pastaTemp))
                        return;
                }

                Cursor = Cursors.WaitCursor;
                btnAnalisar.Enabled = false;

                ExecutarScript(pastaTrabalho);

                rtbResultados.Clear();
                rtbAlertas.Clear();
                CarregarResultados(pastaTrabalho, ano, mes);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao analisar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnAnalisar.Enabled = true;

                if (pastaTemp != null && Directory.Exists(pastaTemp))
                    Directory.Delete(pastaTemp, recursive: true);
            }
        }

        private bool ExtrairArquivosMes(int ano, int mes, string destino)
        {
            // 1. Tentar Ponto-YYYY-MM.zip diretamente na pasta principal
            string zipMensal = Path.Combine(AppDir, $"Ponto-{ano}-{mes:00}.zip");
            if (File.Exists(zipMensal))
            {
                ExtrairZip(zipMensal, destino);
                return true;
            }

            // 2. Tentar dentro de Ponto-YYYY.zip (arquivo anual contendo zips mensais)
            string zipAnual = Path.Combine(AppDir, $"Ponto-{ano}.zip");
            if (File.Exists(zipAnual))
            {
                string zipMensalNome = $"Ponto-{ano}-{mes:00}.zip";

                using (var zip = ZipFile.Read(zipAnual))
                {
                    var entrada = zip[zipMensalNome];
                    if (entrada == null)
                    {
                        MessageBox.Show(
                            $"Arquivo {zipMensalNome} não encontrado dentro de Ponto-{ano}.zip.",
                            "Dados não encontrados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    entrada.Extract(destino, ExtractExistingFileAction.OverwriteSilently);
                }

                // Extrair os .txt do zip mensal recém-extraído
                string zipMensalExtraido = Path.Combine(destino, zipMensalNome);
                ExtrairZip(zipMensalExtraido, destino);
                File.Delete(zipMensalExtraido);
                return true;
            }

            MessageBox.Show(
                $"Nenhum arquivo de ponto encontrado para {mes:00}/{ano}.\n\n" +
                $"Esperado: Ponto-{ano}-{mes:00}.zip ou Ponto-{ano}.zip",
                "Dados não encontrados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private void ExtrairZip(string caminhoZip, string destino)
        {
            using (var zip = ZipFile.Read(caminhoZip))
            {
                foreach (var entrada in zip)
                    entrada.Extract(destino, ExtractExistingFileAction.OverwriteSilently);
            }
        }

        private void ExecutarScript(string pasta)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = $"\"{ScriptPath}\" \"{pasta}\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardError = true,
                StandardErrorEncoding = Encoding.UTF8,
            };

            using (var proc = Process.Start(psi))
            {
                string erro = proc.StandardError.ReadToEnd();
                proc.WaitForExit();

                if (proc.ExitCode != 0 && !string.IsNullOrWhiteSpace(erro))
                    throw new Exception($"Script Python retornou erro:\n{erro}");
            }
        }

        private void CarregarResultados(string pasta, int ano, int mes)
        {
            string resumoPath = Path.Combine(pasta, $"Ponto-Resumo-{ano}-{mes:00}.txt");
            string alertasPath = Path.Combine(pasta, $"Ponto-Alertas-{ano}-{mes:00}.txt");

            if (!File.Exists(resumoPath))
            {
                rtbResultados.Text = "Nenhum resultado gerado para o período selecionado.";
                return;
            }

            rtbResultados.Text = File.ReadAllText(resumoPath, Encoding.UTF8);
            File.Delete(resumoPath);

            if (File.Exists(alertasPath))
            {
                rtbAlertas.Text = File.ReadAllText(alertasPath, Encoding.UTF8);
                File.Delete(alertasPath);
            }
        }
    }
}