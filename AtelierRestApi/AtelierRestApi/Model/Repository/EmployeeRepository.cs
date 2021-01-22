using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AtelierRestApi.Model.Repository
{

    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;

        public EmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<Employee> AddEmployee(Employee employee)
        {
            var res = await context.Employees.AddAsync(employee);
            await context.SaveChangesAsync();
            return res.Entity;
        }

        public async Task<Employee> DeleteEmployee(int employeeId)
        {
            var empD = await context.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
            if (empD != null)
            {
                context.Employees.Remove(empD);
                await context.SaveChangesAsync();
                return empD;

            }
            else
                return null;
        }

        public async Task<Employee> GetEmployee(int employeeId)
        {
            return await context.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
        }

        public async Task<Employee> GetEmployeeEmail(string email)
        {
            return await context.Employees.FirstOrDefaultAsync(e => e.Email == email);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await context.Employees.ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var Res = await context.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employee.EmployeeId);
            if (Res != null)
            {
                Res.FirstName = employee.FirstName;
                Res.LastName = employee.LastName;
                Res.PhotoPath = employee.PhotoPath;
                Res.Email = employee.Email;
                Res.DateOfBirth = employee.DateOfBirth;
                Res.DepartmentId = employee.DepartmentId;
                Res.Gender = employee.Gender;
                await context.SaveChangesAsync();
                return Res;

            }
            else
                return null;
        }
    }
}
