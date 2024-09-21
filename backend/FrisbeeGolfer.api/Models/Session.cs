namespace FrisbeeGolfer.api.Models;

public class Session(string sessionId, List<Player> listOfPlayers, int numberOfHoles)
{

    public string SessionId { get; } = sessionId;
    public List<Player> ListOfPlayers { get; } = listOfPlayers;
    public int NumberOfHoles { get; } = numberOfHoles;
}