namespace FrisbeeGolfer.api.Models;

public class Player(string playerId, string name, int score)
{
    public string PlayerId { get; } = playerId;
    public string Name { get; } = name;
    public int Score { get; set; } = score;

}