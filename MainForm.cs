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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        //altera opções de entrada de produtos 
        //remove a caixa de texto e apresenta uma caixa de seleção com itens pre definidos
        //(tbpCardapio)
        private void ckbTipoProduto_CheckedChanged(object sender, EventArgs e)
        {
            cbxTipoProduto.Visible = false;
            txtProdutoC.Visible = true;
            ckbSelecionarProdP.Visible = true;
            ckbAdicionarProdP.Visible = false;
        }

        //função que fecha a tela ao clicar no (x)
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        //altera entre adicionar e visualizar cadastro do estabelecimento 
        //chama a EditEForm para edição do cadastro
        //pede confirmação de login
        //(tbpEstabelecimento)
        private void cbxOpcoesE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxOpcoesE.SelectedIndex == 1)
            {
                Form f1 = FindForm();
                EditEForm f2 = new EditEForm();
                f2.Show();
                f1.Hide();
            }
            else if (cbxOpcoesE.SelectedIndex == 2) {
                Form f1 = FindForm();
                AddLogin f2 = new AddLogin();
                f2.Show();
                f1.Hide();
            }


        }

        //altera entre adicionar e visualizar cadastro de produtos
        //chama EdidPForm
        //(tbpCardapio)
        private void cbxOpcoesP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxOpcoesP.SelectedIndex == 1)
            {
                Form f1 = FindForm();
                EditPForm f2 = new EditPForm();
                f2.Show();
                f1.Hide();
            }
        }

        //altera a opção de entrada de tipo de produtos para o controle de estoque
        //remove a caixa de seleção e apressenta uma caixa de texto para digitar um tipo de produto novo
        //(tbpEstoque)
        private void ckbAdicionarP_CheckedChanged(object sender, EventArgs e)
        {
            cbxProtudos.Visible = false;
            txtProduto.Visible = true;
            ckbSelecionarProdE.Visible = true;
            ckbAdicionarProdE.Visible = false;
        }

        //adiciona um novo registro de produto a base de dados
        //limpa as caixas de entrada
        //(tbpCardapio)
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ckbAdicionarProdP.Visible = true;
            cbxTipoProduto.Visible = true;
            ckbSelecionarProdP.Visible = false;
            txtProdutoC.Visible = false;
            txtProdutoC.Text = "";
            cbxTipoProduto.Text = "";
            txtDescricaoC.Text = "";
            txtPrecoC.Text = "";
        }

        //altera a opção de entrada de tipo de produto no controle de estoque 
        //remove a caixa de texto e apresenta uma caixa de seleção com opções pre definidas
        //(tbpEstoque)
        private void ckbSelecionarP_CheckedChanged(object sender, EventArgs e)
        {
            ckbAdicionarProdE.Visible = true;
            ckbSelecionarProdE.Visible = false;
            cbxProtudos.Visible = true;
            txtProduto.Visible = false;

        }

        //altera a opção de entrada do tipo de produto 
        //remove a caixa de seleção e apresenta uma caixa de texto para adicionar um produto novo
        //(tbpCardapio)
        private void ckbSelecionarProdP_CheckedChanged(object sender, EventArgs e)
        {
            cbxTipoProduto.Visible = true;
            txtProdutoC.Visible = false;
            ckbAdicionarProdP.Visible = true;
            ckbSelecionarProdP.Visible = false;
        }

        //faz o controle da lista de itens durante a realização de uma venda
        //calcula o subtotal da venda
        //(tbpVenda)
        private void btnAdicionarProdV_Click(object sender, EventArgs e)
        {
            lbxProduto.Items.Add(cbxProdutoV.SelectedItem);
            lbxQuantidade.Items.Add(txtQuantidadeV.Text);
            int qtd = int.Parse(txtQuantidadeV.Text);
            double preco = double.Parse(txtPrecoV.Text);
            lbxPreco.Items.Add(qtd * preco);
            double subtotal = double.Parse(txtSubtotal.Text);
            subtotal += (qtd * preco);
            txtSubtotal.Text = Convert.ToString(subtotal);

            cbxProdutoV.Text = "";
            txtQuantidadeV.Text = "";
            txtPrecoV.Text = "";
        }
        /// <summary>
        /// /Duda não está funcionando
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //altera entre visualizar e alterar horario de funcionamento
        //(tbpEstabelecimento)
        //private void btnAlteraH_Click(object sender, EventArgs e)
        //{
        //    gbxAlteraH.Visible = true;
        //    gbxVizualizaH.Visible = false;
        //}

        //atualiza as informacoes de horario de funcionamento
        //retorna a tela de visualizar informações
        //(tbpEstabelecimento)
        private void btnAtualizaH_Click(object sender, EventArgs e)
        {

        }

        //atualiza o controle de estoque na base de dados
        //limpa os campos de entrada 
        //(tbpEstoque)
        private void btnAtualizarE_Click(object sender, EventArgs e)
        {
            cbxProtudos.Visible = true;
            ckbAdicionarProdE.Visible = true;
            txtProduto.Visible = false;
            ckbSelecionarProdE.Visible = false;
            txtProduto.Text = "";
            cbxProtudos.Text = "";
            txtQtdEstoque.Text = "";
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            //trecho usado para separar data da hora
            //char[] data = new char[12];
            //Convert.ToString(DateTime.Now.Date).CopyTo(0,data,0,10);
            //string temp = "";
            //for (int i = 0; i < 10; i++)
            //{
            //    temp += data[i];
            //}
            //lblDia.Text = Convert.ToString(temp);


            lblDia.Text = Convert.ToString(DateTime.Now);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lblAberturaSeg.Visible = true;
            txtAberturaSeg.Visible = true;
            lblEncerramentoSeg.Visible = true;
            txtEncerramentoSeg.Visible = true;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)// Adicionar atração
        {
            txtBox_addAtracao.Visible = true;
            txtBox_descricaoAtracao.Visible = true;
            txtBox_inseriPreçoAtracao.Visible = true;
            txtbox_InserirHorario.Visible = true;
            txtBox_addAtracao.Text = "";
            txtBox_descricaoAtracao.Text = "";
            txtBox_inseriPreçoAtracao.Text = "";
            txtbox_InserirHorario.Text = "";
            MessageBox.Show("Atração Cadastrado com sucesso");
        }

        private void textBox1_addAtracao_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBox_OpcaoAtracao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBox_OpcaoAtracao.SelectedIndex == 0)// vazio
            {
                MessageBox.Show("Escolha uma opção");                
            }
            else if (cmbBox_OpcaoAtracao.SelectedIndex == 1)// adicionar
            {
                txtBox_addAtracao.Visible = true;
                txtBox_descricaoAtracao.Visible = true;
                txtBox_inseriPreçoAtracao.Visible = true;
                txtbox_InserirHorario.Visible = true;
                MessageBox.Show("Atração Cadastrado com sucesso");
            }
            else if (cmbBox_OpcaoAtracao.SelectedIndex == 2) // editar
            {
                Form f1 = FindForm();
                EditarAtracao f2 = new EditarAtracao();
                f2.Show();
                f1.Hide();
            }
            else if (cmbBox_OpcaoAtracao.SelectedIndex == 3)// excluir
            {
                Form f1 = FindForm();
                ExcluirAtracao f2 = new ExcluirAtracao();
                f2.Show();
                f1.Hide();
            }



        }
    }
}
