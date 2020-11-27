using HandsOfWork.Entities.Produtos;
using HandsOfWork.Repositories.Abstractions;
using HandsOfWork.Services.Abstractions;

namespace HandsOfWork.Services.Produtos
{
    public class ProdutoService : CrudService<Produto>, IProdutoService
    {
        public ProdutoService(ICrudRepository<Produto> crudRepository) : base(crudRepository)
        {
        }
    }
}