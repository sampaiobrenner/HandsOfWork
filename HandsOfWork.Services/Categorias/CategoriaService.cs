using HandsOfWork.Entities.Categorias;
using System;
using System.Collections.Generic;

namespace HandsOfWork.Services.Categorias
{
    public class CategoriaService : ICategoriaService
    {
        public List<Categoria> ListarCategorias()
            => new List<Categoria>
                {
                    new Categoria
                    {
                        Id = Guid.Parse("e8838426-5d40-4aa1-9547-ffa50e527a55"),
                        Descricao = "Eletrônicos"
                    },
                    new Categoria
                    {
                        Id = Guid.Parse("e0078873-2b9e-4ec3-907a-5b06e1bcd9f5"),
                        Descricao = "Diversos"
                    }
                };
    }
}