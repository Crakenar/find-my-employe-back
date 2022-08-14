using FindMyEmployeBack.DTO;
using FindMyEmployeBack.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FindMyEmployeBack.Controllers;

[ApiController]
[Route("[controller]")]
public class CompanyController : ControllerBase
{

    private ICompanyService _companyService;

    public CompanyController(ICompanyService companyService)
    {
        _companyService = companyService;
    }
    
    // GET
    [HttpGet(Name = "GetCompanies")]
    public async Task<IEnumerable<CompanyDTO>> GetCompanies()
    {
        return await _companyService.GetCompanies();
    }
    
}