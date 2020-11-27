using HandsOfWork.Entities.Produtos;
using HandsOfWork.Services.Abstractions;

namespace HandsOfWork.Services.Produtos
{
    public interface IProdutoService : ICrudService<Produto>
    {
    }
}