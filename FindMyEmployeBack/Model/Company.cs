using FindMyEmployeBack.Types;

namespace FindMyEmployeBack.Model;

public class Company
{
    public String Name { get; set; }
    public BusinessType  BusinessType{ get; set; }
    public int NumberOfEmployees { get; set; }
    public String Localisation { get; set; }
}