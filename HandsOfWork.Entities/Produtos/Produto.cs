using HandsOfWork.Entities.Abstractions;
using HandsOfWork.Entities.Categorias;

namespace HandsOfWork.Entities.Produtos
{
    public class Produto : SimpleId<int>
    {
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }
    }
}