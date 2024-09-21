using FrisbeeGolfer.api.Dtos;
using FrisbeeGolfer.api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FrisbeeGolfer.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController(IPlayerRepository playerRepository) : ControllerBase
{
    [HttpPost]
    public IActionResult Post(CreatePlayerDto playerDto)
    {
        return Ok(playerRepository.SavePlayerAsync(playerDto));
    }
}