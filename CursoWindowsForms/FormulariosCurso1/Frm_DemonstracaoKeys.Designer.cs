namespace CursoWindowsForms
{
    partial class Frm_DemonstracaoKeys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DemonstracaoKeys));
            Txt_Input = new TextBox();
            Txt_Msg = new TextBox();
            Btn_Reset = new Button();
            Lbl_Minus = new Label();
            Lbl_Maius = new Label();
            Lbl_Upper = new Label();
            Lbl_Lower = new Label();
            Btn_Sair = new Button();
            SuspendLayout();
            // 
            // Txt_Input
            // 
            Txt_Input.Location = new Point(8, 8);
            Txt_Input.Name = "Txt_Input";
            Txt_Input.Size = new Size(100, 27);
            Txt_Input.TabIndex = 0;
            Txt_Input.KeyDown += Txt_Input_KeyDown;
            // 
            // Txt_Msg
            // 
            Txt_Msg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Txt_Msg.Location = new Point(8, 40);
            Txt_Msg.Multiline = true;
            Txt_Msg.Name = "Txt_Msg";
            Txt_Msg.ScrollBars = ScrollBars.Vertical;
            Txt_Msg.Size = new Size(267, 235);
            Txt_Msg.TabIndex = 1;
            Txt_Msg.TabStop = false;
            Txt_Msg.TextChanged += Txt_Msg_TextChanged;
            // 
            // Btn_Reset
            // 
            Btn_Reset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Reset.Location = new Point(318, 8);
            Btn_Reset.Name = "Btn_Reset";
            Btn_Reset.Size = new Size(75, 28);
            Btn_Reset.TabIndex = 2;
            Btn_Reset.Text = "Limpar";
            Btn_Reset.UseVisualStyleBackColor = true;
            Btn_Reset.Click += Btn_Reset_Click;
            // 
            // Lbl_Minus
            // 
            Lbl_Minus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_Minus.Location = new Point(286, 104);
            Lbl_Minus.Name = "Lbl_Minus";
            Lbl_Minus.Size = new Size(48, 20);
            Lbl_Minus.TabIndex = 3;
            Lbl_Minus.Text = "Minus";
            // 
            // Lbl_Maius
            // 
            Lbl_Maius.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_Maius.AutoSize = true;
            Lbl_Maius.Location = new Point(286, 56);
            Lbl_Maius.Name = "Lbl_Maius";
            Lbl_Maius.Size = new Size(48, 20);
            Lbl_Maius.TabIndex = 4;
            Lbl_Maius.Text = "Maius";
            // 
            // Lbl_Upper
            // 
            Lbl_Upper.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_Upper.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Upper.Location = new Point(331, 56);
            Lbl_Upper.Name = "Lbl_Upper";
            Lbl_Upper.Size = new Size(62, 23);
            Lbl_Upper.TabIndex = 5;
            Lbl_Upper.Click += Lbl_Upper_Click;
            // 
            // Lbl_Lower
            // 
            Lbl_Lower.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_Lower.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Lower.Location = new Point(331, 104);
            Lbl_Lower.Name = "Lbl_Lower";
            Lbl_Lower.Size = new Size(62, 25);
            Lbl_Lower.TabIndex = 6;
            // 
            // Btn_Sair
            // 
            Btn_Sair.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Sair.Location = new Point(318, 244);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(75, 28);
            Btn_Sair.TabIndex = 7;
            Btn_Sair.Text = "Sair";
            Btn_Sair.UseVisualStyleBackColor = true;
            Btn_Sair.Click += Btn_Sair_Click;
            // 
            // Frm_DemonstracaoKeys
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 276);
            Controls.Add(Btn_Sair);
            Controls.Add(Lbl_Lower);
            Controls.Add(Lbl_Upper);
            Controls.Add(Lbl_Maius);
            Controls.Add(Lbl_Minus);
            Controls.Add(Btn_Reset);
            Controls.Add(Txt_Msg);
            Controls.Add(Txt_Input);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_DemonstracaoKeys";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_NovoFormulario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_Input;
        private TextBox Txt_Msg;
        private Button Btn_Reset;
        private Label Lbl_Minus;
        private Label Lbl_Maius;
        private Label Lbl_Upper;
        private Label Lbl_Lower;
        private Button Btn_Sair;
    }
}