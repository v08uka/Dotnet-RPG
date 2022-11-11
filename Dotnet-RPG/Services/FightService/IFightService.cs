﻿using Dotnet_RPG.Dtos.Fight;

namespace Dotnet_RPG.Services.FightService;

public interface IFightService
{
    Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
    
    Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);

    Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);

    Task<ServiceResponse<List<HighScoreDto>>> GetHighScore();
}