using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.NDL.CukCuk.Core.Entities
{
    public class CustomerGroups
    {
        public Guid CustomerGroupId { get; set; }
        public string CustomerGroupName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
