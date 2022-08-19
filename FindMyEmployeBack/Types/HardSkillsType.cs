using System.ComponentModel.DataAnnotations;

namespace FindMyEmployeBack.Types;

public class HardSkillsType
{
    [Key]
    public Guid id { get; set; }
    public String[] DevelopementHardSkills = Enum.GetNames(typeof(HardSkillsDevelopment));
    public String[] MarketingHardSkills = Enum.GetNames(typeof(HardSkillsMarketing));
}