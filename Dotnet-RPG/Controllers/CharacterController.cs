using Microsoft.AspNetCore.Mvc;

namespace Dotnet_RPG.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterController : ControllerBase
{
    private static List<Characer> craracters = new List<Characer>()
    {
        new Characer(),
        new Characer {Id = 1, Name = "Sam"}
    };

    [HttpGet("GetAll")]
    public ActionResult<List<Characer>> Get()
    {
        return Ok(craracters);
    }
    
    [HttpGet("{id:int}")]
    public ActionResult<Characer> GetSingle(int id)
    {
        return Ok(craracters.FirstOrDefault(c => c.Id == id));
    }

    [HttpPost]
    public ActionResult<List<Characer>> AddCharacter(Characer newCharacter)
    {
        craracters.Add(newCharacter);
        return Ok(craracters);
    }
}