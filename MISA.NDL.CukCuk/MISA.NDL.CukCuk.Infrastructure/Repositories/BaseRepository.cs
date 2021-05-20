using Dapper;
using MISA.NDL.CukCuk.Core.Interfaces.IRepositories;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.NDL.CukCuk.Infrastructure.Repositories
{
    public class BaseRepository<NdlEntities> : IBaseRepository<NdlEntities>
    {
        protected string connectionString = "" +
             "Host= 47.241.69.179;" +
                "Port= 3306;" +
                "Database = 15B_MS2_CukCuk_NDLuc;" +
                "User Id = dev;" +
                "Password=12345678;" +
                "ConvertZeroDateTime=True ";
        protected IDbConnection _dbConnection;

        public IEnumerable<NdlEntities> GetAll()
        {
            using (_dbConnection = new MySqlConnection(connectionString))
            {
                var name = typeof(NdlEntities).Name;
                var SqlCommand = $"Proc_Get{name}s";
                var entities = _dbConnection.Query<NdlEntities>(SqlCommand, commandType: CommandType.StoredProcedure);
                return entities;
            }
        }

        public NdlEntities GetById(Guid id)
        {
            using (_dbConnection = new MySqlConnection(connectionString))
            {

                var name = typeof(NdlEntities).Name;
                var param = new DynamicParameters();
                param.Add($"{name}Id", id.ToString());
                var SqlCommand = $"Proc_Get{name}ById";
                var entity = _dbConnection.QueryFirstOrDefault<NdlEntities>(SqlCommand, param: param, commandType: CommandType.StoredProcedure);
                return entity;
            }
        }

        public int Insert(NdlEntities entity)
        {

            using (_dbConnection = new MySqlConnection(connectionString))
            {
                var name = typeof(NdlEntities).Name;
                var param = new DynamicParameters();
                var SqlCommand = $"Proc_Insert{name}";
                var res = _dbConnection.Execute(SqlCommand, param: entity, commandType: CommandType.StoredProcedure);
                return res;
            }
        }

        public int Update(Guid id, NdlEntities entity)
        {
            using (_dbConnection = new MySqlConnection(connectionString))
            {
                var name = typeof(NdlEntities).Name;
                var SqlCommand = $"Proc_Update{name}";
                var result = _dbConnection.Execute(SqlCommand, param: entity, commandType: CommandType.StoredProcedure);
                return result;
            }

        }
        public int Delete(Guid id)
        {
            using (_dbConnection = new MySqlConnection(connectionString))
            {
                var name = typeof(NdlEntities).Name;
                var param = new DynamicParameters();
                param.Add($"{name}Id", id.ToString());
                var SqlCommand = $"Proc_Delete{name}";
                var res = _dbConnection.Execute(SqlCommand, param: param, commandType: CommandType.StoredProcedure);
                return res;
            }
        }
        /// <summary>
        /// Kiểm tra trùng mã
        /// </summary>
        /// <param name="Code">Mã cần kiểm tra</param>
        /// <returns>Có bị trùng hay không? Đúng|Sai</returns>
        /// created by ndluc(20/05/2021)
        public bool CheckCodeExists( string Code)
        {
            using (_dbConnection = new MySqlConnection(connectionString))
            {
                var name = typeof(NdlEntities).Name;
                var param = new DynamicParameters();
                param.Add($"{name}Code", Code);
                var SqlCommand = $"Proc_Check{name}CodeExists";
                var res = _dbConnection.QueryFirstOrDefault<bool>(SqlCommand, param: param, commandType: CommandType.StoredProcedure);
                return res;
            }
        }
    }
}
