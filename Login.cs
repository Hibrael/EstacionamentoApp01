using estacionamentoApp01.Modelo;

namespace estacionamentoApp01
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            /*
            Controle controle = new Controle();
            controle.Acessar(textBox1.Text, textBox2.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com Sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var Menu = new Menu();
                    Menu.Show();

                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("Verifique suas credenciais", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show(controle.mensagem);
            }
            */

            try
            {
                if (textBox1.Text.Equals("Hibrael") && textBox2.Text.Equals("1231"))
                {
                    var Menu = new Menu();
                    Menu.Show();

                    this.Visible = false;
                }

                else
                {
                    MessageBox.Show("Usuário ou senha incorretos",
                        "Desculpe",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    textBox1.Focus();
                    textBox2.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe",
                    ex.Message,
                    MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Info = new Info();
            Info.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}