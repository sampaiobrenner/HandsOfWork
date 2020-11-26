using HandsOfWork.Entities.Abstractions;

namespace HandsOfWork.Entities.Pessoas
{
    public abstract class Pessoa : SimpleId<long>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}