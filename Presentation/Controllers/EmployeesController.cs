
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

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
        public IActionResult GemEmployees (Guid companyId, bool trackChanges) {
            var employees = _service.EmployeeService.GetEmployees(companyId, trackChanges);
            return Ok(employees);
        }

        [HttpGet("{id:Guid}")]
        public IActionResult GetEmployee (Guid companyId, Guid id) {
            var employee  = _service.EmployeeService.GetEmployee(companyId, id, true);
            return Ok(employee);
        }
    }

}