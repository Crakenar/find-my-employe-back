namespace FindMyEmployeBack.Types;

public class HardSkillsType
{

    public String[] DevelopementHardSkills = Enum.GetNames(typeof(HardSkillsDevelopment));
    public String[] MarketingHardSkills = Enum.GetNames(typeof(HardSkillsMarketing));
}