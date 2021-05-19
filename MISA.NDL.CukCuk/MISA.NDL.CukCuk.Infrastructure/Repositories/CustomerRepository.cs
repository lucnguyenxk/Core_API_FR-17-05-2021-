using MISA.NDL.CukCuk.Core.Entities;
using MISA.NDL.CukCuk.Core.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.NDL.CukCuk.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public int Delete(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            Customer customer = new Customer() {
                CustomerId = Guid.NewGuid(),
                FullName = "ndluc",
                Address ="Nam Dinh",
            };
            List<Customer> listCus = new List<Customer>();
            listCus.Add(customer);
            return listCus; 
        }

        public Customer GetById(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public int Insert(Customer customer)
        {

            throw new NotImplementedException();
        }

        public int Uppdate(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
