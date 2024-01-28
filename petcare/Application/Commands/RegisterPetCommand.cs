using Microsoft.AspNetCore.Http;
using petcare.Application.Models;
using petcare.Domain;
using petcare.Persistence.Repositories;

namespace petcare.Application.Commands
{
    public class RegisterPetCommand
    {
        private readonly IUserRepository _userRepository;
        private readonly IPetRepository _petRepository;

        public RegisterPetCommand(IUserRepository userRepository, IPetRepository petRepository)
        {
            _userRepository = userRepository;
            _petRepository = petRepository;
        }

        public async Task<Pet> Register(CreatePetDto createPetDto)
        {
            bool isEmailExists = await _userRepository.CheckUserExists(createPetDto.Email);
            if (isEmailExists)
            {
                throw new Exception("Email Already Exists");
            }

            var user = new User
            {
                Password = createPetDto.Password,
                Email = createPetDto.Email
            };
            user = await _userRepository.AddAsync(user);

            var pet = new Pet
            {
                Name = createPetDto.PetName,
                PetType = createPetDto.PetType,
                BirthDay = Convert.ToDateTime(createPetDto.DateOfBirth),
                Breed = createPetDto.Breed,
                Color = createPetDto.Color,
                Gender = createPetDto.Gender,
                UserId = user.Id
            };

            return await _petRepository.AddAsync(pet);
        }
    }
}
