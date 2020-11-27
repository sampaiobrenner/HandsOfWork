using HandsOfWork.Entities.Pessoas;
using HandsOfWork.Repositories.Abstractions;

namespace HandsOfWork.Repositories.Pessoas
{
    public class PessoaFisicaRepository : CrudRepository<PessoaFisica>, IPessoaFisicaRepository
    {
    }
}