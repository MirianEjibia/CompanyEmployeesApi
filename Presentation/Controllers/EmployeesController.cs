
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransfareObjects;

namespace Controllers.EmployeesController
{

    [Route("api/companies/{companyId}/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IServiceManager _service;
        public EmployeesController(IServiceManager service)
        {
            _service = service;
        }
        public IActionResult GemEmployees(Guid companyId, bool trackChanges)
        {
            var employees = _service.EmployeeService.GetEmployees(companyId, trackChanges);
            return Ok(employees);
        }

        [HttpGet("{id:Guid}", Name = "GetEmployeeForCompany")]
        public IActionResult GetEmployee(Guid companyId, Guid id)
        {
            var employee = _service.EmployeeService.GetEmployee(companyId, id, true);
            return Ok(employee);
        }

        [HttpPost]
        public IActionResult CreateEmployeeForCompany(Guid companyId, [FromBody] EmployeeForCreationDto employee)
        {
            var createdEmployee = _service.EmployeeService.CreateEmployee(companyId, employee, trackChanges: false);
            return CreatedAtRoute("GetEmployeeForCompany", new {companyId, id = createdEmployee.Id }, createdEmployee);
        }
    }

}