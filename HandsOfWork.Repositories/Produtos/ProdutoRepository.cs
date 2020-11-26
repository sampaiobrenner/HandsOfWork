using HandsOfWork.Entities.Produtos;
using System.Collections.Generic;
using System.Linq;

namespace HandsOfWork.Repositories.Produtos
{
    public class ProdutoRepository : IProdutoRepository
    {
        public ProdutoRepository()
        {
            Produtos = new List<Produto>();
        }

        public static List<Produto> Produtos { get; private set; }

        public void Cadastrar(Produto produto) => Produtos.Add(produto);

        public void Editar(Produto produto)
        {
            var produtoOld = ObterPorId(produto.Id);
            if (produtoOld is null) return;

            Produtos.Remove(produtoOld);
            Produtos.Add(produto);
        }

        public void Excluir(int idProduto)
        {
            var produto = ObterPorId(idProduto);
            if (produto is null) return;

            Produtos.Remove(produto);
        }

        public List<Produto> Listar() => Produtos;

        public Produto ObterPorId(int id) => Produtos.FirstOrDefault(x => x.Id == id);
    }
}