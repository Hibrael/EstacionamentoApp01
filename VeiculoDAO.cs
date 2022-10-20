using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamentoApp01
{
    public class BaseDAO
    {
        public static MySqlConnection conexao = new MySqlConnection
            ("Server=localhost;Database=estacionamento_db;User Id=root;Password=123456!;");


    }
    public  class VeiculoDAO : BaseDAO
    {
        public void Add()
        {

        }

        public object Get()
        {
            return null;
        }


    }
}
