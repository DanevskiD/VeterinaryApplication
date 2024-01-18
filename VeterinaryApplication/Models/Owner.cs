using System.ComponentModel.DataAnnotations;

namespace VeterinaryApplication.Models

{
    public class Owner
    {
        public int OwnerId { get; set; }
        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }
        [Range(18, 100, ErrorMessage = "Age must be between 18 and 100.")]
        public int Years { get; set; }
        public List<Pet> Pets { get; set; } = new List<Pet>();

        public string getFirstNameAndLastName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
