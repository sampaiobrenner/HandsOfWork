using System;

namespace HandsOfWork.Entities.Abstractions
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
    }
}