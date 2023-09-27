namespace CursoWindowsForms
{
    partial class Frm_Celular
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
            Btn_validaCelular = new Button();
            Msk_Celular = new MaskedTextBox();
            SuspendLayout();
            // 
            // Btn_validaCelular
            // 
            Btn_validaCelular.Location = new Point(12, 105);
            Btn_validaCelular.Name = "Btn_validaCelular";
            Btn_validaCelular.Size = new Size(94, 29);
            Btn_validaCelular.TabIndex = 0;
            Btn_validaCelular.Text = "Valida";
            Btn_validaCelular.UseVisualStyleBackColor = true;
            Btn_validaCelular.Click += Btn_validaCelular_Click;
            // 
            // Msk_Celular
            // 
            Msk_Celular.BorderStyle = BorderStyle.FixedSingle;
            Msk_Celular.Location = new Point(12, 41);
            Msk_Celular.Mask = "(00)00000-0000";
            Msk_Celular.Name = "Msk_Celular";
            Msk_Celular.Size = new Size(124, 27);
            Msk_Celular.TabIndex = 1;
            Msk_Celular.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // Frm_Celular
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Msk_Celular);
            Controls.Add(Btn_validaCelular);
            Name = "Frm_Celular";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Celular";
            Load += Frm_Celular_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_validaCelular;
        private MaskedTextBox Msk_Celular;
    }
}