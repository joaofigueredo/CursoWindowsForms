namespace CursoWindowsForms
{
    partial class Frm_DemonstacaoKey_UC
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
            Lbl_Lower = new Label();
            Lbl_Upper = new Label();
            Lbl_Maius = new Label();
            Lbl_Minus = new Label();
            Btn_Reset = new Button();
            Txt_Msg = new TextBox();
            Txt_Input = new TextBox();
            SuspendLayout();
            // 
            // Lbl_Lower
            // 
            Lbl_Lower.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_Lower.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Lower.Location = new Point(396, 127);
            Lbl_Lower.Name = "Lbl_Lower";
            Lbl_Lower.Size = new Size(62, 25);
            Lbl_Lower.TabIndex = 14;
            // 
            // Lbl_Upper
            // 
            Lbl_Upper.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_Upper.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Upper.Location = new Point(396, 79);
            Lbl_Upper.Name = "Lbl_Upper";
            Lbl_Upper.Size = new Size(62, 23);
            Lbl_Upper.TabIndex = 13;
            // 
            // Lbl_Maius
            // 
            Lbl_Maius.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_Maius.AutoSize = true;
            Lbl_Maius.Location = new Point(351, 79);
            Lbl_Maius.Name = "Lbl_Maius";
            Lbl_Maius.Size = new Size(48, 20);
            Lbl_Maius.TabIndex = 12;
            Lbl_Maius.Text = "Maius";
            // 
            // Lbl_Minus
            // 
            Lbl_Minus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_Minus.Location = new Point(351, 127);
            Lbl_Minus.Name = "Lbl_Minus";
            Lbl_Minus.Size = new Size(48, 20);
            Lbl_Minus.TabIndex = 11;
            Lbl_Minus.Text = "Minus";
            // 
            // Btn_Reset
            // 
            Btn_Reset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Reset.Location = new Point(351, 26);
            Btn_Reset.Name = "Btn_Reset";
            Btn_Reset.Size = new Size(107, 28);
            Btn_Reset.TabIndex = 10;
            Btn_Reset.Text = "Limpar";
            Btn_Reset.UseVisualStyleBackColor = true;
            Btn_Reset.Click += Btn_Reset_Click;
            // 
            // Txt_Msg
            // 
            Txt_Msg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Txt_Msg.Location = new Point(14, 60);
            Txt_Msg.Multiline = true;
            Txt_Msg.Name = "Txt_Msg";
            Txt_Msg.ScrollBars = ScrollBars.Vertical;
            Txt_Msg.Size = new Size(291, 235);
            Txt_Msg.TabIndex = 9;
            Txt_Msg.TabStop = false;
            // 
            // Txt_Input
            // 
            Txt_Input.Location = new Point(14, 27);
            Txt_Input.Name = "Txt_Input";
            Txt_Input.Size = new Size(100, 27);
            Txt_Input.TabIndex = 8;
            Txt_Input.KeyDown += Txt_Input_KeyDown;
            // 
            // Frm_DemonstacaoKey_UC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Lbl_Lower);
            Controls.Add(Lbl_Upper);
            Controls.Add(Lbl_Maius);
            Controls.Add(Lbl_Minus);
            Controls.Add(Btn_Reset);
            Controls.Add(Txt_Msg);
            Controls.Add(Txt_Input);
            Name = "Frm_DemonstacaoKey_UC";
            Size = new Size(474, 482);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Lbl_Lower;
        private Label Lbl_Upper;
        private Label Lbl_Maius;
        private Label Lbl_Minus;
        private Button Btn_Reset;
        private TextBox Txt_Msg;
        private TextBox Txt_Input;
    }
}
