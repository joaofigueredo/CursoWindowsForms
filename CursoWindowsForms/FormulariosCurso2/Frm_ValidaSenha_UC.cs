using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CursoWindowsFormsBiblioteca.Cls_Uteis;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaSenha_UC : UserControl
    {
        bool VerSenhaTxt = false;
        public Frm_ValidaSenha_UC()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Senha.Clear();
            Lbl_Result.Text = "";
        }


        private void Btn_VerSenha_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                //\0 é um caractere vazio
                Txt_Senha.PasswordChar = '\0';
                VerSenhaTxt = true;
                Btn_VerSenha.Text = "Esconder senha";
            }
            else
            {
                Txt_Senha.PasswordChar = '*';
                VerSenhaTxt = false;
                Btn_VerSenha.Text = "Ver senha";
            }
        }
        

        private void Frm_ValidaSenha_UC_KeyDown(object sender, KeyEventArgs e)
        {

            ChecaForcaSenha verifica = new ChecaForcaSenha();

            ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(Txt_Senha.Text);

            Lbl_Result.Text = forca.ToString();

            if (Lbl_Result.Text == "Inaceitavel" || Lbl_Result.Text == "Fraca")
            {
                Lbl_Result.ForeColor = Color.Red;
            }
            else if (Lbl_Result.Text == "Aceitavel")
            {
                Lbl_Result.ForeColor = Color.Blue;
            }
            else if (Lbl_Result.Text == "Forte" || Lbl_Result.Text == "Segura")
            {
                Lbl_Result.ForeColor = Color.Green;
            }
        }
    }
}
