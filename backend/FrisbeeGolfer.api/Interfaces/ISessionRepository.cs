using FrisbeeGolfer.api.Dtos;
using FrisbeeGolfer.api.Models;

namespace FrisbeeGolfer.api.Interfaces;

public interface ISessionRepository
{
    public Task<List<SessionDto>> GetSessionsAsync();
    public Task<SessionDto> GetSessionAsync(string sessionId);
    public Task SaveSessionAsync();
    public Task DeleteSessionsAsync();
    public Task DeleteSessionAsync(string sessionId);
}