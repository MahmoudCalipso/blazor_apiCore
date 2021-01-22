using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtelierRestApi.Model.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext context;

        public DepartmentRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task <Department> GetDepartment (int departmentId)
        {
            return await context.Departments.FirstOrDefaultAsync(e => e.DepartmentId == departmentId);
        }

        public async Task <Department> AddDepartments  (Department department) 
        {
            var res = await context.Departments.AddAsync(department);
            await context.SaveChangesAsync();
            return res.Entity;
        }
        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await context.Departments.ToListAsync();
        }
    }
}
