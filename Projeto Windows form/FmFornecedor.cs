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
    public partial class FmFornecedor : Form
    {
        private bool ValidaCnpj(string cnpj)
        {
            bool resp = false;
            int digito01 = 0, digito02 = 0;

            digito01 += int.Parse(cnpj.Substring(10, 1)) * 2;
            digito01 += int.Parse(cnpj.Substring(9, 1)) * 3;
            digito01 += int.Parse(cnpj.Substring(8, 1)) * 4;
            digito01 += int.Parse(cnpj.Substring(6, 1)) * 5;
            digito01 += int.Parse(cnpj.Substring(5, 1)) * 6;
            digito01 += int.Parse(cnpj.Substring(4, 1)) * 7;
            digito01 += int.Parse(cnpj.Substring(2, 1)) * 8;
            digito01 += int.Parse(cnpj.Substring(1, 1)) * 9;
            digito01 += int.Parse(cnpj.Substring(0, 1)) * 10;

            digito01 %= 11;

            if (digito01 < 2)
            {
                digito01 = 0;
            }
            else
            {
                digito01 = 11 - digito01;
            }

            digito02 += int.Parse(cnpj.Substring(12, 1)) * 2;
            digito02 += int.Parse(cnpj.Substring(10, 1)) * 3;
            digito02 += int.Parse(cnpj.Substring(9, 1)) * 4;
            digito02 += int.Parse(cnpj.Substring(8, 1)) * 5;
            digito02 += int.Parse(cnpj.Substring(6, 1)) * 6;
            digito02 += int.Parse(cnpj.Substring(5, 1)) * 7;
            digito02 += int.Parse(cnpj.Substring(4, 1)) * 8;
            digito02 += int.Parse(cnpj.Substring(2, 1)) * 9;
            digito02 += int.Parse(cnpj.Substring(1, 1)) * 10;
            digito02 += int.Parse(cnpj.Substring(0, 1)) * 11;


            if (digito02 < 2)
            {
                digito02 = 0;
            }
            else
            {
                digito02 = 11 - digito02;
            }

            if (cnpj.Substring(12, 1) == digito01.ToString()
                && cnpj.Substring(13, 1) == digito02.ToString())
            {
                resp = true;
            }

            return resp;
        }
        private void Habilita()
        {
            cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nr_numeroTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
            nr_telefoneTextBox.Enabled = true;
            cd_cnpjMaskedTextBox.Enabled = true;
            cd_ieTextBox.Enabled = true;
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
            cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nr_numeroTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cepTextBox.Enabled = false;
            nr_telefoneTextBox.Enabled = false;
            cd_cnpjMaskedTextBox.Enabled = false;
            cd_ieTextBox.Enabled = false;
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

        public FmFornecedor()
        {
            InitializeComponent();
        }
        private void tbFornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbFornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFornecedorTableAdapter.Fill(this.cadastroDataSet.tbFornecedor);
            Desabilita();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.AddNew();
            Habilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.RemoveCurrent();
            tbFornecedorTableAdapter.Update(cadastroDataSet.tbFornecedor);
            Desabilita();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCnpj(cd_cnpjMaskedTextBox.Text))
            {
            Validate();
            tbFornecedorBindingSource.EndEdit();
            tbFornecedorTableAdapter.Update(cadastroDataSet.tbFornecedor);
            Desabilita();
            }
            else
            {
                MessageBox.Show("CNPJ inválido !!!");
                cd_cnpjMaskedTextBox.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int codigo, reg;

            FmPesquisaFornecedor fpf = new FmPesquisaFornecedor();
            fpf.ShowDialog();
            codigo = fpf.GetCodigo();

            if (codigo > 0)
            {
                reg = tbFornecedorBindingSource.Find("cd_fornecedor", codigo);
                tbFornecedorBindingSource.Position = reg;
            }
        }
    }
}
