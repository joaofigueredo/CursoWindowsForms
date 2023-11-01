namespace CursoWindowsForms
{
    partial class Frm_Principal_Menu_UC
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal_Menu_UC));
            Mnu_Principal = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            conectarToolStripMenuItem = new ToolStripMenuItem();
            formulárioToolStripMenuItem = new ToolStripMenuItem();
            demonstraçãoKeyToolStripMenuItem = new ToolStripMenuItem();
            helloWorldToolStripMenuItem = new ToolStripMenuItem();
            mascaraToolStripMenuItem = new ToolStripMenuItem();
            validaCPFToolStripMenuItem = new ToolStripMenuItem();
            validaCPF2ToolStripMenuItem = new ToolStripMenuItem();
            validaSenhaToolStripMenuItem = new ToolStripMenuItem();
            celularToolStripMenuItem = new ToolStripMenuItem();
            apagarToolStripMenuItem = new ToolStripMenuItem();
            arquivoToolStripMenuItem1 = new ToolStripMenuItem();
            desconectarToolStripMenuItem = new ToolStripMenuItem();
            byteBankToolStripMenuItem = new ToolStripMenuItem();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            açõesToolStripMenuItem = new ToolStripMenuItem();
            abrirImagemToolStripMenuItem = new ToolStripMenuItem();
            Tbc_Aplicacoes = new TabControl();
            Iml_Imagens = new ImageList(components);
            Mnu_Principal.SuspendLayout();
            SuspendLayout();
            // 
            // Mnu_Principal
            // 
            Mnu_Principal.ImageScalingSize = new Size(20, 20);
            Mnu_Principal.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, byteBankToolStripMenuItem, açõesToolStripMenuItem });
            Mnu_Principal.Location = new Point(0, 0);
            Mnu_Principal.Name = "Mnu_Principal";
            Mnu_Principal.Size = new Size(800, 28);
            Mnu_Principal.TabIndex = 0;
            Mnu_Principal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { conectarToolStripMenuItem, formulárioToolStripMenuItem, apagarToolStripMenuItem, arquivoToolStripMenuItem1, desconectarToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(75, 24);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // conectarToolStripMenuItem
            // 
            conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            conectarToolStripMenuItem.Size = new Size(174, 26);
            conectarToolStripMenuItem.Text = "Conectar";
            conectarToolStripMenuItem.Click += conectarToolStripMenuItem_Click;
            // 
            // formulárioToolStripMenuItem
            // 
            formulárioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { demonstraçãoKeyToolStripMenuItem, helloWorldToolStripMenuItem, mascaraToolStripMenuItem, validaCPFToolStripMenuItem, validaCPF2ToolStripMenuItem, validaSenhaToolStripMenuItem, celularToolStripMenuItem });
            formulárioToolStripMenuItem.Name = "formulárioToolStripMenuItem";
            formulárioToolStripMenuItem.Size = new Size(174, 26);
            formulárioToolStripMenuItem.Text = "Novo";
            // 
            // demonstraçãoKeyToolStripMenuItem
            // 
            demonstraçãoKeyToolStripMenuItem.Name = "demonstraçãoKeyToolStripMenuItem";
            demonstraçãoKeyToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.K;
            demonstraçãoKeyToolStripMenuItem.Size = new Size(264, 26);
            demonstraçãoKeyToolStripMenuItem.Text = "Demonstração &Key";
            demonstraçãoKeyToolStripMenuItem.Click += demonstraçãoKeyToolStripMenuItem_Click;
            // 
            // helloWorldToolStripMenuItem
            // 
            helloWorldToolStripMenuItem.Name = "helloWorldToolStripMenuItem";
            helloWorldToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.W;
            helloWorldToolStripMenuItem.Size = new Size(264, 26);
            helloWorldToolStripMenuItem.Text = "Hello &World";
            helloWorldToolStripMenuItem.Click += helloWorldToolStripMenuItem_Click;
            // 
            // mascaraToolStripMenuItem
            // 
            mascaraToolStripMenuItem.Name = "mascaraToolStripMenuItem";
            mascaraToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.M;
            mascaraToolStripMenuItem.Size = new Size(264, 26);
            mascaraToolStripMenuItem.Text = "&Mascara";
            mascaraToolStripMenuItem.Click += mascaraToolStripMenuItem_Click;
            // 
            // validaCPFToolStripMenuItem
            // 
            validaCPFToolStripMenuItem.Name = "validaCPFToolStripMenuItem";
            validaCPFToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            validaCPFToolStripMenuItem.Size = new Size(264, 26);
            validaCPFToolStripMenuItem.Text = "Valida &CPF";
            validaCPFToolStripMenuItem.Click += validaCPFToolStripMenuItem_Click;
            // 
            // validaCPF2ToolStripMenuItem
            // 
            validaCPF2ToolStripMenuItem.Name = "validaCPF2ToolStripMenuItem";
            validaCPF2ToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.P;
            validaCPF2ToolStripMenuItem.Size = new Size(264, 26);
            validaCPF2ToolStripMenuItem.Text = "Valida C&PF2";
            validaCPF2ToolStripMenuItem.Click += validaCPF2ToolStripMenuItem_Click;
            // 
            // validaSenhaToolStripMenuItem
            // 
            validaSenhaToolStripMenuItem.Name = "validaSenhaToolStripMenuItem";
            validaSenhaToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.S;
            validaSenhaToolStripMenuItem.Size = new Size(264, 26);
            validaSenhaToolStripMenuItem.Text = "Valida &Senha";
            validaSenhaToolStripMenuItem.Click += validaSenhaToolStripMenuItem_Click;
            // 
            // celularToolStripMenuItem
            // 
            celularToolStripMenuItem.Name = "celularToolStripMenuItem";
            celularToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.E;
            celularToolStripMenuItem.Size = new Size(264, 26);
            celularToolStripMenuItem.Text = "C&elular";
            celularToolStripMenuItem.Click += celularToolStripMenuItem_Click;
            // 
            // apagarToolStripMenuItem
            // 
            apagarToolStripMenuItem.Name = "apagarToolStripMenuItem";
            apagarToolStripMenuItem.Size = new Size(174, 26);
            apagarToolStripMenuItem.Text = "Apagar aba";
            apagarToolStripMenuItem.Click += apagarToolStripMenuItem_Click;
            // 
            // arquivoToolStripMenuItem1
            // 
            arquivoToolStripMenuItem1.Name = "arquivoToolStripMenuItem1";
            arquivoToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.W;
            arquivoToolStripMenuItem1.Size = new Size(174, 26);
            arquivoToolStripMenuItem1.Text = "Sair";
            arquivoToolStripMenuItem1.Click += arquivoToolStripMenuItem1_Click;
            // 
            // desconectarToolStripMenuItem
            // 
            desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            desconectarToolStripMenuItem.Size = new Size(174, 26);
            desconectarToolStripMenuItem.Text = "Desconectar";
            desconectarToolStripMenuItem.Click += desconectarToolStripMenuItem_Click;
            // 
            // byteBankToolStripMenuItem
            // 
            byteBankToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            byteBankToolStripMenuItem.Image = Properties.Resources.money_bag;
            byteBankToolStripMenuItem.Name = "byteBankToolStripMenuItem";
            byteBankToolStripMenuItem.Size = new Size(104, 24);
            byteBankToolStripMenuItem.Text = "ByteBank";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem });
            cadastrosToolStripMenuItem.Image = Properties.Resources.cadastro;
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(157, 26);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Image = Properties.Resources.usuario;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(144, 26);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // açõesToolStripMenuItem
            // 
            açõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirImagemToolStripMenuItem });
            açõesToolStripMenuItem.Name = "açõesToolStripMenuItem";
            açõesToolStripMenuItem.Size = new Size(63, 24);
            açõesToolStripMenuItem.Text = "Ações";
            // 
            // abrirImagemToolStripMenuItem
            // 
            abrirImagemToolStripMenuItem.Name = "abrirImagemToolStripMenuItem";
            abrirImagemToolStripMenuItem.Size = new Size(184, 26);
            abrirImagemToolStripMenuItem.Text = "Abrir Imagem";
            abrirImagemToolStripMenuItem.Click += abrirImagemToolStripMenuItem_Click;
            // 
            // Tbc_Aplicacoes
            // 
            Tbc_Aplicacoes.Dock = DockStyle.Fill;
            Tbc_Aplicacoes.ImageList = Iml_Imagens;
            Tbc_Aplicacoes.Location = new Point(0, 28);
            Tbc_Aplicacoes.Name = "Tbc_Aplicacoes";
            Tbc_Aplicacoes.SelectedIndex = 0;
            Tbc_Aplicacoes.Size = new Size(800, 422);
            Tbc_Aplicacoes.TabIndex = 1;
            Tbc_Aplicacoes.MouseDown += Tbc_Aplicacoes_MouseDown;
            // 
            // Iml_Imagens
            // 
            Iml_Imagens.ColorDepth = ColorDepth.Depth8Bit;
            Iml_Imagens.ImageStream = (ImageListStreamer)resources.GetObject("Iml_Imagens.ImageStream");
            Iml_Imagens.TransparentColor = Color.Transparent;
            Iml_Imagens.Images.SetKeyName(0, "Frm_DemonstracaoKey.png");
            Iml_Imagens.Images.SetKeyName(1, "Frm_HelloWorld.png");
            Iml_Imagens.Images.SetKeyName(2, "Frm_Mascara.png");
            Iml_Imagens.Images.SetKeyName(3, "Frm_ValidaCPF.png");
            Iml_Imagens.Images.SetKeyName(4, "Frm_ValidaCPF2.png");
            Iml_Imagens.Images.SetKeyName(5, "Frm_ValidaSenha.png");
            Iml_Imagens.Images.SetKeyName(6, "file-and-folder.png");
            Iml_Imagens.Images.SetKeyName(7, "usuario.png");
            // 
            // Frm_Principal_Menu_UC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Tbc_Aplicacoes);
            Controls.Add(Mnu_Principal);
            MainMenuStrip = Mnu_Principal;
            Name = "Frm_Principal_Menu_UC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Principal";
            Mnu_Principal.ResumeLayout(false);
            Mnu_Principal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Mnu_Principal;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem formulárioToolStripMenuItem;
        private ToolStripMenuItem demonstraçãoKeyToolStripMenuItem;
        private ToolStripMenuItem helloWorldToolStripMenuItem;
        private ToolStripMenuItem mascaraToolStripMenuItem;
        private ToolStripMenuItem validaCPFToolStripMenuItem;
        private ToolStripMenuItem validaCPF2ToolStripMenuItem;
        private ToolStripMenuItem validaSenhaToolStripMenuItem;
        private ToolStripMenuItem celularToolStripMenuItem;
        private ToolStripMenuItem arquivoToolStripMenuItem1;
        private TabControl Tbc_Aplicacoes;
        private ImageList Iml_Imagens;
        private ToolStripMenuItem apagarToolStripMenuItem;
        private ToolStripMenuItem açõesToolStripMenuItem;
        private ToolStripMenuItem abrirImagemToolStripMenuItem;
        private ToolStripMenuItem conectarToolStripMenuItem;
        private ToolStripMenuItem desconectarToolStripMenuItem;
        private ToolStripMenuItem byteBankToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
    }
}