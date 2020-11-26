using HandsOfWork.Entities.Produtos;
using System.Collections.Generic;

namespace HandsOfWork.Services.Produtos
{
    public interface IProdutoService
    {
        void Cadastrar(Produto produto);

        List<Produto> Listar();
    }
}