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
    public partial class FmPesquisaFornecedor : Form
    {
        private int codigo = 0;

        public int GetCodigo()
        {
            return codigo;
        }

        public FmPesquisaFornecedor()
        {
            InitializeComponent();
        }

        private void tbFornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbFornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void FmPesquisaFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbFornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFornecedorTableAdapter.Fill(this.cadastroDataSet.tbFornecedor);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void tbFornecedorDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tbFornecedorDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                this.tbFornecedorTableAdapter.Fill(this.cadastroDataSet.tbFornecedor);
            } 
            else
            {
                this.tbFornecedorTableAdapter.FillByNome(this.cadastroDataSet.tbFornecedor, "%" + txtPesquisa.Text + "%");
            }
        }
    }
}
