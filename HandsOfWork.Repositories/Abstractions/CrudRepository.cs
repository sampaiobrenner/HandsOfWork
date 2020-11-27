using HandsOfWork.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsOfWork.Repositories.Abstractions
{
    public abstract class CrudRepository<TEntity> : ICrudRepository<TEntity>
        where TEntity : BaseEntity
    {
        protected CrudRepository() => Itens = new List<TEntity>();

        public List<TEntity> Itens { get; }

        public void Cadastrar(TEntity entity)
        {
            entity.Id = Guid.NewGuid();
            Itens.Add(entity);
        }

        public void Editar(TEntity entity)
        {
            var entityOld = ObterPorId(entity.Id);
            if (entityOld is null) return;

            Itens.Remove(entityOld);
            Itens.Add(entity);
        }

        public void Excluir(Guid id)
        {
            var entity = ObterPorId(id);
            if (entity is null) return;

            Itens.Remove(entity);
        }

        public List<TEntity> Listar() => Itens;

        public TEntity ObterPorId(Guid id) => Itens.FirstOrDefault(x => x.Id == id);
    }
}