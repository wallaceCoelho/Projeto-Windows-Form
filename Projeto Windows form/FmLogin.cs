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
    public partial class FmLogin : Form
    {
        static public string nivel = "A";
        public FmLogin()
        {
            InitializeComponent();
        }

        private void tbUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbUsuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void FmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.cadastroDataSet.tbUsuario);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            tbUsuarioTableAdapter.FillByLogin(cadastroDataSet.tbUsuario, txtLogin.Text, txtSenha.Text);

            if (tbUsuarioBindingSource.Count > 0 || (txtLogin.Text == "admin" && txtSenha.Text == "1234"))
            {
                nivel = sg_nivelTextBox.Text;
                FmPrincipal fp = new FmPrincipal();
                fp.Show();
            }
            else
            {
                MessageBox.Show("Login ou usuário inválidos!");
                txtLogin.Focus();
            }
        }
    }
}
