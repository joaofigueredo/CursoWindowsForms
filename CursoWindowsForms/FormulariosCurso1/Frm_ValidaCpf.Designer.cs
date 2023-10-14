namespace CursoWindowsForms
{
    partial class Frm_ValidaCpf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ValidaCpf));
            Msk_CPF = new MaskedTextBox();
            Lbl_Resultado = new Label();
            Btn_Reset = new Button();
            Btn_Valida = new Button();
            SuspendLayout();
            // 
            // Msk_CPF
            // 
            Msk_CPF.BorderStyle = BorderStyle.FixedSingle;
            Msk_CPF.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Msk_CPF.Location = new Point(12, 50);
            Msk_CPF.Mask = "000,000,000-00";
            Msk_CPF.Name = "Msk_CPF";
            Msk_CPF.Size = new Size(218, 27);
            Msk_CPF.TabIndex = 0;
            Msk_CPF.MaskInputRejected += Msk_CPF_MaskInputRejected;
            // 
            // Lbl_Resultado
            // 
            Lbl_Resultado.AutoSize = true;
            Lbl_Resultado.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Resultado.Location = new Point(12, 20);
            Lbl_Resultado.Name = "Lbl_Resultado";
            Lbl_Resultado.Size = new Size(77, 27);
            Lbl_Resultado.TabIndex = 1;
            Lbl_Resultado.Text = "label1";
            Lbl_Resultado.Click += Lbl_Resultado_Click;
            // 
            // Btn_Reset
            // 
            Btn_Reset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Reset.Location = new Point(245, 42);
            Btn_Reset.Name = "Btn_Reset";
            Btn_Reset.Size = new Size(111, 35);
            Btn_Reset.TabIndex = 2;
            Btn_Reset.Text = "Limpa";
            Btn_Reset.UseVisualStyleBackColor = true;
            Btn_Reset.Click += Btn_Reset_Click_1;
            // 
            // Btn_Valida
            // 
            Btn_Valida.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Valida.Location = new Point(245, 83);
            Btn_Valida.Name = "Btn_Valida";
            Btn_Valida.Size = new Size(109, 34);
            Btn_Valida.TabIndex = 3;
            Btn_Valida.Text = "Valida";
            Btn_Valida.UseVisualStyleBackColor = true;
            Btn_Valida.Click += Btn_Valida_Click_1;
            // 
            // Frm_ValidaCpf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 173);
            Controls.Add(Btn_Valida);
            Controls.Add(Btn_Reset);
            Controls.Add(Lbl_Resultado);
            Controls.Add(Msk_CPF);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_ValidaCpf";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validação CPF";
            Load += Frm_ValidaCpf_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox Msk_CPF;
        private Label Lbl_Resultado;
        private Button Btn_Reset;
        private Button Btn_Valida;
    }
}