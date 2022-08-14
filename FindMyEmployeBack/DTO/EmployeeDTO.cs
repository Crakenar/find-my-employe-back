using FindMyEmployeBack.Types;

namespace FindMyEmployeBack.DTO;

public class EmployeeDTO
{
    public String Name { get; set; }
    public String LastName { get; set; }
    public int PhoneNumber  { get; set; }
    public String Email  { get; set; }
    public LocalizationType? Localisation  { get; set; }
    public HardSkillsType HardSkills { get; set; }
    public string SoftSkills { get; set; }
    public String[] Hobbies  { get; set; }

    public EmployeeDTO(string name, string lastName, int phoneNumber, string email, LocalizationType? localisation, HardSkillsType hardSkills, string softSkills, string[] hobbies)
    {
        Name = name;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
        Localisation = localisation;
        HardSkills = hardSkills;
        SoftSkills = softSkills;
        Hobbies = hobbies;
    }
}