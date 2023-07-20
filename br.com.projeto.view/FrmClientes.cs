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

        private void FrmClientes_Click(object sender, EventArgs e)
        {

        }

        private void TabelaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar os dados da linha selecionada

            TxtCodigo.Text = TabelaCliente.CurrentRow.Cells[0].Value.ToString();
            TxtNome.Text = TabelaCliente.CurrentRow.Cells[1].Value.ToString();
            TxtRg.Text = TabelaCliente.CurrentRow.Cells[2].Value.ToString();
            TxtCpf.Text = TabelaCliente.CurrentRow.Cells[3].Value.ToString();
            TxtEmail.Text = TabelaCliente.CurrentRow.Cells[4].Value.ToString();
            TxtTelefone.Text = TabelaCliente.CurrentRow.Cells[5].Value.ToString();
            TxtCelular.Text = TabelaCliente.CurrentRow.Cells[6].Value.ToString();
            TxtCep.Text = TabelaCliente.CurrentRow.Cells[7].Value.ToString();
            TxtEndereco.Text = TabelaCliente.CurrentRow.Cells[8].Value.ToString();
            TxtNumero.Text = TabelaCliente.CurrentRow.Cells[9].Value.ToString();
            TxtComp.Text = TabelaCliente.CurrentRow.Cells[10].Value.ToString();
            TxtBairro.Text = TabelaCliente.CurrentRow.Cells[11].Value.ToString();
            TxtCidade.Text = TabelaCliente.CurrentRow.Cells[12].Value.ToString();
            CbUf.Text = TabelaCliente.CurrentRow.Cells[13].Value.ToString();
        }
    }
}
