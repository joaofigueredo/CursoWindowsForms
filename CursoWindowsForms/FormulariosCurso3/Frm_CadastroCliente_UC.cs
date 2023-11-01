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
using CursoWindowsFormsBiblioteca.Classes;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;
using CursoWindowsFormsBiblioteca;

namespace CursoWindowsForms;
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
        Rdb_Masculino.Text = "Masculino";
        Rdb_Feminino.Text = "Feminino";

        Cmb_Estado.Items.Clear();

        string[] lista = { "Acre (AC)", "Alagoas (AL)", "Amapá (AP)", "Amazonas (AM)", "Bahia (BA)", "Ceará (CE)", "Distrito Federal (DF)", "Espírito Santo (ES)", "Goiás (GO)", "Maranhão (MA)", "Mato Grosso (MT)", "Mato Grosso do Sul(MS)", "Minas Gerais(MG)", "Pará(PA)", "Paraíba(PB)", "Paraná(PR)", "Pernambuco(PE)", "Piauí(PI)", "Rio de Janeiro(RJ)", "Rio Grande do Norte(RN)", "Rio Grande do Sul(RS)", "Rondônia(RO)", "Roraima(RR)", "Santa Catarina(SC)", "São Paulo(SP)", "Sergipe(SE)", "Tocantins(TO)" };
        Cmb_Estado.Items.AddRange(lista);

        Tls_Principal.Items[0].ToolTipText = "Criar novo cliente";
        Tls_Principal.Items[1].ToolTipText = "Abrir um cliente existente";
        Tls_Principal.Items[2].ToolTipText = "Salvar cliente selecionado";
        Tls_Principal.Items[3].ToolTipText = "Excluir cliente selecionado";
        Tls_Principal.Items[4].ToolTipText = "Limpar dados da tela";

    }


    private void Chk_TemPai_CheckedChanged(object sender, EventArgs e)
    {
        if (Chk_TemPai.Checked)
        {
            Txt_NomePai.Enabled = false;
            Txt_NomePai.Clear();
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
            Txt_OutroGenero.Focus();
        }
        else
        {
            Txt_OutroGenero.Clear();
            Txt_OutroGenero.Enabled = false;
        }
    }

    private void novaToolStripButton_Click(object sender, EventArgs e)
    {
        try
        {

            Cliente.Unit C = new Cliente.Unit();
            C = LeituraFormulario();

            C.ValidaClasse();
            C.ValidaComplemento();
            MessageBox.Show("Classe inicializada sem erros");
        }
        catch (ValidationException ex)
        {
            MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    Cliente.Unit LeituraFormulario()
    {
        Cliente.Unit C = new Cliente.Unit();

        C.Id = Txt_Codigo.Text;
        C.Nome = Txt_NomeCliente.Text;
        C.NomeMae = Txt_NomeMae.Text;
        C.NomePai = Txt_NomePai.Text;
        if (Chk_TemPai.Checked)
        {
            C.NaoTemPai = true;
        }
        else
        {
            C.NomePai = Txt_NomePai.Text;
            C.NaoTemPai = false;
        }
        if (Rdb_Masculino.Checked)
        {
            C.Genero = 0;
        }
        if (Rdb_Feminino.Checked)
        {
            C.Genero = 1;
        }
        if (Rdb_Outro.Checked)
        {
            C.Genero = 2;
        }
        C.Cpf = Txt_Cpf.Text;
        C.Cep = Txt_Cep.Text;
        C.Logradouro = Txt_Logradouro.Text;
        C.Complemento = Txt_Complemento.Text;
        C.Cidade = Txt_Cidade.Text;
        C.Bairro = Txt_Bairro.Text;

        if (Cmb_Estado.SelectedIndex < 0)
        {
            C.Estado = "";
        }
        else
        {
            C.Estado = Cmb_Estado.Items[Cmb_Estado.SelectedIndex].ToString();
        }

        C.Telefone = Txt_Telefone.Text;
        C.Profissao = Txt_Profissao.Text;
        if (Information.IsNumeric(Txt_RendaFamiliar.Text))
        {
            Double vRenda = Convert.ToDouble(Txt_RendaFamiliar.Text);
            if (vRenda < 0)
            {
                C.RendaFamiliar = 0;
            }
            else
            {
                C.RendaFamiliar = vRenda;
            }
        }
        return C;
    }

    private void abrirToolStripButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Botão abrir clicado!");
    }

    private void salvarToolStripButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Botão salvar clicado!");
    }

    private void apagarToolStripButton1_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Botão excluir clicado!");
    }

    private void limparToolStripButton2_Click(object sender, EventArgs e)
    {
        Txt_Bairro.Clear();
        Txt_Cep.Clear();
        Txt_Cidade.Clear();
        Txt_Codigo.Clear();
        Txt_Complemento.Clear();
        Txt_Cpf.Clear();
        Txt_Logradouro.Clear();
        Txt_NomeCliente.Clear();
        Txt_NomeMae.Clear();
        Txt_NomePai.Clear();
        Txt_OutroGenero.Clear();
        Txt_Profissao.Clear();
        Txt_RendaFamiliar.Clear();
        Txt_Telefone.Clear();
        Cmb_Estado.SelectedIndex = -1;
    }

    private void Txt_Cep_Leave(object sender, EventArgs e)
    {
        string cep = Txt_Cep.Text;
        try
        {
            if (cep != "")
            {
                if(cep.Length == 8)
                {
                    if (Information.IsNumeric(cep))
                    {
                        var vJson = Cls_Uteis.GeraJSONCEP(Txt_Cep.Text);
                        Cep.Unit CEP = new Cep.Unit();
                        CEP = Cep.DesSerializarClasseUnit(vJson);

                        Txt_Logradouro.Text = CEP.logradouro;
                        Txt_Cidade.Text = CEP.localidade;
                        Txt_Bairro.Text = CEP.bairro;

                        Cmb_Estado.SelectedIndex = -1; 

                        for (int i = 0; i < Cmb_Estado.Items.Count; i++)
                        {
                            var vPos = Strings.InStr(Cmb_Estado.Items[i].ToString(), "(" + CEP.uf + ")");
                            if (vPos > 0)
                            {
                                Cmb_Estado.SelectedIndex = i;
                            }
                        }                        
                    }
                }
            }
        }
        catch
        {
            MessageBox.Show("CEP Invalido");
        }
        

        

    }
}