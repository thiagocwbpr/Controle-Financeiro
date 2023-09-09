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

    
    public class FuncionarioDAO
    {
        private MySqlConnection conexao; // Cria a conexão com o banco de dados.

        public FuncionarioDAO() // Construtor para a conexao.
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        public void CadastrarFuncionario(Funcionario obj)
        {
            try
            {
                var sql = @"INSERT INTO tb_funcionarios (
                                id
                               ,nome
                               ,rg
                               ,cpf
                               ,email
                               ,senha
                               ,cargo
                               ,nivel_acesso
                               ,telefone
                               ,celular
                               ,cep
                               ,endereco
                               ,numero
                               ,complemento
                               ,bairro
                               ,cidade
                               ,estado ) values (
                                                 @id
                                                ,@nome
                                                ,@rg
                                                ,@cpf
                                                ,@email
                                                ,@senha
                                                ,@cargo
                                                ,@nivel_acesso
                                                ,@telefone
                                                ,@celular
                                                ,@cep
                                                ,@endereco
                                                ,@numero
                                                ,@complemento
                                                ,@bairro
                                                ,@cidade
                                                ,@estado)";

                MySqlCommand ExecutaCmd = new MySqlCommand(sql, conexao);

                ExecutaCmd.Parameters.AddWithValue("@id", obj.Id);
                ExecutaCmd.Parameters.AddWithValue("@nome", obj.Nome);
                ExecutaCmd.Parameters.AddWithValue("@rg", obj.Rg);
                ExecutaCmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                ExecutaCmd.Parameters.AddWithValue("@email", obj.Email);
                ExecutaCmd.Parameters.AddWithValue("@senha", obj.Senha);
                ExecutaCmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                ExecutaCmd.Parameters.AddWithValue("nivel_acesso", obj.Nivel_Acesso);
                ExecutaCmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                ExecutaCmd.Parameters.AddWithValue("@celular", obj.Celular);
                ExecutaCmd.Parameters.AddWithValue("@cep", obj.Cep);
                ExecutaCmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                ExecutaCmd.Parameters.AddWithValue("@numero", obj.Numero);
                ExecutaCmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                ExecutaCmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                ExecutaCmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                ExecutaCmd.Parameters.AddWithValue("@estado", obj.Uf);

                conexao.Open();

                ExecutaCmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário cadastrado com sucesso!");

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro " + erro);
            }
        }

        public void AlterarFuncionario(Funcionario obj)
        {
            try
            {
                var sql = @"UPDATE tb_funcionarios SET 
                                   nome=@nome
                                  ,rg=@rg
                                  ,cpf=@cpf
                                  ,email=@email
                                  ,senha=@senha
                                  ,cargo=@cargo
                                  ,nivel_acesso=@nivel_acesso
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

                MySqlCommand ExecuteCmd = new MySqlCommand(sql,conexao);

                ExecuteCmd.Parameters.AddWithValue("@id", obj.Id);
                ExecuteCmd.Parameters.AddWithValue("@nome", obj.Nome);
                ExecuteCmd.Parameters.AddWithValue("@rg", obj.Rg);
                ExecuteCmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                ExecuteCmd.Parameters.AddWithValue("@email", obj.Email);
                ExecuteCmd.Parameters.AddWithValue("@senha", obj.Senha);
                ExecuteCmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                ExecuteCmd.Parameters.AddWithValue("@nivel_acesso", obj.Nivel_Acesso);
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

                MessageBox.Show("Dados alterados com sucesso! ");

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Dados não foram alterados! " + erro);
            }
        }

        public void ExcluirFuncionario(Funcionario obj)
        {
            try
            {
                var sql = @"DELETE FROM tb_funcionarios
                            WHERE id = @id";

                MySqlCommand ExecuteCmd = new MySqlCommand(sql, conexao);

                ExecuteCmd.Parameters.AddWithValue("@id", obj.Id);

                conexao.Open();

                ExecuteCmd.ExecuteNonQuery();

                MessageBox.Show("Usuário removido com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Falha ao remover usuário! " + erro);
            }
                       
        }

        public DataTable ListarFuncionario()
        {
            try
            {
                DataTable TabelaFuncionario = new DataTable();

                var sql = @"SELECT * FROM tb_funcionarios";

                MySqlCommand ExecuteCmd = new MySqlCommand(sql, conexao);

                conexao.Open();

                ExecuteCmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(ExecuteCmd);

                da.Fill(TabelaFuncionario);

                conexao.Close();

                return TabelaFuncionario;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possivel consultar os dados " + erro);
            }

            return null;
        }

        public DataTable BuscarNomeFuncionario(string nome)
        {
            try
            {
                DataTable TabelaFuncionario = new DataTable();

                var sql = @"SELECT * 
                                FROM tb_funcionarios 
                                            WHERE nome LIKE @nome";

                MySqlCommand ExecuteCmd = new MySqlCommand(sql,conexao);

                conexao.Open();

                ExecuteCmd.Parameters.AddWithValue("@nome",nome);

                ExecuteCmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(ExecuteCmd);

                da.Fill(TabelaFuncionario);

                conexao.Close();

                return TabelaFuncionario;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possivel buscar o nome! " +  erro);

                return null;
            }
        }
    }
}
