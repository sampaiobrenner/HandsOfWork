using HandsOfWork.Entities.Abstractions;
using HandsOfWork.Entities.Categorias;

namespace HandsOfWork.Entities.Produtos
{
    public class Produto : BaseEntity
    {
        public Categoria Categoria { get; set; }
        public string Descricao { get; set; }
    }
}