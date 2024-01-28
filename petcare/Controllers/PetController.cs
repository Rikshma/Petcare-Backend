using Microsoft.AspNetCore.Mvc;
using petcare.Application.Commands;
using petcare.Application.Models;

namespace petcare.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetController : ControllerBase
    {
        private readonly RegisterPetCommand _registerPetCommand;
        public PetController(RegisterPetCommand registerPetCommand)
        {
            _registerPetCommand = registerPetCommand;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePet([FromBody] CreatePetDto cretePetDto)
        {
           var result = await _registerPetCommand.Register(cretePetDto);
           return Ok(result);
        }
    }
}
