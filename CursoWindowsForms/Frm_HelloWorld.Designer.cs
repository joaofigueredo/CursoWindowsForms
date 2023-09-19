namespace CursoWindowsForms
{
    partial class Frm_HelloWorld
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HelloWorld));
            lbl_Titulo = new Label();
            Btn_Sair = new Button();
            Btn_modificaLabel = new Button();
            txt_ConteudoLabel = new TextBox();
            SuspendLayout();
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Titulo.Location = new Point(106, 32);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(299, 35);
            lbl_Titulo.TabIndex = 0;
            lbl_Titulo.Text = "Curso de Windows Forms";
            lbl_Titulo.Click += lbl_Titulo_Click;
            // 
            // Btn_Sair
            // 
            Btn_Sair.Location = new Point(592, 365);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(166, 29);
            Btn_Sair.TabIndex = 1;
            Btn_Sair.Text = "Sair da aplicação";
            Btn_Sair.UseVisualStyleBackColor = true;
            Btn_Sair.Click += Btn_Sair_Click;
            // 
            // Btn_modificaLabel
            // 
            Btn_modificaLabel.Location = new Point(202, 89);
            Btn_modificaLabel.Name = "Btn_modificaLabel";
            Btn_modificaLabel.Size = new Size(94, 29);
            Btn_modificaLabel.TabIndex = 2;
            Btn_modificaLabel.Text = "Modifica Label";
            Btn_modificaLabel.UseVisualStyleBackColor = true;
            Btn_modificaLabel.Click += Btn_modificaLabel_Click;
            // 
            // txt_ConteudoLabel
            // 
            txt_ConteudoLabel.BorderStyle = BorderStyle.FixedSingle;
            txt_ConteudoLabel.Location = new Point(12, 146);
            txt_ConteudoLabel.Name = "txt_ConteudoLabel";
            txt_ConteudoLabel.Size = new Size(536, 27);
            txt_ConteudoLabel.TabIndex = 3;
            // 
            // Frm_HelloWorld
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_ConteudoLabel);
            Controls.Add(Btn_modificaLabel);
            Controls.Add(Btn_Sair);
            Controls.Add(lbl_Titulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_HelloWorld";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Titulo;
        private Button Btn_Sair;
        private Button Btn_modificaLabel;
        private TextBox txt_ConteudoLabel;
    }
}