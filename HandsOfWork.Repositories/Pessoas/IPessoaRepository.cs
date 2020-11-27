using HandsOfWork.Entities.Pessoas;
using HandsOfWork.Repositories.Abstractions;

namespace HandsOfWork.Repositories.Pessoas
{
    public interface IPessoaRepository : ICrudRepository<Pessoa>
    {
    }
}