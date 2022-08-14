using FindMyEmployeBack.Model;

namespace FindMyEmployeBack.Interfaces;

public interface IEmployeeService
{
    Task<IEnumerable<Employee>> ListEmployees(CancellationToken ctx = default); 
}