using MISA.NDL.CukCuk.Core.Common.Attribute;
using MISA.NDL.CukCuk.Core.Common.NdlException;
using MISA.NDL.CukCuk.Core.Interfaces.IRepositories;
using MISA.NDL.CukCuk.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.NDL.CukCuk.Core.Services
{
    public class BaseService<NdlEntities> : IBaseService<NdlEntities>
    {
        /// <summary>
        /// Khởi tạo đối tượng
        /// </summary>
        IBaseRepository<NdlEntities> iBaseRepository;
        public BaseService(IBaseRepository<NdlEntities> _iBaseRepository)
        {
            iBaseRepository = _iBaseRepository;
        }
        public int Insert(NdlEntities entity)
        {
            validate(entity);
            var res = iBaseRepository.Insert(entity);
            return res;
        }

        public int Update( Guid id, NdlEntities entity)
        {
            var res = iBaseRepository.Update(id, entity);
            return res;
        }
        /// <summary>
        /// validate thông tin đối tượng
        /// </summary>
        /// created by ndluc(20/05/2021)
        protected void validate(NdlEntities entity)
        {
            var properties = typeof(NdlEntities).GetProperties();
            foreach( var property in properties)
            {
                var nonDuplicate = property.GetCustomAttributes(typeof(NonDuplicate), true);
                if(nonDuplicate.Length > 0)
                {
                    var propertyValue = property.GetValue(entity).ToString();
                    var checkRes = iBaseRepository.CheckCodeExists(propertyValue);
                    if (checkRes)
                    {
                        var ErrMsg = (nonDuplicate[0] as NonDuplicate).ErrMsg + propertyValue;
                        throw new NdlException(ErrMsg);
                    }
                }
            }
        }
    }
}
