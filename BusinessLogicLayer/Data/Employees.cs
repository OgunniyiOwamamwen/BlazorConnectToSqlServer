using BusinessLogicLayer.Models;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Data
{
    public class Employees : IEmployees
    {
        #region DataAccessLayer
        private readonly ISqlDataAccess _db;

        public Employees(ISqlDataAccess db)
        {
            _db = db;
        }
        #endregion
        // from the Models folder 'Employee'
        public Task<List<Employee>> GetEmployees()
        {
            string sql = "SELECT * FROM Employees";

            return _db.LoadData<Employee, dynamic>(sql, new { });
        }

        public Task InsertEmployee(Employee _employee)
        {
            string sql = @"INSERT INTO dbo.Employees(SurName, Name, Gender, DepartmentId) VALUES (@SurName, @Name, @Gender, @DepartmentId);";

            return _db.SavaData(sql, _employee);
        }
    }
}
