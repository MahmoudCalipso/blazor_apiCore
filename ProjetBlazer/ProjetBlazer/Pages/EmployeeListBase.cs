using AtelierRestApi.Model;
using Microsoft.AspNetCore.Components;
using ProjetBlazer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetBlazer.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee> employees { get; set; }
      
       /* protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }*/
        protected override async Task OnInitializedAsync()
        {
            employees = (await EmployeeService.GetEmployees()).ToList();

        }
       /* private void LoadEmployees()
        {
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LasteName = "Hastings",
                Email = "David@pragimtech.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                Department = new Department
                {
                    DepartmentId =
            1,
                    DepartmentName = "IT"
                },
                PhotoPath = "images/etudiant_F.jpg"
            };

            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Sam",
                LasteName = "Galloway",
                Email = "Sam@pragimtech.com",
                DateOfBirth = new DateTime(1981, 12, 22),
                Gender = Gender.Male,
                Department = new Department
                { DepartmentId = 2, DepartmentName = "HR" },
                PhotoPath = "images/etudiant_H.jpg"
            };

            Employee e3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Mary",
                LasteName = "Smith",
                Email = "mary@pragimtech.com",
                DateOfBirth = new DateTime(1979, 11, 11),
                Gender = Gender.Female,
                Department = new Department
                { DepartmentId = 1, DepartmentName = "IT" },
                PhotoPath = "images/etudiant_F.jpg"
            };
            Employee e4 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Sara",
                LasteName = "Longway",
                Email = "sara@pragimtech.com",
                DateOfBirth = new DateTime(1982, 9, 23),
                Gender = Gender.Female,
                Department = new Department
                { DepartmentId = 3, DepartmentName = "Payroll" },
                PhotoPath = "images/etudiant_F.jpg"
            };
            Employees = new List<Employee> { e1, e2, e3, e4 };
        }*/
    }
}
