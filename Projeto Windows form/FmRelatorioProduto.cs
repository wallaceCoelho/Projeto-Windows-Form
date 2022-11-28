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
    public partial class FmRelatorioProduto : Form
    {
        public FmRelatorioProduto()
        {
            InitializeComponent();
        }

        private void FmRelatorioProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProdutoTableAdapter.Fill(this.cadastroDataSet.tbProduto);

            this.reportViewer1.RefreshReport();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
