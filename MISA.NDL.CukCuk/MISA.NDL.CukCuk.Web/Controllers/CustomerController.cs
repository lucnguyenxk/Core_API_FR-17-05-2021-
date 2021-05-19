using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.NDL.CukCuk.Core.Entities;
using MISA.NDL.CukCuk.Core.Interfaces.IRepositories;
using MISA.NDL.CukCuk.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.NDL.CukCuk.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerService _iCustomerService;
        ICustomerRepository _iCustomerRepository;
        public CustomerController(ICustomerService iCustomerService, ICustomerRepository iCustomerRepository)
        {
            _iCustomerService = iCustomerService;
            _iCustomerRepository = iCustomerRepository;
        }

        [HttpGet]
        public IEnumerable<Customer> GetAll()
        {
           var res = _iCustomerRepository.GetAll();
            return res;
        }
        [HttpPost]
        public int Insert(Customer customer)
        {
            var res = _iCustomerService.Insert(customer);
            return res;
        }

    }
}
