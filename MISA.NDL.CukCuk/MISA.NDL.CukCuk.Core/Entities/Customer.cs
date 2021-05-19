using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.NDL.CukCuk.Core.Entities
{
    /// <summary>
    /// Thông tin khách hàng 
    /// </summary>
    public class Customer
    {
        #region 
        /// <summary>
        /// 
        /// </summary>
        #endregion
        public Guid CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string FullName { get; set; }
        public string MemberCode { get; set; }
        public string  PhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string CompanyName { get; set; }
        public Guid CustomerGroupId { get; set; }
        public int? Gender { get; set; }
        public string Email { get; set; }
        public string  Address { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string Note { get; set; }
        public string CompanyTaxCode { get; set; }


    }
}
