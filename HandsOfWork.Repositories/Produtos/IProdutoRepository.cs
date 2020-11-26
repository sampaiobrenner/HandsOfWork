using HandsOfWork.Entities.Produtos;
using System.Collections.Generic;

namespace HandsOfWork.Repositories.Produtos
{
    public interface IProdutoRepository
    {
        void Cadastrar(Produto produto);

        List<Produto> Listar();
    }
}