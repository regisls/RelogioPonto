using System;
using System.Windows.Forms;

namespace RelogioPonto
{
    public partial class PassGenerator : Form
    {
        private readonly string[] _minusculas = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        private readonly string[] _maiusculas = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        private readonly string[] _numeros = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private readonly string[] _especiais = { "!", "@", "#", "$", "%", "&", "*", "(", ")", "-", "_", "+", "=", "{", "}", "[", "]", "<", ">", ",", ".", ";", ":", "?", "/", "|", "\\" };
        
        public PassGenerator()
        {
            InitializeComponent();
        }

        private void GerarSenha()
        {
            bool checkedAlgumaOpcao = chkMinusculas.Checked || chkMaiusculas.Checked || chkNumeros.Checked || chkCaracteres.Checked;

            if (!checkedAlgumaOpcao)
            {
                MessageBox.Show("Selecione pelo menos uma opção de caracteres para gerar a senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txtLenght.Text))
            {
                MessageBox.Show("Informe o tamanho da senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            int tamanho = Convert.ToInt32(txtLenght.Text);
            
            string senha = "";
            
            Random rnd = new Random();
            int i = 0;
            while (i < tamanho)
            {
                int tipo = rnd.Next(4);
                
                switch (tipo)
                {
                    case 0:
                        if (chkMinusculas.Checked)
                        {
                            senha += _minusculas[rnd.Next(_minusculas.Length)];
                            i++;
                        }
                        break;
                    case 1:
                        if (chkMaiusculas.Checked)
                        {
                            senha += _maiusculas[rnd.Next(_maiusculas.Length)];
                            i++;
                        }
                        break;
                    case 2:
                        if (chkNumeros.Checked)
                        {
                            senha += _numeros[rnd.Next(_numeros.Length)];
                            i++;
                        }
                        break;
                    case 3:
                        if (chkCaracteres.Checked)
                        {
                            senha += _especiais[rnd.Next(_especiais.Length)];
                            i++;
                        }
                        break;
                }
            }
            
            txtSenha.Text = senha;
        }

        private void btnGerar_Click_1(object sender, EventArgs e)
        {
            GerarSenha();
        }

        private void txtLenght_KeyDown(object sender, KeyEventArgs e)
        {
            // alow only numbers
            if (
                (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && 
                (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && 
                e.KeyCode != Keys.Back && 
                e.KeyCode != Keys.Delete && 
                e.KeyCode != Keys.Left && 
                e.KeyCode != Keys.Right &&
                e.KeyCode != Keys.Home &&
                e.KeyCode != Keys.End)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void aa(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}