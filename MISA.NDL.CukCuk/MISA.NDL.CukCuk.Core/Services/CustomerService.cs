using MISA.NDL.CukCuk.Core.Entities;
using MISA.NDL.CukCuk.Core.Interfaces.IRepositories;
using MISA.NDL.CukCuk.Core.Interfaces.IServices;
using MISA.NDL.CukCuk.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.NDL.CukCuk.Core.Service
{
    public class CustomerService :BaseService<Customer>, ICustomerService
    {
        public CustomerService(ICustomerRepository iBaseRepository) : base(iBaseRepository)
        {

        }
    }
}
