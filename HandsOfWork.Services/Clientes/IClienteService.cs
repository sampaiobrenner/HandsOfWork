using HandsOfWork.Entities.Pessoas;
using HandsOfWork.Services.Abstractions;

namespace HandsOfWork.Services.Clientes
{
    public interface IClienteService : ICrudService<Pessoa>
    {
    }
}