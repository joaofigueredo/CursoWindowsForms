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
    public partial class Frm_Celular : Form
    {
        public Frm_Celular()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Frm_Celular_Load(object sender, EventArgs e)
        {
            Msk_Celular.Focus();
        }

        private void Btn_validaCelular_Click(object sender, EventArgs e)
        {
            
            string vConteudo;
            vConteudo = Msk_Celular.Text;
            vConteudo = vConteudo.Replace("(", "").Replace(")", "").Replace("-", "");
            vConteudo = vConteudo.Trim();

            if (vConteudo == "")
            {
                MessageBox.Show("Digite um número", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (vConteudo.Length < 11)
            {
                MessageBox.Show("Um numero de celular tem 11 digitos", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (vConteudo.Length == 11)
            {
                MessageBox.Show("Numero Válido!", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
