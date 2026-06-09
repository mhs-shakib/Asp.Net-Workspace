using System;
using System.Collections.Generic;
using System.Text;
using Demo.Domain.Contracts;
using Microsoft.EntityFrameworkCore;
namespace Demo.Infrastructure.Data
{
   public class Repository<TAggregateRoot, TKey> : IRepository<TAggregateRoot, TKey>, IDisposable
         where TAggregateRoot : class, IAggregateRoot<TKey>
         where TKey : IComparable
    {
        private readonly DbContext _dbcontext;
        private readonly DbSet<TAggregateRoot> _dbset;
        public Repository(DbContext dbcontext)
        {
            _dbcontext = dbcontext;
            _dbset = _dbcontext.Set<TAggregateRoot>();
        }
        public void Add(TAggregateRoot entity)
        {
           _dbset.Add(entity);
        }
        public async Task AddAsync(TAggregateRoot entity)
        {
            await _dbset.AddAsync(entity);
        }
        public void Dispose()
        {
            _dbcontext.Dispose();
        }
    }
}
