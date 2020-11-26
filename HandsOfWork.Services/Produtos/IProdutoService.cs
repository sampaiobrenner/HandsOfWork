using HandsOfWork.Entities.Produtos;
using System.Collections.Generic;

namespace HandsOfWork.Services.Produtos
{
    public interface IProdutoService
    {
        void Cadastrar(Produto produto);

        void Editar(Produto produto);

        void Excluir(int idProduto);

        List<Produto> Listar();

        Produto ObterPorId(int id);
    }
}