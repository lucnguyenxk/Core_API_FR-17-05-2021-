using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.NDL.CukCuk.Core.Common.NdlException
{
    public class NdlException : Exception
    {
        public NdlException(string msg) : base(msg)
        {

        }
    }
}
