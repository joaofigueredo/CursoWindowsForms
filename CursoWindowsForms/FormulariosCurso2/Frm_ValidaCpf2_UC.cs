using CursoWindowsFormsBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaCpf2_UC : UserControl
    {
        public Frm_ValidaCpf2_UC()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            string vConteudo;
            vConteudo = Msk_CPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "");
            vConteudo = vConteudo.Trim();

            if (vConteudo == "")
            {
                MessageBox.Show("Você deve digitar um CPF", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (vConteudo.Length < 11)
                {
                    MessageBox.Show("Cpf deve ter 11 digitos", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Frm_Questao db = new Frm_Questao("confuso1", "flamengo");
                    db.ShowDialog();
                    //if (MessageBox.Show("Você deseja realmente validar o CPF", "Mensagem de validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                        if (db.DialogResult == DialogResult.Yes)
                    {
                        bool validaCPF = false;
                        validaCPF = Cls_Uteis.Valida(Msk_CPF.Text);
                        if (validaCPF == true)
                        {
                            MessageBox.Show("CPF Válido", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cpf Inválido", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Msk_CPF.Clear();
                            Msk_CPF.Focus();
                        }
                    }
                }
            }
        }

        private void Frm_ValidaCpf2_UC_Load(object sender, EventArgs e)
        {
            Msk_CPF.Focus();

        }
    }
}
