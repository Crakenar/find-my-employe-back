
using System.ComponentModel.DataAnnotations;
using FindMyEmployeBack.Types;
using Microsoft.EntityFrameworkCore;

namespace FindMyEmployeBack.Model;

public class Employee
{
    [Key]
    public Guid id { get; set; }
    public String Name { get; set; }
    public String LastName { get; set; }
    public int PhoneNumber  { get; set; }
    public String Email  { get; set; }
    public LocalizationType? Localisation  { get; set; }
    public HardSkillsType HardSkills { get; set; }
    public String SoftSkills { get; set; }
    
    public ICollection<HobbieUri> Hobbies  { get; set; }
    
    
}