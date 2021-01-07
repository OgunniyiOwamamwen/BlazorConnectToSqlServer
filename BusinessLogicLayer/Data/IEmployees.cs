using BusinessLogicLayer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Data
{
    public interface IEmployees
    {
        Task<List<Employee>> GetEmployees();
        Task InsertEmployee(Employee _employee);
    }
}