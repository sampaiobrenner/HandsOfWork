using HandsOfWork.Entities.Abstractions;

namespace HandsOfWork.Entities.Categorias
{
    public class Categoria : SimpleId<int>
    {
        public string Descricao { get; set; }
    }
}