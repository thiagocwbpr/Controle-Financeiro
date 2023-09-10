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
    
    public class ClienteDAO
    {   
        // Criação de conexão

        private MySqlConnection conexao;
        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }
        
        // Metodo CadastrarCliente
        public void CadastrarCliente(Cliente obj)
        {
            try
            {
                string sql = @"INSERT INTO tb_clientes(
                               nome,
                               rg,
                               cpf,
                               email,
                               telefone,
                               celular,
                               cep,
                               endereco,
                               numero,
                               complemento,
                               bairro,
                               cidade,
                               estado)
                                        VALUES(
                                                @nome,
                                                @rg,
                                                @cpf,
                                                @email,
                                                @telefone,
                                                @celular,
                                                @cep,
                                                @endereco,
                                                @numero,
                                                @complemento,
                                                @bairro,
                                                @cidade,
                                                @estado)";

                // Organizando o comando SQL com a classe clientes.

                MySqlCommand ExecutaCmd = new MySqlCommand(sql,conexao);

                ExecutaCmd.Parameters.AddWithValue("@nome", obj.Nome);
                ExecutaCmd.Parameters.AddWithValue("@rg", obj.Rg);
                ExecutaCmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                ExecutaCmd.Parameters.AddWithValue("@email", obj.Email);
                ExecutaCmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                ExecutaCmd.Parameters.AddWithValue("@celular", obj.Celular);
                ExecutaCmd.Parameters.AddWithValue("@cep", obj.Cep);
                ExecutaCmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                ExecutaCmd.Parameters.AddWithValue("@numero", obj.Numero);
                ExecutaCmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                ExecutaCmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                ExecutaCmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                ExecutaCmd.Parameters.AddWithValue("@estado", obj.Uf);

                // Abrir a conexão e executar o comando SQL

                conexao.Open();
                ExecutaCmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Cliente não cadastrado! Verfique o erro : " + erro);
            }
        }

        // Metodo ListarClientes
        public DataTable ListarClientes()
        {
            try
            {
                // Criando o DataTable e o comando SQL
                DataTable TabelaCliente = new DataTable(); // DataTable representa uma tabela SQL.

                string sql = @"SELECT * FROM tb_clientes"; // string contendo o comando SQL.
                
                // Organizando o comando sql e execução.

                MySqlCommand ExecuteCmd = new MySqlCommand(sql,conexao); // executa o comando SQL retornando as info do BD.

                conexao.Open(); // Abrindo conexão com o banco de dados.
                ExecuteCmd.ExecuteNonQuery(); // retorna um conjunto de resultado, como o SELECT em SQL.

                // Criando o MySqlDataAdapter para preencher os dados no DataTable.

                MySqlDataAdapter da = new MySqlDataAdapter(ExecuteCmd); // Usado para preencher um DataSet(Conjunto de Dados). Cria uma ponte entre BD e DataSet.

                da.Fill(TabelaCliente); // Preenche o DataSet(Conjunto de dados, colunas, linhas, relacionamentos) 

                conexao.Close();

                return TabelaCliente;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar a consulta." + erro);
            }
            return null;
        }

        //Buscar cliente por nome
        public DataTable BuscarNomeCliente(string nome)
        {
            try
            {
                DataTable TabelaCliente = new DataTable(); // Cria tabela em memoria.

                string sql = @"SELECT *   
	                            FROM tb_clientes
                                        WHERE nome = @nome"; // Query SQL.

                MySqlCommand ExecuteCmd = new MySqlCommand(sql,conexao); // Envia requisição de conexão e query.

                conexao.Open();
                ExecuteCmd.Parameters.AddWithValue("@nome", nome); // Adiciona os parametros 

                ExecuteCmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(ExecuteCmd);

                da.Fill(TabelaCliente);

                conexao.Close();

                return TabelaCliente;

              
            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possivel realizar a consulta! " + erro);
            }
            return null;
        }

        public DataTable BuscarClientePorNome(string nome)
        {
            try
            {
                DataTable TabelaCliente = new DataTable(); // Cria tabela em memoria.

                string sql = @"SELECT *   
	                            FROM tb_clientes
                                        WHERE nome LIKE @nome"; // Query SQL usando LIKE para busca.

                MySqlCommand ExecuteCmd = new MySqlCommand(sql, conexao); // Envia requisição de conexão e query.

                conexao.Open();
                ExecuteCmd.Parameters.AddWithValue("@nome", nome); // Adiciona os parametros 

                ExecuteCmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(ExecuteCmd);

                da.Fill(TabelaCliente);

                conexao.Close();

                return TabelaCliente;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possivel realizar a consulta! " + erro);
            }
            return null;
        }
        // Metodo AlterarCliente
        public void AlterarCliente(Cliente obj)
        {
            try
            {
                string sql = @"UPDATE tb_clientes SET
                               id=@id,
                               nome=@nome,
                               rg=@rg,
                               cpf=@cpf,
                               email=@email,
                               telefone=@telefone,
                               celular=@celular,
                               cep=@cep,
                               endereco=@endereco,
                               numero=@numero,
                               complemento=@complemento,
                               bairro=@bairro,
                               cidade=@cidade,
                               estado=@estado
                                    WHERE id=@id"; // O editar esta utilizando o WHERE ID. No Cliente é TextCodigo.

                // Organizando o comando SQL com a classe clientes.

                MySqlCommand ExecutaCmd = new MySqlCommand(sql, conexao);

                ExecutaCmd.Parameters.AddWithValue("@id", obj.Id);
                ExecutaCmd.Parameters.AddWithValue("@nome", obj.Nome);
                ExecutaCmd.Parameters.AddWithValue("@rg", obj.Rg);
                ExecutaCmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                ExecutaCmd.Parameters.AddWithValue("@email", obj.Email);
                ExecutaCmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                ExecutaCmd.Parameters.AddWithValue("@celular", obj.Celular);
                ExecutaCmd.Parameters.AddWithValue("@cep", obj.Cep);
                ExecutaCmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                ExecutaCmd.Parameters.AddWithValue("@numero", obj.Numero);
                ExecutaCmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                ExecutaCmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                ExecutaCmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                ExecutaCmd.Parameters.AddWithValue("@estado", obj.Uf);

                // Abrir a conexão e executar o comando SQL

                conexao.Open();
                ExecutaCmd.ExecuteNonQuery();

                MessageBox.Show("Dados alterados com sucesso!");

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Alteração não realizada! Verfique o erro : " + erro);
            }
        }
        // Metodo ExcluirCliente

        public void ExcluirCliente(Cliente obj)
        {
            try
            {
                string sql = @"DELETE FROM tb_clientes 
                                         WHERE id=@id";

                // Organizando o comando SQL com a classe clientes.

                MySqlCommand ExecutaCmd = new MySqlCommand(sql, conexao);

                ExecutaCmd.Parameters.AddWithValue("@id", obj.Id);

                // Abrir a conexão e executar o comando SQL

                conexao.Open();
                ExecutaCmd.ExecuteNonQuery();

                MessageBox.Show("Dados excluídos com sucesso!");

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Os dados não foram excluídos! Verfique o erro : " + erro);
            }
        }

        // Metodo BuscarClientePorCpf
    }
}
