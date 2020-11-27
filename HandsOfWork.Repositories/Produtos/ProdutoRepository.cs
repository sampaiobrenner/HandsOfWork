using HandsOfWork.Entities.Produtos;
using HandsOfWork.Repositories.Abstractions;

namespace HandsOfWork.Repositories.Produtos
{
    public class ProdutoRepository : CrudRepository<Produto>, IProdutoRepository
    {
    }
}