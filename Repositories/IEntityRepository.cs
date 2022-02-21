using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Repositories
{
    public interface IEntityRepository<T> where T : class,new()
    {
        //list of items
        IQueryable<T> GetAllQueryable();
        //IEnumerable<>
    }
}
