using HandsOfWork.Entities.Categorias;
using System;
using System.Collections.Generic;

namespace HandsOfWork.Services.Categorias
{
    public class CategoriaService : ICategoriaService
    {
        public List<Categoria> ListarCategorias()
        {
            var categoria1 = new Categoria()
            {
                Id = Guid.NewGuid(),
                Descricao = "Teste 1"
            };

            var categoria2 = new Categoria()
            {
                Id = Guid.NewGuid(),
                Descricao = "Teste 2"
            };

            return new List<Categoria> { categoria1, categoria2 };
        }
    }
}