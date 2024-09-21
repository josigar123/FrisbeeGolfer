using FrisbeeGolfer.api.Dtos;
using FrisbeeGolfer.api.Interfaces;
using MongoDB.Driver;

namespace FrisbeeGolfer.api.Repositories;

public class PlayerRepository : IPlayerRepository
{
    private readonly IMongoCollection<PlayerDto> _playerCollection;
    
    public PlayerRepository(MongoClient mongoClient)
    {
        var database = mongoClient.GetDatabase("frisbeegolfer");
        _playerCollection = database.GetCollection<PlayerDto>("players");
    }
    
    public Task<List<PlayerDto>> GetPlayersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<PlayerDto> GetPlayerAsync(string playerId)
    {
        throw new NotImplementedException();
    }

    public Task SavePlayerAsync(CreatePlayerDto createPlayerDto)
    {
        var player = new PlayerDto(createPlayerDto.PlayerId, createPlayerDto.Name, createPlayerDto.Score);
        return _playerCollection.InsertOneAsync(player);
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