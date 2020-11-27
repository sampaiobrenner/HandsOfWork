using HandsOfWork.Services.Pessoas;
using HandsOfWork.Services.Produtos;
using System.Windows.Forms;

namespace HandsOfWork.Views.Movimentacoes
{
    public partial class FormMovimentacoes : Form
    {
        private readonly IPessoaService _pessoaService;
        private readonly IProdutoService _produtoService;

        public FormMovimentacoes(IProdutoService produtoService, IPessoaService pessoaService)
        {
            _produtoService = produtoService;
            _pessoaService = pessoaService;
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
            cboCliente.DataSource = _pessoaService.Listar();
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