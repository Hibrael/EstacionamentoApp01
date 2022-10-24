using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamentoApp01
{
    internal class Banco
    {
        private static MySqlConnection conexao;

        public static MySqlConnection ConexaoBanco()
        {
            conexao = new MySqlConnection("Server=localhost;Database=estacionamento_db;User Id=root;Password=mysql123!;");
            conexao.Open();
            return conexao;
        }

        public class BaseDAO
        {
            public static MySqlConnection conexao = new MySqlConnection
                ("Server=localhost;Database=estacionamento_db;User Id=root;Password=mysql123!;");


        }

    }
}
