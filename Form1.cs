namespace estacionamentoApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Equals("Hibrael") && textBox2.Text.Equals("1231"))
                {
                    // ir para menu
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
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            var Info = new Info();
            Info.Show();

        
        }
    }
}