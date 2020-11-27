using HandsOfWork.Entities.Pessoas;
using HandsOfWork.Repositories.Abstractions;
using HandsOfWork.Services.Abstractions;

namespace HandsOfWork.Services.Pessoas
{
    public class PessoaFisicaService : CrudService<PessoaFisica>, IPessoaFisicaService
    {
        public PessoaFisicaService(ICrudRepository<PessoaFisica> crudRepository) : base(crudRepository)
        {
        }
    }
}