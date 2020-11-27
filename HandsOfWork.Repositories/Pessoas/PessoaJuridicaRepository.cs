using HandsOfWork.Entities.Pessoas;
using HandsOfWork.Repositories.Abstractions;

namespace HandsOfWork.Repositories.Pessoas
{
    public class PessoaJuridicaRepository : CrudRepository<PessoaJuridica>, IPessoaJuridicaRepository
    {
    }
}