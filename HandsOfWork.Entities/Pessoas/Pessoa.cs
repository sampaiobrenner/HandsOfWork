using HandsOfWork.Entities.Abstractions;

namespace HandsOfWork.Entities.Pessoas
{
    public class Pessoa : BaseEntity
    {
        public string Email { get; set; }
        public string Nome { get; set; }
    }
}