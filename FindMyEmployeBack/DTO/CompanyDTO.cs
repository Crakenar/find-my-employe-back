using FindMyEmployeBack.Types;

namespace FindMyEmployeBack.DTO;

public class CompanyDTO
{
    public String Name { get; set; }
    public int NumberOfEmployees { get; set; }
    public String Localisation { get; set; }


    public CompanyDTO(string name, int numberOfEmployees, string localisation)
    {
        Name = name;
        NumberOfEmployees = numberOfEmployees;
        Localisation = localisation;
    }
}