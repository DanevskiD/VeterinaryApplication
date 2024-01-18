using Humanizer;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

namespace VeterinaryApplication.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        [Required(ErrorMessage = "Pet names is required.")]
        public string Name { get; set; }
        [Range(0, 50, ErrorMessage = "Pet age must be between 0 and 50.")]
        public int Age { get; set; }
        [Display(Name = "Owner")]
        [Required(ErrorMessage = "Owner is required.")]
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
        public List<Vaccine> Vaccines { get; set; } = new List<Vaccine>();
        public string GetPetDetails()
        {
            return $"Pet Name: {Name}, Age: {Age}, Owner ID: {OwnerId}";
        }
        [NotMapped]
        public List<int> VaccinesParams { get; set; }
    }
 
}
