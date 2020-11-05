using System;
using System.Windows.Forms;
using HandsOfWork.Entities;

namespace HandsOfWork.Views
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var formCadastroCliente = new FormCadastroCliente(ModoOperacao.Adicionar);
            formCadastroCliente.ShowDialog();
        }
    }
}