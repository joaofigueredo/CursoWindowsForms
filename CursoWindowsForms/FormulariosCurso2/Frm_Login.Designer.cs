namespace CursoWindowsForms
{
    partial class Frm_Login
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
            Pic_Login = new PictureBox();
            Lbl_Login = new Label();
            Txt_Login = new TextBox();
            Txt_Senha = new TextBox();
            Btn_Ok = new Button();
            Btn_Cancela = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Pic_Login).BeginInit();
            SuspendLayout();
            // 
            // Pic_Login
            // 
            Pic_Login.Image = Properties.Resources.key;
            Pic_Login.Location = new Point(12, 16);
            Pic_Login.Name = "Pic_Login";
            Pic_Login.Size = new Size(100, 100);
            Pic_Login.SizeMode = PictureBoxSizeMode.StretchImage;
            Pic_Login.TabIndex = 0;
            Pic_Login.TabStop = false;
            // 
            // Lbl_Login
            // 
            Lbl_Login.Location = new Point(119, 8);
            Lbl_Login.Name = "Lbl_Login";
            Lbl_Login.Size = new Size(68, 21);
            Lbl_Login.TabIndex = 1;
            Lbl_Login.Text = "Label 1";
            // 
            // Txt_Login
            // 
            Txt_Login.BorderStyle = BorderStyle.FixedSingle;
            Txt_Login.Location = new Point(122, 33);
            Txt_Login.Name = "Txt_Login";
            Txt_Login.Size = new Size(151, 27);
            Txt_Login.TabIndex = 2;
            // 
            // Txt_Senha
            // 
            Txt_Senha.BorderStyle = BorderStyle.FixedSingle;
            Txt_Senha.Location = new Point(122, 89);
            Txt_Senha.Name = "Txt_Senha";
            Txt_Senha.Size = new Size(151, 27);
            Txt_Senha.TabIndex = 3;
            // 
            // Btn_Ok
            // 
            Btn_Ok.Location = new Point(12, 132);
            Btn_Ok.Name = "Btn_Ok";
            Btn_Ok.Size = new Size(94, 29);
            Btn_Ok.TabIndex = 4;
            Btn_Ok.Text = "Ok";
            Btn_Ok.UseVisualStyleBackColor = true;
            Btn_Ok.Click += Btn_Ok_Click;
            // 
            // Btn_Cancela
            // 
            Btn_Cancela.Location = new Point(194, 132);
            Btn_Cancela.Name = "Btn_Cancela";
            Btn_Cancela.Size = new Size(75, 29);
            Btn_Cancela.TabIndex = 5;
            Btn_Cancela.Text = "Cancela";
            Btn_Cancela.UseVisualStyleBackColor = true;
            Btn_Cancela.Click += Btn_Cancela_Click;
            // 
            // label1
            // 
            label1.Location = new Point(119, 63);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 6;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 166);
            Controls.Add(label1);
            Controls.Add(Btn_Cancela);
            Controls.Add(Btn_Ok);
            Controls.Add(Txt_Senha);
            Controls.Add(Txt_Login);
            Controls.Add(Lbl_Login);
            Controls.Add(Pic_Login);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Login";
            ((System.ComponentModel.ISupportInitialize)Pic_Login).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Pic_Login;
        private Label Lbl_Login;
        private TextBox Txt_Login;
        private TextBox Txt_Senha;
        private Button Btn_Ok;
        private Button Btn_Cancela;
        private Label label1;
    }
}