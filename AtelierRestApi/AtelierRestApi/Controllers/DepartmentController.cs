using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtelierRestApi.Model;
using AtelierRestApi.Model.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtelierRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {

        private readonly IDepartmentRepository DepRepository;
        public DepartmentController(IDepartmentRepository DepRepository)
        {
            this.DepRepository = DepRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetDepartments()
        {
            try
            {
                return Ok(await DepRepository.GetDepartments());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Department>> GetDepartment(int id)
        {
            try
            {
                var result = await DepRepository.GetDepartment(id);
                if (result == null) return NotFound();
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Department>> CreateDepartment([FromBody] Department department)
        {
            try
            {
                if (department == null)
                    return BadRequest();
                var createdEmployee = await DepRepository.AddDepartments(department);
                return CreatedAtAction(nameof(GetDepartment),
                new { id = createdEmployee.DepartmentId }, createdEmployee);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error creating new employee record");
            }
        }





    }
}
