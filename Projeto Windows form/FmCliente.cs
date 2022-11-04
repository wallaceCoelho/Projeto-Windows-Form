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
    public partial class FmCliente : Form
    {
        private void Habilita()
        {
            cd_clienteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nr_casaTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
            nr_telefoneTextBox.Enabled = true;
            cd_cpfTextBox.Enabled = true;
            cd_rgTextBox.Enabled = true;
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
            cd_clienteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nr_casaTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cepTextBox.Enabled = false;
            nr_telefoneTextBox.Enabled = false;
            cd_cpfTextBox.Enabled = false;
            cd_rgTextBox.Enabled = false;
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
        public FmCliente()
        {
            InitializeComponent();
        }

        private void tbClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void FmCliente_Load(object sender, EventArgs e)
        {
            // O método 'Fill()' é um método que subustitua o script do SQL = SELECT * FROM tabela
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.cadastroDataSet.tbCliente);
            Desabilita();

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.AddNew();
            Habilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.RemoveCurrent();
            tbClienteTableAdapter.Update(cadastroDataSet.tbCliente);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbClienteBindingSource.EndEdit();
            tbClienteTableAdapter.Update(cadastroDataSet.tbCliente);
            Desabilita();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
