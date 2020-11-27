using HandsOfWork.Entities.Pessoas;
using HandsOfWork.Repositories.Abstractions;
using HandsOfWork.Services.Abstractions;

namespace HandsOfWork.Services.Pessoas
{
    public class PessoaJuridicaService : CrudService<PessoaJuridica>, IPessoaJuridicaService
    {
        public PessoaJuridicaService(ICrudRepository<PessoaJuridica> crudRepository) : base(crudRepository)
        {
        }
    }
}