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

        private void BtnSalvar_Click(object sender, EventArgs e) // Responsável por 'Cadastrar' os clientes no banco.
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

            TabelaCliente.DataSource = dao.ListarClientes(); // Após cadastrar o cliente, é realizado um novo select no banco.


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

            // Alterar para a guia de Dados Pessoais

            TabClientes.SelectedTab = tabPage1; // <-- Quando selecionar a pessoa na consulta, vai para a pagina de cadastro.

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            // Método responsável por exclusão dos dados do cliente cadastrado.

            Cliente obj = new Cliente();
            obj.Id = int.Parse(TxtCodigo.Text);

            ClienteDAO dao = new ClienteDAO();

            dao.ExcluirCliente(obj);

            TabelaCliente.DataSource = dao.ListarClientes();

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            obj.Id = int.Parse(TxtCodigo.Text); // Os dados do cliente serão alterados pelo ID. Conforme Método Alterar.
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
            dao.AlterarCliente(obj);

            TabelaCliente.DataSource = dao.ListarClientes();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e) // Botão pesquisar.
        {
            string nome = TxtPesquisa.Text;

            ClienteDAO dao = new ClienteDAO();

            TabelaCliente.DataSource = dao.BuscarNomeCliente(nome);


            if (TabelaCliente.Rows.Count == 0)
            {
                TabelaCliente.DataSource = dao.ListarClientes();
            }



        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            var nome = "%" + TxtPesquisa.Text + "%";

            ClienteDAO dao = new ClienteDAO();

            TabelaCliente.DataSource = dao.BuscarClientePorNome(nome);
        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            // botão consultar CEP.

            try
            {
               // Implementação da API ViaCEP para consulta de CEP.
                string cep = TxtCep.Text;
                string xml = $"https://viacep.com.br/ws/{cep}/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                // Estrutura de conexão entre a interface gráfica e a API.

                TxtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                TxtComp.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                TxtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                TxtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                CbUf.Text = dados.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Endereço não encontrado. Por favor digite manualmente.");
            }
        }
    }
}
