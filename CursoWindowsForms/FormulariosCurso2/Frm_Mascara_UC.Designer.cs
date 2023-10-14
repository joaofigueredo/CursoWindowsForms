namespace CursoWindowsForms
{
    partial class Frm_Mascara_UC
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
            Btn_MostrarConteudo = new Button();
            Btn_Telefone = new Button();
            Btn_Senha = new Button();
            Btn_Data = new Button();
            Btn_Moeda = new Button();
            Btn_Cep = new Button();
            Btn_Hora = new Button();
            Lbl_MascaraAtiva = new Label();
            Lbl_Conteudo = new Label();
            Msk_TextBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // Btn_MostrarConteudo
            // 
            Btn_MostrarConteudo.Location = new Point(43, 231);
            Btn_MostrarConteudo.Name = "Btn_MostrarConteudo";
            Btn_MostrarConteudo.Size = new Size(258, 37);
            Btn_MostrarConteudo.TabIndex = 20;
            Btn_MostrarConteudo.Text = "Mostrar Conteudo";
            Btn_MostrarConteudo.UseVisualStyleBackColor = true;
            Btn_MostrarConteudo.Click += Btn_MostrarConteudo_Click;
            // 
            // Btn_Telefone
            // 
            Btn_Telefone.Location = new Point(219, 188);
            Btn_Telefone.Name = "Btn_Telefone";
            Btn_Telefone.Size = new Size(82, 37);
            Btn_Telefone.TabIndex = 19;
            Btn_Telefone.Text = "Telefone";
            Btn_Telefone.UseVisualStyleBackColor = true;
            Btn_Telefone.Click += Btn_Telefone_Click;
            // 
            // Btn_Senha
            // 
            Btn_Senha.Location = new Point(131, 188);
            Btn_Senha.Name = "Btn_Senha";
            Btn_Senha.Size = new Size(82, 37);
            Btn_Senha.TabIndex = 18;
            Btn_Senha.Text = "Senha";
            Btn_Senha.UseVisualStyleBackColor = true;
            Btn_Senha.Click += Btn_Senha_Click;
            // 
            // Btn_Data
            // 
            Btn_Data.Location = new Point(43, 188);
            Btn_Data.Name = "Btn_Data";
            Btn_Data.Size = new Size(82, 37);
            Btn_Data.TabIndex = 17;
            Btn_Data.Text = "Data";
            Btn_Data.UseVisualStyleBackColor = true;
            Btn_Data.Click += Btn_Data_Click;
            // 
            // Btn_Moeda
            // 
            Btn_Moeda.Location = new Point(219, 134);
            Btn_Moeda.Name = "Btn_Moeda";
            Btn_Moeda.Size = new Size(82, 37);
            Btn_Moeda.TabIndex = 16;
            Btn_Moeda.Text = "Moeda";
            Btn_Moeda.UseVisualStyleBackColor = true;
            Btn_Moeda.Click += Btn_Moeda_Click;
            // 
            // Btn_Cep
            // 
            Btn_Cep.Location = new Point(131, 134);
            Btn_Cep.Name = "Btn_Cep";
            Btn_Cep.Size = new Size(82, 37);
            Btn_Cep.TabIndex = 15;
            Btn_Cep.Text = "Cep";
            Btn_Cep.UseVisualStyleBackColor = true;
            Btn_Cep.Click += Btn_Cep_Click;
            // 
            // Btn_Hora
            // 
            Btn_Hora.Location = new Point(43, 134);
            Btn_Hora.Name = "Btn_Hora";
            Btn_Hora.Size = new Size(82, 37);
            Btn_Hora.TabIndex = 14;
            Btn_Hora.Text = "Hora";
            Btn_Hora.UseVisualStyleBackColor = true;
            Btn_Hora.Click += Btn_Hora_Click;
            // 
            // Lbl_MascaraAtiva
            // 
            Lbl_MascaraAtiva.AutoSize = true;
            Lbl_MascaraAtiva.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_MascaraAtiva.Location = new Point(43, 99);
            Lbl_MascaraAtiva.Name = "Lbl_MascaraAtiva";
            Lbl_MascaraAtiva.Size = new Size(0, 24);
            Lbl_MascaraAtiva.TabIndex = 13;
            // 
            // Lbl_Conteudo
            // 
            Lbl_Conteudo.AutoSize = true;
            Lbl_Conteudo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Conteudo.Location = new Point(43, 270);
            Lbl_Conteudo.Name = "Lbl_Conteudo";
            Lbl_Conteudo.Size = new Size(0, 24);
            Lbl_Conteudo.TabIndex = 12;
            // 
            // Msk_TextBox
            // 
            Msk_TextBox.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Msk_TextBox.Location = new Point(43, 55);
            Msk_TextBox.Name = "Msk_TextBox";
            Msk_TextBox.Size = new Size(258, 30);
            Msk_TextBox.TabIndex = 11;
            // 
            // Frm_Mascara_UC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Btn_MostrarConteudo);
            Controls.Add(Btn_Telefone);
            Controls.Add(Btn_Senha);
            Controls.Add(Btn_Data);
            Controls.Add(Btn_Moeda);
            Controls.Add(Btn_Cep);
            Controls.Add(Btn_Hora);
            Controls.Add(Lbl_MascaraAtiva);
            Controls.Add(Lbl_Conteudo);
            Controls.Add(Msk_TextBox);
            Name = "Frm_Mascara_UC";
            Size = new Size(338, 324);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_MostrarConteudo;
        private Button Btn_Telefone;
        private Button Btn_Senha;
        private Button Btn_Data;
        private Button Btn_Moeda;
        private Button Btn_Cep;
        private Button Btn_Hora;
        private Label Lbl_MascaraAtiva;
        private Label Lbl_Conteudo;
        private MaskedTextBox Msk_TextBox;
    }
}
