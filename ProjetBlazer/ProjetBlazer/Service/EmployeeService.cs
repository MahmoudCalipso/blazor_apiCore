
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AtelierRestApi.Model;
using Microsoft.AspNetCore.Components;


namespace ProjetBlazer.Service
{
    public class EmployeeService : IEmployeeService
    {

        private readonly HttpClient httpClient;
        private IEnumerable<Employee> employees;
        private Employee employee;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public  async Task<Employee> GetEmployee(int id)
        {
             employee = await httpClient.GetJsonAsync<Employee>($"/api/Employee/{id}");
            return employee;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
              employees = await httpClient.GetJsonAsync<Employee[]>("/api/Employee");
            return employees;
        }
    }
}
