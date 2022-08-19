using System.ComponentModel.DataAnnotations;

namespace FindMyEmployeBack.Model;

public class HobbieUri
{
    [Key]
    public int Id { get; set; }

    public string Uri { get; set; } = null!;
}