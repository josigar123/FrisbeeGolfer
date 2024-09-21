using FrisbeeGolfer.api.Dtos;
using FrisbeeGolfer.api.Interfaces;

namespace FrisbeeGolfer.api.Repositories;

public class PlayerRepository : IPlayerRepository
{

    public Task<List<PlayerDto>> GetPlayersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<PlayerDto> GetPlayerAsync(string playerId)
    {
        throw new NotImplementedException();
    }

    public Task SavePlayerAsync(PlayerDto player)
    {
        throw new NotImplementedException();
    }

    public Task DeletePlayersAsync()
    {
        throw new NotImplementedException();
    }

    public Task DeletePlayerAsync(string playerId)
    {
        throw new NotImplementedException();
    }
}