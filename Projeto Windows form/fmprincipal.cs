using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Projeto_Windows_form
{
    public partial class FmPrincipal : Form
    {
        public FmPrincipal()
        {
            InitializeComponent();
            FmSplashScreen frmSplashScreen = new FmSplashScreen();
            frmSplashScreen.Show();
            Thread.Sleep(3000);
            frmSplashScreen.Close();   
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmUsuario fu = new FmUsuario();
            fu.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmCliente fc = new FmCliente();
            fc.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmProduto fp = new FmProduto();
            fp.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmFornecedor ff = new FmFornecedor();
            ff.ShowDialog();
        }

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (FmLogin.nivel == "A")
            {
                FmRelatorioUsuario fru = new FmRelatorioUsuario();
                fru.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não tem autorização para acessar esta página!");
            }
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FmRelatorioCliente frc = new FmRelatorioCliente();
            frc.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FmRelatorioFornecedor frf = new FmRelatorioFornecedor();
            frf.ShowDialog();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FmRelatorioProduto frp = new FmRelatorioProduto();
            frp.ShowDialog();
        }

        private void FmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
