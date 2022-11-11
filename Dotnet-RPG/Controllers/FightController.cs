using Dotnet_RPG.Dtos.Fight;
using Dotnet_RPG.Services.FightService;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_RPG.Controllers;

[ApiController]
[Route("[controller]")]
public class FightController : ControllerBase
{
    private readonly FightService _fightService;

    public FightController(FightService fightService)
    {
        _fightService = fightService;
    }

    [HttpPost("Weapon")]
    public async Task<ActionResult<ServiceResponse<AttackResultDto>>> WeaponAttack(WeaponAttackDto request)
    {
        return Ok(await _fightService.WeaponAttack(request));
    }

    [HttpPost("Skill")]
    public async Task<ActionResult<ServiceResponse<AttackResultDto>>> SkillAttack(SkillAttackDto request)
    {
        return Ok(await _fightService.SkillAttack(request));
    }
    
    [HttpPost]
    public async Task<ActionResult<ServiceResponse<FightResultDto>>> Fight(FightRequestDto request)
    {
        return Ok(await _fightService.Fight(request));
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<HighScoreDto>>>> GetHighScore()
    {
        return Ok(await _fightService.GetHighScore());
    }
}