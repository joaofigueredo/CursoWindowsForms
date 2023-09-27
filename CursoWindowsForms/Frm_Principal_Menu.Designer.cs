namespace CursoWindowsForms
{
    partial class Frm_Principal_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal_Menu));
            Mnu_Principal = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            formulárioToolStripMenuItem = new ToolStripMenuItem();
            demonstraçãoKeyToolStripMenuItem = new ToolStripMenuItem();
            helloWorldToolStripMenuItem = new ToolStripMenuItem();
            mascaraToolStripMenuItem = new ToolStripMenuItem();
            validaCPFToolStripMenuItem = new ToolStripMenuItem();
            validaCPF2ToolStripMenuItem = new ToolStripMenuItem();
            validaSenhaToolStripMenuItem = new ToolStripMenuItem();
            celularToolStripMenuItem = new ToolStripMenuItem();
            arquivoToolStripMenuItem1 = new ToolStripMenuItem();
            Mnu_Principal.SuspendLayout();
            SuspendLayout();
            // 
            // Mnu_Principal
            // 
            Mnu_Principal.ImageScalingSize = new Size(20, 20);
            Mnu_Principal.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
            Mnu_Principal.Location = new Point(0, 0);
            Mnu_Principal.Name = "Mnu_Principal";
            Mnu_Principal.Size = new Size(800, 28);
            Mnu_Principal.TabIndex = 0;
            Mnu_Principal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formulárioToolStripMenuItem, arquivoToolStripMenuItem1 });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(75, 24);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // formulárioToolStripMenuItem
            // 
            formulárioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { demonstraçãoKeyToolStripMenuItem, helloWorldToolStripMenuItem, mascaraToolStripMenuItem, validaCPFToolStripMenuItem, validaCPF2ToolStripMenuItem, validaSenhaToolStripMenuItem, celularToolStripMenuItem });
            formulárioToolStripMenuItem.Name = "formulárioToolStripMenuItem";
            formulárioToolStripMenuItem.Size = new Size(224, 26);
            formulárioToolStripMenuItem.Text = "Novo";
            formulárioToolStripMenuItem.Click += formulárioToolStripMenuItem_Click;
            // 
            // demonstraçãoKeyToolStripMenuItem
            // 
            demonstraçãoKeyToolStripMenuItem.Image = (Image)resources.GetObject("demonstraçãoKeyToolStripMenuItem.Image");
            demonstraçãoKeyToolStripMenuItem.Name = "demonstraçãoKeyToolStripMenuItem";
            demonstraçãoKeyToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.K;
            demonstraçãoKeyToolStripMenuItem.Size = new Size(264, 26);
            demonstraçãoKeyToolStripMenuItem.Text = "Demonstração &Key";
            demonstraçãoKeyToolStripMenuItem.Click += demonstraçãoKeyToolStripMenuItem_Click;
            // 
            // helloWorldToolStripMenuItem
            // 
            helloWorldToolStripMenuItem.Image = (Image)resources.GetObject("helloWorldToolStripMenuItem.Image");
            helloWorldToolStripMenuItem.Name = "helloWorldToolStripMenuItem";
            helloWorldToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.W;
            helloWorldToolStripMenuItem.Size = new Size(264, 26);
            helloWorldToolStripMenuItem.Text = "Hello &World";
            helloWorldToolStripMenuItem.Click += helloWorldToolStripMenuItem_Click;
            // 
            // mascaraToolStripMenuItem
            // 
            mascaraToolStripMenuItem.Image = (Image)resources.GetObject("mascaraToolStripMenuItem.Image");
            mascaraToolStripMenuItem.Name = "mascaraToolStripMenuItem";
            mascaraToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.M;
            mascaraToolStripMenuItem.Size = new Size(264, 26);
            mascaraToolStripMenuItem.Text = "&Mascara";
            mascaraToolStripMenuItem.Click += mascaraToolStripMenuItem_Click;
            // 
            // validaCPFToolStripMenuItem
            // 
            validaCPFToolStripMenuItem.Image = (Image)resources.GetObject("validaCPFToolStripMenuItem.Image");
            validaCPFToolStripMenuItem.Name = "validaCPFToolStripMenuItem";
            validaCPFToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            validaCPFToolStripMenuItem.Size = new Size(264, 26);
            validaCPFToolStripMenuItem.Text = "Valida &CPF";
            validaCPFToolStripMenuItem.Click += validaCPFToolStripMenuItem_Click;
            // 
            // validaCPF2ToolStripMenuItem
            // 
            validaCPF2ToolStripMenuItem.Image = (Image)resources.GetObject("validaCPF2ToolStripMenuItem.Image");
            validaCPF2ToolStripMenuItem.Name = "validaCPF2ToolStripMenuItem";
            validaCPF2ToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.P;
            validaCPF2ToolStripMenuItem.Size = new Size(264, 26);
            validaCPF2ToolStripMenuItem.Text = "Valida C&PF2";
            validaCPF2ToolStripMenuItem.Click += validaCPF2ToolStripMenuItem_Click;
            // 
            // validaSenhaToolStripMenuItem
            // 
            validaSenhaToolStripMenuItem.Image = (Image)resources.GetObject("validaSenhaToolStripMenuItem.Image");
            validaSenhaToolStripMenuItem.Name = "validaSenhaToolStripMenuItem";
            validaSenhaToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.S;
            validaSenhaToolStripMenuItem.Size = new Size(264, 26);
            validaSenhaToolStripMenuItem.Text = "Valida &Senha";
            validaSenhaToolStripMenuItem.Click += validaSenhaToolStripMenuItem_Click;
            // 
            // celularToolStripMenuItem
            // 
            celularToolStripMenuItem.Image = (Image)resources.GetObject("celularToolStripMenuItem.Image");
            celularToolStripMenuItem.Name = "celularToolStripMenuItem";
            celularToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.E;
            celularToolStripMenuItem.Size = new Size(264, 26);
            celularToolStripMenuItem.Text = "C&elular";
            celularToolStripMenuItem.Click += celularToolStripMenuItem_Click;
            // 
            // arquivoToolStripMenuItem1
            // 
            arquivoToolStripMenuItem1.Name = "arquivoToolStripMenuItem1";
            arquivoToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.W;
            arquivoToolStripMenuItem1.Size = new Size(224, 26);
            arquivoToolStripMenuItem1.Text = "Sair";
            arquivoToolStripMenuItem1.Click += arquivoToolStripMenuItem1_Click;
            // 
            // Frm_Principal_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Mnu_Principal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = Mnu_Principal;
            Name = "Frm_Principal_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Principal";
            Load += Frm_Principal_Menu_Load;
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
    }
}