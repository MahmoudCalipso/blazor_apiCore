using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtelierRestApi.Model.Repository
{
   public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int departmentId);
        Task <Department> AddDepartments(Department department);
    }
}
