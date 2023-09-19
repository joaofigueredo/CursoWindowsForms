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
    public partial class Frm_DemonstracaoKeys : Form
    {
        public Frm_DemonstracaoKeys()
        {
            InitializeComponent();
        }

        private void Lbl_Upper_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Msg_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {

            Txt_Input.Clear();
            Txt_Msg.Clear();
        }

        private void Txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            Txt_Msg.AppendText("\r\n" + "Pressionei uma tecla: " + e.KeyCode + "\r\n");
            Txt_Msg.AppendText("\t" + "Codigo da tecla: " + ((int)e.KeyCode) + "\r\n");

            Lbl_Upper.Text = e.KeyCode.ToString().ToUpper();
            Lbl_Lower.Text = e.KeyCode.ToString().ToLower();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
