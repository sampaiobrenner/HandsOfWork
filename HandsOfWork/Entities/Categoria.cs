namespace HandsOfWork.Entities
{
    public class Categoria : SimpleId<int>
    {
        public string Descricao { get; set; }
    }
}