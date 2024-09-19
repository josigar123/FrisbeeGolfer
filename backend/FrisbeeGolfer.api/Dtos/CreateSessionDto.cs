
using FrisbeeGolfer.api.Models;

namespace FrisbeeGolfer.api.Dtos;

public class CreateSessionDto(List<Player> listOfPlayers, int numberOfHoles)
{
    public string SessionId { get; } = Guid.NewGuid().ToString();
    public List<Player> ListOfPlayers { get; } = listOfPlayers;
    public int NumberOfHoles { get; } = numberOfHoles;
}