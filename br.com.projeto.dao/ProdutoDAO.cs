using Controle_de_Vendas.br.com.projeto.conexao;
using Controle_de_Vendas.br.com.projeto.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Vendas.br.com.projeto.dao
{
    public class ProdutoDAO

    {
        private MySqlConnection conexao;
        public ProdutoDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        public void CadastrarProduto(Produto obj)
        {
            try
            {
                string sql = @" INSERT INTO tb_produtos (
                                descricao,
                                preco,
                                qtd_estoque,
                                for_id) VALUES(
                                                @descricao,
                                                @preco,
                                                @qtde_estoque,
                                                @for_id) ";

                MySqlCommand ExecuteCmd = new MySqlCommand(sql, conexao);

                ExecuteCmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                ExecuteCmd.Parameters.AddWithValue("@preco", obj.Preco);
                ExecuteCmd.Parameters.AddWithValue("@qtde_estoque", obj.Quantidade);
                ExecuteCmd.Parameters.AddWithValue("@for_id", obj.for_id);

                conexao.Open();

                ExecuteCmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso!");

                conexao.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Produto não foi cadastrado! " + ex);
            }
        }
    }
}
