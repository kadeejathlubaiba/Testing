using MainProject.Models;
using MainProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Services
{
    public class CustomerBL
    {
        private IEntityRepository<Customer> _customerRepository { get; set; }
        public CustomerBL(IEntityRepository<Customer> customerRepository){
            _customerRepository = customerRepository;
        }

        //get all customer
        public List<Customer> GetAllActiveCustomer()
        {
            var result = _customerRepository.GetAllQueryable()
                .Where(c => c.IsDeleted == false).ToList();
            return result;
        }
    }
}
