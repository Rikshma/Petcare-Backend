using petcare.Domain;

namespace petcare.Application.Models
{
    public class CreatePetDto
    {
        public string OwnerName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PetName { get; set; }
        public PetType PetType { get; set; }
        public Breed Breed { get; set; }
        public string DateOfBirth { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Color { get; set; }
    }
}
