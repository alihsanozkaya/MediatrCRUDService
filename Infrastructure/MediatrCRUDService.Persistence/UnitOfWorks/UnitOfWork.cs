using MediatrCRUDService.Application.Interfaces.Repositories;
using MediatrCRUDService.Application.Interfaces.UnitOfWorks;
using MediatrCRUDService.Persistence.Context;
using MediatrCRUDService.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async ValueTask DisposeAsync()
        {
            await _appDbContext.DisposeAsync();
        }

        public int Save() 
        { 
            return _appDbContext.SaveChanges(); 
        }

        public async Task<int> SaveAsync()
        {
            return await _appDbContext.SaveChangesAsync();
        }

        IReadRepository<T> IUnitOfWork.GetReadRepository<T>()
        {
            return new ReadRepository<T>(_appDbContext);
        }

        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>()
        {
            return new WriteRepository<T>(_appDbContext);
        }
    }
}
