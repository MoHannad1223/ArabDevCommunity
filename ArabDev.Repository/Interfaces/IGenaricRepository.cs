using ArabDev.Data.DataOrEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabDev.Repository.Interfaces
{
  public  interface IGenaricRepository<TEntity,TKey> where TEntity :BaseEntity<TKey>
    {
        Task<TEntity> GetByIdAsync(TKey? id);

      //  Task<TEntity> GetByIdAsNoTrackingAsync(TKey? id);

        Task<TEntity> SearchByNameAsync(TKey? username);
        Task<IReadOnlyList<TEntity>> GetAllAsync();

        Task<IReadOnlyList<TEntity>> GetAllAsNoTrackingAsync();

        Task AddAsync(TEntity entity);

        void UpdateAsync(TEntity entity);

        void DeleteAsync(TEntity entity);
    }
}
