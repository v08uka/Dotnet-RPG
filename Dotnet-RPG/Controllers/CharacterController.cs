using System.Security.Claims;
using Dotnet_RPG.Dtos.Character;
using Dotnet_RPG.Services.CharacterService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_RPG.Controllers;

[ApiController]
[Authorize]
[Route("api/[controller]")]
public class CharacterController : ControllerBase
{
    private readonly ICharacterService _characterService;

    public CharacterController(ICharacterService characterService)
    {
        _characterService = characterService;
    }
    
    [HttpGet("GetAll")]
    public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Get()
    {
        var userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
        return Ok(await _characterService.GetAllCharacters(userId));
    }
    
    [HttpGet("{id:int}")]
    public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetSingle(int id)
    {
        return Ok(await _characterService.GetCharacterById(id));
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> AddCharacter(AddCharacterDto newCharacter)
    {
        return Ok(await _characterService.AddCharacter(newCharacter));
    }
    
    [HttpPut]
    public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> UpdateCharacter(UpdateCharacterDto updatedCharacter)
    {
        var response = await _characterService.UpdateCharacter(updatedCharacter);
        if (response.Data == null)
            return NotFound(response);
        
        return Ok(response);
    }
    
    [HttpDelete("{id:int}")]
    public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Delete(int id)
    {
        var response = await _characterService.DeleteCharacter(id);
        if (response.Data == null)
            return NotFound(response);
        
        return Ok(response);
    }
}