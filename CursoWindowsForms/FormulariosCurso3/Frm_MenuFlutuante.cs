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
    public partial class Frm_MenuFlutuante : Form
    {
        public Frm_MenuFlutuante()
        {
            InitializeComponent();
        }

        private void Frm_MenuFlutuante_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                var posicaoX = e.X;
                var posicaoY = e.Y;

                var ContextMenu = new ContextMenuStrip();

                var vToolTip01 = DesenhaItemMenu("Item do menu 1", "key");
                var vToolTip02 = DesenhaItemMenu("Item do menu 2", "key");


                //Criando item de menu utilizando uma classe
                ContextMenu.Items.Add(vToolTip01);
                ContextMenu.Items.Add(vToolTip02);


                ContextMenu.Show(this, new Point(posicaoX, posicaoY));
                vToolTip01.Click += vToolTip01_Click;
                vToolTip02.Click += vToolTip02_Click;
            }

            //Ação dos itens do toolStrip
            void vToolTip01_Click(object sender, EventArgs e)
            {
                lbl_fla.BackColor = Color.Red;
            }

            void vToolTip02_Click(object sender, EventArgs e)
            {

            }

            ToolStripMenuItem DesenhaItemMenu(string texto, string nomeImagem)
            {
                var vToolTip = new ToolStripMenuItem();
                vToolTip.Text = texto;

                Image MyImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
                vToolTip.Image = MyImage;

                return vToolTip;
            }

        }
    }
}
