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
    public partial class FmProduto : Form
    {
        private void Habilita()
        {
            cd_produtoTextBox.Enabled = false;
            nm_produtoTextBox.Enabled = true;
            sg_unidadeTextBox.Enabled = true;
            vl_custoTextBox.Enabled = true;
            vl_vendaTextBox.Enabled = true;
            qt_estoqueTextBox.Enabled = true;
            cd_fornecedorTextBox.Enabled = true;
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
            cd_produtoTextBox.Enabled = false;
            nm_produtoTextBox.Enabled = false;
            sg_unidadeTextBox.Enabled = false;
            vl_custoTextBox.Enabled = false;
            vl_vendaTextBox.Enabled = false;
            qt_estoqueTextBox.Enabled = false;
            cd_fornecedorTextBox.Enabled = false;
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
        public FmProduto()
        {
            InitializeComponent();
        }

        private void FmProduto_Load(object sender, EventArgs e)
        {
            // O método 'Fill()' é um método que subustitua o script do SQL = SELECT * FROM tabela
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProdutoTableAdapter.Fill(this.cadastroDataSet.tbProduto);
            Desabilita();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.AddNew();
            Habilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.RemoveCurrent();
            tbProdutoTableAdapter.Update(cadastroDataSet.tbProduto);
            Desabilita();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (nm_produtoTextBox.Text == "" && sg_unidadeTextBox.Text == ""
                && vl_custoTextBox.Text == "" && cd_fornecedorTextBox.Text == "")
            {
                MessageBox.Show("Preencha todos os campos !!!");
                nm_produtoTextBox.Focus();
            }
            else
            {
                Validate();
                tbProdutoBindingSource.EndEdit();
                tbProdutoTableAdapter.Update(cadastroDataSet.tbProduto);
                Desabilita()
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int codigo, reg;

            FmPesquisaProduto fpp = new FmPesquisaProduto();
            fpp.ShowDialog();
            codigo = fpp.GetCodigo();

            if (codigo > 0)
            {
                reg = tbProdutoBindingSource.Find("cd_produto", codigo);
                tbProdutoBindingSource.Position = reg;
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

            strDados = "FICHA DE PRODUTOS" + (char)10 + (char)10;
            objImpressao.DrawString(strDados, new Font("Arial", 20, FontStyle.Bold), Brushes.Red, 300, 50);

            strDados = "Código: " + cd_produtoTextBox.Text + (char)10;
            strDados += "Descrição: " + nm_produtoTextBox.Text + (char)10;
            strDados += "Unidade: " + sg_unidadeTextBox.Text + (char)10;
            strDados += "Quantidade em estoque: " + qt_estoqueTextBox.Text + (char)10;
            strDados += "Preço de custo: " + vl_custoTextBox.Text + (char)10;
            strDados += "Preço de venda: " + vl_vendaTextBox.Text;

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 120);
            objImpressao.DrawLine(new Pen(Brushes.Black), 50, 80, 800, 80);
        }
    }
}
