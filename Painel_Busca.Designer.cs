namespace estacionamentoApp01
{
    partial class Painel_Busca
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Proprietario = new System.Windows.Forms.TextBox();
            this.Placa = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.id_veiculo = new System.Windows.Forms.TextBox();
            this.horaEntrada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proprietário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id veículo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora entrada:";
            // 
            // Proprietario
            // 
            this.Proprietario.Location = new System.Drawing.Point(95, 19);
            this.Proprietario.Name = "Proprietario";
            this.Proprietario.Size = new System.Drawing.Size(155, 23);
            this.Proprietario.TabIndex = 5;
            // 
            // Placa
            // 
            this.Placa.Location = new System.Drawing.Point(95, 58);
            this.Placa.Name = "Placa";
            this.Placa.Size = new System.Drawing.Size(155, 23);
            this.Placa.TabIndex = 6;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(94, 100);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(156, 23);
            this.txtModelo.TabIndex = 7;
            // 
            // id_veiculo
            // 
            this.id_veiculo.Location = new System.Drawing.Point(95, 137);
            this.id_veiculo.Name = "id_veiculo";
            this.id_veiculo.Size = new System.Drawing.Size(156, 23);
            this.id_veiculo.TabIndex = 8;
            // 
            // horaEntrada
            // 
            this.horaEntrada.Location = new System.Drawing.Point(95, 175);
            this.horaEntrada.Name = "horaEntrada";
            this.horaEntrada.Size = new System.Drawing.Size(156, 23);
            this.horaEntrada.TabIndex = 9;
            // 
            // Painel_Busca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.horaEntrada);
            this.Controls.Add(this.id_veiculo);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.Placa);
            this.Controls.Add(this.Proprietario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Painel_Busca";
            this.Size = new System.Drawing.Size(468, 247);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox Proprietario;
        private TextBox Placa;
        private TextBox txtModelo;
        private TextBox id_veiculo;
        private TextBox horaEntrada;
    }
}
