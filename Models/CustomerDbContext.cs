using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Models
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions options)
       {

       }
            DbSet<Customer>Customer { get; set; }
    }
}
