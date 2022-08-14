using FindMyEmployeBack.DTO;

namespace FindMyEmployeBack.Interfaces;

public interface ICompanyService
{
    Task<IEnumerable<CompanyDTO>> GetCompanies(CancellationToken ctx = default);
}