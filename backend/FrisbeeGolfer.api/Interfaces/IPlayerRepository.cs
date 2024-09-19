using FrisbeeGolfer.api.Models;

namespace FrisbeeGolfer.api.Interfaces;

public interface IPlayerRepository
{
    public Task<List<Player>> GetPlayersAsync();
    public Task<Player> GetPlayerAsync(string playerId);
    public Task SavePlayerAsync(Player player);
    public Task DeletePlayersAsync();
    public Task DeletePlayerAsync(string playerId);
}