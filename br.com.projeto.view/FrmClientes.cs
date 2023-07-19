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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // Receber os dados dentro de um objeto modelo cliente

            Cliente obj = new Cliente();

            obj.Nome = TxtNome.Text;
            obj.Rg = TxtRg.Text;
            obj.Cpf = TxtCpf.Text;
            obj.Email = TxtEmail.Text;
            obj.Telefone = TxtTelefone.Text;
            obj.Celular = TxtCelular.Text;
            obj.Cep = TxtCep.Text;
            obj.Endereco = TxtEndereco.Text;
            obj.Numero = int.Parse(TxtNumero.Text);
            obj.Complemento = TxtComp.Text;
            obj.Bairro = TxtBairro.Text;
            obj.Cidade = TxtCidade.Text;
            obj.Uf = CbUf.Text;

            // Criando objeto da classe ClienteDAO e chamar o metodo cadastrar

            ClienteDAO dao = new ClienteDAO();
            dao.CadastrarCliente(obj);

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {

        }

        private void TabelaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();

            TabelaCliente.DataSource = dao.ListarClientes();
        }
    }
}
