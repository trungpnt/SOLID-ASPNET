using Microsoft.AspNetCore.Mvc;
using solid_demo.Models;

namespace solid_demo.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeRepository _employeeRepository;

        //Constructor Injection, This EmployeeController class doesn't know the real logic ( which is carried out by MockEmployeeRepository ) behind IEmployeeRepository.
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployeeById (int id)
        {
            var foundEmployee = _employeeRepository.GetEmployeeById(id);
            return Ok(foundEmployee);
        }
    }
}