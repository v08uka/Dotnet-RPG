using Dotnet_RPG.Dtos.Character;

namespace Dotnet_RPG.Services.CharacterService;

public interface ICharacterService
{
    Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();

    Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);

    Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
}