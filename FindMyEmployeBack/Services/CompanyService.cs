using FindMyEmployeBack.DTO;
using FindMyEmployeBack.Interfaces;
using FindMyEmployeBack.Types;

namespace FindMyEmployeBack.Services;

public class CompanyService : ICompanyService
{

    private static readonly CompanyDTO[] _companies = new[]
    {
        new CompanyDTO("COmpany 1", 1200, LocalizationType.Grenoble.Name),
        new CompanyDTO("COmpany 2", 45, LocalizationType.LYON.Name),
        new CompanyDTO("COmpany 9", 907, LocalizationType.MARSEILLE.Name),
    };
    public async Task<IEnumerable<CompanyDTO>> GetCompanies(CancellationToken ctx = default)
    {
        return  _companies.ToArray();
    }
}