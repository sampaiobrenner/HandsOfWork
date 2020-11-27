using HandsOfWork.Entities.Abstractions;
using System;
using System.Collections.Generic;

namespace HandsOfWork.Repositories.Abstractions
{
    public interface ICrudRepository<TEntity>
        where TEntity : BaseEntity
    {
        void Cadastrar(TEntity entity);

        void Editar(TEntity entity);

        void Excluir(Guid id);

        List<TEntity> Listar();

        TEntity ObterPorId(Guid id);
    }
}