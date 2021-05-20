using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.NDL.CukCuk.Core.Interfaces.IServices
{
    public interface IBaseService<NdlEntities>
    {
        /// <summary>
        /// thêm đối tượng 
        /// </summary>
        /// <param name="entity"> đối tượng cần thêm</param>
        /// <returns> số lượng đối tượng được thêm</returns>
        public int Insert(NdlEntities entity);
        /// <summary>
        /// Sửa đối tượng
        /// </summary>
        /// <param name="id"> id đối tượng cần sửa</param>
        /// <param name="entity"> thông tin đối tượng cấn sửa</param>
        /// <returns>số lượng đối tượng được sửa</returns>
        public int Update(Guid id, NdlEntities entity);
    }
}
