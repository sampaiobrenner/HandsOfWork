using System;
using System.Windows.Forms;

namespace HandsOfWork.Views.Clientes
{
    public partial class FormCliente : Form
    {
        private readonly FormCadastroCliente _formCadastroCliente;

        public FormCliente(FormCadastroCliente formCadastroCliente)
        {
            _formCadastroCliente = formCadastroCliente;
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _formCadastroCliente.ShowDialog();
        }
    }
}