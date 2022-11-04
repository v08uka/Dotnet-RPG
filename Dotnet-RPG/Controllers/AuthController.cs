using Dotnet_RPG.Dtos.User;
using Dotnet_RPG.Services.AuthService;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_RPG.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
    {
        var response = await _authService.Register(
            new User{Username = request.Username}, request.Password
            );
        return response.Success ? Ok(response) : BadRequest(response);
    }
}