using MISA.NDL.CukCuk.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.NDL.CukCuk.Core.Interfaces.IServices
{
    public interface ICustomerService
    {
        
        public int Insert(Customer customer);
        public int Uppdate(Customer customer);
    }
}
