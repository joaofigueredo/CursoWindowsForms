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
    public partial class Frm_principal : Form
    {
        public Frm_principal()
        {
            InitializeComponent();
        }

        private void Btn_demonstracaoKey_Click(object sender, EventArgs e)
        {
            Frm_DemonstracaoKeys f = new Frm_DemonstracaoKeys();
            f.ShowDialog();

        }

        private void Btn_HelloWorld_Click(object sender, EventArgs e)
        {
            Frm_HelloWorld f = new Frm_HelloWorld();
            f.ShowDialog();
        }

        private void Btn_Mascara_Click(object sender, EventArgs e)
        {
            Frm_Mascara f = new Frm_Mascara();
            f.ShowDialog();
        }

        private void Btn_ValidaCpf_Click(object sender, EventArgs e)
        {
            Frm_ValidaCpf f = new Frm_ValidaCpf();
            f.ShowDialog();
        }

        private void Btn_ValidaCpf2_Click(object sender, EventArgs e)
        {
            Frm_ValidaCpf2 f = new Frm_ValidaCpf2();
            f.ShowDialog();
        }

        private void Btn_ValidaSenha_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha f = new Frm_ValidaSenha();
            f.ShowDialog();
        }
    }
}
