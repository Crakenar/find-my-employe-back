using FindMyEmployeBack.DTO;

namespace FindMyEmployeBack.Interfaces;

public interface IEmployeeService
{
    Task<IEnumerable<EmployeeDTO>> ListEmployees(CancellationToken ctx = default); 
}