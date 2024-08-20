﻿using MediatrCRUDService.Application.Interfaces.Repositories;
using MediatrCRUDService.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : class, IEntityBase, new()
    {
        private readonly DbContext _context;
        public ReadRepository(DbContext context)
        {
            _context = context;
        }
        private DbSet<T> Table { get => _context.Set<T>(); }    
        public async Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null)
        {
            Table.AsNoTracking();

            if (predicate != null)
            {
                Table.Where(predicate);   
            }
            return await Table.CountAsync();
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate, bool enableTracking = false)
        {
            if (!enableTracking)
            {
                Table.AsNoTracking();
            }

            return Table.Where(predicate);
        }

        public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false)
        {
            IQueryable<T> queryable = Table;

            if (!enableTracking)
            {
                queryable = queryable.AsNoTracking();
            }

            if (include != null)
            {
                queryable = include(queryable);
            }

            if (predicate != null)
            {
                queryable = queryable.Where(predicate);
            }

            if (orderBy != null)
            {
                return await orderBy(queryable).ToListAsync();
            }

            return await queryable.ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool enableTracking = false)
        {
            IQueryable<T> queryable = Table;

            if (!enableTracking)
            {
                queryable = queryable.AsNoTracking();
            }

            if (include != null)
            {
                queryable = include(queryable);
            }

            return await queryable.FirstOrDefaultAsync(predicate);
        }
    }
}
