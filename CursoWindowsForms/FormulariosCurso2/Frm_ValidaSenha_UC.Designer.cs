namespace CursoWindowsForms
{
    partial class Frm_ValidaSenha_UC
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
            Btn_VerSenha = new Button();
            Lbl_Resultado = new Label();
            Txt_Senha = new TextBox();
            Btn_Reset = new Button();
            Lbl_Result = new Label();
            SuspendLayout();
            // 
            // Btn_VerSenha
            // 
            Btn_VerSenha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_VerSenha.Location = new Point(299, 61);
            Btn_VerSenha.Name = "Btn_VerSenha";
            Btn_VerSenha.Size = new Size(111, 28);
            Btn_VerSenha.TabIndex = 7;
            Btn_VerSenha.Text = "Ver Senha";
            Btn_VerSenha.UseVisualStyleBackColor = true;
            Btn_VerSenha.Click += Btn_VerSenha_Click;
            // 
            // Lbl_Resultado
            // 
            Lbl_Resultado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Lbl_Resultado.AutoSize = true;
            Lbl_Resultado.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Resultado.Location = new Point(12, -75);
            Lbl_Resultado.Name = "Lbl_Resultado";
            Lbl_Resultado.Size = new Size(0, 29);
            Lbl_Resultado.TabIndex = 6;
            // 
            // Txt_Senha
            // 
            Txt_Senha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Txt_Senha.BorderStyle = BorderStyle.FixedSingle;
            Txt_Senha.Location = new Point(12, 29);
            Txt_Senha.Name = "Txt_Senha";
            Txt_Senha.PasswordChar = '*';
            Txt_Senha.Size = new Size(281, 27);
            Txt_Senha.TabIndex = 5;
            // 
            // Btn_Reset
            // 
            Btn_Reset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Reset.Location = new Point(299, 27);
            Btn_Reset.Name = "Btn_Reset";
            Btn_Reset.Size = new Size(111, 28);
            Btn_Reset.TabIndex = 4;
            Btn_Reset.Text = "Limpa";
            Btn_Reset.UseVisualStyleBackColor = true;
            Btn_Reset.Click += Btn_Reset_Click;
            // 
            // Lbl_Result
            // 
            Lbl_Result.AutoSize = true;
            Lbl_Result.Location = new Point(12, 69);
            Lbl_Result.Name = "Lbl_Result";
            Lbl_Result.Size = new Size(0, 20);
            Lbl_Result.TabIndex = 8;
            // 
            // Frm_ValidaSenha_UC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Lbl_Result);
            Controls.Add(Btn_VerSenha);
            Controls.Add(Lbl_Resultado);
            Controls.Add(Txt_Senha);
            Controls.Add(Btn_Reset);
            Name = "Frm_ValidaSenha_UC";
            Size = new Size(413, 138);
            KeyDown += Frm_ValidaSenha_UC_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_VerSenha;
        private Label Lbl_Resultado;
        private TextBox Txt_Senha;
        private Button Btn_Reset;
        private Label Lbl_Result;
    }
}
