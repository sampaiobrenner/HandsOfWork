using HandsOfWork.Entities.Categorias;
using System.Collections.Generic;

namespace HandsOfWork.Services.Categorias
{
    public interface ICategoriaService
    {
        List<Categoria> ListarCategorias();
    }
}