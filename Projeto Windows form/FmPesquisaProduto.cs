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
    public partial class FmPesquisaProduto : Form
    {
        private int codigo = 0;

        public int GetCodigo()
        {
            return codigo;
        }

        public FmPesquisaProduto()
        {
            InitializeComponent();
        }

        private void tbProdutoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbProdutoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void FmPesquisaProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProdutoTableAdapter.Fill(this.cadastroDataSet.tbProduto);

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                this.tbProdutoTableAdapter.Fill(this.cadastroDataSet.tbProduto);
            }
            else
            {
                this.tbProdutoTableAdapter.FillByNome(this.cadastroDataSet.tbProduto, "%" + txtPesquisa.Text + "%");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void tbProdutoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tbProdutoDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }
    }
}
