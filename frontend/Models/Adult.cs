using System.Text.Json.Serialization;

namespace DNPAssignment1FamilyManagementSystem.Models {
public class Adult : Person {
    public Job JobTitle { get; set; }
}
}