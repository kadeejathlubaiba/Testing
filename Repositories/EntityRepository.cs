using MainProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Repositories
{
    public class EntityRepository<T> :IEntityRepository<T> where T:class,new()
    {
        //declare dbContext
        private CustomerDbContext _context;
        private DbSet<T> _dbSet;

        public EntityRepository(CustomerDbContext dbContext)
        {
            _context = dbContext;
            _dbSet = _context.Set<T>();
        }
        public virtual IQueryable<T> GetAllQueryable()
        {
            return _dbSet;
        }
    }
}
