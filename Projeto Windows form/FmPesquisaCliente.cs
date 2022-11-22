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
    public partial class FmPesquisaCliente : Form
    {
        private int codigo;

        public int GetCodigo()
        {
            return codigo;
        }
        public FmPesquisaCliente()
        {
            InitializeComponent();
        }

        private void tbClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void FmPesquisaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.cadastroDataSet.tbCliente);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbClienteDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tbClienteDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }
    }
}
