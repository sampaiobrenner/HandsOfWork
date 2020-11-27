using HandsOfWork.Services.Pessoas;
using HandsOfWork.Services.Produtos;
using System.Windows.Forms;

namespace HandsOfWork.Views.Movimentacoes
{
    public partial class FormMovimentacoes : Form
    {
        private readonly IPessoaFisicaService _pessoaFisicaService;
        private readonly IProdutoService _produtoService;

        public FormMovimentacoes(IProdutoService produtoService, IPessoaFisicaService pessoaFisicaService)
        {
            _produtoService = produtoService;
            _pessoaFisicaService = pessoaFisicaService;
            InitializeComponent();
            CarregarClientes();
            CarregarProdutos();
        }

        private void btnFechar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
        }

        private void CarregarClientes()
        {
            cboCliente.DataSource = _pessoaFisicaService.Listar();
            cboCliente.ValueMember = "Id";
            cboCliente.DisplayMember = "Nome";
        }

        private void CarregarProdutos()
        {
            cboProduto.DataSource = _produtoService.Listar();
            cboProduto.ValueMember = "Id";
            cboProduto.DisplayMember = "Descricao";
        }
    }
}