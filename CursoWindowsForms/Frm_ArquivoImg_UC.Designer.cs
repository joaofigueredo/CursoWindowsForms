namespace CursoWindowsForms
{
    partial class Frm_ArquivoImg_UC
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
            Lbl_ArquivoImagem = new Label();
            pic_ArquivoImagem = new PictureBox();
            btn_Cor = new Button();
            btn_Font = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_ArquivoImagem).BeginInit();
            SuspendLayout();
            // 
            // Lbl_ArquivoImagem
            // 
            Lbl_ArquivoImagem.AutoSize = true;
            Lbl_ArquivoImagem.Location = new Point(17, 35);
            Lbl_ArquivoImagem.Name = "Lbl_ArquivoImagem";
            Lbl_ArquivoImagem.Size = new Size(50, 20);
            Lbl_ArquivoImagem.TabIndex = 0;
            Lbl_ArquivoImagem.Text = "label1";
            // 
            // pic_ArquivoImagem
            // 
            pic_ArquivoImagem.Location = new Point(17, 81);
            pic_ArquivoImagem.Name = "pic_ArquivoImagem";
            pic_ArquivoImagem.Size = new Size(209, 156);
            pic_ArquivoImagem.SizeMode = PictureBoxSizeMode.Zoom;
            pic_ArquivoImagem.TabIndex = 1;
            pic_ArquivoImagem.TabStop = false;
            // 
            // btn_Cor
            // 
            btn_Cor.Location = new Point(17, 3);
            btn_Cor.Name = "btn_Cor";
            btn_Cor.Size = new Size(94, 29);
            btn_Cor.TabIndex = 2;
            btn_Cor.Text = "Cor";
            btn_Cor.UseVisualStyleBackColor = true;
            btn_Cor.Click += btn_Cor_Click;
            // 
            // btn_Font
            // 
            btn_Font.Location = new Point(132, 3);
            btn_Font.Name = "btn_Font";
            btn_Font.Size = new Size(94, 29);
            btn_Font.TabIndex = 3;
            btn_Font.Text = "Font";
            btn_Font.UseVisualStyleBackColor = true;
            btn_Font.Click += btn_Font_Click;
            // 
            // Frm_ArquivoImg_UC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Font);
            Controls.Add(btn_Cor);
            Controls.Add(pic_ArquivoImagem);
            Controls.Add(Lbl_ArquivoImagem);
            Name = "Frm_ArquivoImg_UC";
            Size = new Size(425, 378);
            ((System.ComponentModel.ISupportInitialize)pic_ArquivoImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_ArquivoImagem;
        private PictureBox pic_ArquivoImagem;
        private Button btn_Cor;
        private Button btn_Font;
    }
}
