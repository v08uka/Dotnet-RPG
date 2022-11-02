using Dotnet_RPG.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_RPG.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterController : ControllerBase
{
    private readonly ICharacterService _characterService;

    public CharacterController(ICharacterService characterService)
    {
        _characterService = characterService;
    }
    [HttpGet("GetAll")]
    public async Task<ActionResult<List<Characer>>> Get()
    {
        return Ok(await _characterService.GetAllCharacters());
    }
    
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Characer>> GetSingle(int id)
    {
        return Ok(await _characterService.GetCharacterById(id));
    }

    [HttpPost]
    public async Task<ActionResult<List<Characer>>> AddCharacter(Characer newCharacter)
    {
        return Ok(await _characterService.AddCharacter(newCharacter));
    }
}