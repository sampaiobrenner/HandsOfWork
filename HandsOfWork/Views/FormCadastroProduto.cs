using System;
using System.Windows.Forms;
using HandsOfWork.Entities;
using HandsOfWork.Services;

namespace HandsOfWork.Views
{
    public partial class FormCadastroProduto : Form
    {
        private readonly ModoOperacao _modoOperacao;

        public FormCadastroProduto(ModoOperacao modoOperacao)
        {
            _modoOperacao = modoOperacao;
            InitializeComponent();
            CarregarCategorias();
        }

        private void CarregarCategorias()
        {
            var categoriaService = new CategoriaService();
            cboCategoria.DataSource = categoriaService.ListarCategorias();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var produto = new Produto()
            {
                Id = 1,
                Descricao = lblNome.Text,
                Categoria = new Categoria()
                {
                    Id = 1,
                    Descricao = "Categoria teste"
                }
            };

            var produtoService = new ProdutoService();
            switch (_modoOperacao)
            {
                case ModoOperacao.Adicionar:
                    produtoService.Cadastrar(produto);
                    break;
                    
                case ModoOperacao.Alterar:
                    produtoService.Editar(produto);
                    break;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}