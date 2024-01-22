using System.ComponentModel.DataAnnotations;
namespace Read.Models;
public class DoctorModel
{
    //Teacher Id, Teacher Name, Teacher Email, Teacher Qualification and Teacher Location.
  [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public int  Age { get; set; }
    public string? Email { get; set; }
    public string? Specialization { get; set; }
    public int? ContactNumber { get; set; }
    public string? Location { get; set; }
    


}