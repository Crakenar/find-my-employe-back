using FindMyEmployeBack.DTO;
using FindMyEmployeBack.Interfaces;
using FindMyEmployeBack.Model;
using FindMyEmployeBack.Types;
using Microsoft.OpenApi.Extensions;

namespace FindMyEmployeBack.Services;

public class EmployeeService : IEmployeeService
{

    private static readonly EmployeeDTO[] _employees = new[]
    {
        new EmployeeDTO("e1", "e1", 333333333, "e1@e1", LocalizationType.Grenoble, null, SoftSkills.Calm.GetDisplayName(), null),
        new EmployeeDTO("e2", "e2", 222222222, "e2@e2", LocalizationType.LYON, null, SoftSkills.Curiosity.GetDisplayName(), null),
        new EmployeeDTO("e3", "e3", 1111111111, "e3@e3", LocalizationType.PARIS, null, SoftSkills.DecisionMaker.GetDisplayName(), null),
    };

    
    public async Task<IEnumerable<EmployeeDTO>> ListEmployees(CancellationToken ctx = default)
    {
        return _employees.ToArray();
    }
}