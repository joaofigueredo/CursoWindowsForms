namespace CursoWindowsForms
{
    partial class Frm_Busca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Busca));
            Tls_Principal = new ToolStrip();
            salvarToolStripButton = new ToolStripButton();
            apagarToolStripButton1 = new ToolStripButton();
            lst_Busca = new ListBox();
            Tls_Principal.SuspendLayout();
            SuspendLayout();
            // 
            // Tls_Principal
            // 
            Tls_Principal.ImageScalingSize = new Size(20, 20);
            Tls_Principal.Items.AddRange(new ToolStripItem[] { salvarToolStripButton, apagarToolStripButton1 });
            Tls_Principal.Location = new Point(0, 0);
            Tls_Principal.Name = "Tls_Principal";
            Tls_Principal.Size = new Size(549, 27);
            Tls_Principal.TabIndex = 33;
            Tls_Principal.Text = "toolStrip1";
            // 
            // salvarToolStripButton
            // 
            salvarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            salvarToolStripButton.Image = (Image)resources.GetObject("salvarToolStripButton.Image");
            salvarToolStripButton.ImageTransparentColor = Color.Magenta;
            salvarToolStripButton.Name = "salvarToolStripButton";
            salvarToolStripButton.Size = new Size(29, 24);
            salvarToolStripButton.Text = "&Salvar";
            salvarToolStripButton.Click += salvarToolStripButton_Click;
            // 
            // apagarToolStripButton1
            // 
            apagarToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            apagarToolStripButton1.Image = Properties.Resources.botao_x;
            apagarToolStripButton1.ImageTransparentColor = Color.Magenta;
            apagarToolStripButton1.Name = "apagarToolStripButton1";
            apagarToolStripButton1.Size = new Size(29, 24);
            apagarToolStripButton1.Text = "toolStripButton1";
            apagarToolStripButton1.Click += apagarToolStripButton1_Click;
            // 
            // lst_Busca
            // 
            lst_Busca.FormattingEnabled = true;
            lst_Busca.ItemHeight = 20;
            lst_Busca.Location = new Point(12, 50);
            lst_Busca.Name = "lst_Busca";
            lst_Busca.Size = new Size(525, 364);
            lst_Busca.TabIndex = 34;
           
            // 
            // Frm_Busca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 437);
            Controls.Add(lst_Busca);
            Controls.Add(Tls_Principal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Busca";
            Text = "Frm_Busca";
            Tls_Principal.ResumeLayout(false);
            Tls_Principal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip Tls_Principal;
        private ToolStripButton salvarToolStripButton;
        private ToolStripButton apagarToolStripButton1;
        private ListBox lst_Busca;
    }
}