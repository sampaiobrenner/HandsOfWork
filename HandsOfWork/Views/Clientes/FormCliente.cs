using HandsOfWork.Services.Pessoas;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace HandsOfWork.Views.Clientes
{
    public partial class FormCliente : Form
    {
        private readonly IPessoaService _pessoaService;
        private readonly IServiceProvider _serviceProvider;

        public FormCliente(IServiceProvider serviceProvider, IPessoaService pessoaService)
        {
            _serviceProvider = serviceProvider;
            _pessoaService = pessoaService;
            InitializeComponent();
            PreencherGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count <= 0) return;

            var formCadastroCliente = _serviceProvider.GetService<FormCadastroCliente>();
            formCadastroCliente.IdPessoa = Guid.Parse(dgvClientes.SelectedRows[0].Cells[0].Value.ToString() ?? string.Empty);
            formCadastroCliente.ShowDialog();

            PreencherGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count <= 0) return;

            var idCliente = Guid.Parse(dgvClientes.SelectedRows[0].Cells[0].Value.ToString() ?? string.Empty);
            _pessoaService.Excluir(idCliente);

            PreencherGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var formCadastroCliente = _serviceProvider.GetService<FormCadastroCliente>();
            formCadastroCliente?.ShowDialog();

            PreencherGrid();
        }

        private void PreencherGrid()
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = _pessoaService.Listar();
            dgvClientes.Refresh();
        }
    }
}