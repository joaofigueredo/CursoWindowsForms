namespace CursoWindowsForms
{
    partial class Frm_Questao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Questao));
            Lbl_Questao = new Label();
            Btn_Ok = new Button();
            Btn_Cancela = new Button();
            Pic_Image = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Pic_Image).BeginInit();
            SuspendLayout();
            // 
            // Lbl_Questao
            // 
            Lbl_Questao.AutoSize = true;
            Lbl_Questao.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Questao.Location = new Point(18, 9);
            Lbl_Questao.Name = "Lbl_Questao";
            Lbl_Questao.Size = new Size(297, 25);
            Lbl_Questao.TabIndex = 0;
            Lbl_Questao.Text = "Você deseja validar a senha?";
            // 
            // Btn_Ok
            // 
            Btn_Ok.Location = new Point(147, 60);
            Btn_Ok.Name = "Btn_Ok";
            Btn_Ok.Size = new Size(115, 33);
            Btn_Ok.TabIndex = 1;
            Btn_Ok.Text = "Sim. Continue";
            Btn_Ok.UseVisualStyleBackColor = true;
            Btn_Ok.Click += Btn_Ok_Click;
            // 
            // Btn_Cancela
            // 
            Btn_Cancela.Location = new Point(147, 89);
            Btn_Cancela.Name = "Btn_Cancela";
            Btn_Cancela.Size = new Size(115, 29);
            Btn_Cancela.TabIndex = 2;
            Btn_Cancela.Text = "Nâo. Pare";
            Btn_Cancela.UseVisualStyleBackColor = true;
            Btn_Cancela.Click += Btn_Cancela_Click;
            // 
            // Pic_Image
            // 
            Pic_Image.Image = (Image)resources.GetObject("Pic_Image.Image");
            Pic_Image.Location = new Point(12, 56);
            Pic_Image.Name = "Pic_Image";
            Pic_Image.Size = new Size(125, 62);
            Pic_Image.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_Image.TabIndex = 3;
            Pic_Image.TabStop = false;
            // 
            // Frm_Questao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 143);
            Controls.Add(Pic_Image);
            Controls.Add(Btn_Cancela);
            Controls.Add(Btn_Ok);
            Controls.Add(Lbl_Questao);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Questao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Questão";
            ((System.ComponentModel.ISupportInitialize)Pic_Image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Questao;
        private Button Btn_Ok;
        private Button Btn_Cancela;
        private PictureBox Pic_Image;
    }
}