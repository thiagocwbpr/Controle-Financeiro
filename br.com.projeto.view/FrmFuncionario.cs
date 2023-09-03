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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {

            FuncionarioDAO dao = new FuncionarioDAO();

            TabFuncionario.DataSource = dao.ListarFuncionario();

            if (TabFuncionario.Rows.Count == 0 || TxtPesquisa.Text == string.Empty)
            {
                MessageBox.Show("Funcionário não encontrado!");

                TabFuncionario.DataSource = dao.ListarFuncionario();
            }
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {

            var nome = "%" + TxtPesquisa.Text + "%";

            FuncionarioDAO dao = new FuncionarioDAO();
            TabFuncionario.DataSource = dao.BuscarNomeFuncionario(nome);


        }



        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtRg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TxtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TxtCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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

        private void TxtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtComp_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbUf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbNivelAcesso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();

            obj.Nome = TxtNome.Text;
            obj.Rg = TxtRg.Text;
            obj.Cpf = TxtCpf.Text;
            obj.Email = TxtEmail.Text;
            obj.Telefone = TxtTelefone.Text;
            obj.Celular = TxtCelular.Text;
            obj.Cargo = CbCargo.SelectedItem.ToString();
            obj.Senha = TxtSenha.Text;
            obj.Cep = TxtCep.Text;
            obj.Endereco = TxtEndereco.Text;
            obj.Numero = int.Parse(TxtNumero.Text);
            obj.Complemento = TxtComp.Text;
            obj.Bairro = TxtBairro.Text;
            obj.Cidade = TxtCidade.Text;
            obj.Uf = CbUf.SelectedItem.ToString();
            obj.Nivel_Acesso = CbNivelAcesso.SelectedItem.ToString();

            FuncionarioDAO dao = new FuncionarioDAO();

            dao.CadastrarFuncionario(obj);

            TabFuncionario.DataSource = dao.ListarFuncionario();

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();

            obj.Id = int.Parse(TxtCodigo.Text);
            obj.Nome = TxtNome.Text;
            obj.Rg = TxtRg.Text;
            obj.Cpf = TxtCpf.Text;
            obj.Email = TxtEmail.Text;
            obj.Telefone = TxtTelefone.Text;
            obj.Celular = TxtCelular.Text;
            obj.Cargo = CbCargo.SelectedItem.ToString();
            obj.Senha = TxtSenha.Text;
            obj.Cep = TxtCep.Text;
            obj.Endereco = TxtEndereco.Text;
            obj.Numero = int.Parse(TxtNumero.Text);
            obj.Complemento = TxtComp.Text;
            obj.Bairro = TxtBairro.Text;
            obj.Cidade = TxtCidade.Text;
            obj.Uf = CbUf.SelectedItem.ToString();
            obj.Nivel_Acesso = CbNivelAcesso.SelectedItem.ToString();

            FuncionarioDAO dao = new FuncionarioDAO();

            dao.AlterarFuncionario(obj);

            TabFuncionario.DataSource = dao.ListarFuncionario(); // atualiza o datagridview (atualiza a tabela)
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();

            obj.Id = int.Parse(TxtCodigo.Text);

            FuncionarioDAO dao = new FuncionarioDAO();

            dao.ExcluirFuncionario(obj);

            TabFuncionario.DataSource = dao.ListarFuncionario(); // atualiza o datagridview (atualiza a tabela)
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();

            TabFuncionario.DataSource = dao.ListarFuncionario();
        }

        private void TabFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCodigo.Text = TabFuncionario.CurrentRow.Cells[0].Value.ToString();
            TxtNome.Text = TabFuncionario.CurrentRow.Cells[1].Value.ToString();
            TxtRg.Text = TabFuncionario.CurrentRow.Cells[2].Value.ToString();
            TxtCpf.Text = TabFuncionario.CurrentRow.Cells[3].Value.ToString();
            TxtEmail.Text = TabFuncionario.CurrentRow.Cells[4].Value.ToString();
            TxtSenha.Text = TabFuncionario.CurrentRow.Cells[5].Value.ToString();
            CbCargo.Text = TabFuncionario.CurrentRow.Cells[6].Value.ToString();
            CbNivelAcesso.Text = TabFuncionario.CurrentRow.Cells[7].Value.ToString();
            TxtTelefone.Text = TabFuncionario.CurrentRow.Cells[8].Value.ToString();
            TxtCelular.Text = TabFuncionario.CurrentRow.Cells[9].Value.ToString();
            TxtCep.Text = TabFuncionario.CurrentRow.Cells[10].Value.ToString();
            TxtEndereco.Text = TabFuncionario.CurrentRow.Cells[11].Value.ToString();
            TxtNumero.Text = TabFuncionario.CurrentRow.Cells[12].Value.ToString();
            TxtComp.Text = TabFuncionario.CurrentRow.Cells[13].Value.ToString();
            TxtBairro.Text = TabFuncionario.CurrentRow.Cells[14].Value.ToString();
            TxtCidade.Text = TabFuncionario.CurrentRow.Cells[15].Value.ToString();
            CbUf.Text = TabFuncionario.CurrentRow.Cells[16].Value.ToString();

            TabelaFuncionarios.SelectedTab = tabPage2;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().Limpar(this);
        }
    }
}
