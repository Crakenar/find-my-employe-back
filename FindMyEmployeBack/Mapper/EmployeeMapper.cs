using FindMyEmployeBack.DTO;
using FindMyEmployeBack.Model;

namespace FindMyEmployeBack.Mapper;

public class EmployeeMapper
{
    public EmployeeDTO MappingEmployee(Employee employee)
    {
        return new EmployeeDTO
        (
            employee.Name,
            employee.LastName,
            employee.PhoneNumber,
            employee.Email,
            employee.Localisation,
            employee.HardSkills,
            employee.SoftSkills,
            employee.Hobbies
        );
    }
    
    public async Task<EmployeeDTO[]> MappingCompanyList(Employee[] employees)
    {
        List<EmployeeDTO> employeeDtos = new List<EmployeeDTO>();
        for (int i = 0; i < employees.Length; i++)
        {
            try
            {
                EmployeeDTO companyDto = MappingEmployee(employees[i]);
                employeeDtos.Add(companyDto);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        return employeeDtos.ToArray();
    }
}