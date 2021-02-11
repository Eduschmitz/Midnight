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
    public partial class EditarAtracao : Form
    {
        public EditarAtracao()
        {
            InitializeComponent();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvarP_Click(object sender, EventArgs e)
        {
            txt_editaAtracaoNome.Visible = true;
            txt_editadescricao.Visible = true;
            txt_editaPrecoAtracao.Visible = true;
            txt_editaPrecoAtracao.Visible = true;
            txt_editaAtracaoNome.Text = "";
            txt_editadescricao.Text = "";
            txt_editaPrecoAtracao.Text = "";
            txt_editaPrecoAtracao.Text = "";
            MessageBox.Show("Atração Editada com sucesso");            
            Form f1 = FindForm();
            MainForm f2 = new MainForm();
            f2.Show();
            f1.Hide();            
        }
    }
}
