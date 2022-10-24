using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace estacionamentoApp01
{
    public partial class Menu : Form
    {
        MySqlConnection conexao = Banco.BaseDAO.conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public Menu()
        {
            InitializeComponent();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=estacionamento_db;User Id=root;Password=mysql123!;");

                strSQL = "DELETE FROM VEICULO WHERE VEICULO_ID = @ID";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", txtID.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Registro deletado",
                       "Operação Bem sucedida",
                       MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                txtNome.Text = "";
                txtModelo.Text = "";
                txtPlaca.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=estacionamento_db;User Id=root;Password=mysql123!;");

                strSQL = "INSERT INTO VEICULO (Nome, Placa, Modelo, hora_entrada, hora_saida, tipo_id) " +
                    "values (@Nome, @Placa, @Modelo, @hora_entrada, @hora_saida, @tipo_id)";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@Nome", txtNome.Text);
                comando.Parameters.AddWithValue("@Placa", txtPlaca.Text);
                comando.Parameters.AddWithValue("@Modelo", txtModelo.Text);
                comando.Parameters.AddWithValue("@tipo_id", txtTipo.Text);
                comando.Parameters.AddWithValue("@hora_entrada", DateTime.Now); 
                comando.Parameters.AddWithValue("@Hora_Saida", null);
                
                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Veiculo Adicionado",
                       "Operação Bem sucedida",
                       MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                txtNome.Text = "";
                txtModelo.Text = "";
                txtPlaca.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("Confirmar alterações", "Tem certeza?", MessageBoxButtons.OK, MessageBoxIcon.Question);


                conexao = new MySqlConnection("Server=localhost;Database=estacionamento_db;User Id=root;Password=mysql123!;");

                strSQL = "UPDATE VEICULO SET NOME = @Nome, PLaca = @Placa, Modelo = @Modelo  WHERE VEICULO_ID = @ID";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", txtID.Text);
                comando.Parameters.AddWithValue("@Nome", txtNome.Text);
                comando.Parameters.AddWithValue("@Placa", txtPlaca.Text);
                comando.Parameters.AddWithValue("@Modelo", txtModelo.Text);
               

                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Registro alterado",
                       "Operação Bem sucedida",
                       MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                txtNome.Text = "";
                txtModelo.Text = "";
                txtPlaca.Text = "";
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=estacionamento_db;User Id=root;Password=mysql123!;");

                strSQL = "SELECT * FROM VEICULO WHERE VEICULO_ID = @ID";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", txtID.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txtNome.Text = Convert.ToString(dr["Nome"]);
                    txtPlaca.Text = Convert.ToString(dr["Placa"]);
                    txtModelo.Text = Convert.ToString(dr["Modelo"]);  
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=estacionamento_db;User Id=root;Password=mysql123!;");

                strSQL = "SELECT veiculo_id, Nome, Placa, Modelo, descrição as Tipo, hora_entrada, Hora_saida FROM veiculo INNER JOIN tipo_veiculo ON id_tipo = tipo_id";

                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvDados.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var Saida = new Saida();
            Saida.Show();
            conexao = null;
            comando = null;
        }
    }
}
