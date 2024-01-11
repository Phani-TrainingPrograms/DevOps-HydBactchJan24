using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleCoreWebApi.Models;

namespace SampleCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeDbContext employeeDbContext;
        public EmployeesController(EmployeeDbContext context)
        {
            employeeDbContext = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAllEmployees()
        {
            return this.employeeDbContext.Employees.ToList();
        }

        [HttpGet("{empId: int}")]
        public async Task<ActionResult<Employee>> GetEmployee(int empId) 
        { 
            return await employeeDbContext.Employees.FindAsync(empId); 
        }

        [HttpPost]
        public async Task<ActionResult> AddNewEmployee(Employee emp)
        {
            await employeeDbContext.Employees.AddAsync(emp);
            await employeeDbContext.SaveChangesAsync();
            return Ok();
        }

        public async Task<ActionResult> UpdateEmployee(Employee emp)
        {
            employeeDbContext.Employees.Update(emp);
            await employeeDbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{empId: int}")]
        public async Task<ActionResult> DeleteEmployee(int empId)
        {
            var foundEmp = await employeeDbContext.Employees.FindAsync(empId);
            if (foundEmp != null)
            {
                employeeDbContext.Employees.Remove(foundEmp);
                await employeeDbContext.SaveChangesAsync();
            }
            return Ok();
        }

    }
}
