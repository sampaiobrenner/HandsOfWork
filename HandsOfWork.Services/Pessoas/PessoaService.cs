using HandsOfWork.Entities.Pessoas;
using HandsOfWork.Repositories.Abstractions;
using HandsOfWork.Services.Abstractions;

namespace HandsOfWork.Services.Pessoas
{
    public class PessoaService : CrudService<Pessoa>, IPessoaService
    {
        public PessoaService(ICrudRepository<Pessoa> crudRepository) : base(crudRepository)
        {
        }
    }
}