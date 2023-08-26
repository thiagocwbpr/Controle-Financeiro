using Controle_de_Vendas.br.com.projeto.conexao;
using Controle_de_Vendas.br.com.projeto.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Vendas.br.com.projeto.dao
{

    
    public class FuncionarioDAO
    {
        private MySqlConnection conexao;

        public FuncionarioDAO() // Construtor
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

                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro " + erro);
            }
        }
    }
}
