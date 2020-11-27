using HandsOfWork.Entities.Abstractions;
using HandsOfWork.Repositories.Abstractions;
using System;
using System.Collections.Generic;

namespace HandsOfWork.Services.Abstractions
{
    public abstract class CrudService<TEntity> : ICrudService<TEntity>
        where TEntity : BaseEntity
    {
        private readonly ICrudRepository<TEntity> _crudRepository;

        protected CrudService(ICrudRepository<TEntity> crudRepository) => _crudRepository = crudRepository;

        public void Cadastrar(TEntity entity) => _crudRepository.Cadastrar(entity);

        public void Editar(TEntity entity) => _crudRepository.Editar(entity);

        public void Excluir(Guid id) => _crudRepository.Excluir(id);

        public List<TEntity> Listar() => _crudRepository.Listar();

        public TEntity ObterPorId(Guid id) => _crudRepository.ObterPorId(id);
    }
}