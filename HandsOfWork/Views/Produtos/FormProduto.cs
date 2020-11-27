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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count <= 0) return;

            var formCadastroProduto = _serviceProvider.GetService<FormCadastroProduto>();
            formCadastroProduto.IdProduto = Guid.Parse(dgvProdutos.SelectedRows[0].Cells[0].Value.ToString() ?? string.Empty);
            formCadastroProduto.ShowDialog();

            PreencherGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count <= 0) return;

            var idProduto = Guid.Parse(dgvProdutos.SelectedRows[0].Cells[0].Value.ToString() ?? string.Empty);
            _produtoService.Excluir(idProduto);

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

            PreencherGrid();
        }

        private void PreencherGrid()
        {
            dgvProdutos.AutoGenerateColumns = false;
            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = _produtoService.Listar();
            dgvProdutos.Refresh();
        }
    }
}