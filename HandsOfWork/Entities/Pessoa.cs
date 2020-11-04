namespace HandsOfWork.Entities
{
    public abstract class Pessoa : SimpleId<long>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}