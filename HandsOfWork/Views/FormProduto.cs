using System;
using System.Windows.Forms;
using HandsOfWork.Entities;

namespace HandsOfWork.Views
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Visible = false;
            var formCadastroProduto = new FormCadastroProduto(ModoOperacao.Adicionar);
            formCadastroProduto.ShowDialog();
            Visible = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}