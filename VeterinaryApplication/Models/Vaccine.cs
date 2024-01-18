using System.ComponentModel.DataAnnotations;
namespace VeterinaryApplication.Models
{
    public class Vaccine
    {
        public int VaccineId { get; set; }
        [Required(ErrorMessage = "Vaccine name is required.")]
        public string Name { get; set; }
        public List<Pet> Pets { get; set; } = new List<Pet>();
    }
}