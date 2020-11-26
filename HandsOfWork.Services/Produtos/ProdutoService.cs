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

        public void Editar(Produto produto) => _produtoRepository.Editar(produto);

        public void Excluir(int idProduto) => _produtoRepository.Excluir(idProduto);

        public List<Produto> Listar() => _produtoRepository.Listar();

        public Produto ObterPorId(int id) => _produtoRepository.ObterPorId(id);

        private void GerarIdProduto(Produto produto)
        {
            produto.Id = _idProduto;
            _idProduto++;
        }
    }
}