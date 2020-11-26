using HandsOfWork.Entities.Produtos;
using HandsOfWork.Repositories.Produtos;
using System.Collections.Generic;

namespace HandsOfWork.Services.Produtos
{
    public class ProdutoService : IProdutoService
    {
        private static int _idProduto = 1;
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void Cadastrar(Produto produto)
        {
            GerarIdProduto(produto);
            _produtoRepository.Cadastrar(produto);
        }

        public void Editar(Produto produto)
        {
        }

        public void Excluir()
        {
        }

        public List<Produto> Listar() => _produtoRepository.Listar();

        private void GerarIdProduto(Produto produto)
        {
            produto.Id = _idProduto;
            _idProduto++;
        }
    }
}