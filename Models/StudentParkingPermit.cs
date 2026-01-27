using System.ComponentModel.DataAnnotations;

namespace ParkingPermitService.Models
{
    public class StudentParkingPermit
    {
        public int Id {get;set;}

        [Required]
        [EmailAddress]
        public string Email {get; set;} = string.Empty;

        [Required]
        [StringLength(12, MinimumLength =3)]
        public string NumberPlate {get; set;} = string.Empty;

        [Required]
        [StringLength(15)]
        public string ParkingType {get; set;} = "monthly";

        [Required]
        public DateTime ExpiryDate {get; set;}
    }
}