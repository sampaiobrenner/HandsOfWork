using HandsOfWork.Views.Clientes;
using HandsOfWork.Views.Movimentacoes;
using HandsOfWork.Views.Produtos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace HandsOfWork.Views.MenuPrincipal
{
    public partial class FormPrincipal : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public FormPrincipal(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void btnListagemClientes_Click(object sender, EventArgs e)
        {
            var formCliente = _serviceProvider.GetService<FormCliente>();
            formCliente?.ShowDialog();
        }

        private void btnListagemProdutos_Click(object sender, EventArgs e)
        {
            var formProduto = _serviceProvider.GetService<FormProduto>();
            formProduto?.ShowDialog();
        }

        private void btnMovimentacoes_Click(object sender, EventArgs e)
        {
            var formMovimentacoes = _serviceProvider.GetService<FormMovimentacoes>();
            formMovimentacoes?.ShowDialog();
        }
    }
}