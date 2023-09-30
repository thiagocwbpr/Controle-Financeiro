using Controle_de_Vendas.br.com.projeto.dao;
using Controle_de_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.projeto.view
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void TxtEndereco_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            FornecedorDAO f_dao = new FornecedorDAO();

            CbFornecedor.DataSource = f_dao.ListarFornecedor();
            CbFornecedor.DisplayMember = "nome";
            CbFornecedor.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valor do Fornecedor " + CbFornecedor.SelectedValue);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.Descricao = TxtDescricao.Text;
            obj.Preco = double.Parse(TxtPreco.Text);
            obj.Quantidade = int.Parse(TxtQuantidade.Text);
            obj.for_id = int.Parse(CbFornecedor.SelectedValue.ToString());

            ProdutoDAO dao = new ProdutoDAO();

            dao.CadastrarProduto(obj);

            new Helpers();
        }
    }
}
