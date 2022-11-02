namespace Dotnet_RPG.Services.CharacterService;

public interface ICharacterService
{
    Task<List<Characer>> GetAllCharacters();

    Task<Characer> GetCharacterById(int id);

    Task<List<Characer>> AddCharacter(Characer newCharacter);
}