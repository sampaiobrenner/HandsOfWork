using HandsOfWork.Entities.Produtos;
using HandsOfWork.Repositories.Abstractions;

namespace HandsOfWork.Repositories.Produtos
{
    public interface IProdutoRepository : ICrudRepository<Produto>
    {
    }
}