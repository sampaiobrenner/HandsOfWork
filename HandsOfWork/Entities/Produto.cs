namespace HandsOfWork.Entities
{
    public class Produto : SimpleId<int>
    {
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }
    }
}