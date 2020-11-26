using HandsOfWork.Entities.Produtos;
using System.Collections.Generic;

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

        public List<Produto> Listar() => Produtos;
    }
}