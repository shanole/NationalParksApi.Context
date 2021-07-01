using System.ComponentModel.DataAnnotations;

namespace NationalParksApi.Models
{
  public class Park
  {
    public int ParkId {get; set;}
    [Required]
    public string Name {get; set;}
    [Required]
    public string Location {get; set;}
    [Required]
    [Range(0, 50000, ErrorMessage = "Area must be between 0 and 50,000 kilometers squared.")]
    public float AreaKmSquared {get; set;}
    [Required]
    [StringLength(600)]
    public string Description {get; set;}
  }
}