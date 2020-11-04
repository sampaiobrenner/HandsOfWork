using System;
using System.Windows.Forms;

namespace HandsOfWork.Views
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnListagemClientes_Click(object sender, EventArgs e)
        {
            var formCliente = new FormCliente();
            formCliente.ShowDialog();
        }

        private void btnListagemProdutos_Click(object sender, EventArgs e)
        {
            var formProduto = new FormProduto();
            formProduto.ShowDialog();
        }
    }
}