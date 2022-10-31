using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamentoApp01.DAL
{
    internal class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        MySqlCommand cmd = new MySqlCommand();
        Conexao con = new Conexao();
        MySqlDataReader? dr;
        public bool VerificarLogin(String login, String senha)
        {
            cmd.CommandText = "Select * from usuario where usuario = @usuario and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();    
                if(dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";
            }
            return tem;
        }
    }
}
