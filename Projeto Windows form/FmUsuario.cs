using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Windows_form
{
    public partial class FmUsuario : Form
    {
        private void Habilita()
        {
            cd_usuarioTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = true;
            sg_nivelTextBox.Enabled = true;
            nm_loginTextBox.Enabled = true;
            cd_senhaTextBox.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            btnAnterior.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
            btnProximo.Enabled = false;
        }

        private void Desabilita()
        {
            cd_usuarioTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = false;
            sg_nivelTextBox.Enabled = false;
            nm_loginTextBox.Enabled = false;
            cd_senhaTextBox.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNovo.Enabled = true;
            btnAnterior.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
            btnProximo.Enabled = true;
        }
        public FmUsuario()
        {
            InitializeComponent();
        }

        private void tbUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void FmUsuario_Load(object sender, EventArgs e)
        {
            // O método 'Fill()' é um método que subustitua o script do SQL = SELECT * FROM tabela
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.cadastroDataSet.tbUsuario);
            Desabilita();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.AddNew();
            Habilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.RemoveCurrent();
            tbUsuarioTableAdapter.Update(cadastroDataSet.tbUsuario);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (nm_loginTextBox.Text == "" && nm_usuarioTextBox.Text == "" 
                && sg_nivelTextBox.Text == "" && cd_senhaTextBox.Text == "")
            {
                MessageBox.Show("Preencha todos os compos !!!");
                nm_loginTextBox.Focus();
            }
            else
            {
                Validate();
                tbUsuarioBindingSource.EndEdit();
                tbUsuarioTableAdapter.Update(cadastroDataSet.tbUsuario);
                Desabilita();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int codigo, reg;

            FmPesquisaUsuario fpu = new FmPesquisaUsuario();
            fpu.ShowDialog();
            codigo = fpu.GetCodigo();

            if (codigo > 0)
            {
                reg = tbUsuarioBindingSource.Find("cd_usuario", codigo);
                tbUsuarioBindingSource.Position = reg;
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE USUÁRIOS" + (char)10 + (char)10;
            objImpressao.DrawString(strDados, new Font("Arial", 20, FontStyle.Bold), Brushes.Red, 300, 50);

            strDados = "Código: " + cd_usuarioTextBox.Text + (char)10;
            strDados += "Nome: " + nm_usuarioTextBox.Text + (char)10;
            strDados += "Nível: " + sg_nivelTextBox.Text + (char)10;
            strDados += "Login: " + nm_loginTextBox.Text;

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 120);
            objImpressao.DrawLine(new Pen(Brushes.Black), 50, 80, 800, 80);
        }
    }
}
