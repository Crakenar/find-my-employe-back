using System.Runtime.Intrinsics.X86;
using FindMyEmployeBack.DTO;
using FindMyEmployeBack.Interfaces;
using FindMyEmployeBack.Model;
using FindMyEmployeBack.Services;
using FindMyEmployeBack.Types;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Writers;

namespace FindMyEmployeBack.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{

    private IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }
    // GET
    [HttpGet(Name = "GetEmployees")]
    public async Task<IEnumerable<EmployeeDTO>> GetEmployees()
    {
        var listEmployees = await _employeeService.ListEmployees();
        return listEmployees;
    }
}