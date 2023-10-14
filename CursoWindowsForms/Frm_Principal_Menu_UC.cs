﻿using System;
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
    public partial class Frm_Principal_Menu_UC : Form
    {
        int ControleHelloWorld = 0;
        int ControleDemonstracaoKeys = 0;
        int ControleMascara = 0;
        int ControleValidaCpf1 = 0;
        int ControleValidaCpf2 = 0;
        int ControleValidaSenha = 0;
        int ControleArquivoImagem = 0;
        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();

            formulárioToolStripMenuItem.Enabled = false;
            apagarToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;

        }

        private void formulárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleDemonstracaoKeys++;
            Frm_DemonstacaoKey_UC Uc = new Frm_DemonstacaoKey_UC();
            Uc.Dock = DockStyle.Fill;
            TabPage Tb = new TabPage();
            Tb.Name = "Demonstração Keys";
            Tb.Text = "Demonstração Keys " + ControleDemonstracaoKeys;
            Tb.ImageIndex = 0;
            Tb.Controls.Add(Uc);
            Tbc_Aplicacoes.TabPages.Add(Tb);
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWorld++;
            Frm_HelloWorld_UC Uc = new Frm_HelloWorld_UC();
            Uc.Dock = DockStyle.Fill;
            TabPage Tb = new TabPage();
            Tb.Name = "Hello World";
            Tb.Text = "Hello World " + ControleHelloWorld;
            Tb.ImageIndex = 1;
            Tb.Controls.Add(Uc);
            Tbc_Aplicacoes.TabPages.Add(Tb);
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleMascara++;
            Frm_Mascara_UC Uc = new Frm_Mascara_UC();
            Uc.Dock = DockStyle.Fill;
            TabPage Tb = new TabPage();
            Tb.Name = "Mascara";
            Tb.Text = "Mascara " + ControleMascara;
            Tb.ImageIndex = 2;
            Tb.Controls.Add(Uc);
            Tbc_Aplicacoes.TabPages.Add(Tb);
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCpf1++;
            Frm_ValidaCpf1_UC Uc = new Frm_ValidaCpf1_UC();
            Uc.Dock = DockStyle.Fill;
            TabPage Tb = new TabPage();
            Tb.Name = "Valida CPF";
            Tb.Text = "Valida Cpf (" + ControleValidaCpf1 + ")";
            Tb.ImageIndex = 3;
            Tb.Controls.Add(Uc);
            Tbc_Aplicacoes.TabPages.Add(Tb);
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCpf2++;
            Frm_ValidaCpf2_UC Uc = new Frm_ValidaCpf2_UC();
            Uc.Dock = DockStyle.Fill;
            TabPage Tb = new TabPage();
            Tb.Name = "Valida CPF2";
            Tb.Text = "Valida Cpf2 (" + ControleValidaCpf2 + ")";
            Tb.ImageIndex = 4;
            Tb.Controls.Add(Uc);
            Tbc_Aplicacoes.TabPages.Add(Tb);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaSenha++;
            Frm_ValidaSenha_UC Uc = new Frm_ValidaSenha_UC();
            Uc.Dock = DockStyle.Fill;
            TabPage Tb = new TabPage();
            Tb.Name = "Valida Senha";
            Tb.Text = "Valida Senha (" + ControleValidaSenha + ")";
            Tb.ImageIndex = 5;
            Tb.Controls.Add(Uc);
            Tbc_Aplicacoes.TabPages.Add(Tb);
        }

        private void celularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Celular F = new Frm_Celular();
            F.ShowDialog();
        }

        private void arquivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhuma aba aberta");
            }

        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Db = new OpenFileDialog();
            Db.InitialDirectory = "C:\\Users\\joaof\\OneDrive\\Documentos\\Alura\\Windows forms\\CursoWindowsForms-Parte2\\CursoWindowsForms\\Imagens";
            Db.Filter = "PNG|*.PNG";
            Db.Title = "Escolha a imagem";

            if (Db.ShowDialog() == DialogResult.OK)
            {
                string nomeImagem = Db.FileName;

                ControleArquivoImagem++;
                Frm_ArquivoImg_UC Uc = new Frm_ArquivoImg_UC(nomeImagem);
                Uc.Dock = DockStyle.Fill;
                TabPage Tb = new TabPage();
                Tb.Name = "Aquivo Imagem";
                Tb.Text = "Arquivo Imagem (" + ControleArquivoImagem + ")";
                Tb.ImageIndex = 6;
                Tb.Controls.Add(Uc);
                Tbc_Aplicacoes.TabPages.Add(Tb);
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login();
            login.ShowDialog();

            if (login.DialogResult == DialogResult.OK)
            {
                string senha = login.senha;
                string usuario = login.login;
                
                if(CursoWindowsFormsBiblioteca.Cls_Uteis.ValidaSenhaLogin(senha) == true)
                {
                    formulárioToolStripMenuItem.Enabled = true;
                    apagarToolStripMenuItem.Enabled = true;
                    abrirImagemToolStripMenuItem.Enabled = true;
                    conectarToolStripMenuItem.Enabled = false;
                    desconectarToolStripMenuItem.Enabled = true;

                    MessageBox.Show("Bem vindo " + usuario + "! ", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Senha invalida" + login + " !", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Questao Db = new Frm_Questao("confuso1", "Voce deseja desconectar?");
            Db.ShowDialog();

            if (Db.DialogResult == DialogResult.Yes)
            {
                //Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);

                for(int i = Tbc_Aplicacoes.TabPages.Count - 1; i >=0 ; i--)
                {
                    Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.TabPages[i]);
                }


                formulárioToolStripMenuItem.Enabled = false;
                apagarToolStripMenuItem.Enabled = false;
                abrirImagemToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
                desconectarToolStripMenuItem.Enabled = false;
            }
            
        }
    }
}
