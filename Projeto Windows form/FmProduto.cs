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
            Validate();
            tbProdutoBindingSource.EndEdit();
            tbProdutoTableAdapter.Update(cadastroDataSet.tbProduto);
            Desabilita();
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
    }
}
