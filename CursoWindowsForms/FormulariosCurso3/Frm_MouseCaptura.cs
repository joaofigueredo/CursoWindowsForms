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
    public partial class Frm_MouseCaptura : Form
    {
        public Frm_MouseCaptura()
        {
            InitializeComponent();
        }

        private void btn_Captura_MouseDown(object sender, MouseEventArgs e)
        {
            //pegar o que foi feito no mouse
            string str1 = e.Button.ToString();
            MessageBox.Show("Foi pressionado o botão: " + str1);
        }
    }
}
