﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace estacionamentoApp01
{
    public partial class Saida : Form
    {
        MySqlConnection conexao = Banco.BaseDAO.conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public Saida()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string placa = "";
            string modelo;
            string Nome;
            DateTime Hora_entrada;
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=estacionamento_db;User Id=root;Password=mysql123!;");

                strSQL = "SELECT *, round(TIMESTAMPDIFF(minute,hora_entrada, now())) as Tempo FROM VEICULO WHERE VEICULO_ID = @ID";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", txtID.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                

                while (dr.Read())
                {
                    textBox1.Text = Convert.ToString(dr["Nome"]);
                    textBox3.Text = Convert.ToString(dr["Placa"]);
                    textBox4.Text = Convert.ToString(dr["Modelo"]);
                    textBox5.Text = Convert.ToString(dr["Hora_entrada"]);
                    textBox6.Text = Convert.ToString(dr["tempo"] + "MIN");
                    Hora_entrada = Convert.ToDateTime(dr["Hora_entrada"]);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=estacionamento_db;User Id=root;Password=mysql123!;");
                //Banco.ConexaoBanco();
                strSQL = "UPDATE VEICULO SET Hora_Saida = @Hora_Saida WHERE VEICULO_ID = @ID";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", txtID.Text);
                comando.Parameters.AddWithValue("@Hora_Saida", DateTime.Now);

                conexao.Open();

                comando.ExecuteNonQuery();

                //var tempo = strSQL = "SELECT round(TIMESTAMPDIFF(minute,hora_entrada, now())) as Tempo FROM VEICULO WHERE VEICULO_ID = @ID";
                //var tipo = strSQL = "select tipo_id from veiculo where Veiculo_id = 2";

                //Convert.ToInt32(tempo);
               // Convert.ToInt32(tipo);

                //Metodos.CalcularValor(tempo, tipo);
                

                



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
                MessageBox.Show("Saída declarada",
                       "Operação Bem sucedida",
                       MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

