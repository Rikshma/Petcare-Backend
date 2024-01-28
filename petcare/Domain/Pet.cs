namespace petcare.Domain
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PetType PetType { get; set; }
        public DateTime BirthDay { get; set; }
        public Breed Breed { get; set; }
        public Gender Gender { get; set; }
        public string Color { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
