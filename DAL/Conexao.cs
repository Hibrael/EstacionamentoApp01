using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamentoApp01.DAL
{
    public class Conexao
    {
        MySqlConnection con = new MySqlConnection();
        public Conexao()
        {
            con.ConnectionString = @"User Id=root;Host=localhost;Database=estacionamento_db";
            //con = new MySqlConnection("Server=localhost;Database=estacionamento_db;User Id=root;Password=mysql123!;");

        }

        public MySqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con; 
            
        }
   
        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }
}
