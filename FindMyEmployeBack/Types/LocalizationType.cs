using System.ComponentModel;

namespace FindMyEmployeBack.Types;

public class LocalizationType
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public static LocalizationType Grenoble => new LocalizationType(1,"GRENOBLE");
    public static LocalizationType PARIS => new LocalizationType( 2,"PARIS");
    public static LocalizationType MARSEILLE => new LocalizationType( 3,"MARSEILLE");
    public static LocalizationType LYON => new LocalizationType( 4,"LYON");

    public LocalizationType(int id, string name)
    {
        Id = id;
        Name = name;
    }
}