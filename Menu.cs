using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace estacionamentoApp01
{
    public partial class Menu : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Adicionar_Veiculo = new Adicionar_Veiculo();
            Adicionar_Veiculo.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost3306;Database=estacionamento;Uid=root;Pwd=mysql1231");

                strSQL = "iNSERT INTO veiculo (Proprietario, Placa, Modelo, Marca) VALUES (@Proprietario @Placa @Modelo @Marca";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@Proprietario", txtProrpietario.Text);
                comando.Parameters.AddWithValue("@Placa", txtPlaca.Text);
                comando.Parameters.AddWithValue("@Modelo", txtModelo.Text);
                
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }

        }
    }
}
