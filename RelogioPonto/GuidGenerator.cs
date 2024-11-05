using System;
using System.Linq;
using System.Windows.Forms;

namespace RelogioPonto
{
    public partial class GuidGenerator : Form
    {
        public GuidGenerator()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
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

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Informe a quantidade de GUID's que devem ser gerados", "Gerador de GUIDS's", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            lstGuids.Items.Clear();
            int i = 0;
            
            while (i < int.Parse(textBox1.Text))
            {
                lstGuids.Items.Add(Guid.NewGuid().ToString());
                lstGuids.Update();
                i++;
            }
        }

        private void lstGuids_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void lstGuids_KeyDown(object sender, KeyEventArgs e)
        {
            // on ctrl+c copy to clipboard all selected items
            if (e.KeyCode == Keys.C && e.Control)
            {
                string selecionados = "";
                foreach (var item in lstGuids.SelectedItems.Cast<string>())
                {
                    selecionados += item + Environment.NewLine;
                }
                Clipboard.SetText(selecionados);
            }
        }
    }
}