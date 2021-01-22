using AtelierRestApi.Model;
using Microsoft.AspNetCore.Components;
using ProjetBlazer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetBlazer.Pages
{
    public class EmployeeDetailsBase : ComponentBase

    {

        public Employee Employee { get; set; } = new Employee();
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Parameter]
        public string Id { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
        }
    }
}
