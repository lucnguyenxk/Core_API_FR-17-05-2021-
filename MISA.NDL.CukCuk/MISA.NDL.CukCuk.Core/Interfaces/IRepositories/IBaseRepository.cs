using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.NDL.CukCuk.Core.Interfaces.IRepositories
{

    public interface IBaseRepository<NdlEntities>
    {
        /// <summary>
        /// lấy toàn bộ dữ liệu
        /// </summary>
        /// <returns>
        /// danh sách các đối tượng lấy được
        /// </returns>
        public IEnumerable<NdlEntities> GetAll();
        /// <summary>
        /// lấy đối tượng theo id
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns>đối tượng tìm kiếm đc theo id</returns>
        public NdlEntities GetById(Guid entityId);
        /// <summary>
        /// thêm  đối tượng
        /// </summary>
        /// <param name="entity"> đối tượng cần thêm</param>
        /// <returns> số lượng dối tượng được thêm</returns>
        public int Insert(NdlEntities entity);
        /// <summary>
        /// cập nhật đối tượng
        /// </summary>
        /// <param name="id"> id đối tượng cần cập nhật</param>
        /// <param name="entity"> thông tin cần cập nhật</param>
        /// <returns>số đối tượng được cập nhật</returns>
        public int Update(Guid id,NdlEntities entity);
        /// <summary>
        /// xóa bỏ đối tượng theo id
        /// </summary>
        /// <param name="entityId"> id đối tượng cần xóa bỏ</param>
        /// <returns> số lượng đối tượng bị xóa</returns>
        public int Delete(Guid entityId);
        /// <summary>
        /// Kiểm tra việc bị trùng mã đối tượng
        /// </summary>
        /// <param name="Code">Mã cần kiểm tra</param>
        /// <returns> kết quả trùng mã đúng hoặc sai</returns>
        public bool CheckCodeExists(string Code);
    }
}
