namespace CursoWindowsForms
{
    partial class Frm_MouseEventos
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
            Btn_Mouse = new Button();
            SuspendLayout();
            // 
            // Btn_Mouse
            // 
            Btn_Mouse.Location = new Point(61, 116);
            Btn_Mouse.Name = "Btn_Mouse";
            Btn_Mouse.Size = new Size(421, 219);
            Btn_Mouse.TabIndex = 0;
            Btn_Mouse.UseVisualStyleBackColor = true;
            Btn_Mouse.MouseDown += Btn_Mouse_MouseDown;
            Btn_Mouse.MouseEnter += Btn_Mouse_MouseEnter;
            Btn_Mouse.MouseLeave += Btn_Mouse_MouseLeave;
            Btn_Mouse.MouseHover += Btn_Mouse_MouseHover;
            Btn_Mouse.MouseUp += Btn_Mouse_MouseUp;
            // 
            // Frm_MouseEventos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 465);
            Controls.Add(Btn_Mouse);
            Name = "Frm_MouseEventos";
            Text = "Frm_MouseEventos";
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_Mouse;
    }
}