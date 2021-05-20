using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.NDL.CukCuk.Core.Common.Attribute
{
    [AttributeUsage(AttributeTargets.Property)]
    public class NonDuplicate : System.Attribute
    {
        public string ErrMsg;
        public NonDuplicate(string errMsg)
        {
            ErrMsg = errMsg;
        }
    }
}
