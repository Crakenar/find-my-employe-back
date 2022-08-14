
using FindMyEmployeBack.Types;

namespace FindMyEmployeBack.Model;

public class Employee
{
    public String Name { get; set; }
    public String LastName { get; set; }
    public int PhoneNumber  { get; set; }
    public String Email  { get; set; }
    public LocalizationType? Localisation  { get; set; }
    public HardSkillsType HardSkills { get; set; }
    public string SoftSkills { get; set; }
    public String[] Hobbies  { get; set; }

    public Employee(string name, string lastName, int phoneNumber, string email, LocalizationType localization, HardSkillsType hardSkills, string softSkills, string[] hobbies)
    {
        Name = name;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
        Localisation = localization;
        HardSkills = hardSkills;
        SoftSkills = softSkills;
        Hobbies = hobbies;
    }
    
}