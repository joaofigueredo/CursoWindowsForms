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
    public partial class Frm_ArquivoImg_UC : UserControl
    {
        public Frm_ArquivoImg_UC(string nomeImagem)
        {
            InitializeComponent();
            Lbl_ArquivoImagem.Text = nomeImagem;
            pic_ArquivoImagem.ImageLocation = nomeImagem;
        }

        private void btn_Cor_Click(object sender, EventArgs e)
        {
            ColorDialog Cdb = new ColorDialog();
            if (Cdb.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArquivoImagem.ForeColor = Cdb.Color;
            }
        }

        private void btn_Font_Click(object sender, EventArgs e)
        {
            FontDialog Fdb = new FontDialog();
            if (Fdb.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArquivoImagem.Font = Fdb.Font;
            }
        }
    }
}