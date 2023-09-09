using Controle_de_Vendas.br.com.projeto.conexao;
using Controle_de_Vendas.br.com.projeto.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Vendas.br.com.projeto.dao
{
    public class FornecedorDAO
    {
        MySqlConnection conexao;

        public FornecedorDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        public void CadastrarFornecedor(Fornecedores obj)
        {
            try
            {
                var sql = @"INSERT INTO tb_fornecedores
                        (id
                        ,nome
                        ,cnpj
                        ,email
                        ,telefone
                        ,celular
                        ,cep
                        ,endereco
                        ,numero
                        ,complemento
                        ,bairro
                        ,cidade
                        ,estado) values (
                                          @id
                                         ,@nome
                                         ,@cnpj
                                         ,@email
                                         ,@telefone
                                         ,@celular
                                         ,@cep
                                         ,@endereco
                                         ,@numero
                                         ,@complemento
                                         ,@bairro
                                         ,@cidade
                                         ,@estado)";

                MySqlCommand ExecuteCmd = new MySqlCommand(sql, conexao);

                ExecuteCmd.Parameters.AddWithValue("@id", obj.Id);
                ExecuteCmd.Parameters.AddWithValue("@nome", obj.Nome);
                ExecuteCmd.Parameters.AddWithValue("@cnpj", obj.CNPJ);
                ExecuteCmd.Parameters.AddWithValue("@email", obj.Email);
                ExecuteCmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                ExecuteCmd.Parameters.AddWithValue("@celular", obj.Celular);
                ExecuteCmd.Parameters.AddWithValue("@cep", obj.Cep);
                ExecuteCmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                ExecuteCmd.Parameters.AddWithValue("numero", obj.Numero);
                ExecuteCmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                ExecuteCmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                ExecuteCmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                ExecuteCmd.Parameters.AddWithValue("@estado", obj.Uf);

                conexao.Open();

                ExecuteCmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor cadastrado com sucesso!");

                conexao.Close();

                
            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possível cadastrar Fornecedor " + erro);
            }



        }

        public DataTable ListarFornecedor()
        {
            try
            {
                DataTable TabelaFuncionario = new DataTable();

                var sql = @"SELECT * FROM tb_fornecedores";

                MySqlCommand ExecuteCmd = new MySqlCommand(sql, conexao);

                conexao.Open();

                ExecuteCmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(ExecuteCmd);


                da.Fill(TabelaFuncionario);

                conexao.Close();

                return TabelaFuncionario;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void AlterarFornecedor(Fornecedores obj)
        {
            try
            {
                var sql = @"UPDATE tb_fornecedores SET
                            id=@id
                           ,nome=@nome
                           ,cnpj=@cnpj
                           ,email=@email
                           ,telefone=@telefone
                           ,celular=@celular
                           ,cep=@cep
                           ,endereco=@endereco
                           ,numero=@numero
                           ,complemento=@complemento
                           ,bairro=@bairro
                           ,cidade=@cidade
                           ,estado=@estado
                                WHERE id=@id";

                MySqlCommand ExecuteCmd = new MySqlCommand(sql, conexao);

                ExecuteCmd.Parameters.AddWithValue("@id", obj.Id);
                ExecuteCmd.Parameters.AddWithValue("@nome", obj.Nome);
                ExecuteCmd.Parameters.AddWithValue("@cnpj", obj.CNPJ);
                ExecuteCmd.Parameters.AddWithValue("@email", obj.Email);
                ExecuteCmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                ExecuteCmd.Parameters.AddWithValue("@celular", obj.Celular);
                ExecuteCmd.Parameters.AddWithValue("@cep", obj.Cep);
                ExecuteCmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                ExecuteCmd.Parameters.AddWithValue("@numero", obj.Numero);
                ExecuteCmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                ExecuteCmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                ExecuteCmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                ExecuteCmd.Parameters.AddWithValue("@estado", obj.Uf);

                conexao.Open();

                ExecuteCmd.ExecuteNonQuery();

                MessageBox.Show("Dados do fornecedor alterados com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Dados do fornecedor não foram alterados! " + erro);
            }
        }

        public DataTable BuscarNomeFornecedor(string nome)
        {
            try
            {
                DataTable TabelaFornecedor = new DataTable();

                string sql = @"SELECT * 
                                    FROM tb_fornecedores 
                                                    WHERE nome LIKE @nome";
                MySqlCommand ExecuteCmd = new MySqlCommand(sql, conexao);

                conexao.Open();

                ExecuteCmd.Parameters.AddWithValue("@nome", nome);

                ExecuteCmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(ExecuteCmd);

                da.Fill(TabelaFornecedor);

                conexao.Close();

                return TabelaFornecedor;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel buscar o nome " + erro);

                return null;
            }

            
        }

        public void ExcluirFornecedor(Fornecedores obj)
        {
            try
            {
                var sql = @"DELETE FROM tb_fornecedores WHERE id = @id";

                MySqlCommand ExecuteCmd = new MySqlCommand(sql,conexao);

                ExecuteCmd.Parameters.AddWithValue("@id", obj.Id);

                conexao.Open();

                ExecuteCmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor excluído com sucesso!");

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possivel excluir o fornecedor." + erro);
            }
        }
    }
}
