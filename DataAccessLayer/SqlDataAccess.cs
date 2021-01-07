using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _configuration;

        public string ConnectionStringName { get; set; } = "defaultJoinDataEmployee";

        public SqlDataAccess(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // LoadData
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            string connectionString = _configuration.GetConnectionString(ConnectionStringName);

            using (IDbConnection _connection = new SqlConnection(connectionString))
            {
                var data = await _connection.QueryAsync<T>(sql, parameters);

                return data.ToList();
            }
        }

        // SavaData
        public async Task SavaData<T>(string sql, T parameters)
        {
            string _connectionString = _configuration.GetConnectionString(ConnectionStringName);

            using (IDbConnection _connection = new SqlConnection(_connectionString))
            {
                await _connection.ExecuteAsync(sql, parameters);
            }
        }
    }
}
