using ArabDev.Data.DataOrEntities;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabDev.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        IGenaricRepository<TEntity, Tkey> Repository<TEntity, Tkey>() where TEntity : BaseEntity<Tkey>;

        Task<int> CompleteAync();
        ValueTask DisposeAsync();
    }
}
