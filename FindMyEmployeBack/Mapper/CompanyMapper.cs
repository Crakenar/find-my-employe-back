using FindMyEmployeBack.DTO;
using FindMyEmployeBack.Model;

namespace FindMyEmployeBack.Mapper;

public class CompanyMapper
{
    public CompanyDTO MappingCompany(Company company)
    {
        return new CompanyDTO
        (
            company.Name,
            company.NumberOfEmployees,
            company.Localisation
        );
    }

    public async Task<CompanyDTO[]> MappingCompanyList(Company[] company)
    {
        List<CompanyDTO> companyDtos = new List<CompanyDTO>();
        for (int i = 0; i < company.Length; i++)
        {
            try
            {
                CompanyDTO companyDto = MappingCompany(company[i]);
                companyDtos.Add(companyDto);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        return companyDtos.ToArray();
    }
}