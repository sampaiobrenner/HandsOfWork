using HandsOfWork.Services.Produtos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace HandsOfWork.Views.Produtos
{
    public partial class FormProduto : Form
    {
        private readonly IProdutoService _produtoService;
        private readonly IServiceProvider _serviceProvider;

        public FormProduto(IServiceProvider serviceProvider, IProdutoService produtoService)
        {
            _serviceProvider = serviceProvider;
            _produtoService = produtoService;
            InitializeComponent();
            PreencherGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var formCadastroProduto = _serviceProvider.GetService<FormCadastroProduto>();
            formCadastroProduto?.ShowDialog();
        }

        private void PreencherGrid()
        {
            dgvProdutos.AutoGenerateColumns = false;
            dgvProdutos.DataSource = _produtoService.Listar();
        }
    }
}