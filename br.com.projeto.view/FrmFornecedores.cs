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
    public partial class FrmFornecedores : Form
    {
        public FrmFornecedores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            try
            {
                var cep = TxtCep.Text;
                var xml = $"https://viacep.com.br/ws/{cep}/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                TxtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                TxtComp.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                TxtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                TxtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                CbUf.Text = dados.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possível consultar CEP" + erro);
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().Limpar(this);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Fornecedores obj = new Fornecedores();

            obj.Nome = TxtNome.Text;
            obj.CNPJ = TxtCnpj.Text;
            obj.Email = TxtEmail.Text;
            obj.Telefone = TxtTelefone.Text;
            obj.Celular = TxtCelular.Text;
            obj.Cep = TxtCep.Text;
            obj.Endereco = TxtEndereco.Text;
            obj.Numero = int.Parse(TxtNumero.Text);
            obj.Complemento = TxtComp.Text;
            obj.Bairro = TxtBairro.Text;
            obj.Cidade = TxtCidade.Text;
            obj.Uf = CbUf.SelectedItem.ToString();

            FornecedorDAO dao = new FornecedorDAO();

            dao.CadastrarFornecedor(obj);

        }

        private void TxtCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Fornecedores obj = new Fornecedores();

            obj.Nome = TxtNome.Text;
            obj.CNPJ = TxtCnpj.Text;
            obj.Email = TxtEmail.Text;
            obj.Telefone = TxtTelefone.Text;
            obj.Celular = TxtCelular.Text;
            obj.Cep = TxtCep.Text;
            obj.Endereco = TxtEndereco.Text;
            obj.Numero = int.Parse(TxtNumero.Text);
            obj.Complemento = TxtComp.Text;
            obj.Bairro = TxtBairro.Text;
            obj.Cidade = TxtCidade.Text;
            obj.Uf = CbUf.SelectedItem.ToString();

            FornecedorDAO dao = new FornecedorDAO();

            dao.AlterarFornecedor(obj);
        }

        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();
            TabFornecedores.DataSource = dao.ListarFornecedor();
        }
    }
}
