using CursoWindowsFormsBiblioteca.DataBases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Busca : Form
    {
        List<List<string>> _ListaBusca = new List<List<string>>();
        public string IdSelect { get; set; }

        public Frm_Busca(List<List<string>> Lista)
        {
            _ListaBusca = Lista;
            InitializeComponent();

            this.Text = "Busca";
            Tls_Principal.Items[0].ToolTipText = "Salvar a seleção";
            Tls_Principal.Items[1].ToolTipText = "Fechar a seleção";

            PreencherLista();
            lst_Busca.Sorted = true;
        }

        private void PreencherLista()
        {
            lst_Busca.Items.Clear();
            for (int i = 0; i <= _ListaBusca.Count - 1; i++)
            {
                ItemBox item = new ItemBox();
                item.id = _ListaBusca[i][0];
                item.nome = _ListaBusca[i][1];
                lst_Busca.Items.Add(item);
            }
        }

        private void apagarToolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ItemBox itemSelecionado = new ItemBox();
            itemSelecionado = (ItemBox)lst_Busca.Items[lst_Busca.SelectedIndex];
            IdSelect = itemSelecionado.id;
            this.Close();
        }

        class ItemBox
        {
            public string id { get; set; }
            public string nome{ get; set; }

            public override string ToString()
            {
                return nome;
            }
        }
    }
}