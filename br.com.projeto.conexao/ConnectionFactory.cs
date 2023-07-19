using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Vendas.br.com.projeto.conexao
{
    public class ConnectionFactory
    {
        // Método que conecta com o banco de dados MySql.

        public static MySqlConnection GetConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["BDVendas"].ConnectionString;

            return new MySqlConnection(conexao);
        }
    }
}
