using MISA.NDL.CukCuk.Core.Entities;
using MISA.NDL.CukCuk.Core.Interfaces.IRepositories;
using MISA.NDL.CukCuk.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.NDL.CukCuk.Core.Service
{
    public class CustomerService : ICustomerService
    {
        ICustomerRepository _iCustomerRepository;
        public CustomerService(ICustomerRepository iCustomerRepository)
        {
            _iCustomerRepository = iCustomerRepository;
        }
        public int Insert(Customer customer)
        {
            validate();
            var res = _iCustomerRepository.Insert(customer);
            return res;
        }

        public int Uppdate(Customer customer)
        {
            throw new NotImplementedException();
        }
        public void validate()
        {

        }
    }
}
