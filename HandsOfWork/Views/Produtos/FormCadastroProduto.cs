using HandsOfWork.Entities.Categorias;
using HandsOfWork.Entities.Produtos;
using HandsOfWork.Services.Categorias;
using HandsOfWork.Services.Produtos;
using System;
using System.Windows.Forms;

namespace HandsOfWork.Views.Produtos
{
    public partial class FormCadastroProduto : Form
    {
        private readonly ICategoriaService _categoriaService;
        private readonly IProdutoService _produtoService;

        public FormCadastroProduto(IProdutoService produtoService, ICategoriaService categoriaService)
        {
            _produtoService = produtoService;
            _categoriaService = categoriaService;
            InitializeComponent();
            CarregarCategorias();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblNome.Text))
            {
                MessageBox.Show("O campo nome deve ser informado.");
                return;
            }

            var produto = new Produto
            {
                Descricao = lblNome.Text,
                Categoria = new Categoria
                {
                    Id = cboCategoria.SelectedIndex,
                    Descricao = cboCategoria.Text
                }
            };

            _produtoService.Cadastrar(produto);
            Close();
        }

        private void CarregarCategorias()
        {
            cboCategoria.DataSource = _categoriaService.ListarCategorias();
        }
    }
}