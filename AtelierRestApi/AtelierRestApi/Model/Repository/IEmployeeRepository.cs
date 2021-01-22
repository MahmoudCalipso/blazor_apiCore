using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtelierRestApi.Model.Repository
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int employeeId);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        Task<Employee> DeleteEmployee(int employeeId);
        Task<Employee> GetEmployeeEmail(string email);

    }
}
