using HandsOfWork.Entities.Produtos;
using System.Collections.Generic;

namespace HandsOfWork.Repositories.Produtos
{
    public interface IProdutoRepository
    {
        void Cadastrar(Produto produto);

        void Editar(Produto produto);

        void Excluir(int idProduto);

        List<Produto> Listar();

        Produto ObterPorId(int id);
    }
}