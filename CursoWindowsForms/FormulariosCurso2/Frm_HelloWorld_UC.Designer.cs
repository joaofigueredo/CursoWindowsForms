namespace CursoWindowsForms
{
    partial class Frm_HelloWorld_UC
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
            txt_ConteudoLabel = new TextBox();
            Btn_modificaLabel = new Button();
            lbl_Titulo = new Label();
            SuspendLayout();
            // 
            // txt_ConteudoLabel
            // 
            txt_ConteudoLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_ConteudoLabel.BorderStyle = BorderStyle.FixedSingle;
            txt_ConteudoLabel.Location = new Point(13, 132);
            txt_ConteudoLabel.Name = "txt_ConteudoLabel";
            txt_ConteudoLabel.Size = new Size(550, 27);
            txt_ConteudoLabel.TabIndex = 6;
            // 
            // Btn_modificaLabel
            // 
            Btn_modificaLabel.Location = new Point(140, 79);
            Btn_modificaLabel.Name = "Btn_modificaLabel";
            Btn_modificaLabel.Size = new Size(240, 29);
            Btn_modificaLabel.TabIndex = 5;
            Btn_modificaLabel.Text = "Modifica Label";
            Btn_modificaLabel.UseVisualStyleBackColor = true;
            Btn_modificaLabel.Click += Btn_modificaLabel_Click;
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Titulo.Location = new Point(110, 16);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(299, 35);
            lbl_Titulo.TabIndex = 4;
            lbl_Titulo.Text = "Curso de Windows Forms";
            // 
            // Frm_HelloWorld_UC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txt_ConteudoLabel);
            Controls.Add(Btn_modificaLabel);
            Controls.Add(lbl_Titulo);
            Name = "Frm_HelloWorld_UC";
            Size = new Size(583, 499);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_ConteudoLabel;
        private Button Btn_modificaLabel;
        private Label lbl_Titulo;
    }
}
