namespace CursoWindowsForms
{
    partial class Frm_MenuFlutuante
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
            lbl_fla = new Label();
            SuspendLayout();
            // 
            // lbl_fla
            // 
            lbl_fla.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_fla.Location = new Point(109, 110);
            lbl_fla.Name = "lbl_fla";
            lbl_fla.Size = new Size(203, 63);
            lbl_fla.TabIndex = 0;
            lbl_fla.Text = "FLamengo";
            // 
            // Frm_MenuFlutuante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_fla);
            Name = "Frm_MenuFlutuante";
            Text = "Frm_MenuFlutuante";
            MouseDown += Frm_MenuFlutuante_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_fla;
    }
}