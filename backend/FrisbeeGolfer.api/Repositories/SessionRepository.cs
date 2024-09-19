using FrisbeeGolfer.api.Dtos;
using FrisbeeGolfer.api.Interfaces;

namespace FrisbeeGolfer.api.Repositories;

public class SessionRepository : ISessionRepository
{
    public Task<List<SessionDto>> GetSessionsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<SessionDto> GetSessionAsync(string sessionId)
    {
        throw new NotImplementedException();
    }

    public Task SaveSessionAsync()
    {
        throw new NotImplementedException();
    }

    public Task DeleteSessionsAsync()
    {
        throw new NotImplementedException();
    }

    public Task DeleteSessionAsync(string sessionId)
    {
        throw new NotImplementedException();
    }
}