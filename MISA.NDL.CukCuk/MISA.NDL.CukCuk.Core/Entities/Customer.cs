using MISA.NDL.CukCuk.Core.Common.Attribute;
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
    /// created by : ndLuc(19/02/2021)
    public class Customer
    {
        #region Property
        /// <summary>
        /// Id khách hàng
        /// </summary>
        public Guid CustomerId { get; set; }
        /// <summary>
        /// Mã khách hàng
        /// </summary>
        [NonDuplicate("Mã khách hàng đã tồn tại trong hệ thống, vui lòng kiểm tra lại!")]
        public string CustomerCode { get; set; }
        /// <summary>
        /// Họ và tên
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Mã thẻ thành viên
        /// </summary>
        public string MemberCode { get; set; }
        /// <summary>
        /// số điện thoại
        /// </summary>
        public string  PhoneNumber { get; set; }
        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime? DateOfBirth { get; set; }
        /// <summary>
        /// Tên côn ty
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// Id nhóm khách hàng
        /// </summary>
        public Guid CustomerGroupId { get; set; }
        /// <summary>
        /// giới tính
        /// </summary>
        public int? Gender { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Địa chỉ
        /// </summary>
        public string  Address { get; set; }
        /// <summary>
        /// Ngày tạo
        /// </summary>
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// Ngày chỉnh sửa
        /// </summary>
        public DateTime? ModifiedDate { get; set; }
        /// <summary>
        /// người tạo thông tin
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// người sửa thông tin
        /// </summary>
        public string ModifiedBy { get; set; }
        /// <summary>
        /// ghi chú
        /// </summary>
        public string Note { get; set; }
        /// <summary>
        /// Mã công ty
        /// </summary>
        public string CompanyTaxCode { get; set; }
        #endregion 

    }
}
