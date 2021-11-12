using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyManagementRestApi.Models {
public class Family {
    
    public int Id { get; set; }
    [Required] 
    [Key, Column(Order=0)]
    public string StreetName { get; set; }
    [Required, Range(1, Int32.MaxValue, ErrorMessage = "Value must be greater than 0")]
    [Key, Column(Order = 1)]
    public int HouseNumber{ get; set; }
    public List<Adult> Adults { get; set; }
    public List<Child> Children{ get; set; }
    public List<Pet> Pets{ get; set; }

    public Family() {
        Adults = new List<Adult>();
        Children = new List<Child>();
        Pets = new List<Pet>(); 
    }
}


}