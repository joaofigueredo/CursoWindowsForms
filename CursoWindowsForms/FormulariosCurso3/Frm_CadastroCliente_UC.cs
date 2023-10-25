using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CursoWindowsForms
{
    public partial class Frm_CadastroCliente_UC : UserControl
    {
        public Frm_CadastroCliente_UC()
        {
            InitializeComponent();

            Txt_OutroGenero.Enabled = false;

            Lbl_Bairro.Text = "Bairro";
            Lbl_Cep.Text = "CEP";
            Lbl_Complemento.Text = "Complemento";
            Lbl_Cpf.Text = "CPF";
            Cmb_Estado.Text = "Estado";
            Grp_Genero.Text = "Genero";
            Lbl_Logradouro.Text = "Logradouro";
            Lbl_NomeCliente.Text = "Nome do Cliente";
            Lbl_NomeMae.Text = "Nome da Mãe";
            Lbl_NomePai.Text = "Nome do Pai";
            Lbl_Profissao.Text = "Profissão";
            Lbl_RendaFamiliar.Text = "Renda Familiar";
            Lbl_Telefone.Text = "Telefone";
            Grp_Codigo.Text = "Codigo";
            Grp_DadosPessoais.Text = "Dadoes Pessoais";
            Grp_Outros.Text = "Outros";
            Grp_Endereco.Text = "Endereço";
            Lbl_Cidade.Text = "Cidade";
            Chk_TemPai.Text = "Pai desconhecido";

            Cmb_Estado.Items.Clear();

        }

        private void Txt_Cpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Bairro_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Cpf_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Complemento_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Cep_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Profissao_Click(object sender, EventArgs e)
        {

        }

        private void Txt_NomePai_TextChanged(object sender, EventArgs e)
        {

        }

        private void Chk_TemPai_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_TemPai.Checked)
            {
                Txt_NomePai.Enabled = false;
            }
            else
            {
                Txt_NomePai.Enabled = true;
            }
        }

        private void Rdb_Outro_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_Outro.Checked)
            {
                Txt_OutroGenero.Enabled = true;
            }
        }
    }
}
