using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.NDL.CukCuk.Core.Common.NdlException;
using MISA.NDL.CukCuk.Core.Interfaces.IRepositories;
using MISA.NDL.CukCuk.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.NDL.CukCuk.Web.Controllers
{
    /// <summary>
    /// Api base
    /// </summary>
    /// created by ndluc(20/05/2021)
    /// <typeparam name="NdlEntities"></typeparam>
    [Route("api/v1/[controller]s")]
    [ApiController]
    public class BaseController<NdlEntities> : ControllerBase
    {
        /// <summary>
        /// Khởi tạo các đối tượng cần sử dụng
        /// </summary>
        IBaseService<NdlEntities> iBaseService;
        IBaseRepository<NdlEntities> iBaseRepository;
        public BaseController(IBaseService<NdlEntities> _iBaseService, IBaseRepository<NdlEntities> _iBaseRepository)
        {
            iBaseRepository = _iBaseRepository;
            iBaseService = _iBaseService;
        }
        /// <summary>
        /// lấy toàn bộ dữ liệu
        /// </summary>
        /// 500 - lỗi serve
        /// 400 - lỗi dữ liệu đầu vào
        /// 200 -  lấy dữ liệu thành công
        /// <returns>Danh sách tất cả đối tượng</returns>
        [HttpGet]
        public IEnumerable<NdlEntities> GetAll()
        {
            var res = iBaseRepository.GetAll();
            return res;
        }
        /// <summary>
        /// api thêm đối tượng
        /// </summary>/// 
        /// 500 - lỗi serve
        /// 400 - lỗi dữ liệu đầu vào
        /// 200 -  lấy dữ liệu thành công
        /// <param name="entity"> đối tượng cần thêm</param>
        /// <returns> số lượng đối tượng cần thêm</returns>
        [HttpPost]
        public IActionResult Insert([FromBody] NdlEntities entity)
        {
            try
            {
                var res = iBaseService.Insert(entity);
                return Ok(res);
            }
            catch (NdlException ex)
            {
                return StatusCode(400, ex.Message);
            }
        }
        /// <summary>
        /// api xóa đối tượng
        /// </summary>
        /// <param name="id"> id đối tượng cần xóa</param>
        /// <returns> số lượng đối tượng bị xóa</returns>
        /// 500 - lỗi serve
        /// 400 - lỗi dữ liệu đầu vào
        /// 200 -  lấy dữ liệu thành công
        [HttpDelete("{id}")]
        public int Delete(Guid id)
        {
            var res = iBaseRepository.Delete(id);
            return res;
        }
        /// <summary>
        /// api cập nhật đối tượng theo id
        /// </summary>
        /// 500 - lỗi serve
        /// 400 - lỗi dữ liệu đầu vào
        /// 200 -  lấy dữ liệu thành công
        /// <param name="id"> id đối tượng cần cập nhật</param>
        /// <param name="entity"> thông tin đối tượng cần cập nhật</param>
        /// <returns> số lượng đối tượng được cập nhật</returns>
        [HttpPut("{id}")]
        public int Uppdate(Guid id, NdlEntities entity)
        {
            var res = iBaseService.Update(id, entity);
            return res;
        }
        /// <summary>
        /// Lấy đội tượng theo id
        /// </summary>
        /// <param name="id">id đối tượng cần lấy</param>
        /// <returns> đối tượng cần lấy</returns>
        /// 500 - lỗi serve
        /// 400 - lỗi dữ liệu đầu vào
        /// 200 -  lấy dữ liệu thành công
        [HttpGet("{id}")]
        public NdlEntities GetById( Guid id)
        {
            var res = iBaseRepository.GetById(id);
            return res;
        }
    }
}
