using MISA.NDL.CukCuk.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.NDL.CukCuk.Core.Interfaces.IRepositories
{
    public interface ICustomerRepository
    {
        public IEnumerable<Customer> GetAll();
        public Customer GetById(Guid customerId);
        public int Insert(Customer customer);
        public int Uppdate(Customer customer);
        public int Delete(Guid customerId);

    }
}
