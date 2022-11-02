namespace Dotnet_RPG.Services.CharacterService;

public class CharacterService : ICharacterService
{
    private static List<Characer> craracters = new List<Characer>()
    {
        new Characer(),
        new Characer {Id = 1, Name = "Sam"}
    };
    
    public async Task<List<Characer>> GetAllCharacters()
    {
        return craracters;
    }

    public async Task<Characer> GetCharacterById(int id)
    {
        return craracters.FirstOrDefault(c => c.Id == id);
    }

    public async Task<List<Characer>> AddCharacter(Characer newCharacter)
    {
        craracters.Add(newCharacter);
        return craracters;
    }
}