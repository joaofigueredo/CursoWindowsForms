namespace CursoWindowsForms
{
    partial class Frm_MouseCaptura
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
            btn_Captura = new Button();
            SuspendLayout();
            // 
            // btn_Captura
            // 
            btn_Captura.Location = new Point(64, 71);
            btn_Captura.Name = "btn_Captura";
            btn_Captura.Size = new Size(542, 272);
            btn_Captura.TabIndex = 0;
            btn_Captura.Text = "button1";
            btn_Captura.UseVisualStyleBackColor = true;
            btn_Captura.MouseDown += btn_Captura_MouseDown;
            // 
            // Frm_MouseCaptura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 400);
            Controls.Add(btn_Captura);
            Name = "Frm_MouseCaptura";
            Text = "Frm_MouseCaptura";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Captura;
    }
}