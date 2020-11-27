using HandsOfWork.Entities.Pessoas;
using HandsOfWork.Repositories.Abstractions;

namespace HandsOfWork.Repositories.Pessoas
{
    public class PessoaRepository : CrudRepository<Pessoa>, IPessoaRepository
    {
    }
}