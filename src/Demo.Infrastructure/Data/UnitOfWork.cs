using Demo.Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.Data
{ 
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DbContext _dbcontext;

        public UnitOfWork(DbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public void Dispose()
        {
            _dbcontext.Dispose();
        }
        public void save()
        {
            _dbcontext.SaveChanges();
        }
        public async void saveAsync()
        {
           await _dbcontext.SaveChangesAsync();
        }
    }
}
