using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DNPAssignment1FamilyManagementSystem.Models {
public class Child : Person {

    public List<Interest> Interests { get; set; }
    public List<Pet> Pets { get; set; }
}
}