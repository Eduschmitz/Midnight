using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midnight
{
    public partial class ExcluirAtracao : Form
    {
        public ExcluirAtracao()
        {
            InitializeComponent();
        }

        private void btnExcluirAtracao_Click(object sender, EventArgs e)
        {
            txt_excluiAtracaoNome.Visible = true;
            txt_ExcluiDescricaoAtracao.Visible = true;
            txt_ExcluiHoraAtracao.Visible = true;
            txt_excluiAtracaoNome.Text = "";
            txt_ExcluiDescricaoAtracao.Text = "";
            txt_ExcluiHoraAtracao.Text = "";
            MessageBox.Show("Atração Excluida com sucesso");
            Form f1 = FindForm();
            MainForm f2 = new MainForm();
            f2.Show();
            f1.Hide();
            
        }

        private void txt_excluiAtracaoNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
