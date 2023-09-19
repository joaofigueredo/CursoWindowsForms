namespace CursoWindowsForms
{
    partial class Frm_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_principal));
            Btn_demonstracaoKey = new Button();
            Btn_HelloWorld = new Button();
            Btn_Mascara = new Button();
            Btn_ValidaCpf = new Button();
            Btn_ValidaCpf2 = new Button();
            Btn_ValidaSenha = new Button();
            SuspendLayout();
            // 
            // Btn_demonstracaoKey
            // 
            Btn_demonstracaoKey.Image = (Image)resources.GetObject("Btn_demonstracaoKey.Image");
            Btn_demonstracaoKey.Location = new Point(12, 12);
            Btn_demonstracaoKey.Name = "Btn_demonstracaoKey";
            Btn_demonstracaoKey.Size = new Size(114, 48);
            Btn_demonstracaoKey.TabIndex = 0;
            Btn_demonstracaoKey.Text = "Demonstração Key";
            Btn_demonstracaoKey.UseVisualStyleBackColor = true;
            Btn_demonstracaoKey.Click += Btn_demonstracaoKey_Click;
            // 
            // Btn_HelloWorld
            // 
            Btn_HelloWorld.Image = (Image)resources.GetObject("Btn_HelloWorld.Image");
            Btn_HelloWorld.Location = new Point(132, 12);
            Btn_HelloWorld.Name = "Btn_HelloWorld";
            Btn_HelloWorld.Size = new Size(114, 48);
            Btn_HelloWorld.TabIndex = 1;
            Btn_HelloWorld.Text = "Hello World";
            Btn_HelloWorld.UseVisualStyleBackColor = true;
            Btn_HelloWorld.Click += Btn_HelloWorld_Click;
            // 
            // Btn_Mascara
            // 
            Btn_Mascara.Image = (Image)resources.GetObject("Btn_Mascara.Image");
            Btn_Mascara.Location = new Point(250, 12);
            Btn_Mascara.Name = "Btn_Mascara";
            Btn_Mascara.Size = new Size(114, 48);
            Btn_Mascara.TabIndex = 2;
            Btn_Mascara.Text = "Mascara";
            Btn_Mascara.UseVisualStyleBackColor = true;
            Btn_Mascara.Click += Btn_Mascara_Click;
            // 
            // Btn_ValidaCpf
            // 
            Btn_ValidaCpf.Image = (Image)resources.GetObject("Btn_ValidaCpf.Image");
            Btn_ValidaCpf.Location = new Point(12, 68);
            Btn_ValidaCpf.Name = "Btn_ValidaCpf";
            Btn_ValidaCpf.Size = new Size(114, 48);
            Btn_ValidaCpf.TabIndex = 3;
            Btn_ValidaCpf.Text = "Valida CPF";
            Btn_ValidaCpf.UseVisualStyleBackColor = true;
            Btn_ValidaCpf.Click += Btn_ValidaCpf_Click;
            // 
            // Btn_ValidaCpf2
            // 
            Btn_ValidaCpf2.Image = (Image)resources.GetObject("Btn_ValidaCpf2.Image");
            Btn_ValidaCpf2.Location = new Point(132, 68);
            Btn_ValidaCpf2.Name = "Btn_ValidaCpf2";
            Btn_ValidaCpf2.Size = new Size(114, 48);
            Btn_ValidaCpf2.TabIndex = 4;
            Btn_ValidaCpf2.Text = "Valida CPF2";
            Btn_ValidaCpf2.UseVisualStyleBackColor = true;
            Btn_ValidaCpf2.Click += Btn_ValidaCpf2_Click;
            // 
            // Btn_ValidaSenha
            // 
            Btn_ValidaSenha.Image = (Image)resources.GetObject("Btn_ValidaSenha.Image");
            Btn_ValidaSenha.Location = new Point(250, 66);
            Btn_ValidaSenha.Name = "Btn_ValidaSenha";
            Btn_ValidaSenha.Size = new Size(114, 48);
            Btn_ValidaSenha.TabIndex = 5;
            Btn_ValidaSenha.Text = "Valida Senha";
            Btn_ValidaSenha.UseVisualStyleBackColor = true;
            Btn_ValidaSenha.Click += Btn_ValidaSenha_Click;
            // 
            // Frm_principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 121);
            Controls.Add(Btn_ValidaSenha);
            Controls.Add(Btn_ValidaCpf2);
            Controls.Add(Btn_ValidaCpf);
            Controls.Add(Btn_Mascara);
            Controls.Add(Btn_HelloWorld);
            Controls.Add(Btn_demonstracaoKey);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_demonstracaoKey;
        private Button Btn_HelloWorld;
        private Button Btn_Mascara;
        private Button Btn_ValidaCpf;
        private Button Btn_ValidaCpf2;
        private Button Btn_ValidaSenha;
    }
}