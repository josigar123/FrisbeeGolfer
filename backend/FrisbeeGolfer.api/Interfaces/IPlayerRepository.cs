using FrisbeeGolfer.api.Dtos;

namespace FrisbeeGolfer.api.Interfaces;

public interface IPlayerRepository
{
    public Task<List<PlayerDto>> GetPlayersAsync();
    public Task<PlayerDto> GetPlayerAsync(string playerId);
    public Task SavePlayerAsync(CreatePlayerDto player);
    public Task DeletePlayersAsync();
    public Task DeletePlayerAsync(string playerId);
}